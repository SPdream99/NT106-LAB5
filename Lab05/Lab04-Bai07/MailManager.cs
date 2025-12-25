using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;
using MimeKit;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_Bai07
{
    public partial class MailManager : Form
    {
        // ===== CẤU HÌNH MAIL SERVER =====
        private const string IMAP_HOST = "imap.gmail.com";
        private const int IMAP_PORT = 993;
        private const string SERVER_EMAIL = "akito1211shinonome@gmail.com"; // mail trung tâm
        private const string APP_PASSWORD = "oqbi zara aooz qvql"; // app password

        public MailManager()
        {
            InitializeComponent();
            txtEmail.Text = SERVER_EMAIL;
            InitListView();

            // Mở form login
            FormLogin login = new FormLogin();
            login.Show();
        }

        // ===== CẤU HÌNH LISTVIEW =====
        private void InitListView()
        {
            lstMail.View = View.Details;
            lstMail.FullRowSelect = true;
            lstMail.GridLines = true;
            lstMail.Width = 750;
            lstMail.Columns.Clear();
            lstMail.Columns.Add("From", 220);
            lstMail.Columns.Add("Subject", 330);
            lstMail.Columns.Add("Time", 200);
        }

        // ===== NÚT RELOAD THỦ CÔNG =====
        private void btnReload_Click(object sender, EventArgs e)
        {
            Task.Run(async () => await LoadEmails());
        }

        // ===== HÀM GỌI API THÊM MÓN ĂN VÀ HIỂN THỊ THÔNG BÁO =====
        private async Task AddMonAn(string tenMonAn, int gia, string moTa, string hinhAnh, string diaChi)
        {
            try
            {
                var body = new
                {
                    ten_mon_an = tenMonAn,
                    gia = gia,
                    mo_ta = moTa,
                    hinh_anh = hinhAnh,
                    dia_chi = diaChi
                };
                var api = new ApiClient();
                var res = await api.PostAsync<FoodModel>("api/v1/monan/add", body);

                // Thông báo thêm món thành công
                if (lstMail.InvokeRequired)
                {
                    lstMail.Invoke(new Action(() =>
                    {
                        MessageBox.Show($"Đã thêm món ăn: {tenMonAn}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                }
                else
                {
                    MessageBox.Show($"Đã thêm món ăn: {tenMonAn}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm món ăn {tenMonAn} thất bại!\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== HÀM XỬ LÝ EMAIL THREAD-SAFE =====
        private async Task ProcessEmailSafe(MimeMessage message)
        {
            if (message.Subject != "Đóng góp món ăn")
                return;

            if (string.IsNullOrWhiteSpace(message.TextBody))
                return;

            var lines = message.TextBody.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                var parts = line.Split(';');
                if (parts.Length != 2) continue;

                string tenMonAn = parts[0].Trim();
                string hinhAnh = parts[1].Trim();

                // Gọi API add món ăn
                await AddMonAn(tenMonAn, 0, "không có mô tả", hinhAnh, "chưa cập nhật");
            }

            // Cập nhật ListView
            if (lstMail.InvokeRequired)
            {
                lstMail.Invoke(new Action(() =>
                {
                    lstMail.Items.Insert(0, new ListViewItem(new string[]
                    {
                        message.From.ToString(),
                        message.Subject,
                        message.Date.ToString()
                    }));
                }));
            }
            else
            {
                lstMail.Items.Insert(0, new ListViewItem(new string[]
                {
                    message.From.ToString(),
                    message.Subject,
                    message.Date.ToString()
                }));
            }
        }

        // ===== HÀM LOAD EMAIL THREAD-SAFE =====
        private async Task LoadEmails()
        {
            try
            {
                using (var client = new ImapClient())
                {
                    client.Connect(IMAP_HOST, IMAP_PORT, SecureSocketOptions.SslOnConnect);
                    client.Authenticate(SERVER_EMAIL, APP_PASSWORD);

                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadWrite);

                    // Lấy tất cả mail chưa đọc
                    var uids = inbox.Search(SearchQuery.NotSeen);

                    // Lấy 20 mail mới nhất
                    uids = uids.Reverse().Take(20).ToList();

                    foreach (var uid in uids)
                    {
                        var message = inbox.GetMessage(uid);

                        await ProcessEmailSafe(message);

                        inbox.AddFlags(uid, MessageFlags.Seen, true);
                    }

                    client.Disconnect(true);
                }

                // Thông báo reload thành công
                if (lstMail.InvokeRequired)
                {
                    lstMail.Invoke(new Action(() =>
                    {
                        MessageBox.Show("Reload email thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                }
                else
                {
                    MessageBox.Show("Reload email thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load email:\n" + ex.Message);
            }
        }
    }
}
