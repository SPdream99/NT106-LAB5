using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Windows.Forms;

namespace Lab04_Bai07
{
    public partial class SendEmail : Form
    {
        public SendEmail()
        {
            InitializeComponent();

            txtTitle.Text = "Đóng góp món ăn";
            txtTo.Text = "akito1211shinonome@gmail.com";

            // Gmail của bạn
            txtFrom.Text = "leo716496@gmail.com";

            // App Password (16 ký tự)
            txtPass.Text = "aknc eoqf qzaa rinw";
        }

        private bool IsValidBody(string body)
        {
            var lines = body.Split(
                new[] { '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                if (!line.Contains(";")) return false;

                var parts = line.Split(';');
                if (parts.Length != 2) return false;

                if (string.IsNullOrWhiteSpace(parts[0]) ||
                    string.IsNullOrWhiteSpace(parts[1]))
                    return false;
            }
            return true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!IsValidBody(txtBody.Text))
            {
                MessageBox.Show(
                    "Body không đúng định dạng!\n<Món ăn>;<Hình ảnh>");
                return;
            }

            try
            {
                var message = new MimeMessage();
                message.From.Add(MailboxAddress.Parse(txtFrom.Text.Trim()));
                message.To.Add(MailboxAddress.Parse(txtTo.Text.Trim()));
                message.Subject = txtTitle.Text;

                message.Body = new TextPart("plain")
                {
                    Text = txtBody.Text
                };
                using (var client = new SmtpClient())
                {
                    client.Connect(
                        "smtp.gmail.com",
                        587,
                        SecureSocketOptions.StartTls);
                    client.Authenticate(
                        txtFrom.Text.Trim(),
                        txtPass.Text.Trim());

                    client.Send(message);
                    client.Disconnect(true);
                }

                MessageBox.Show("Đã gửi mail qua Gmail!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gửi mail thất bại!\n" + ex.Message);
            }
        }
    }
}
