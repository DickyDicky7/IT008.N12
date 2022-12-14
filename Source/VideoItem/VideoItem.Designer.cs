namespace MyMediaPlayer
{
    partial class VideoItem
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
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ThumbnailBox = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.TitleLB = new System.Windows.Forms.Label();
            this.siticonePanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailBox)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BorderColor = System.Drawing.Color.Black;
            this.siticonePanel1.BorderRadius = 10;
            this.siticonePanel1.BorderThickness = 1;
            this.siticonePanel1.Controls.Add(this.tableLayoutPanel1);
            this.siticonePanel1.Location = new System.Drawing.Point(10, 10);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(290, 290);
            this.siticonePanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ThumbnailBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TitleLB, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 290);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseClick);
            // 
            // ThumbnailBox
            // 
            this.ThumbnailBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThumbnailBox.ImageRotate = 0F;
            this.ThumbnailBox.InitialImage = null;
            this.ThumbnailBox.Location = new System.Drawing.Point(3, 3);
            this.ThumbnailBox.Name = "ThumbnailBox";
            this.ThumbnailBox.Size = new System.Drawing.Size(284, 197);
            this.ThumbnailBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ThumbnailBox.TabIndex = 2;
            this.ThumbnailBox.TabStop = false;
            // 
            // TitleLB
            // 
            this.TitleLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLB.AutoSize = true;
            this.TitleLB.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TitleLB.Location = new System.Drawing.Point(120, 234);
            this.TitleLB.Name = "TitleLB";
            this.TitleLB.Size = new System.Drawing.Size(49, 25);
            this.TitleLB.TabIndex = 1;
            this.TitleLB.Text = "Title";
            this.TitleLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VideoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.siticonePanel1);
            this.Name = "VideoItem";
            this.Size = new System.Drawing.Size(310, 310);
            this.siticonePanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox ThumbnailBox;
        private System.Windows.Forms.Label TitleLB;
    }
}
