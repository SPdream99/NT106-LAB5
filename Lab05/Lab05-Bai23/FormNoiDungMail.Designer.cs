namespace Lab05_Bai23
{
    partial class FormNoiDungMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            richtextbox_Body = new RichTextBox();
            lbl_Subject = new Label();
            lbl_From = new Label();
            lbl_Date = new Label();
            lbl_TieuDe = new Label();
            lbl_NguoiGui = new Label();
            lbl_NgayGui = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 31);
            label1.Name = "label1";
            label1.Size = new Size(119, 37);
            label1.TabIndex = 0;
            label1.Text = "Subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 91);
            label2.Name = "label2";
            label2.Size = new Size(91, 37);
            label2.TabIndex = 1;
            label2.Text = "From:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 151);
            label3.Name = "label3";
            label3.Size = new Size(85, 37);
            label3.TabIndex = 2;
            label3.Text = "Date:";
            // 
            // richtextbox_Body
            // 
            richtextbox_Body.Location = new Point(43, 211);
            richtextbox_Body.Name = "richtextbox_Body";
            richtextbox_Body.Size = new Size(1021, 453);
            richtextbox_Body.TabIndex = 3;
            richtextbox_Body.Text = "";
            // 
            // lbl_Subject
            // 
            lbl_Subject.AutoSize = true;
            lbl_Subject.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Subject.Location = new Point(177, 31);
            lbl_Subject.Name = "lbl_Subject";
            lbl_Subject.Size = new Size(0, 37);
            lbl_Subject.TabIndex = 4;
            // 
            // lbl_From
            // 
            lbl_From.AutoSize = true;
            lbl_From.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_From.Location = new Point(177, 91);
            lbl_From.Name = "lbl_From";
            lbl_From.Size = new Size(0, 37);
            lbl_From.TabIndex = 5;
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Date.Location = new Point(177, 151);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(0, 37);
            lbl_Date.TabIndex = 6;
            // 
            // lbl_TieuDe
            // 
            lbl_TieuDe.AutoSize = true;
            lbl_TieuDe.Location = new Point(177, 35);
            lbl_TieuDe.Name = "lbl_TieuDe";
            lbl_TieuDe.Size = new Size(78, 32);
            lbl_TieuDe.TabIndex = 0;
            lbl_TieuDe.Text = "label4";
            // 
            // lbl_NguoiGui
            // 
            lbl_NguoiGui.AutoSize = true;
            lbl_NguoiGui.Location = new Point(183, 91);
            lbl_NguoiGui.Name = "lbl_NguoiGui";
            lbl_NguoiGui.Size = new Size(78, 32);
            lbl_NguoiGui.TabIndex = 8;
            lbl_NguoiGui.Text = "label5";
            // 
            // lbl_NgayGui
            // 
            lbl_NgayGui.AutoSize = true;
            lbl_NgayGui.Location = new Point(183, 156);
            lbl_NgayGui.Name = "lbl_NgayGui";
            lbl_NgayGui.Size = new Size(78, 32);
            lbl_NgayGui.TabIndex = 9;
            lbl_NgayGui.Text = "label6";
            // 
            // FormNoiDungMail
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1094, 698);
            Controls.Add(lbl_NgayGui);
            Controls.Add(lbl_NguoiGui);
            Controls.Add(lbl_TieuDe);
            Controls.Add(lbl_Date);
            Controls.Add(lbl_From);
            Controls.Add(lbl_Subject);
            Controls.Add(richtextbox_Body);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormNoiDungMail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormNoiDungMail";
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox richtextbox_Body;
        private Label lbl_Subject;
        private Label lbl_From;
        private Label lbl_Date;
        private Label lbl_TieuDe;
        private Label lbl_NguoiGui;
        private Label lbl_NgayGui;
    }
}