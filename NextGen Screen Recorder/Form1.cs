using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NextGen_Screen_Recorder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StaticData.MainForm = this;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ConfirmOnExit)
            {
                if (MessageBox.Show("Do you want to Exit NextGen Screen Recorder", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Properties.Settings.Default.HideToTrayOnClose = false;
                    Application.Exit();
                }
            }
            else Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var img = Helpers.ScreenCapture.CaptureScreen();
            this.Show();
            new ImageViewer(img).Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Click += NotifyIcon1_Click;
            StaticData.NotificationTrayIcon = this.Icon;
        }

        private void NotifyIcon1_Click(object sender, EventArgs e)
        {
            StaticData.MainForm.Show();
            notifyIcon1.Icon = null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Properties.Settings.Default.HideToTrayOnClose)
            {
                notifyIcon1.Icon = StaticData.NotificationTrayIcon;
                e.Cancel = true;
                this.Hide();
                notifyIcon1.ShowBalloonTip(1000, "Minimized to Tray", "Next Gen Screen Recorder is Minimized to Tray", ToolTipIcon.Info);
            }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PrefsEditor().ShowDialog();
        }
    }
}
