namespace IT008.N12_015
{
    partial class MusicList
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
            this.mediaItemContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // mediaItemContainer
            // 
            this.mediaItemContainer.AutoScroll = true;
            this.mediaItemContainer.AutoSize = true;
            this.mediaItemContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaItemContainer.Location = new System.Drawing.Point(0, 0);
            this.mediaItemContainer.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.mediaItemContainer.Name = "mediaItemContainer";
            this.mediaItemContainer.Size = new System.Drawing.Size(525, 450);
            this.mediaItemContainer.TabIndex = 1;
            this.mediaItemContainer.Resize += new System.EventHandler(this.mediaItemContainer_Resize);
            // 
            // MusicList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mediaItemContainer);
            this.Name = "MusicList";
            this.Size = new System.Drawing.Size(525, 450);
            this.Load += new System.EventHandler(this.MusicList_Load);
            this.Resize += new System.EventHandler(this.mediaItemContainer_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mediaItemContainer;
    }
}
