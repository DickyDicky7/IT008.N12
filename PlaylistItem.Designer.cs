namespace IT008.N12_015
{
    partial class PlaylistItem
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
            this.Playlist = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.titleLB = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.Thumnail = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.Menu = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.renamePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeThumnailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Playlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Thumnail)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Playlist
            // 
            this.Playlist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Playlist.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Playlist.BorderRadius = 15;
            this.Playlist.Controls.Add(this.titleLB);
            this.Playlist.Controls.Add(this.Thumnail);
            this.Playlist.Location = new System.Drawing.Point(0, 0);
            this.Playlist.Name = "Playlist";
            this.Playlist.ShadowDecoration.Parent = this.Playlist;
            this.Playlist.Size = new System.Drawing.Size(822, 100);
            this.Playlist.TabIndex = 0;
            // 
            // titleLB
            // 
            this.titleLB.BackColor = System.Drawing.Color.Transparent;
            this.titleLB.BorderRadius = 10;
            this.titleLB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titleLB.DefaultText = "";
            this.titleLB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.titleLB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.titleLB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titleLB.DisabledState.Parent = this.titleLB;
            this.titleLB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.titleLB.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.titleLB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.titleLB.FocusedState.Parent = this.titleLB;
            this.titleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.titleLB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.titleLB.HoverState.Parent = this.titleLB;
            this.titleLB.Location = new System.Drawing.Point(74, 4);
            this.titleLB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleLB.Name = "titleLB";
            this.titleLB.PasswordChar = '\0';
            this.titleLB.PlaceholderText = "";
            this.titleLB.SelectedText = "";
            this.titleLB.ShadowDecoration.Parent = this.titleLB;
            this.titleLB.Size = new System.Drawing.Size(648, 53);
            this.titleLB.TabIndex = 0;
            this.titleLB.TextChanged += new System.EventHandler(this.titleLB_TextChanged);
            // 
            // Thumnail
            // 
            this.Thumnail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Thumnail.BorderRadius = 15;
            this.Thumnail.FillColor = System.Drawing.Color.Transparent;
            this.Thumnail.Image = global::IT008.N12_015.Properties.Resources.icons8_playlist_64;
            this.Thumnail.ImageRotate = 0F;
            this.Thumnail.InitialImage = null;
            this.Thumnail.Location = new System.Drawing.Point(3, 3);
            this.Thumnail.Name = "Thumnail";
            this.Thumnail.ShadowDecoration.Parent = this.Thumnail;
            this.Thumnail.Size = new System.Drawing.Size(64, 64);
            this.Thumnail.TabIndex = 0;
            this.Thumnail.TabStop = false;
            this.Thumnail.Click += new System.EventHandler(this.Thumnail_Click);
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renamePlaylistToolStripMenuItem,
            this.changeThumnailToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Menu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.Menu.RenderStyle.ColorTable = null;
            this.Menu.RenderStyle.RoundedEdges = true;
            this.Menu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.Menu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Menu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Menu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.Menu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.Menu.Size = new System.Drawing.Size(188, 48);
            // 
            // renamePlaylistToolStripMenuItem
            // 
            this.renamePlaylistToolStripMenuItem.Name = "renamePlaylistToolStripMenuItem";
            this.renamePlaylistToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.renamePlaylistToolStripMenuItem.Text = "Rename Playlist";
            this.renamePlaylistToolStripMenuItem.Click += new System.EventHandler(this.renameTitle);
            // 
            // changeThumnailToolStripMenuItem
            // 
            this.changeThumnailToolStripMenuItem.Name = "changeThumnailToolStripMenuItem";
            this.changeThumnailToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.changeThumnailToolStripMenuItem.Text = "Change Thumnail";
            // 
            // PlaylistItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.Menu;
            this.Controls.Add(this.Playlist);
            this.Name = "PlaylistItem";
            this.Size = new System.Drawing.Size(822, 100);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlaylistItem_MouseClick);
            this.Playlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Thumnail)).EndInit();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel Playlist;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox Thumnail;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox titleLB;
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem renamePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeThumnailToolStripMenuItem;
    }
}
