namespace MyMediaPlayer
{
    partial class TrackItem
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
            this.containerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.inforPanel = new System.Windows.Forms.TableLayoutPanel();
            this.artistLB = new System.Windows.Forms.Label();
            this.albumLB = new System.Windows.Forms.Label();
            this.durationLB = new System.Windows.Forms.Label();
            this.genreLB = new System.Windows.Forms.Label();
            this.titleLB = new System.Windows.Forms.Label();
            this.containerPanel.SuspendLayout();
            this.inforPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.White;
            this.containerPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.containerPanel.BorderRadius = 10;
            this.containerPanel.BorderThickness = 1;
            this.containerPanel.Controls.Add(this.inforPanel);
            this.containerPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.FillColor = System.Drawing.Color.White;
            this.containerPanel.Location = new System.Drawing.Point(26, 3);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(713, 43);
            this.containerPanel.TabIndex = 1;
            // 
            // inforPanel
            // 
            this.inforPanel.BackColor = System.Drawing.Color.Transparent;
            this.inforPanel.ColumnCount = 5;
            this.inforPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.inforPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.inforPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.inforPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inforPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inforPanel.Controls.Add(this.artistLB, 1, 0);
            this.inforPanel.Controls.Add(this.albumLB, 2, 0);
            this.inforPanel.Controls.Add(this.durationLB, 4, 0);
            this.inforPanel.Controls.Add(this.genreLB, 3, 0);
            this.inforPanel.Controls.Add(this.titleLB, 0, 0);
            this.inforPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inforPanel.Location = new System.Drawing.Point(0, 0);
            this.inforPanel.Margin = new System.Windows.Forms.Padding(0);
            this.inforPanel.Name = "inforPanel";
            this.inforPanel.RowCount = 1;
            this.inforPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inforPanel.Size = new System.Drawing.Size(713, 43);
            this.inforPanel.TabIndex = 0;
            this.inforPanel.MouseEnter += new System.EventHandler(this.TrackItem_MouseEnter);
            this.inforPanel.MouseLeave += new System.EventHandler(this.TrackItem_MouseLeave);
            // 
            // artistLB
            // 
            this.artistLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.artistLB.AutoEllipsis = true;
            this.artistLB.AutoSize = true;
            this.artistLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.artistLB.Location = new System.Drawing.Point(287, 14);
            this.artistLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.artistLB.Name = "artistLB";
            this.artistLB.Size = new System.Drawing.Size(35, 15);
            this.artistLB.TabIndex = 2;
            this.artistLB.Text = "Artist";
            this.artistLB.MouseEnter += new System.EventHandler(this.TrackItem_MouseEnter);
            this.artistLB.MouseLeave += new System.EventHandler(this.TrackItem_MouseLeave);
            // 
            // albumLB
            // 
            this.albumLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.albumLB.AutoEllipsis = true;
            this.albumLB.AutoSize = true;
            this.albumLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.albumLB.Location = new System.Drawing.Point(429, 14);
            this.albumLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.albumLB.Name = "albumLB";
            this.albumLB.Size = new System.Drawing.Size(43, 15);
            this.albumLB.TabIndex = 3;
            this.albumLB.Text = "Album";
            this.albumLB.MouseEnter += new System.EventHandler(this.TrackItem_MouseEnter);
            this.albumLB.MouseLeave += new System.EventHandler(this.TrackItem_MouseLeave);
            // 
            // durationLB
            // 
            this.durationLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.durationLB.AutoEllipsis = true;
            this.durationLB.AutoSize = true;
            this.durationLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.durationLB.Location = new System.Drawing.Point(642, 14);
            this.durationLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.durationLB.Name = "durationLB";
            this.durationLB.Size = new System.Drawing.Size(54, 15);
            this.durationLB.TabIndex = 4;
            this.durationLB.Text = "Duration";
            this.durationLB.MouseEnter += new System.EventHandler(this.TrackItem_MouseEnter);
            this.durationLB.MouseLeave += new System.EventHandler(this.TrackItem_MouseLeave);
            // 
            // genreLB
            // 
            this.genreLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genreLB.AutoSize = true;
            this.genreLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.genreLB.Location = new System.Drawing.Point(571, 14);
            this.genreLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genreLB.Name = "genreLB";
            this.genreLB.Size = new System.Drawing.Size(38, 15);
            this.genreLB.TabIndex = 5;
            this.genreLB.Text = "Genre";
            // 
            // titleLB
            // 
            this.titleLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleLB.AutoEllipsis = true;
            this.titleLB.AutoSize = true;
            this.titleLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.titleLB.Location = new System.Drawing.Point(2, 14);
            this.titleLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLB.Name = "titleLB";
            this.titleLB.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.titleLB.Size = new System.Drawing.Size(45, 15);
            this.titleLB.TabIndex = 1;
            this.titleLB.Text = "Title";
            this.titleLB.MouseEnter += new System.EventHandler(this.TrackItem_MouseEnter);
            this.titleLB.MouseLeave += new System.EventHandler(this.TrackItem_MouseLeave);
            // 
            // TrackItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.containerPanel);
            this.MinimumSize = new System.Drawing.Size(0, 32);
            this.Name = "TrackItem";
            this.Padding = new System.Windows.Forms.Padding(26, 3, 11, 3);
            this.Size = new System.Drawing.Size(750, 49);
            this.Load += new System.EventHandler(this.TrackItem_Load);
            this.MouseEnter += new System.EventHandler(this.TrackItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.TrackItem_MouseLeave);
            this.containerPanel.ResumeLayout(false);
            this.inforPanel.ResumeLayout(false);
            this.inforPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel containerPanel;
        private System.Windows.Forms.TableLayoutPanel inforPanel;
        private System.Windows.Forms.Label artistLB;
        private System.Windows.Forms.Label albumLB;
        private System.Windows.Forms.Label durationLB;
        private System.Windows.Forms.Label genreLB;
        private System.Windows.Forms.Label titleLB;
    }
}
