using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;


namespace Lab05_Bai23
{
    public partial class FormNoiDungMail : Form
    {
        private readonly MimeMessage _message;
        public FormNoiDungMail(MimeMessage message)
        {
            InitializeComponent();
            _message = message;

            RenderMail();
        }

        private void RenderMail()
        {
            // ===== SUBJECT =====
            if (!string.IsNullOrWhiteSpace(_message.Subject))
            {
                lbl_TieuDe.Text = _message.Subject;
                lbl_TieuDe.Visible = true;
            }
            else
            {
                lbl_TieuDe.Visible = false;
            }

            // ===== FROM =====
            if (_message.From != null && _message.From.Count > 0)
            {
                lbl_NguoiGui.Text = _message.From.ToString();
                lbl_NguoiGui.Visible = true;
            }
            else
            {
                lbl_NguoiGui.Visible = false;
            }

            // ===== DATE =====
            if (_message.Date != DateTimeOffset.MinValue)
            {
                lbl_NgayGui.Text = _message.Date.ToLocalTime().ToString("dd/MM/yyyy HH:mm");
                lbl_NgayGui.Visible = true;
            }
            else
            {
                lbl_NgayGui.Visible = false;
            }

            // ===== BODY =====
            RenderBody();
        }

        private void RenderBody()
        {
            string body;

            if (!string.IsNullOrWhiteSpace(_message.TextBody))
            {
                body = _message.TextBody;
            }
            else if (!string.IsNullOrWhiteSpace(_message.HtmlBody))
            {
                string html = _message.HtmlBody;

                html = Regex.Replace(html, "<(script|style)[^>]*?>.*?</\\1>",
                    "", RegexOptions.Singleline | RegexOptions.IgnoreCase);

                string plain = Regex.Replace(html, "<.*?>", " ");
                plain = WebUtility.HtmlDecode(plain);
                plain = Regex.Replace(plain, "\\s+", " ").Trim();

                if (string.IsNullOrWhiteSpace(plain))
                    body = "(No content)";
                else
                    body = "[Email dạng HTML – không hiển thị được nội dung]";
            }
            else
            {
                body = "(No content)";
            }

            // Nếu không có nội dung → ẩn RichTextBox?
            if (body == "(No content)")
            {
                richtextbox_Body.Text = body;
                richtextbox_Body.ForeColor = Color.Gray;
            }
            else
            {
                richtextbox_Body.Text = body;
                richtextbox_Body.ForeColor = Color.Black;
            }
        }


        
    }
}
