using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using Newtonsoft.Json;

namespace Bai04Lab05
{
    public partial class Bai04 : Form
    {
        List<Phim> dsPhim = new List<Phim>();
        Dictionary<string, List<string>> gheDaChon = new Dictionary<string, List<string>>();
        Dictionary<string, HoaDon> lichSuBanVe = new Dictionary<string, HoaDon>();

        public Bai04()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private async void ReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://betacinemas.vn/phim.htm";
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36");

                progressBar1.Value = 10;
                string html = await client.GetStringAsync(url);
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                var nodes = doc.DocumentNode.SelectNodes("//div[contains(@class, 'tab-content')]//div[contains(@class, 'col-')]");

                if (nodes == null)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phim!");
                    return;
                }

                dsPhim.Clear();
                cbMovie.Items.Clear();
                cbRoom.Items.Clear();

                foreach (var node in nodes)
                {
                    var titleNode = node.SelectSingleNode(".//h3/a");
                    var imgNode = node.SelectSingleNode(".//img");
                    var linkNode = node.SelectSingleNode(".//a[contains(@href, 'chi-tiet-phim')]");

                    if (titleNode != null && imgNode != null)
                    {
                        string tenPhim = WebUtility.HtmlDecode(titleNode.InnerText.Trim());
                        string linkAnh = imgNode.GetAttributeValue("src", "");
                        string linkChiTiet = titleNode.GetAttributeValue("href", "");

                        if (!linkChiTiet.StartsWith("http"))
                            linkChiTiet = "https://betacinemas.vn" + linkChiTiet;

                        if (dsPhim.Any(x => x.TenPhim == tenPhim)) continue;

                        Phim p = new Phim
                        {
                            TenPhim = tenPhim,
                            LinkAnh = linkAnh,
                            LinkChiTiet = linkChiTiet,
                            GiaVe = 90000,
                            DanhSachPhong = new List<int> { 1, 2, 3 }
                        };

                        dsPhim.Add(p);
                        cbMovie.Items.Add(p.TenPhim);
                    }
                }

                string json = JsonConvert.SerializeObject(dsPhim, Formatting.Indented);
                File.WriteAllText("movies.json", json);

                progressBar1.Value = 100;
                if (cbMovie.Items.Count > 0) cbMovie.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRoom.Items.Clear();
            if (cbMovie.SelectedIndex == -1) return;

            string tenPhim = cbMovie.SelectedItem.ToString();
            var phim = dsPhim.FirstOrDefault(x => x.TenPhim == tenPhim);

            if (phim != null)
            {
                foreach (int phong in phim.DanhSachPhong)
                {
                    cbRoom.Items.Add("Phòng " + phong);
                }
                try
                {
                    pbPoster.Load(phim.LinkAnh);
                }
                catch
                {
                    pbPoster.Image = null;
                }
            }

            if (cbRoom.Items.Count > 0) cbRoom.SelectedIndex = 0;
            lblResult.Text = "Tổng tiền: 0đ";
        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaoGhe();
        }

        private void TaoGhe()
        {
            panelSeats.Controls.Clear();
            if (cbMovie.SelectedIndex == -1 || cbRoom.SelectedIndex == -1) return;

            string tenPhim = cbMovie.SelectedItem.ToString();
            string tenPhong = cbRoom.SelectedItem.ToString();
            string keyPhong = tenPhim + "_" + tenPhong;

            int dong = 3;
            int cot = 5;
            string[] hangGhe = { "A", "B", "C" };
            int x = 0, y = 0;

            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Button btn = new Button();
                    string maGhe = hangGhe[i] + (j + 1);

                    btn.Text = maGhe;
                    btn.Width = 100;
                    btn.Height = 100;
                    btn.Location = new Point(x, y);
                    btn.Click += BtnGhe_Click;

                    string fullKey = keyPhong + "_" + maGhe;

                    if (lichSuBanVe.ContainsKey(fullKey))
                    {
                        btn.BackColor = Color.Gray;
                        btn.Enabled = false;
                    }
                    else if (gheDaChon.ContainsKey(keyPhong) && gheDaChon[keyPhong].Contains(maGhe))
                    {
                        btn.BackColor = Color.Blue;
                        btn.ForeColor = Color.White;
                    }
                    else
                    {
                        btn.BackColor = LayMauGheMacDinh(maGhe);
                    }

                    panelSeats.Controls.Add(btn);
                    x += 105;
                }
                x = 0;
                y += 125;
            }
        }

        private Color LayMauGheMacDinh(string ghe)
        {
            string[] veVot = { "A1", "A5", "C1", "C5" };
            string[] veVIP = { "B2", "B3", "B4" };

            if (veVot.Contains(ghe)) return Color.Yellow;
            if (veVIP.Contains(ghe)) return Color.Pink;
            return Color.White;
        }

        private void BtnGhe_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string maGhe = btn.Text;
            string tenPhim = cbMovie.SelectedItem.ToString();
            string tenPhong = cbRoom.SelectedItem.ToString();
            string keyPhong = tenPhim + "_" + tenPhong;
            string fullKey = keyPhong + "_" + maGhe;

            if (lichSuBanVe.ContainsKey(fullKey))
            {
                MessageBox.Show("Ghế này đã bán!");
                return;
            }

            if (!gheDaChon.ContainsKey(keyPhong))
            {
                gheDaChon[keyPhong] = new List<string>();
            }

            if (gheDaChon[keyPhong].Contains(maGhe))
            {
                gheDaChon[keyPhong].Remove(maGhe);
                btn.BackColor = LayMauGheMacDinh(maGhe);
                btn.ForeColor = Color.Black;
            }
            else
            {
                gheDaChon[keyPhong].Add(maGhe);
                btn.BackColor = Color.Blue;
                btn.ForeColor = Color.White;
            }
            TinhTienTam();
        }

        private void TinhTienTam()
        {
            long tong = 0;
            foreach (var item in gheDaChon)
            {
                string tenPhim = item.Key.Split('_')[0];
                var phim = dsPhim.FirstOrDefault(p => p.TenPhim == tenPhim);
                if (phim == null) continue;

                foreach (string ghe in item.Value)
                {
                    tong += TinhGiaGhe(phim.GiaVe, ghe);
                }
            }
            lblResult.Text = $"Tổng tiền: {tong:N0} đ";
        }

        private int TinhGiaGhe(int giaGoc, string ghe)
        {
            if (ghe == "A1" || ghe == "A5" || ghe == "C1" || ghe == "C5") return giaGoc / 4;
            if (ghe == "B2" || ghe == "B3" || ghe == "B4") return giaGoc * 2;
            return giaGoc;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomerName.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập tên và email!");
                return;
            }

            string tenPhim = cbMovie.SelectedItem.ToString();
            string tenPhong = cbRoom.SelectedItem.ToString();
            string keyPhong = tenPhim + "_" + tenPhong;

            if (!gheDaChon.ContainsKey(keyPhong) || gheDaChon[keyPhong].Count == 0)
            {
                MessageBox.Show("Chưa chọn ghế nào!");
                return;
            }

            var phim = dsPhim.FirstOrDefault(p => p.TenPhim == tenPhim);
            int tongTien = 0;
            List<string> dsGheDat = gheDaChon[keyPhong];

            foreach (var ghe in dsGheDat)
            {
                tongTien += TinhGiaGhe(phim.GiaVe, ghe);
            }

            HoaDon hd = new HoaDon
            {
                HoTen = txtCustomerName.Text,
                Email = txtEmail.Text,
                TongTien = tongTien,
                NgayDat = DateTime.Now,
                GheDaDat = new List<string>(dsGheDat),
                TenPhim = tenPhim
            };

            foreach (var ghe in dsGheDat)
            {
                lichSuBanVe[keyPhong + "_" + ghe] = hd;
            }

            GuiMail(hd, phim.LinkAnh);

            gheDaChon[keyPhong].Clear();
            TaoGhe();

            MessageBox.Show($"Đã thanh toán {tongTien:N0}đ. Đặt vé thành công! Vui lòng kiểm tra Email.");
        }

        private void GuiMail(HoaDon hd, string poster)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("rigerbob7@gmail.com");
                mail.To.Add(hd.Email);
                mail.Subject = "Vé xem phim: " + hd.TenPhim;

                string body = "<h1>HÓA ĐƠN XEM PHIM</h1>";
                body += $"<p>Khách hàng: {hd.HoTen}</p>";
                body += $"<p>Phim: {hd.TenPhim}</p>";
                body += $"<p>Ghế: {string.Join(", ", hd.GheDaDat)}</p>";
                body += $"<h3 style='color:red'>Tổng tiền: {hd.TongTien:N0} VNĐ</h3>";
                body += $"<img src='{poster}' width='200' />";
                body += $"<p style='color:white'>Chúc bạn cô đơn vui vẻ</p>";

                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("rigerbob7@gmail.com", "elql ggyy vxgf kskq");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi mail: " + ex.Message);
            }
        }

        private void pbPoster_Click(object sender, EventArgs e)
        {
            if (cbMovie.SelectedIndex != -1)
            {
                var phim = dsPhim.FirstOrDefault(p => p.TenPhim == cbMovie.SelectedItem.ToString());
                if (phim != null)
                {
                    Browser frm = new Browser(phim.LinkChiTiet);
                    frm.Show();
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class Phim
    {
        public string TenPhim { get; set; }
        public int GiaVe { get; set; }
        public List<int> DanhSachPhong { get; set; }
        public string LinkAnh { get; set; }
        public string LinkChiTiet { get; set; }
    }

    public class HoaDon
    {
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string TenPhim { get; set; }
        public List<string> GheDaDat { get; set; }
        public int TongTien { get; set; }
        public DateTime NgayDat { get; set; }
    }
}