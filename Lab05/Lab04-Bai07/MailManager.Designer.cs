namespace Lab04_Bai07
{
    partial class MailManager
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
            txtEmail = new TextBox();
            lstMail = new ListView();
            btnReload = new Button();
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
            lblAddFood.Size = new Size(201, 37);
            lblAddFood.TabIndex = 4;
            lblAddFood.Text = "Mail Manager";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 57);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 5;
            label1.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(68, 57);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(226, 27);
            txtEmail.TabIndex = 6;
            // 
            // lstMail
            // 
            lstMail.Location = new Point(19, 102);
            lstMail.Name = "lstMail";
            lstMail.Size = new Size(750, 310);
            lstMail.TabIndex = 7;
            lstMail.UseCompatibleStateImageBehavior = false;
            // 
            // btnReload
            // 
            btnReload.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReload.Location = new Point(617, 52);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(152, 36);
            btnReload.TabIndex = 8;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += this.btnReload_Click;
            // 
            // MailManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReload);
            Controls.Add(lstMail);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(lblAddFood);
            Name = "MailManager";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddFood;
        private Label label1;
        private TextBox txtEmail;
        private ListView lstMail;
        private Button btnReload;
    }
}