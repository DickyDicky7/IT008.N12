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
            this.picBox_media = new System.Windows.Forms.PictureBox();
            this.lbl_media_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_media)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_media
            // 
            this.picBox_media.Location = new System.Drawing.Point(0, 0);
            this.picBox_media.Name = "picBox_media";
            this.picBox_media.Size = new System.Drawing.Size(150, 150);
            this.picBox_media.TabIndex = 0;
            this.picBox_media.TabStop = false;
            // 
            // lbl_media_title
            // 
            this.lbl_media_title.Location = new System.Drawing.Point(150, 0);
            this.lbl_media_title.Name = "lbl_media_title";
            this.lbl_media_title.Size = new System.Drawing.Size(300, 150);
            this.lbl_media_title.TabIndex = 1;
            this.lbl_media_title.Text = "Media\'s Title Goes Here";
            // 
            // MediaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_media_title);
            this.Controls.Add(this.picBox_media);
            this.Name = "MediaItem";
            this.Size = new System.Drawing.Size(450, 150);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_media)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_media;
        private System.Windows.Forms.Label lbl_media_title;
    }
}
