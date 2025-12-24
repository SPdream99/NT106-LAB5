namespace Lab05_Bai23
{
    partial class Form23
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_Email = new TextBox();
            txt_Password = new TextBox();
            rb_IMAP = new RadioButton();
            rb_POP3 = new RadioButton();
            btn_Login = new Button();
            label2 = new Label();
            label3 = new Label();
            lv_Mail = new ListView();
            lbl_Total = new Label();
            lbl_Recent = new Label();
            label5 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 46);
            label1.Name = "label1";
            label1.Size = new Size(88, 37);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(175, 44);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(592, 39);
            txt_Email.TabIndex = 2;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(175, 108);
            txt_Password.Multiline = true;
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(592, 39);
            txt_Password.TabIndex = 3;
            // 
            // rb_IMAP
            // 
            rb_IMAP.AutoSize = true;
            rb_IMAP.Location = new Point(175, 182);
            rb_IMAP.Name = "rb_IMAP";
            rb_IMAP.Size = new Size(101, 36);
            rb_IMAP.TabIndex = 5;
            rb_IMAP.TabStop = true;
            rb_IMAP.Text = "IMAP";
            rb_IMAP.UseVisualStyleBackColor = true;
            // 
            // rb_POP3
            // 
            rb_POP3.AutoSize = true;
            rb_POP3.Location = new Point(393, 182);
            rb_POP3.Name = "rb_POP3";
            rb_POP3.Size = new Size(102, 36);
            rb_POP3.TabIndex = 6;
            rb_POP3.TabStop = true;
            rb_POP3.Text = "POP3";
            rb_POP3.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Login.Location = new Point(893, 67);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(150, 62);
            btn_Login.TabIndex = 7;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 110);
            label2.Name = "label2";
            label2.Size = new Size(134, 37);
            label2.TabIndex = 8;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 180);
            label3.Name = "label3";
            label3.Size = new Size(117, 37);
            label3.TabIndex = 9;
            label3.Text = "Method:";
            // 
            // lv_Mail
            // 
            lv_Mail.Location = new Point(35, 313);
            lv_Mail.Name = "lv_Mail";
            lv_Mail.Size = new Size(1045, 505);
            lv_Mail.TabIndex = 10;
            lv_Mail.UseCompatibleStateImageBehavior = false;
            lv_Mail.DoubleClick += lv_Mail_DoubleClick;
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Total.Location = new Point(123, 256);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(87, 37);
            lbl_Total.TabIndex = 11;
            lbl_Total.Text = "          ";
            // 
            // lbl_Recent
            // 
            lbl_Recent.AutoSize = true;
            lbl_Recent.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Recent.Location = new Point(484, 256);
            lbl_Recent.Name = "lbl_Recent";
            lbl_Recent.Size = new Size(101, 37);
            lbl_Recent.TabIndex = 12;
            lbl_Recent.Text = "            ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(35, 256);
            label5.Name = "label5";
            label5.Size = new Size(80, 37);
            label5.TabIndex = 14;
            label5.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(376, 256);
            label4.Name = "label4";
            label4.Size = new Size(102, 37);
            label4.TabIndex = 15;
            label4.Text = "Recent:";
            // 
            // Form23
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1121, 845);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(lbl_Recent);
            Controls.Add(lbl_Total);
            Controls.Add(lv_Mail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_Login);
            Controls.Add(rb_POP3);
            Controls.Add(rb_IMAP);
            Controls.Add(txt_Password);
            Controls.Add(txt_Email);
            Controls.Add(label1);
            Name = "Form23";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form23";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Email;
        private TextBox txt_Password;
        private RadioButton rb_IMAP;
        private RadioButton rb_POP3;
        private Button btn_Login;
        private Label label2;
        private Label label3;
        private ListView lv_Mail;
        private Label lbl_Total;
        private Label lbl_Recent;
        private Label label5;
        private Label label4;
    }
}
