namespace MyMediaPlayer
{
    partial class SearchBox
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
            this.Panel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.ContextMenuStrip = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.ZingMP3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SoundCloudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpotifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.IntegrationButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Pagination = new MyMediaPlayer.Pagination();
            this.Panel.SuspendLayout();
            this.ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.Pagination);
            this.Panel.Controls.Add(this.IntegrationButton);
            this.Panel.Controls.Add(this.TextBox);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.ShadowDecoration.Parent = this.Panel;
            this.Panel.Size = new System.Drawing.Size(520, 60);
            this.Panel.TabIndex = 2;
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZingMP3ToolStripMenuItem,
            this.SoundCloudToolStripMenuItem,
            this.SpotifyToolStripMenuItem});
            this.ContextMenuStrip.Name = "ContextMenuStrip";
            this.ContextMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ContextMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.White;
            this.ContextMenuStrip.RenderStyle.ColorTable = null;
            this.ContextMenuStrip.RenderStyle.RoundedEdges = true;
            this.ContextMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ContextMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ContextMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ContextMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.White;
            this.ContextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ContextMenuStrip.Size = new System.Drawing.Size(180, 82);
            // 
            // ZingMP3ToolStripMenuItem
            // 
            this.ZingMP3ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ZingMP3ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ZingMP3ToolStripMenuItem.Image = global::MyMediaPlayer.Properties.Resources.zing_mp3;
            this.ZingMP3ToolStripMenuItem.Name = "ZingMP3ToolStripMenuItem";
            this.ZingMP3ToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.ZingMP3ToolStripMenuItem.Text = "      ZingMP3";
            this.ZingMP3ToolStripMenuItem.Click += new System.EventHandler(this.ZingMP3ToolStripMenuItem_Click);
            // 
            // SoundCloudToolStripMenuItem
            // 
            this.SoundCloudToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.SoundCloudToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.SoundCloudToolStripMenuItem.Image = global::MyMediaPlayer.Properties.Resources.sound_cloud;
            this.SoundCloudToolStripMenuItem.Name = "SoundCloudToolStripMenuItem";
            this.SoundCloudToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.SoundCloudToolStripMenuItem.Text = "      SoundCloud";
            this.SoundCloudToolStripMenuItem.Click += new System.EventHandler(this.SoundCloudToolStripMenuItem_Click);
            // 
            // SpotifyToolStripMenuItem
            // 
            this.SpotifyToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.SpotifyToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.SpotifyToolStripMenuItem.Image = global::MyMediaPlayer.Properties.Resources.spotify;
            this.SpotifyToolStripMenuItem.Name = "SpotifyToolStripMenuItem";
            this.SpotifyToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.SpotifyToolStripMenuItem.Text = "      Spotify";
            this.SpotifyToolStripMenuItem.Click += new System.EventHandler(this.SpotifyToolStripMenuItem_Click);
            // 
            // TextBox
            // 
            this.TextBox.Animated = true;
            this.TextBox.BackColor = System.Drawing.Color.White;
            this.TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TextBox.BorderRadius = 10;
            this.TextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBox.DefaultText = "";
            this.TextBox.DisabledState.Parent = this.TextBox;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TextBox.FocusedState.FillColor = System.Drawing.Color.LightGray;
            this.TextBox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TextBox.FocusedState.Parent = this.TextBox;
            this.TextBox.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TextBox.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.TextBox.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TextBox.HoverState.Parent = this.TextBox;
            this.TextBox.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TextBox.IconLeft = global::MyMediaPlayer.Properties.Resources.searching;
            this.TextBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.TextBox.IconLeftSize = new System.Drawing.Size(25, 25);
            this.TextBox.IconRight = global::MyMediaPlayer.Properties.Resources.searching;
            this.TextBox.IconRightOffset = new System.Drawing.Point(5, 0);
            this.TextBox.IconRightSize = new System.Drawing.Size(25, 25);
            this.TextBox.Location = new System.Drawing.Point(0, 0);
            this.TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox.Name = "TextBox";
            this.TextBox.PasswordChar = '\0';
            this.TextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TextBox.PlaceholderText = "What will it be? ...";
            this.TextBox.SelectedText = "";
            this.TextBox.ShadowDecoration.Parent = this.TextBox;
            this.TextBox.Size = new System.Drawing.Size(520, 30);
            this.TextBox.TabIndex = 2;
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // IntegrationButton
            // 
            this.IntegrationButton.Animated = true;
            this.IntegrationButton.BorderColor = System.Drawing.Color.White;
            this.IntegrationButton.BorderRadius = 5;
            this.IntegrationButton.BorderThickness = 1;
            this.IntegrationButton.CheckedState.Parent = this.IntegrationButton;
            this.IntegrationButton.ContextMenuStrip = this.ContextMenuStrip;
            this.IntegrationButton.CustomImages.Parent = this.IntegrationButton;
            this.IntegrationButton.DisabledState.Parent = this.IntegrationButton;
            this.IntegrationButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.IntegrationButton.FillColor = System.Drawing.Color.White;
            this.IntegrationButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.IntegrationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.IntegrationButton.HoverState.BorderColor = System.Drawing.Color.White;
            this.IntegrationButton.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.IntegrationButton.HoverState.FillColor = System.Drawing.Color.White;
            this.IntegrationButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.IntegrationButton.HoverState.Parent = this.IntegrationButton;
            this.IntegrationButton.Image = global::MyMediaPlayer.Properties.Resources.down;
            this.IntegrationButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IntegrationButton.Location = new System.Drawing.Point(420, 30);
            this.IntegrationButton.Name = "IntegrationButton";
            this.IntegrationButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.IntegrationButton.ShadowDecoration.Parent = this.IntegrationButton;
            this.IntegrationButton.Size = new System.Drawing.Size(100, 30);
            this.IntegrationButton.TabIndex = 3;
            this.IntegrationButton.Click += new System.EventHandler(this.IntegrationButton_Click);
            // 
            // Pagination
            // 
            this.Pagination.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pagination.Location = new System.Drawing.Point(0, 30);
            this.Pagination.Name = "Pagination";
            this.Pagination.Size = new System.Drawing.Size(420, 30);
            this.Pagination.TabIndex = 4;
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Panel);
            this.Name = "SearchBox";
            this.Size = new System.Drawing.Size(520, 60);
            this.Panel.ResumeLayout(false);
            this.ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel Panel;
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ZingMP3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SoundCloudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpotifyToolStripMenuItem;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton IntegrationButton;
        private Pagination Pagination;
    }
}
