using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Windows.Forms;

namespace Lab05_Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string from = txtFrom.Text.Trim();
            string password = txtPassword.Text.Trim(); // App Password Gmail
            string to = txtTo.Text.Trim();
            string subject = txtSubject.Text.Trim();
            string body = rtbBody.Text;

            if (string.IsNullOrEmpty(from) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(to))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ From, Password và To!");
                return;
            }

            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Sender", from));
                message.To.Add(new MailboxAddress("Receiver", to));
                message.Subject = subject;
                message.Body = new TextPart("plain")
                {
                    Text = body
                };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);
                    client.Authenticate(from, password);
                    client.Send(message);
                    client.Disconnect(true);
                }

                MessageBox.Show("Gửi email thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
