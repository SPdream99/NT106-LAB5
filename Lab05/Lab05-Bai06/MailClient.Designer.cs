namespace Lab05_Bai06
{
    partial class MailClient
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.txtIMAPPort = new System.Windows.Forms.TextBox();
            this.lblIMAPPort = new System.Windows.Forms.Label();
            this.txtIMAPHost = new System.Windows.Forms.TextBox();
            this.lblIMAP = new System.Windows.Forms.Label();
            this.txtSMTPPort = new System.Windows.Forms.TextBox();
            this.lblSMTPPort = new System.Windows.Forms.Label();
            this.txtSMTPHost = new System.Windows.Forms.TextBox();
            this.lblSMTP = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.listViewEmails = new System.Windows.Forms.ListView();
            this.colFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlContent = new System.Windows.Forms.TabControl();
            this.tabView = new System.Windows.Forms.TabPage();
            this.webBrowserView = new System.Windows.Forms.WebBrowser();
            this.lblViewFrom = new System.Windows.Forms.Label();
            this.lblViewSubject = new System.Windows.Forms.Label();
            this.tabSend = new System.Windows.Forms.TabPage();
            this.chkIsHtml = new System.Windows.Forms.CheckBox();
            this.lblAttachmentCount = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBody = new System.Windows.Forms.RichTextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelLogin.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tabControlContent.SuspendLayout();
            this.tabView.SuspendLayout();
            this.tabSend.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.groupBoxSettings);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Controls.Add(this.txtEmail);
            this.panelLogin.Controls.Add(this.lblEmail);
            this.panelLogin.Controls.Add(this.lblLoginTitle);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(1312, 690);
            this.panelLogin.TabIndex = 0;
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.txtIMAPPort);
            this.groupBoxSettings.Controls.Add(this.lblIMAPPort);
            this.groupBoxSettings.Controls.Add(this.txtIMAPHost);
            this.groupBoxSettings.Controls.Add(this.lblIMAP);
            this.groupBoxSettings.Controls.Add(this.txtSMTPPort);
            this.groupBoxSettings.Controls.Add(this.lblSMTPPort);
            this.groupBoxSettings.Controls.Add(this.txtSMTPHost);
            this.groupBoxSettings.Controls.Add(this.lblSMTP);
            this.groupBoxSettings.Location = new System.Drawing.Point(456, 222);
            this.groupBoxSettings.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSettings.Size = new System.Drawing.Size(400, 172);
            this.groupBoxSettings.TabIndex = 6;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Server Settings";
            // 
            // txtIMAPPort
            // 
            this.txtIMAPPort.Location = new System.Drawing.Point(307, 37);
            this.txtIMAPPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtIMAPPort.Name = "txtIMAPPort";
            this.txtIMAPPort.Size = new System.Drawing.Size(65, 22);
            this.txtIMAPPort.TabIndex = 3;
            this.txtIMAPPort.Text = "993";
            // 
            // lblIMAPPort
            // 
            this.lblIMAPPort.AutoSize = true;
            this.lblIMAPPort.Location = new System.Drawing.Point(267, 41);
            this.lblIMAPPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIMAPPort.Name = "lblIMAPPort";
            this.lblIMAPPort.Size = new System.Drawing.Size(31, 16);
            this.lblIMAPPort.TabIndex = 2;
            this.lblIMAPPort.Text = "Port";
            // 
            // txtIMAPHost
            // 
            this.txtIMAPHost.Location = new System.Drawing.Point(80, 37);
            this.txtIMAPHost.Margin = new System.Windows.Forms.Padding(4);
            this.txtIMAPHost.Name = "txtIMAPHost";
            this.txtIMAPHost.Size = new System.Drawing.Size(172, 22);
            this.txtIMAPHost.TabIndex = 1;
            this.txtIMAPHost.Text = "imap.gmail.com";
            // 
            // lblIMAP
            // 
            this.lblIMAP.AutoSize = true;
            this.lblIMAP.Location = new System.Drawing.Point(13, 41);
            this.lblIMAP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIMAP.Name = "lblIMAP";
            this.lblIMAP.Size = new System.Drawing.Size(39, 16);
            this.lblIMAP.TabIndex = 0;
            this.lblIMAP.Text = "IMAP";
            // 
            // txtSMTPPort
            // 
            this.txtSMTPPort.Location = new System.Drawing.Point(307, 86);
            this.txtSMTPPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtSMTPPort.Name = "txtSMTPPort";
            this.txtSMTPPort.Size = new System.Drawing.Size(65, 22);
            this.txtSMTPPort.TabIndex = 7;
            this.txtSMTPPort.Text = "587";
            // 
            // lblSMTPPort
            // 
            this.lblSMTPPort.AutoSize = true;
            this.lblSMTPPort.Location = new System.Drawing.Point(267, 90);
            this.lblSMTPPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSMTPPort.Name = "lblSMTPPort";
            this.lblSMTPPort.Size = new System.Drawing.Size(31, 16);
            this.lblSMTPPort.TabIndex = 6;
            this.lblSMTPPort.Text = "Port";
            // 
            // txtSMTPHost
            // 
            this.txtSMTPHost.Location = new System.Drawing.Point(80, 86);
            this.txtSMTPHost.Margin = new System.Windows.Forms.Padding(4);
            this.txtSMTPHost.Name = "txtSMTPHost";
            this.txtSMTPHost.Size = new System.Drawing.Size(172, 22);
            this.txtSMTPHost.TabIndex = 5;
            this.txtSMTPHost.Text = "smtp.gmail.com";
            // 
            // lblSMTP
            // 
            this.lblSMTP.AutoSize = true;
            this.lblSMTP.Location = new System.Drawing.Point(13, 90);
            this.lblSMTP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSMTP.Name = "lblSMTP";
            this.lblSMTP.Size = new System.Drawing.Size(45, 16);
            this.lblSMTP.TabIndex = 4;
            this.lblSMTP.Text = "SMTP";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(456, 406);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(400, 49);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(456, 172);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(399, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(456, 153);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(456, 111);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(399, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(456, 91);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblLoginTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLoginTitle.Location = new System.Drawing.Point(456, 25);
            this.lblLoginTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(225, 54);
            this.lblLoginTitle.TabIndex = 0;
            this.lblLoginTitle.Text = "Mail Client";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.splitContainerMain);
            this.panelMain.Controls.Add(this.panelTopBar);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1312, 690);
            this.panelMain.TabIndex = 1;
            this.panelMain.Visible = false;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 62);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.listViewEmails);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tabControlContent);
            this.splitContainerMain.Size = new System.Drawing.Size(1312, 628);
            this.splitContainerMain.SplitterDistance = 533;
            this.splitContainerMain.SplitterWidth = 5;
            this.splitContainerMain.TabIndex = 1;
            // 
            // listViewEmails
            // 
            this.listViewEmails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFrom,
            this.colSubject,
            this.colDate});
            this.listViewEmails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEmails.FullRowSelect = true;
            this.listViewEmails.HideSelection = false;
            this.listViewEmails.Location = new System.Drawing.Point(0, 0);
            this.listViewEmails.Margin = new System.Windows.Forms.Padding(4);
            this.listViewEmails.Name = "listViewEmails";
            this.listViewEmails.Size = new System.Drawing.Size(533, 628);
            this.listViewEmails.TabIndex = 0;
            this.listViewEmails.UseCompatibleStateImageBehavior = false;
            this.listViewEmails.View = System.Windows.Forms.View.Details;
            this.listViewEmails.SelectedIndexChanged += new System.EventHandler(this.listViewEmails_SelectedIndexChanged);
            // 
            // colFrom
            // 
            this.colFrom.Text = "From";
            this.colFrom.Width = 120;
            // 
            // colSubject
            // 
            this.colSubject.Text = "Subject";
            this.colSubject.Width = 180;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 100;
            // 
            // tabControlContent
            // 
            this.tabControlContent.Controls.Add(this.tabView);
            this.tabControlContent.Controls.Add(this.tabSend);
            this.tabControlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlContent.Location = new System.Drawing.Point(0, 0);
            this.tabControlContent.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlContent.Name = "tabControlContent";
            this.tabControlContent.SelectedIndex = 0;
            this.tabControlContent.Size = new System.Drawing.Size(774, 628);
            this.tabControlContent.TabIndex = 0;
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.webBrowserView);
            this.tabView.Controls.Add(this.lblViewFrom);
            this.tabView.Controls.Add(this.lblViewSubject);
            this.tabView.Location = new System.Drawing.Point(4, 25);
            this.tabView.Margin = new System.Windows.Forms.Padding(4);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tabView.Size = new System.Drawing.Size(766, 599);
            this.tabView.TabIndex = 0;
            this.tabView.Text = "View Mail";
            this.tabView.UseVisualStyleBackColor = true;
            // 
            // webBrowserView
            // 
            this.webBrowserView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserView.Location = new System.Drawing.Point(13, 78);
            this.webBrowserView.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowserView.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowserView.Name = "webBrowserView";
            this.webBrowserView.Size = new System.Drawing.Size(740, 509);
            this.webBrowserView.TabIndex = 2;
            // 
            // lblViewFrom
            // 
            this.lblViewFrom.AutoSize = true;
            this.lblViewFrom.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblViewFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblViewFrom.Location = new System.Drawing.Point(13, 46);
            this.lblViewFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViewFrom.Name = "lblViewFrom";
            this.lblViewFrom.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.lblViewFrom.Size = new System.Drawing.Size(50, 32);
            this.lblViewFrom.TabIndex = 1;
            this.lblViewFrom.Text = "From: ";
            // 
            // lblViewSubject
            // 
            this.lblViewSubject.AutoSize = true;
            this.lblViewSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblViewSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblViewSubject.Location = new System.Drawing.Point(13, 12);
            this.lblViewSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViewSubject.Name = "lblViewSubject";
            this.lblViewSubject.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblViewSubject.Size = new System.Drawing.Size(82, 34);
            this.lblViewSubject.TabIndex = 0;
            this.lblViewSubject.Text = "Subject";
            // 
            // tabSend
            // 
            this.tabSend.Controls.Add(this.chkIsHtml);
            this.tabSend.Controls.Add(this.lblAttachmentCount);
            this.tabSend.Controls.Add(this.btnBrowse);
            this.tabSend.Controls.Add(this.btnSend);
            this.tabSend.Controls.Add(this.txtBody);
            this.tabSend.Controls.Add(this.lblBody);
            this.tabSend.Controls.Add(this.txtSubject);
            this.tabSend.Controls.Add(this.lblSubject);
            this.tabSend.Controls.Add(this.txtTo);
            this.tabSend.Controls.Add(this.lblTo);
            this.tabSend.Location = new System.Drawing.Point(4, 25);
            this.tabSend.Margin = new System.Windows.Forms.Padding(4);
            this.tabSend.Name = "tabSend";
            this.tabSend.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tabSend.Size = new System.Drawing.Size(766, 599);
            this.tabSend.TabIndex = 1;
            this.tabSend.Text = "Compose";
            this.tabSend.UseVisualStyleBackColor = true;
            // 
            // chkIsHtml
            // 
            this.chkIsHtml.AutoSize = true;
            this.chkIsHtml.Checked = true;
            this.chkIsHtml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsHtml.Location = new System.Drawing.Point(307, 542);
            this.chkIsHtml.Margin = new System.Windows.Forms.Padding(4);
            this.chkIsHtml.Name = "chkIsHtml";
            this.chkIsHtml.Size = new System.Drawing.Size(66, 20);
            this.chkIsHtml.TabIndex = 9;
            this.chkIsHtml.Text = "HTML";
            this.chkIsHtml.UseVisualStyleBackColor = true;
            // 
            // lblAttachmentCount
            // 
            this.lblAttachmentCount.AutoSize = true;
            this.lblAttachmentCount.Location = new System.Drawing.Point(13, 542);
            this.lblAttachmentCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttachmentCount.Name = "lblAttachmentCount";
            this.lblAttachmentCount.Size = new System.Drawing.Size(89, 16);
            this.lblAttachmentCount.TabIndex = 8;
            this.lblAttachmentCount.Text = "0 attachments";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(160, 535);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(133, 31);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Attach File...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(613, 535);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(133, 37);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(13, 172);
            this.txtBody.Margin = new System.Windows.Forms.Padding(4);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(732, 344);
            this.txtBody.TabIndex = 5;
            this.txtBody.Text = "";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(13, 148);
            this.lblBody.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(39, 16);
            this.lblBody.TabIndex = 4;
            this.lblBody.Text = "Body";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(13, 105);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(732, 22);
            this.txtSubject.TabIndex = 3;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(13, 80);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(52, 16);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Subject";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(13, 43);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(732, 22);
            this.txtTo.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(13, 18);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 16);
            this.lblTo.TabIndex = 0;
            this.lblTo.Text = "To";
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTopBar.Controls.Add(this.btnSignOut);
            this.panelTopBar.Controls.Add(this.btnRefresh);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1312, 62);
            this.panelTopBar.TabIndex = 0;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(160, 12);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(133, 37);
            this.btnSignOut.TabIndex = 1;
            this.btnSignOut.Text = "Logout";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(13, 12);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(133, 37);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 664);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1312, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 20);
            this.lblStatus.Text = "Ready";
            // 
            // MailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MailClient";
            this.Text = "Email Client - Lab 05";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tabControlContent.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.tabView.PerformLayout();
            this.tabSend.ResumeLayout(false);
            this.tabSend.PerformLayout();
            this.panelTopBar.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.TextBox txtIMAPPort;
        private System.Windows.Forms.Label lblIMAPPort;
        private System.Windows.Forms.TextBox txtIMAPHost;
        private System.Windows.Forms.Label lblIMAP;
        private System.Windows.Forms.TextBox txtSMTPPort;
        private System.Windows.Forms.Label lblSMTPPort;
        private System.Windows.Forms.TextBox txtSMTPHost;
        private System.Windows.Forms.Label lblSMTP;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ListView listViewEmails;
        private System.Windows.Forms.ColumnHeader colFrom;
        private System.Windows.Forms.ColumnHeader colSubject;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.TabControl tabControlContent;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.TabPage tabSend;
        private System.Windows.Forms.Label lblViewSubject;
        private System.Windows.Forms.Label lblViewFrom;
        private System.Windows.Forms.WebBrowser webBrowserView;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.RichTextBox txtBody;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblAttachmentCount;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.CheckBox chkIsHtml;
    }
}