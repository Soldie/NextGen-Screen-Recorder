﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NextGen_Screen_Recorder
{
    public partial class ImageViewer : Form
    {
        public Image Image { get; set; }
        public bool Dirty { get; set; }
        public ImageViewer()
        {
            InitializeComponent();
        }

        public ImageViewer(Image Image)
        {

        }

        private void ImageViewer_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void SaveImageButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.ShowDialog();
        }

        private void ImageViewer_Resize(object sender, EventArgs e)
        {

        }
    }
}
