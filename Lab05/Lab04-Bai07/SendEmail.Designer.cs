namespace Lab04_Bai07
{
    partial class SendEmail
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
            lblAddFood = new Label();
            label1 = new Label();
            label2 = new Label();
            txtFrom = new TextBox();
            txtTo = new TextBox();
            txtTitle = new TextBox();
            txtBody = new TextBox();
            label3 = new Label();
            btnSend = new Button();
            label4 = new Label();
            txtPass = new TextBox();
            SuspendLayout();
            // 
            // lblAddFood
            // 
            lblAddFood.AutoSize = true;
            lblAddFood.BackColor = Color.Transparent;
            lblAddFood.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddFood.ForeColor = Color.LightSalmon;
            lblAddFood.Location = new Point(11, 9);
            lblAddFood.Margin = new Padding(2, 0, 2, 0);
            lblAddFood.Name = "lblAddFood";
            lblAddFood.Size = new Size(161, 37);
            lblAddFood.TabIndex = 3;
            lblAddFood.Text = "Send Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(429, 71);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 5;
            label2.Text = "To:";
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(83, 68);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(280, 27);
            txtFrom.TabIndex = 6;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(477, 68);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(311, 27);
            txtTo.TabIndex = 7;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(83, 162);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(705, 27);
            txtTitle.TabIndex = 8;
            // 
            // txtBody
            // 
            txtBody.Location = new Point(12, 195);
            txtBody.Multiline = true;
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(776, 208);
            txtBody.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 10;
            label3.Text = "Title:";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(451, 409);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(337, 29);
            btnSend.TabIndex = 11;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 111);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 12;
            label4.Text = "Pass:";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(83, 111);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(280, 27);
            txtPass.TabIndex = 13;
            // 
            // SendEmail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(btnSend);
            Controls.Add(label3);
            Controls.Add(txtBody);
            Controls.Add(txtTitle);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblAddFood);
            Name = "SendEmail";
            Text = "SendEmail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddFood;
        private Label label1;
        private Label label2;
        private TextBox txtFrom;
        private TextBox txtTo;
        private TextBox txtTitle;
        private TextBox txtBody;
        private Label label3;
        private Button btnSend;
        private Label label4;
        private TextBox txtPass;
    }
}