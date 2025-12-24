using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_Bai06
{
    public partial class MailClient : Form
    {
        private EmailService _emailService;
        private List<string> _attachments = new List<string>();

        public MailClient()
        {
            InitializeComponent();
            SetupService();
        }

        private void SetupService()
        {
            _emailService = new EmailService();

            _emailService.OnProgress += (msg) =>
            {
                if (this.InvokeRequired)
                    this.Invoke(new Action(() => lblStatus.Text = msg));
                else
                    lblStatus.Text = msg;
            };

            _emailService.OnLoginCompleted += (success, msg) =>
            {
                this.Invoke(new Action(() => {
                    if (success)
                    {
                        panelLogin.Visible = false;
                        panelMain.Visible = true;
                        _ = _emailService.GetRecentEmailsAsync(20);
                    }
                    else MessageBox.Show(msg, "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            };

            _emailService.OnEmailsLoaded += (list) =>
            {
                this.Invoke(new Action(() => {
                    listViewEmails.Items.Clear();
                    foreach (var m in list)
                    {
                        var item = new ListViewItem(m.From);
                        item.SubItems.Add(m.Subject);
                        item.SubItems.Add(m.Date);
                        item.Tag = m;
                        listViewEmails.Items.Add(item);
                    }
                    lblStatus.Text = "Sẵn sàng";
                }));
            };

            _emailService.OnBodyLoaded += (html) =>
            {
                this.Invoke(new Action(() => {
                    webBrowserView.DocumentText = "about:blank";
                    if (webBrowserView.Document != null)
                        webBrowserView.Document.Write(html);
                    else
                        webBrowserView.DocumentText = html;
                }));
            };

            _emailService.OnEmailSent += (success, msg) =>
            {
                this.Invoke(new Action(() => {
                    MessageBox.Show(msg);
                    if (success) ResetForm();
                }));
            };
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                _emailService.Configure(txtIMAPHost.Text, int.Parse(txtIMAPPort.Text), txtSMTPHost.Text, int.Parse(txtSMTPPort.Text));
                await _emailService.AuthenticateAsync(txtEmail.Text, txtPassword.Text);
            }
            catch { MessageBox.Show("Vui lòng kiểm tra lại định dạng Port."); }
        }

        private async void btnRefresh_Click(object sender, EventArgs e) => await _emailService.GetRecentEmailsAsync(20);

        private async void listViewEmails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEmails.SelectedItems.Count > 0)
            {
                var mail = (EmailMessage)listViewEmails.SelectedItems[0].Tag;
                lblViewSubject.Text = mail.Subject;
                lblViewFrom.Text = $"Từ: {mail.From}";
                await _emailService.GetEmailBodyAsync(mail.Index);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            _emailService.SendEmail(txtTo.Text, txtSubject.Text, txtBody.Text, chkIsHtml.Checked, _attachments);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Multiselect = true })
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _attachments.AddRange(ofd.FileNames);
                    lblAttachmentCount.Text = $"{_attachments.Count} tệp đính kèm";
                }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelLogin.Visible = true;
            txtPassword.Clear();
            listViewEmails.Items.Clear();
            webBrowserView.DocumentText = "";
        }

        private void ResetForm()
        {
            txtTo.Clear(); txtSubject.Clear(); txtBody.Clear();
            _attachments.Clear(); lblAttachmentCount.Text = "0 tệp đính kèm";
        }
    }

    public class EmailMessage
    {
        public int Index { get; set; }
        public string Subject { get; set; }
        public string From { get; set; }
        public string Date { get; set; }
    }

    public class EmailService
    {
        public event Action<string> OnProgress;
        public event Action<bool, string> OnLoginCompleted;
        public event Action<List<EmailMessage>> OnEmailsLoaded;
        public event Action<string> OnBodyLoaded;
        public event Action<bool, string> OnEmailSent;

        private string _ih, _sh, _u, _p;
        private int _ip, _sp;

        public void Configure(string ih, int ip, string sh, int sp) { _ih = ih; _ip = ip; _sh = sh; _sp = sp; }

        public async Task AuthenticateAsync(string u, string p)
        {
            _u = u; _p = p;
            OnProgress?.Invoke("Đang kết nối server...");
            try
            {
                using (var tcp = new TcpClient())
                {
                    await tcp.ConnectAsync(_ih, _ip);
                    using (var ssl = new SslStream(tcp.GetStream()))
                    {
                        await ssl.AuthenticateAsClientAsync(_ih);
                        await ReceiveResponse(ssl);
                        var res = await SendCommand(ssl, $"L1 LOGIN {u} {p}", "L1");
                        OnLoginCompleted?.Invoke(res.Contains("L1 OK"), res.Contains("L1 OK") ? "Thành công" : "Xác thực thất bại");
                    }
                }
            }
            catch (Exception ex) { OnLoginCompleted?.Invoke(false, ex.Message); }
        }

        public async Task GetRecentEmailsAsync(int count)
        {
            var list = new List<EmailMessage>();
            OnProgress?.Invoke("Đang đồng bộ danh sách...");
            try
            {
                using (var tcp = new TcpClient())
                {
                    await tcp.ConnectAsync(_ih, _ip);
                    using (var ssl = new SslStream(tcp.GetStream()))
                    {
                        await ssl.AuthenticateAsClientAsync(_ih);
                        await ReceiveResponse(ssl);
                        await SendCommand(ssl, $"L1 LOGIN {_u} {_p}", "L1");
                        await SendCommand(ssl, "L2 SELECT INBOX", "L2");

                        var resSearch = await SendCommand(ssl, "L3 SEARCH ALL", "L3");
                        var idsMatch = Regex.Match(resSearch, @"SEARCH (.*)\r\n");
                        if (!idsMatch.Success) return;

                        var ids = idsMatch.Groups[1].Value.Trim().Split(' ');
                        int counter = 0;
                        for (int i = ids.Length - 1; i >= 0 && counter < count; i--)
                        {
                            if (string.IsNullOrEmpty(ids[i])) continue;
                            int idx = int.Parse(ids[i]);
                            var h = await SendCommand(ssl, $"L4 FETCH {idx} (BODY[HEADER.FIELDS (SUBJECT FROM DATE)])", "L4");
                            list.Add(new EmailMessage
                            {
                                Index = idx,
                                Subject = FullDecode(ParseHeader(h, "Subject")),
                                From = FullDecode(ParseHeader(h, "From")),
                                Date = ParseHeader(h, "Date")
                            });
                            counter++;
                        }
                    }
                }
                OnEmailsLoaded?.Invoke(list);
                OnProgress?.Invoke("Hoàn tất.");
            }
            catch { OnProgress?.Invoke("Lỗi kết nối IMAP."); }
        }

        public async Task GetEmailBodyAsync(int index)
        {
            OnProgress?.Invoke("Đang lấy nội dung HTML...");
            try
            {
                using (var tcp = new TcpClient())
                {
                    await tcp.ConnectAsync(_ih, _ip);
                    using (var ssl = new SslStream(tcp.GetStream()))
                    {
                        await ssl.AuthenticateAsClientAsync(_ih);
                        await ReceiveResponse(ssl);
                        await SendCommand(ssl, $"L1 LOGIN {_u} {_p}", "L1");
                        await SendCommand(ssl, "L2 SELECT INBOX", "L2");
                        // Fetch nội dung thô của mail
                        var res = await SendCommand(ssl, $"L3 FETCH {index} (BODY[TEXT])", "L3");
                        string html = ExtractHtmlPart(res);
                        OnBodyLoaded?.Invoke(html);
                        OnProgress?.Invoke("Đã tải thư.");
                    }
                }
            }
            catch { }
        }

        public void SendEmail(string to, string sub, string body, bool html, List<string> atts)
        {
            OnProgress?.Invoke("Đang gửi mail...");
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                using (var mail = new MailMessage(_u, to, sub, body) { IsBodyHtml = html })
                {
                    if (atts != null) foreach (var a in atts) mail.Attachments.Add(new Attachment(a));
                    using (var smtp = new SmtpClient(_sh, _sp))
                    {
                        smtp.Credentials = new NetworkCredential(_u, _p);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
                OnEmailSent?.Invoke(true, "Gửi thư thành công!");
            }
            catch (Exception ex) { OnEmailSent?.Invoke(false, "Lỗi: " + ex.Message); }
        }

        private async Task<string> SendCommand(SslStream ssl, string cmd, string tag)
        {
            byte[] b = Encoding.ASCII.GetBytes(cmd + "\r\n");
            await ssl.WriteAsync(b, 0, b.Length);
            return await ReceiveResponse(ssl, tag);
        }

        private async Task<string> ReceiveResponse(SslStream ssl, string tag = null)
        {
            StringBuilder sb = new StringBuilder();
            byte[] buffer = new byte[65536];
            int read;
            while (true)
            {
                read = await ssl.ReadAsync(buffer, 0, buffer.Length);
                if (read <= 0) break;
                sb.Append(Encoding.UTF8.GetString(buffer, 0, read));
                string current = sb.ToString();
                if (tag != null && (current.Contains(tag + " OK") || current.Contains(tag + " NO") || current.Contains(tag + " BAD"))) break;
                if (tag == null && current.Contains("\r\n")) break;
                await Task.Delay(20);
            }
            return sb.ToString();
        }

        private string ParseHeader(string raw, string name)
        {
            var m = Regex.Match(raw, $@"{name}:\s*(.*)", RegexOptions.IgnoreCase);
            return m.Success ? m.Groups[1].Value.Trim() : "N/A";
        }

        private string FullDecode(string input)
        {
            if (string.IsNullOrEmpty(input) || input == "N/A") return input;
            string pattern = @"=\?utf-8\?([BQ])\?(.*?)\?=";
            return Regex.Replace(input, pattern, m => {
                string type = m.Groups[1].Value.ToUpper();
                string data = m.Groups[2].Value;
                if (type == "B") return Encoding.UTF8.GetString(Convert.FromBase64String(data));
                if (type == "Q") return data.Replace("_", " ");
                return data;
            }, RegexOptions.IgnoreCase);
        }

        private string ExtractHtmlPart(string raw)
        {
            // Xử lý Literal IMAP {size}
            var mSize = Regex.Match(raw, @"\{(\d+)\}\r\n");
            string body = raw;
            if (mSize.Success)
            {
                int start = mSize.Index + mSize.Length;
                int size = int.Parse(mSize.Groups[1].Value);
                body = (start + size <= raw.Length) ? raw.Substring(start, size) : raw.Substring(start);
            }

            if (body.Contains("Content-Type: text/html"))
            {
                int htmlIndex = body.IndexOf("Content-Type: text/html");
                string sub = body.Substring(htmlIndex);
                int bodyStart = sub.IndexOf("\r\n\r\n");
                if (bodyStart != -1)
                {
                    string htmlContent = sub.Substring(bodyStart + 4);
                    int endBoundary = htmlContent.IndexOf("\r\n--");
                    if (endBoundary != -1) return htmlContent.Substring(0, endBoundary).Trim();
                    return htmlContent.Trim();
                }
            }
            return body.Trim();
        }
    }
}