namespace VPNConnected
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.myNotificationIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.myContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectedIconTextbox = new System.Windows.Forms.TextBox();
            this.disconnectedIconTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectedIconBrowse = new System.Windows.Forms.Button();
            this.disconnectedIconBrowse = new System.Windows.Forms.Button();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.myContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // myNotificationIcon
            // 
            this.myNotificationIcon.ContextMenuStrip = this.myContextMenu;
            this.myNotificationIcon.Text = "VPN Disconnected";
            this.myNotificationIcon.Visible = true;
            this.myNotificationIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.myNotificationIcon_MouseDoubleClick);
            // 
            // myContextMenu
            // 
            this.myContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.myContextMenu.Name = "contextMenuStrip1";
            this.myContextMenu.Size = new System.Drawing.Size(93, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.onExitClick);
            // 
            // connectedIconTextbox
            // 
            this.connectedIconTextbox.Location = new System.Drawing.Point(12, 25);
            this.connectedIconTextbox.Name = "connectedIconTextbox";
            this.connectedIconTextbox.Size = new System.Drawing.Size(150, 20);
            this.connectedIconTextbox.TabIndex = 1;
            // 
            // disconnectedIconTextbox
            // 
            this.disconnectedIconTextbox.Location = new System.Drawing.Point(12, 64);
            this.disconnectedIconTextbox.Name = "disconnectedIconTextbox";
            this.disconnectedIconTextbox.Size = new System.Drawing.Size(150, 20);
            this.disconnectedIconTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Connected icon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Disconnected icon";
            // 
            // connectedIconBrowse
            // 
            this.connectedIconBrowse.Location = new System.Drawing.Point(168, 25);
            this.connectedIconBrowse.Name = "connectedIconBrowse";
            this.connectedIconBrowse.Size = new System.Drawing.Size(59, 20);
            this.connectedIconBrowse.TabIndex = 5;
            this.connectedIconBrowse.Text = "Browse";
            this.connectedIconBrowse.UseVisualStyleBackColor = true;
            this.connectedIconBrowse.Click += new System.EventHandler(this.connectedIconBrowse_Click);
            // 
            // disconnectedIconBrowse
            // 
            this.disconnectedIconBrowse.Location = new System.Drawing.Point(168, 64);
            this.disconnectedIconBrowse.Name = "disconnectedIconBrowse";
            this.disconnectedIconBrowse.Size = new System.Drawing.Size(59, 20);
            this.disconnectedIconBrowse.TabIndex = 6;
            this.disconnectedIconBrowse.Text = "Browse";
            this.disconnectedIconBrowse.UseVisualStyleBackColor = true;
            this.disconnectedIconBrowse.Click += new System.EventHandler(this.disconnectedIconBrowse_Click);
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(12, 103);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(150, 20);
            this.hostTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Host or IP to test";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(168, 103);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(59, 20);
            this.applyButton.TabIndex = 9;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 133);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hostTextBox);
            this.Controls.Add(this.disconnectedIconBrowse);
            this.Controls.Add(this.connectedIconBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disconnectedIconTextbox);
            this.Controls.Add(this.connectedIconTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "VPNConnected";
            this.Shown += new System.EventHandler(this.onShow);
            this.Resize += new System.EventHandler(this.onResize);
            this.myContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon myNotificationIcon;
        private System.Windows.Forms.ContextMenuStrip myContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox connectedIconTextbox;
        private System.Windows.Forms.TextBox disconnectedIconTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectedIconBrowse;
        private System.Windows.Forms.Button disconnectedIconBrowse;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button applyButton;
    }
}

