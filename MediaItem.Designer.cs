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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.thumbNailPTB = new System.Windows.Forms.PictureBox();
            this.titleLB = new System.Windows.Forms.Label();
            this.artistLB = new System.Windows.Forms.Label();
            this.albumLB = new System.Windows.Forms.Label();
            this.durationLB = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbNailPTB)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.thumbNailPTB, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.titleLB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.artistLB, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.albumLB, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.durationLB, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // thumbNailPTB
            // 
            this.thumbNailPTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.thumbNailPTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thumbNailPTB.Location = new System.Drawing.Point(3, 3);
            this.thumbNailPTB.Name = "thumbNailPTB";
            this.thumbNailPTB.Size = new System.Drawing.Size(94, 94);
            this.thumbNailPTB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thumbNailPTB.TabIndex = 0;
            this.thumbNailPTB.TabStop = false;
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.titleLB.Location = new System.Drawing.Point(103, 0);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(33, 16);
            this.titleLB.TabIndex = 1;
            this.titleLB.Text = "Title";
            // 
            // artistLB
            // 
            this.artistLB.AutoSize = true;
            this.artistLB.Location = new System.Drawing.Point(362, 0);
            this.artistLB.Name = "artistLB";
            this.artistLB.Size = new System.Drawing.Size(36, 16);
            this.artistLB.TabIndex = 2;
            this.artistLB.Text = "Artist";
            // 
            // albumLB
            // 
            this.albumLB.AutoSize = true;
            this.albumLB.Location = new System.Drawing.Point(491, 0);
            this.albumLB.Name = "albumLB";
            this.albumLB.Size = new System.Drawing.Size(45, 16);
            this.albumLB.TabIndex = 3;
            this.albumLB.Text = "Album";
            // 
            // durationLB
            // 
            this.durationLB.AutoSize = true;
            this.durationLB.Location = new System.Drawing.Point(620, 0);
            this.durationLB.Name = "durationLB";
            this.durationLB.Size = new System.Drawing.Size(57, 16);
            this.durationLB.TabIndex = 4;
            this.durationLB.Text = "Duration";
            // 
            // MediaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MediaItem";
            this.Size = new System.Drawing.Size(700, 100);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbNailPTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox thumbNailPTB;
        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.Label artistLB;
        private System.Windows.Forms.Label albumLB;
        private System.Windows.Forms.Label durationLB;
    }
}
