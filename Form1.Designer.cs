namespace SSHMonitor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.addConnBtn = new System.Windows.Forms.Button();
            this.addConnPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connTestResultLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.cancelAddBtn = new System.Windows.Forms.Button();
            this.testBtn = new System.Windows.Forms.Button();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serverNameText = new System.Windows.Forms.TextBox();
            this.hostTxt = new System.Windows.Forms.TextBox();
            this.portText = new System.Windows.Forms.TextBox();
            this.userText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userAddTxt = new System.Windows.Forms.TextBox();
            this.basePanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.editConnBtn = new System.Windows.Forms.Button();
            this.wirePanel = new System.Windows.Forms.Panel();
            this.wirePanelGroup = new System.Windows.Forms.GroupBox();
            this.vpnSettingsList = new System.Windows.Forms.ListView();
            this.nameHeader = new System.Windows.Forms.ColumnHeader();
            this.remoteIpHeader = new System.Windows.Forms.ColumnHeader();
            this.virtualIpHeader = new System.Windows.Forms.ColumnHeader();
            this.bytesRecHeader = new System.Windows.Forms.ColumnHeader();
            this.bytesSentHeader = new System.Windows.Forms.ColumnHeader();
            this.lastSeenHeader = new System.Windows.Forms.ColumnHeader();
            this.closeConfiguratorBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dlConfigContextBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.showQrConfigContextBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserContextBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.addConnPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.wirePanel.SuspendLayout();
            this.wirePanelGroup.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addConnBtn
            // 
            this.addConnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addConnBtn.Location = new System.Drawing.Point(641, 12);
            this.addConnBtn.Name = "addConnBtn";
            this.addConnBtn.Size = new System.Drawing.Size(147, 23);
            this.addConnBtn.TabIndex = 1;
            this.addConnBtn.Text = "Add new connection";
            this.addConnBtn.UseVisualStyleBackColor = true;
            this.addConnBtn.Click += new System.EventHandler(this.addConnBtn_Click);
            // 
            // addConnPanel
            // 
            this.addConnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addConnPanel.Controls.Add(this.groupBox1);
            this.addConnPanel.Location = new System.Drawing.Point(12, 12);
            this.addConnPanel.Name = "addConnPanel";
            this.addConnPanel.Size = new System.Drawing.Size(776, 413);
            this.addConnPanel.TabIndex = 2;
            this.addConnPanel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connTestResultLabel);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.cancelAddBtn);
            this.groupBox1.Controls.Add(this.testBtn);
            this.groupBox1.Controls.Add(this.inputPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new connection";
            // 
            // connTestResultLabel
            // 
            this.connTestResultLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connTestResultLabel.AutoSize = true;
            this.connTestResultLabel.Location = new System.Drawing.Point(224, 231);
            this.connTestResultLabel.Name = "connTestResultLabel";
            this.connTestResultLabel.Size = new System.Drawing.Size(0, 15);
            this.connTestResultLabel.TabIndex = 8;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveBtn.Enabled = false;
            this.saveBtn.Location = new System.Drawing.Point(224, 254);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(18, 10);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(89, 23);
            this.addUserBtn.TabIndex = 1;
            this.addUserBtn.Text = "Add user";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Visible = false;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // cancelAddBtn
            // 
            this.cancelAddBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelAddBtn.Location = new System.Drawing.Point(458, 254);
            this.cancelAddBtn.Name = "cancelAddBtn";
            this.cancelAddBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelAddBtn.TabIndex = 6;
            this.cancelAddBtn.Text = "Cancel";
            this.cancelAddBtn.UseVisualStyleBackColor = true;
            this.cancelAddBtn.Click += new System.EventHandler(this.cancelAddBtn_Click);
            // 
            // testBtn
            // 
            this.testBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.testBtn.Location = new System.Drawing.Point(377, 254);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 6;
            this.testBtn.Text = "Test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // inputPanel
            // 
            this.inputPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputPanel.Controls.Add(this.label8);
            this.inputPanel.Controls.Add(this.label1);
            this.inputPanel.Controls.Add(this.serverNameText);
            this.inputPanel.Controls.Add(this.hostTxt);
            this.inputPanel.Controls.Add(this.portText);
            this.inputPanel.Controls.Add(this.userText);
            this.inputPanel.Controls.Add(this.label4);
            this.inputPanel.Controls.Add(this.passText);
            this.inputPanel.Controls.Add(this.label3);
            this.inputPanel.Controls.Add(this.label2);
            this.inputPanel.Location = new System.Drawing.Point(224, 72);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(309, 158);
            this.inputPanel.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host";
            // 
            // serverNameText
            // 
            this.serverNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serverNameText.Location = new System.Drawing.Point(98, 19);
            this.serverNameText.Name = "serverNameText";
            this.serverNameText.Size = new System.Drawing.Size(211, 23);
            this.serverNameText.TabIndex = 0;
            // 
            // hostTxt
            // 
            this.hostTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hostTxt.Location = new System.Drawing.Point(98, 48);
            this.hostTxt.Name = "hostTxt";
            this.hostTxt.Size = new System.Drawing.Size(211, 23);
            this.hostTxt.TabIndex = 0;
            // 
            // portText
            // 
            this.portText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.portText.Location = new System.Drawing.Point(98, 77);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(211, 23);
            this.portText.TabIndex = 1;
            this.portText.Text = "22";
            // 
            // userText
            // 
            this.userText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userText.Location = new System.Drawing.Point(98, 106);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(211, 23);
            this.userText.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // passText
            // 
            this.passText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passText.Location = new System.Drawing.Point(98, 135);
            this.passText.Name = "passText";
            this.passText.PasswordChar = '*';
            this.passText.Size = new System.Drawing.Size(211, 23);
            this.passText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // userAddTxt
            // 
            this.userAddTxt.Location = new System.Drawing.Point(113, 10);
            this.userAddTxt.Name = "userAddTxt";
            this.userAddTxt.Size = new System.Drawing.Size(176, 23);
            this.userAddTxt.TabIndex = 2;
            this.userAddTxt.Visible = false;
            // 
            // basePanel
            // 
            this.basePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basePanel.Location = new System.Drawing.Point(12, 41);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(776, 378);
            this.basePanel.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Online = ";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(61, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 32);
            this.label10.TabIndex = 5;
            this.label10.Text = "•";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Loading =";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.BlueViolet;
            this.label12.Location = new System.Drawing.Point(144, 419);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 32);
            this.label12.TabIndex = 5;
            this.label12.Text = "•";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(210, 419);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 32);
            this.label13.TabIndex = 5;
            this.label13.Text = "•";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(174, 428);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "Error =";
            // 
            // editConnBtn
            // 
            this.editConnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editConnBtn.Location = new System.Drawing.Point(499, 12);
            this.editConnBtn.Name = "editConnBtn";
            this.editConnBtn.Size = new System.Drawing.Size(136, 23);
            this.editConnBtn.TabIndex = 1;
            this.editConnBtn.Text = "Edit connections";
            this.editConnBtn.UseVisualStyleBackColor = true;
            this.editConnBtn.Click += new System.EventHandler(this.editConnBtn_Click);
            // 
            // wirePanel
            // 
            this.wirePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wirePanel.Controls.Add(this.wirePanelGroup);
            this.wirePanel.Location = new System.Drawing.Point(12, 41);
            this.wirePanel.Name = "wirePanel";
            this.wirePanel.Size = new System.Drawing.Size(776, 384);
            this.wirePanel.TabIndex = 6;
            this.wirePanel.Visible = false;
            // 
            // wirePanelGroup
            // 
            this.wirePanelGroup.Controls.Add(this.vpnSettingsList);
            this.wirePanelGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wirePanelGroup.Location = new System.Drawing.Point(0, 0);
            this.wirePanelGroup.Name = "wirePanelGroup";
            this.wirePanelGroup.Size = new System.Drawing.Size(776, 384);
            this.wirePanelGroup.TabIndex = 1;
            this.wirePanelGroup.TabStop = false;
            this.wirePanelGroup.Text = "groupBox2";
            // 
            // vpnSettingsList
            // 
            this.vpnSettingsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vpnSettingsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.remoteIpHeader,
            this.virtualIpHeader,
            this.bytesRecHeader,
            this.bytesSentHeader,
            this.lastSeenHeader});
            this.vpnSettingsList.HideSelection = false;
            this.vpnSettingsList.Location = new System.Drawing.Point(6, 22);
            this.vpnSettingsList.Name = "vpnSettingsList";
            this.vpnSettingsList.Size = new System.Drawing.Size(764, 353);
            this.vpnSettingsList.TabIndex = 0;
            this.vpnSettingsList.UseCompatibleStateImageBehavior = false;
            this.vpnSettingsList.View = System.Windows.Forms.View.Details;
            this.vpnSettingsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.vpnSettingsList_MouseClick);
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "User";
            this.nameHeader.Width = 90;
            // 
            // remoteIpHeader
            // 
            this.remoteIpHeader.Text = "Remote IP";
            this.remoteIpHeader.Width = 128;
            // 
            // virtualIpHeader
            // 
            this.virtualIpHeader.Text = "Virtual IP";
            this.virtualIpHeader.Width = 128;
            // 
            // bytesRecHeader
            // 
            this.bytesRecHeader.Text = "Bytes Received";
            this.bytesRecHeader.Width = 96;
            // 
            // bytesSentHeader
            // 
            this.bytesSentHeader.Text = "Bytes Sent";
            this.bytesSentHeader.Width = 96;
            // 
            // lastSeenHeader
            // 
            this.lastSeenHeader.Text = "Last Seen";
            this.lastSeenHeader.Width = 200;
            // 
            // closeConfiguratorBtn
            // 
            this.closeConfiguratorBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeConfiguratorBtn.Location = new System.Drawing.Point(641, 11);
            this.closeConfiguratorBtn.Name = "closeConfiguratorBtn";
            this.closeConfiguratorBtn.Size = new System.Drawing.Size(147, 23);
            this.closeConfiguratorBtn.TabIndex = 7;
            this.closeConfiguratorBtn.Text = "Close configurator";
            this.closeConfiguratorBtn.UseVisualStyleBackColor = true;
            this.closeConfiguratorBtn.Visible = false;
            this.closeConfiguratorBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dlConfigContextBtn,
            this.showQrConfigContextBtn,
            this.deleteUserContextBtn});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 70);
            // 
            // dlConfigContextBtn
            // 
            this.dlConfigContextBtn.Name = "dlConfigContextBtn";
            this.dlConfigContextBtn.Size = new System.Drawing.Size(165, 22);
            this.dlConfigContextBtn.Text = "Download config";
            this.dlConfigContextBtn.Click += new System.EventHandler(this.dlConfigContextBtn_Click);
            // 
            // showQrConfigContextBtn
            // 
            this.showQrConfigContextBtn.Name = "showQrConfigContextBtn";
            this.showQrConfigContextBtn.Size = new System.Drawing.Size(165, 22);
            this.showQrConfigContextBtn.Text = "Show config QR";
            this.showQrConfigContextBtn.Click += new System.EventHandler(this.showQrConfigContextBtn_Click);
            // 
            // deleteUserContextBtn
            // 
            this.deleteUserContextBtn.Name = "deleteUserContextBtn";
            this.deleteUserContextBtn.Size = new System.Drawing.Size(165, 22);
            this.deleteUserContextBtn.Text = "Delete";
            this.deleteUserContextBtn.Click += new System.EventHandler(this.deleteUserContextBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userAddTxt);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.closeConfiguratorBtn);
            this.Controls.Add(this.wirePanel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.editConnBtn);
            this.Controls.Add(this.addConnBtn);
            this.Controls.Add(this.basePanel);
            this.Controls.Add(this.addConnPanel);
            this.Name = "Form1";
            this.Text = "SSH Monitor (v1.0)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.addConnPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.wirePanel.ResumeLayout(false);
            this.wirePanelGroup.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addConnBtn;
        private System.Windows.Forms.Panel addConnPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox portText;
        private System.Windows.Forms.TextBox hostTxt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label connTestResultLabel;
        private System.Windows.Forms.TextBox se;
        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox serverNameText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button editConnBtn;
        private System.Windows.Forms.Panel wirePanel;
        private System.Windows.Forms.Panel l;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox wirePanelGroup;
        private System.Windows.Forms.Button closeConfiguratorBtn;
        private System.Windows.Forms.ListView vpnSettingsList;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader remoteIpHeader;
        private System.Windows.Forms.ColumnHeader virtualIpHeader;
        private System.Windows.Forms.ColumnHeader bytesRecHeader;
        private System.Windows.Forms.ColumnHeader bytesSentHeader;
        private System.Windows.Forms.ColumnHeader lastSeenHeader;
        private System.Windows.Forms.Button cancelAddBtn;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox userAddTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteUserContextBtn;
        private System.Windows.Forms.ToolStripMenuItem dlConfigContextBtn;
        private System.Windows.Forms.ToolStripMenuItem showQrConfigContextBtn;
    }
}

