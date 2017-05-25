using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextGen_Screen_Recorder
{
    public partial class AreaSelector : Form
    {

        public Rectangle SelectedArea { get; set; }

        public AreaSelector()
        {
            InitializeComponent();
        }

        private void AreaSelector_Load(object sender, EventArgs e)
        {
            this.Hide();
            var screen = Helpers.ScreenCapture.CaptureScreen();
            this.Show();
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.pictureBox1.Image = screen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
