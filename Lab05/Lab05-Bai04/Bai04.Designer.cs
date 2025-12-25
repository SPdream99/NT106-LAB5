namespace Bai04Lab05
{
    partial class Bai04
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            progressBar1 = new ProgressBar();
            ReadFile = new Button();
            label3 = new Label();
            exit = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            SCREEN = new Label();
            label2 = new Label();
            label1 = new Label();
            panelSeats = new Panel();
            lblResult = new Label();
            btnCalculate = new Button();
            cbRoom = new ComboBox();
            cbMovie = new ComboBox();
            pbPoster = new PictureBox();
            label9 = new Label();
            txtCustomerName = new TextBox();
            label10 = new Label();
            txtEmail = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPoster).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(804, 218);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(244, 35);
            progressBar1.TabIndex = 52;
            // 
            // ReadFile
            // 
            ReadFile.Location = new Point(804, 172);
            ReadFile.Margin = new Padding(3, 4, 3, 4);
            ReadFile.Name = "ReadFile";
            ReadFile.Size = new Size(125, 35);
            ReadFile.TabIndex = 48;
            ReadFile.Text = "Tải dữ liệu";
            ReadFile.UseVisualStyleBackColor = true;
            ReadFile.Click += ReadFile_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(400, 38);
            label3.Name = "label3";
            label3.Size = new Size(353, 48);
            label3.TabIndex = 0;
            label3.Text = "BÁN VÉ ONLINE";
            // 
            // exit
            // 
            exit.BackColor = Color.White;
            exit.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.Location = new Point(239, 794);
            exit.Margin = new Padding(3, 4, 3, 4);
            exit.Name = "exit";
            exit.Size = new Size(131, 74);
            exit.TabIndex = 44;
            exit.Text = "THOÁT";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1149, 135);
            panel2.TabIndex = 42;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(SCREEN);
            panel1.Location = new Point(41, 160);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 71);
            panel1.TabIndex = 41;
            // 
            // SCREEN
            // 
            SCREEN.AutoSize = true;
            SCREEN.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SCREEN.ForeColor = Color.White;
            SCREEN.Location = new Point(198, 12);
            SCREEN.Name = "SCREEN";
            SCREEN.Size = new Size(150, 35);
            SCREEN.TabIndex = 0;
            SCREEN.Text = "MÀN HÌNH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(804, 389);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 40;
            label2.Text = "Chọn rạp số";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(804, 269);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 39;
            label1.Text = "Chọn phim";
            // 
            // panelSeats
            // 
            panelSeats.BorderStyle = BorderStyle.FixedSingle;
            panelSeats.Location = new Point(41, 254);
            panelSeats.Margin = new Padding(3, 4, 3, 4);
            panelSeats.Name = "panelSeats";
            panelSeats.Size = new Size(527, 410);
            panelSeats.TabIndex = 38;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.Red;
            lblResult.Location = new Point(38, 741);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(150, 26);
            lblResult.TabIndex = 37;
            lblResult.Text = "Tổng tiền: 0đ";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.LightSkyBlue;
            btnCalculate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(41, 794);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(132, 74);
            btnCalculate.TabIndex = 36;
            btnCalculate.Text = "THANH TOÁN";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // cbRoom
            // 
            cbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoom.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbRoom.FormattingEnabled = true;
            cbRoom.Location = new Point(809, 434);
            cbRoom.Margin = new Padding(3, 4, 3, 4);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(321, 30);
            cbRoom.TabIndex = 35;
            cbRoom.SelectedIndexChanged += cbRoom_SelectedIndexChanged;
            // 
            // cbMovie
            // 
            cbMovie.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMovie.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMovie.FormattingEnabled = true;
            cbMovie.Location = new Point(809, 314);
            cbMovie.Margin = new Padding(3, 4, 3, 4);
            cbMovie.Name = "cbMovie";
            cbMovie.Size = new Size(321, 30);
            cbMovie.TabIndex = 34;
            cbMovie.SelectedIndexChanged += cbMovie_SelectedIndexChanged;
            // 
            // pbPoster
            // 
            pbPoster.BorderStyle = BorderStyle.FixedSingle;
            pbPoster.Location = new Point(600, 160);
            pbPoster.Margin = new Padding(3, 4, 3, 4);
            pbPoster.Name = "pbPoster";
            pbPoster.Size = new Size(198, 311);
            pbPoster.SizeMode = PictureBoxSizeMode.Zoom;
            pbPoster.TabIndex = 53;
            pbPoster.TabStop = false;
            pbPoster.Click += pbPoster_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(600, 530);
            label9.Name = "label9";
            label9.Size = new Size(101, 25);
            label9.TabIndex = 55;
            label9.Text = "Họ và tên:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerName.Location = new Point(605, 566);
            txtCustomerName.Margin = new Padding(3, 4, 3, 4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(444, 32);
            txtCustomerName.TabIndex = 56;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(605, 639);
            label10.Name = "label10";
            label10.Size = new Size(66, 25);
            label10.TabIndex = 57;
            label10.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(605, 675);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(444, 32);
            txtEmail.TabIndex = 58;
            // 
            // BT4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1149, 1015);
            Controls.Add(txtEmail);
            Controls.Add(label10);
            Controls.Add(txtCustomerName);
            Controls.Add(label9);
            Controls.Add(pbPoster);
            Controls.Add(progressBar1);
            Controls.Add(ReadFile);
            Controls.Add(exit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelSeats);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(cbRoom);
            Controls.Add(cbMovie);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BT4";
            Text = "Bài 4 - Lab 05";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPoster).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.Label SCREEN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSeats;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.ComboBox cbMovie;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
    }
}