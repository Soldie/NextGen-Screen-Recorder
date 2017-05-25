namespace NextGen_Screen_Recorder
{
    partial class ImageViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageViewer));
            this.SaveImageButton = new System.Windows.Forms.ToolStripButton();
            this.SuspendLayout();
            // 
            // SaveImageButton
            // 
            this.SaveImageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveImageButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveImageButton.Image")));
            this.SaveImageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveImageButton.Name = "SaveImageButton";
            this.SaveImageButton.Size = new System.Drawing.Size(24, 24);
            this.SaveImageButton.Text = "toolStripButton1";
            this.SaveImageButton.Click += new System.EventHandler(this.SaveImageButton_Click);
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 480);
            this.Name = "ImageViewer";
            this.Text = "ImageViewer";
            this.Load += new System.EventHandler(this.ImageViewer_Load);
            this.Resize += new System.EventHandler(this.ImageViewer_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton SaveImageButton;
    }
}