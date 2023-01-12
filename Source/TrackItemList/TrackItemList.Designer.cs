namespace MyMediaPlayer
{
    partial class TrackItemList
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
            this.mediaItemContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // mediaItemContainer
            // 
            this.mediaItemContainer.AutoScroll = true;
            this.mediaItemContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaItemContainer.Location = new System.Drawing.Point(0, 0);
            this.mediaItemContainer.Name = "mediaItemContainer";
            this.mediaItemContainer.Size = new System.Drawing.Size(777, 527);
            this.mediaItemContainer.TabIndex = 0;
            // 
            // MusicList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.mediaItemContainer);
            this.Name = "MusicList";
            this.Size = new System.Drawing.Size(777, 527);
            this.Load += new System.EventHandler(this.TrackItemList_Load);
            this.Resize += new System.EventHandler(this.mediaItemContainer_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mediaItemContainer;
    }
}
