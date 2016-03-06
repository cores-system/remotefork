﻿namespace RemoteFork {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.IP = new System.Windows.Forms.Label();
            this.cbDlna = new System.Windows.Forms.CheckBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.devicesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadPlaylistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbAutoIp = new System.Windows.Forms.CheckBox();
            this.bStartServer = new System.Windows.Forms.Button();
            this.bStopServer = new System.Windows.Forms.Button();
            this.tbIp = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAutoStart = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Location = new System.Drawing.Point(3, 45);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(20, 13);
            this.IP.TabIndex = 16;
            this.IP.Text = "IP:";
            // 
            // cbDlna
            // 
            this.cbDlna.AutoSize = true;
            this.cbDlna.Checked = true;
            this.cbDlna.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDlna.Location = new System.Drawing.Point(12, 170);
            this.cbDlna.Name = "cbDlna";
            this.cbDlna.Size = new System.Drawing.Size(116, 17);
            this.cbDlna.TabIndex = 5;
            this.cbDlna.Text = "RemoteFork DLNA";
            this.cbDlna.UseVisualStyleBackColor = true;
            this.cbDlna.CheckedChanged += new System.EventHandler(this.cbDlna_CheckedChanged);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(43, 68);
            this.tbPort.Name = "tbPort";
            this.tbPort.ReadOnly = true;
            this.tbPort.Size = new System.Drawing.Size(145, 20);
            this.tbPort.TabIndex = 4;
            this.tbPort.TabStop = false;
            this.tbPort.Text = "8027";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.settingsToolStripMenuItem.Text = "Настройки";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // openTestToolStripMenuItem
            // 
            this.openTestToolStripMenuItem.Name = "openTestToolStripMenuItem";
            this.openTestToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.openTestToolStripMenuItem.Text = "Открыть тест";
            this.openTestToolStripMenuItem.Click += new System.EventHandler(this.openTestToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Port:";
            // 
            // devicesToolStripMenuItem1
            // 
            this.devicesToolStripMenuItem1.Name = "devicesToolStripMenuItem1";
            this.devicesToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.devicesToolStripMenuItem1.Text = "Нет активных устройств";
            this.devicesToolStripMenuItem1.Click += new System.EventHandler(this.devicesToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPlaylistToolStripMenuItem1,
            this.openTestToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 92);
            // 
            // loadPlaylistToolStripMenuItem1
            // 
            this.loadPlaylistToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devicesToolStripMenuItem1});
            this.loadPlaylistToolStripMenuItem1.Name = "loadPlaylistToolStripMenuItem1";
            this.loadPlaylistToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.loadPlaylistToolStripMenuItem1.Text = "Загрузить плейлист";
            this.loadPlaylistToolStripMenuItem1.MouseHover += new System.EventHandler(this.loadPlaylistToolStripMenuItem1_MouseHover);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RemoteFork 1.2";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbAutoIp
            // 
            this.cbAutoIp.AutoSize = true;
            this.cbAutoIp.Location = new System.Drawing.Point(6, 19);
            this.cbAutoIp.Name = "cbAutoIp";
            this.cbAutoIp.Size = new System.Drawing.Size(61, 17);
            this.cbAutoIp.TabIndex = 2;
            this.cbAutoIp.Text = "Auto IP";
            this.cbAutoIp.UseVisualStyleBackColor = true;
            this.cbAutoIp.Click += new System.EventHandler(this.cbAutoIp_CheckedChanged);
            // 
            // bStartServer
            // 
            this.bStartServer.Location = new System.Drawing.Point(12, 12);
            this.bStartServer.Name = "bStartServer";
            this.bStartServer.Size = new System.Drawing.Size(94, 23);
            this.bStartServer.TabIndex = 0;
            this.bStartServer.Text = "Start server";
            this.bStartServer.UseVisualStyleBackColor = true;
            this.bStartServer.Click += new System.EventHandler(this.bStartServer_Click);
            // 
            // bStopServer
            // 
            this.bStopServer.Enabled = false;
            this.bStopServer.Location = new System.Drawing.Point(112, 12);
            this.bStopServer.Name = "bStopServer";
            this.bStopServer.Size = new System.Drawing.Size(94, 23);
            this.bStopServer.TabIndex = 1;
            this.bStopServer.Text = "Stop server";
            this.bStopServer.UseVisualStyleBackColor = true;
            this.bStopServer.Click += new System.EventHandler(this.bStopServer_Click);
            // 
            // tbIp
            // 
            this.tbIp.Location = new System.Drawing.Point(43, 42);
            this.tbIp.Name = "tbIp";
            this.tbIp.Size = new System.Drawing.Size(145, 20);
            this.tbIp.TabIndex = 3;
            this.tbIp.TextChanged += new System.EventHandler(this.tbIp_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 198);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(217, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAutoIp);
            this.groupBox1.Controls.Add(this.tbIp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IP);
            this.groupBox1.Controls.Add(this.tbPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP:PORT";
            // 
            // cbAutoStart
            // 
            this.cbAutoStart.AutoSize = true;
            this.cbAutoStart.Checked = true;
            this.cbAutoStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoStart.Location = new System.Drawing.Point(12, 41);
            this.cbAutoStart.Name = "cbAutoStart";
            this.cbAutoStart.Size = new System.Drawing.Size(121, 17);
            this.cbAutoStart.TabIndex = 5;
            this.cbAutoStart.Text = "Auto start on startup";
            this.cbAutoStart.UseVisualStyleBackColor = true;
            this.cbAutoStart.CheckedChanged += new System.EventHandler(this.cbAutoStart_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 220);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cbAutoStart);
            this.Controls.Add(this.cbDlna);
            this.Controls.Add(this.bStartServer);
            this.Controls.Add(this.bStopServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoteFork 1.2.f2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.CheckBox cbDlna;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTestToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem devicesToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadPlaylistToolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox cbAutoIp;
        private System.Windows.Forms.Button bStartServer;
        private System.Windows.Forms.Button bStopServer;
        private System.Windows.Forms.TextBox tbIp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbAutoStart;
    }
}