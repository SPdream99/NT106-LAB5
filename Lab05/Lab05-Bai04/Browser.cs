using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace Bai04Lab05
{
    public partial class Browser : Form
    {
        private string _url;
        public Browser(string url)
        {
            InitializeComponent();
            _url = url;
            this.Load += FrmBrowser_Load;
        }
        private async void FrmBrowser_Load(object sender, EventArgs e)
        {
            try
            {
                await webView21.EnsureCoreWebView2Async();
                if (!string.IsNullOrEmpty(_url) && Uri.IsWellFormedUriString(_url, UriKind.Absolute))
                {
                    webView21.CoreWebView2.Navigate(_url);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo trình duyệt: " + ex.Message);
            }
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }
    }
}
