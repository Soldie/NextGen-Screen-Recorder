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
    public partial class PrefsEditor : Form
    {
        public PrefsEditor()
        {
            InitializeComponent();
        }

        private void PrefsEditor_Load(object sender, EventArgs e)
        {
            tabPage3.Parent.Controls.Remove(tabPage3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure that you dont want to save the changes. The settings will be lost", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            this.Close();
        }
    }
}
