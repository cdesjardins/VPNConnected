using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using Microsoft.Win32;
using System.Threading;

namespace VPNConnected
{
    public partial class mainForm : Form
    {
        System.Windows.Forms.Timer m_myTimer = new System.Windows.Forms.Timer();
        Icon m_connectedIcon = Properties.Resources.faviconred;
        Icon m_disconnectedIcon = Properties.Resources.faviconblue;
        Ping m_ping = new Ping();
        OpenFileDialog m_openFileDialog = new OpenFileDialog();

        public mainForm()
        {
            InitializeComponent();
        }
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            Thread oThread = new Thread(new ThreadStart(pinger));
            oThread.Start();
        }
        private void pinger()
        {
            PingReply reply;
            try
            {
                reply = m_ping.Send((string)Properties.Settings.Default["HostName"]);
                if (reply.Status == IPStatus.Success)
                {
                    this.myNotificationIcon.Icon = m_connectedIcon;
                    this.myNotificationIcon.Text = "VPN Connected";
                }
                else
                {
                    this.myNotificationIcon.Icon = m_disconnectedIcon;
                    this.myNotificationIcon.Text = "VPN Disconnected";
                }
            }
            catch (Exception e)
            {
                if (e != null)
                {
                }
                this.myNotificationIcon.Icon = m_disconnectedIcon;
            }
        }

        private void loadIconFile(string fileName, ref Icon icon, ref TextBox textbox)
        {
            Icon tmpIcon;
            if (fileName.Length > 0)
            {
                try
                {
                    tmpIcon = new Icon(fileName);
                    icon = tmpIcon;
                    textbox.Text = fileName;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void onShow(object sender, EventArgs e)
        {
            m_myTimer.Tick += new EventHandler(TimerEventProcessor);
            m_myTimer.Interval = 10000;
            m_myTimer.Start();
            loadIconFile(Properties.Settings.Default.DisconnectedIconFile, ref m_disconnectedIcon, ref disconnectedIconTextbox);
            loadIconFile(Properties.Settings.Default.ConnectedIconFile, ref m_connectedIcon, ref connectedIconTextbox);

            hostTextBox.Text = (string)Properties.Settings.Default.HostName;
            this.myNotificationIcon.Icon = m_disconnectedIcon;

            if (!Properties.Settings.Default.HostName.Equals("vpn.work"))
            {
                Hide();
            }
        }

        private void onExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void myNotificationIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void onResize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

        private void disconnectedIconBrowse_Click(object sender, EventArgs e)
        {
            if (m_openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                disconnectedIconTextbox.Text = m_openFileDialog.FileName;
            }
        }

        private void connectedIconBrowse_Click(object sender, EventArgs e)
        {
            if (m_openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                connectedIconTextbox.Text = m_openFileDialog.FileName;
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            loadIconFile(disconnectedIconTextbox.Text, ref m_disconnectedIcon, ref disconnectedIconTextbox);
            loadIconFile(connectedIconTextbox.Text, ref m_connectedIcon, ref connectedIconTextbox);
            Properties.Settings.Default.DisconnectedIconFile = disconnectedIconTextbox.Text;
            Properties.Settings.Default.ConnectedIconFile = connectedIconTextbox.Text;
            Properties.Settings.Default.HostName = hostTextBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
