namespace IT008.N12_015
{
    partial class MediaItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PicBoxMedia = new System.Windows.Forms.PictureBox();
            this.LabelMediaTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxMedia
            // 
            this.PicBoxMedia.Location = new System.Drawing.Point(0, 0);
            this.PicBoxMedia.Name = "PicBoxMedia";
            this.PicBoxMedia.Size = new System.Drawing.Size(150, 150);
            this.PicBoxMedia.TabIndex = 0;
            this.PicBoxMedia.TabStop = false;
            // 
            // LabelMediaTitle
            // 
            this.LabelMediaTitle.Location = new System.Drawing.Point(150, 0);
            this.LabelMediaTitle.Name = "LabelMediaTitle";
            this.LabelMediaTitle.Size = new System.Drawing.Size(300, 150);
            this.LabelMediaTitle.TabIndex = 1;
            this.LabelMediaTitle.Text = "Media\'s Title Goes Here";
            // 
            // MediaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelMediaTitle);
            this.Controls.Add(this.PicBoxMedia);
            this.Name = "MediaItem";
            this.Size = new System.Drawing.Size(450, 150);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxMedia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxMedia;
        private System.Windows.Forms.Label LabelMediaTitle;
    }
}
