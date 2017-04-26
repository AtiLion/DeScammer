namespace DeScammerControlPanel
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblClientStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShutdownClient = new System.Windows.Forms.Button();
            this.btnDisconnectClient = new System.Windows.Forms.Button();
            this.tabTrolls = new System.Windows.Forms.TabPage();
            this.tabRemoteOptions = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabTrolls);
            this.tabControl1.Controls.Add(this.tabRemoteOptions);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(470, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.groupBox1);
            this.tabMain.Controls.Add(this.groupBox2);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(462, 351);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server connection";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(164, 45);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 45);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(136, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP to virtual machine:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(118, 19);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(182, 20);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "127.0.0.1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblClientStatus);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnShutdownClient);
            this.groupBox2.Controls.Add(this.btnDisconnectClient);
            this.groupBox2.Location = new System.Drawing.Point(320, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // lblClientStatus
            // 
            this.lblClientStatus.AutoSize = true;
            this.lblClientStatus.ForeColor = System.Drawing.Color.Red;
            this.lblClientStatus.Location = new System.Drawing.Point(6, 87);
            this.lblClientStatus.Name = "lblClientStatus";
            this.lblClientStatus.Size = new System.Drawing.Size(73, 13);
            this.lblClientStatus.TabIndex = 3;
            this.lblClientStatus.Text = "Disconnected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client status:";
            // 
            // btnShutdownClient
            // 
            this.btnShutdownClient.Enabled = false;
            this.btnShutdownClient.Location = new System.Drawing.Point(6, 48);
            this.btnShutdownClient.Name = "btnShutdownClient";
            this.btnShutdownClient.Size = new System.Drawing.Size(122, 23);
            this.btnShutdownClient.TabIndex = 1;
            this.btnShutdownClient.Text = "Shutdown Server";
            this.btnShutdownClient.UseVisualStyleBackColor = true;
            this.btnShutdownClient.Click += new System.EventHandler(this.btnShutdownClient_Click);
            // 
            // btnDisconnectClient
            // 
            this.btnDisconnectClient.Enabled = false;
            this.btnDisconnectClient.Location = new System.Drawing.Point(6, 19);
            this.btnDisconnectClient.Name = "btnDisconnectClient";
            this.btnDisconnectClient.Size = new System.Drawing.Size(122, 23);
            this.btnDisconnectClient.TabIndex = 0;
            this.btnDisconnectClient.Text = "Disconnect Client";
            this.btnDisconnectClient.UseVisualStyleBackColor = true;
            this.btnDisconnectClient.Click += new System.EventHandler(this.btnDisconnectClient_Click);
            // 
            // tabTrolls
            // 
            this.tabTrolls.Location = new System.Drawing.Point(4, 22);
            this.tabTrolls.Name = "tabTrolls";
            this.tabTrolls.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrolls.Size = new System.Drawing.Size(462, 351);
            this.tabTrolls.TabIndex = 1;
            this.tabTrolls.Text = "Trolls";
            this.tabTrolls.UseVisualStyleBackColor = true;
            // 
            // tabRemoteOptions
            // 
            this.tabRemoteOptions.Location = new System.Drawing.Point(4, 22);
            this.tabRemoteOptions.Name = "tabRemoteOptions";
            this.tabRemoteOptions.Size = new System.Drawing.Size(462, 351);
            this.tabRemoteOptions.TabIndex = 2;
            this.tabRemoteOptions.Text = "Remote Options";
            this.tabRemoteOptions.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 377);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeScammer Control Panel";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabTrolls;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDisconnectClient;
        private System.Windows.Forms.Button btnShutdownClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClientStatus;
        private System.Windows.Forms.TabPage tabRemoteOptions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnClear;
    }
}

