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
            this.artistLB = new System.Windows.Forms.Label();
            this.albumLB = new System.Windows.Forms.Label();
            this.titleLB = new System.Windows.Forms.Label();
            this.durationLB = new System.Windows.Forms.Label();
            this.genreLB = new System.Windows.Forms.Label();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneContextMenuStrip = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.playMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.siticoneContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.artistLB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.albumLB, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.titleLB, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.durationLB, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.genreLB, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.MediaItem_Click);
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.MediaItem_MouseEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.MediaItem_MouseLeave);
            this.tableLayoutPanel1.MouseHover += new System.EventHandler(this.MediaItem_MouseHover);
            // 
            // artistLB
            // 
            this.artistLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.artistLB.AutoEllipsis = true;
            this.artistLB.AutoSize = true;
            this.artistLB.Location = new System.Drawing.Point(389, 17);
            this.artistLB.Name = "artistLB";
            this.artistLB.Size = new System.Drawing.Size(36, 16);
            this.artistLB.TabIndex = 2;
            this.artistLB.Text = "Artist";
            this.artistLB.Click += new System.EventHandler(this.MediaItem_Click);
            this.artistLB.MouseEnter += new System.EventHandler(this.MediaItem_MouseEnter);
            this.artistLB.MouseLeave += new System.EventHandler(this.MediaItem_MouseLeave);
            this.artistLB.MouseHover += new System.EventHandler(this.MediaItem_MouseHover);
            // 
            // albumLB
            // 
            this.albumLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.albumLB.AutoEllipsis = true;
            this.albumLB.AutoSize = true;
            this.albumLB.Location = new System.Drawing.Point(582, 17);
            this.albumLB.Name = "albumLB";
            this.albumLB.Size = new System.Drawing.Size(45, 16);
            this.albumLB.TabIndex = 3;
            this.albumLB.Text = "Album";
            this.albumLB.Click += new System.EventHandler(this.MediaItem_Click);
            this.albumLB.MouseEnter += new System.EventHandler(this.MediaItem_MouseEnter);
            this.albumLB.MouseLeave += new System.EventHandler(this.MediaItem_MouseLeave);
            this.albumLB.MouseHover += new System.EventHandler(this.MediaItem_MouseHover);
            // 
            // titleLB
            // 
            this.titleLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleLB.AutoEllipsis = true;
            this.titleLB.AutoSize = true;
            this.titleLB.Location = new System.Drawing.Point(3, 17);
            this.titleLB.Name = "titleLB";
            this.titleLB.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.titleLB.Size = new System.Drawing.Size(53, 16);
            this.titleLB.TabIndex = 1;
            this.titleLB.Text = "Title";
            this.titleLB.Click += new System.EventHandler(this.MediaItem_Click);
            this.titleLB.MouseEnter += new System.EventHandler(this.MediaItem_MouseEnter);
            this.titleLB.MouseLeave += new System.EventHandler(this.MediaItem_MouseLeave);
            this.titleLB.MouseHover += new System.EventHandler(this.MediaItem_MouseHover);
            // 
            // durationLB
            // 
            this.durationLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.durationLB.AutoEllipsis = true;
            this.durationLB.AutoSize = true;
            this.durationLB.Location = new System.Drawing.Point(871, 17);
            this.durationLB.Name = "durationLB";
            this.durationLB.Size = new System.Drawing.Size(57, 16);
            this.durationLB.TabIndex = 4;
            this.durationLB.Text = "Duration";
            this.durationLB.Click += new System.EventHandler(this.MediaItem_Click);
            this.durationLB.MouseEnter += new System.EventHandler(this.MediaItem_MouseEnter);
            this.durationLB.MouseLeave += new System.EventHandler(this.MediaItem_MouseLeave);
            this.durationLB.MouseHover += new System.EventHandler(this.MediaItem_MouseHover);
            // 
            // genreLB
            // 
            this.genreLB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genreLB.AutoSize = true;
            this.genreLB.Location = new System.Drawing.Point(775, 17);
            this.genreLB.Name = "genreLB";
            this.genreLB.Size = new System.Drawing.Size(44, 16);
            this.genreLB.TabIndex = 5;
            this.genreLB.Text = "Genre";
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.siticonePanel1.BorderRadius = 10;
            this.siticonePanel1.BorderThickness = 1;
            this.siticonePanel1.Controls.Add(this.tableLayoutPanel1);
            this.siticonePanel1.CustomBorderColor = System.Drawing.Color.Black;
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(30, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(965, 50);
            this.siticonePanel1.TabIndex = 1;
            // 
            // siticoneContextMenuStrip
            // 
            this.siticoneContextMenuStrip.BackColor = System.Drawing.Color.White;
            this.siticoneContextMenuStrip.ImageScalingSize = new System.Drawing.Size(15, 15);
            this.siticoneContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playMenuItem,
            this.addToMenuItem,
            this.propertiesMenuItem});
            this.siticoneContextMenuStrip.Margin = new System.Windows.Forms.Padding(3);
            this.siticoneContextMenuStrip.Name = "siticoneContextMenuStrip";
            this.siticoneContextMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.siticoneContextMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.siticoneContextMenuStrip.RenderStyle.ColorTable = null;
            this.siticoneContextMenuStrip.RenderStyle.RoundedEdges = true;
            this.siticoneContextMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.siticoneContextMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.siticoneContextMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.siticoneContextMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.siticoneContextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.siticoneContextMenuStrip.Size = new System.Drawing.Size(146, 76);
            // 
            // playMenuItem
            // 
            this.playMenuItem.Image = global::IT008.N12_015.Properties.Resources.play_button__1_;
            this.playMenuItem.Name = "playMenuItem";
            this.playMenuItem.Size = new System.Drawing.Size(145, 24);
            this.playMenuItem.Text = "Play";
            // 
            // addToMenuItem
            // 
            this.addToMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playQueueToolStripMenuItem,
            this.newPlaylistToolStripMenuItem});
            this.addToMenuItem.Image = global::IT008.N12_015.Properties.Resources.plus;
            this.addToMenuItem.Name = "addToMenuItem";
            this.addToMenuItem.Size = new System.Drawing.Size(145, 24);
            this.addToMenuItem.Text = "Add to";
            // 
            // playQueueToolStripMenuItem
            // 
            this.playQueueToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.playQueueToolStripMenuItem.Image = global::IT008.N12_015.Properties.Resources.icons8_playlist_64;
            this.playQueueToolStripMenuItem.Name = "playQueueToolStripMenuItem";
            this.playQueueToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.playQueueToolStripMenuItem.Text = "Play Queue";
            // 
            // newPlaylistToolStripMenuItem
            // 
            this.newPlaylistToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.newPlaylistToolStripMenuItem.Image = global::IT008.N12_015.Properties.Resources.plus;
            this.newPlaylistToolStripMenuItem.Name = "newPlaylistToolStripMenuItem";
            this.newPlaylistToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.newPlaylistToolStripMenuItem.Text = "New Playlist";
            // 
            // propertiesMenuItem
            // 
            this.propertiesMenuItem.Image = global::IT008.N12_015.Properties.Resources.information;
            this.propertiesMenuItem.Name = "propertiesMenuItem";
            this.propertiesMenuItem.Size = new System.Drawing.Size(145, 24);
            this.propertiesMenuItem.Text = "Properties";
            // 
            // MediaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ContextMenuStrip = this.siticoneContextMenuStrip;
            this.Controls.Add(this.siticonePanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MediaItem";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 5, 0);
            this.Size = new System.Drawing.Size(1000, 50);
            this.MouseEnter += new System.EventHandler(this.MediaItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MediaItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.MediaItem_MouseHover);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.siticonePanel1.ResumeLayout(false);
            this.siticoneContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.Label artistLB;
        private System.Windows.Forms.Label albumLB;
        private System.Windows.Forms.Label durationLB;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label genreLB;
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip siticoneContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem playMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesMenuItem;
    }
}
