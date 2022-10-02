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
            this.inforPanel = new System.Windows.Forms.TableLayoutPanel();
            this.artistLB = new System.Windows.Forms.Label();
            this.albumLB = new System.Windows.Forms.Label();
            this.titleLB = new System.Windows.Forms.Label();
            this.durationLB = new System.Windows.Forms.Label();
            this.genreLB = new System.Windows.Forms.Label();
            this.containerPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.contextMenu = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.playMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inforPanel.SuspendLayout();
            this.containerPanel.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.inforPanel.Controls.Add(this.titleLB, 0, 0);
            this.inforPanel.Controls.Add(this.durationLB, 4, 0);
            this.inforPanel.Controls.Add(this.genreLB, 3, 0);
            this.inforPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inforPanel.Location = new System.Drawing.Point(0, 0);
            this.inforPanel.Margin = new System.Windows.Forms.Padding(0);
            this.inforPanel.Name = "inforPanel";
            this.inforPanel.RowCount = 1;
            this.inforPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inforPanel.Size = new System.Drawing.Size(965, 50);
            this.inforPanel.TabIndex = 0;
            this.inforPanel.Click += new System.EventHandler(this.MediaItem_Click);
            this.inforPanel.MouseEnter += new System.EventHandler(this.MediaItem_MouseEnter);
            this.inforPanel.MouseLeave += new System.EventHandler(this.MediaItem_MouseLeave);
            this.inforPanel.MouseHover += new System.EventHandler(this.MediaItem_MouseHover);
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
            // containerPanel
            // 
            this.containerPanel.BorderColor = System.Drawing.Color.Gainsboro;
            this.containerPanel.BorderRadius = 10;
            this.containerPanel.BorderThickness = 1;
            this.containerPanel.Controls.Add(this.inforPanel);
            this.containerPanel.CustomBorderColor = System.Drawing.Color.Black;
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(30, 0);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.ShadowDecoration.Parent = this.containerPanel;
            this.containerPanel.Size = new System.Drawing.Size(965, 50);
            this.containerPanel.TabIndex = 1;
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.Color.White;
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(15, 15);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playMenuItem,
            this.addToMenuItem,
            this.propertiesMenuItem});
            this.contextMenu.Margin = new System.Windows.Forms.Padding(3);
            this.contextMenu.Name = "siticoneContextMenuStrip";
            this.contextMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.contextMenu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.contextMenu.RenderStyle.ColorTable = null;
            this.contextMenu.RenderStyle.RoundedEdges = true;
            this.contextMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.contextMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.contextMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.contextMenu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.contextMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.contextMenu.Size = new System.Drawing.Size(211, 104);
            // 
            // playMenuItem
            // 
            this.playMenuItem.Image = global::IT008.N12_015.Properties.Resources.play_button__1_;
            this.playMenuItem.Name = "playMenuItem";
            this.playMenuItem.Size = new System.Drawing.Size(210, 24);
            this.playMenuItem.Text = "Play";
            this.playMenuItem.Click += new System.EventHandler(this.playMenuItem_Click);
            // 
            // addToMenuItem
            // 
            this.addToMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playQueueToolStripMenuItem,
            this.newPlaylistToolStripMenuItem});
            this.addToMenuItem.Image = global::IT008.N12_015.Properties.Resources.plus;
            this.addToMenuItem.Name = "addToMenuItem";
            this.addToMenuItem.Size = new System.Drawing.Size(210, 24);
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
            this.propertiesMenuItem.Size = new System.Drawing.Size(210, 24);
            this.propertiesMenuItem.Text = "Properties";
            // 
            // MediaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.containerPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MediaItem";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 5, 0);
            this.Size = new System.Drawing.Size(1000, 50);
            this.MouseEnter += new System.EventHandler(this.MediaItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MediaItem_MouseLeave);
            this.MouseHover += new System.EventHandler(this.MediaItem_MouseHover);
            this.inforPanel.ResumeLayout(false);
            this.inforPanel.PerformLayout();
            this.containerPanel.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel inforPanel;
        private System.Windows.Forms.Label titleLB;
        private System.Windows.Forms.Label artistLB;
        private System.Windows.Forms.Label albumLB;
        private System.Windows.Forms.Label durationLB;
        private Siticone.Desktop.UI.WinForms.SiticonePanel containerPanel;
        private System.Windows.Forms.Label genreLB;
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem playMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesMenuItem;
    }
}
