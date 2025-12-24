using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MimeKit;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Security;
using MailKit.Security;




namespace Lab05_Bai23
{
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
            InitListView();
        }

        private void InitListView()
        {
            lv_Mail.View = View.Details;
            lv_Mail.FullRowSelect = true;
            lv_Mail.GridLines = true;

            lv_Mail.Columns.Add("Email", 200);
            lv_Mail.Columns.Add("From", 300);
            lv_Mail.Columns.Add("Thời gian", 150);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;   

                lv_Mail.Items.Clear();

                if (rb_IMAP.Checked)
                {
                    ReadMailIMAP();   // BÀI 2
                }
                else
                {
                    ReadMailPOP3();   // BÀI 3
                }
            }
            catch (AuthenticationException)
            {
                MessageBox.Show("Email hoặc mật khẩu không đúng.\nLưu ý: Gmail cần App Password.",
                    "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối tới mail server.\n\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =======================
        // BÀI 2 – IMAP
        // =======================
        private void ReadMailIMAP()
        {
            using (var client = new ImapClient())
            {
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate(txt_Email.Text, txt_Password.Text);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                lbl_Total.Text = inbox.Count.ToString();

                int recent = 0;

                for (int i = inbox.Count - 1; i >= 0 && i >= inbox.Count - 20; i--)
                {
                    var message = inbox.GetMessage(i);

                    if (message.Date.Date == DateTime.Today)
                        recent++;

                    ListViewItem item = new ListViewItem(message.Subject);
                    item.SubItems.Add(message.From.ToString());
                    item.SubItems.Add(message.Date.ToString("dd/MM/yyyy HH:mm"));

                    item.Tag = message;

                    lv_Mail.Items.Add(item);
                }

                lbl_Recent.Text = recent.ToString();
                client.Disconnect(true);
            }
        }

        // =======================
        // BÀI 3 – POP3
        // =======================
        private void ReadMailPOP3()
        {
            using (var client = new Pop3Client())
            {
                client.Connect("pop.gmail.com", 995, true);
                client.Authenticate(txt_Email.Text, txt_Password.Text);

                lbl_Total.Text = client.Count.ToString();

                int recent = 0;

                for (int i = client.Count - 1; i >= 0 && i >= client.Count - 20; i--)
                {
                    var message = client.GetMessage(i);

                    if (message.Date.Date == DateTime.Today)
                        recent++;

                    ListViewItem item = new ListViewItem(message.Subject);
                    item.SubItems.Add(message.From.ToString());
                    item.SubItems.Add(message.Date.ToString("dd/MM/yyyy HH:mm"));

                    item.Tag = message;

                    lv_Mail.Items.Add(item);
                }

                lbl_Recent.Text = recent.ToString();
                client.Disconnect(true);
            }
        }


        private void lv_Mail_DoubleClick(object sender, EventArgs e)
        {

            if (lv_Mail.SelectedItems.Count == 0) return;

            var msg = lv_Mail.SelectedItems[0].Tag as MimeKit.MimeMessage;
            if (msg == null) return;

            using (var f = new FormNoiDungMail(msg))
            {
                f.ShowDialog();
            }

        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txt_Email.Text))
            {
                MessageBox.Show("Vui lòng nhập email.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Email.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Password.Focus();
                return false;
            }

            if (!rb_IMAP.Checked && !rb_POP3.Checked)
            {
                MessageBox.Show("Vui lòng chọn giao thức IMAP hoặc POP3.", "Thiếu lựa chọn",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

    }
}
