using System;
using System.Windows.Forms;

namespace MyMediaPlayer
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
            this.Menu = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.renamePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.musicList = new MyMediaPlayer.TrackItemList();
            this.playButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.showButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ImageScalingSize = new System.Drawing.Size(15, 15);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renamePlaylistToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.Menu.MaximumSize = new System.Drawing.Size(0, 500);
            this.Menu.Name = "Menu";
            this.Menu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Menu.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Menu.RenderStyle.ColorTable = null;
            this.Menu.RenderStyle.RoundedEdges = true;
            this.Menu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.Menu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Menu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Menu.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Menu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.Menu.Size = new System.Drawing.Size(118, 48);
            // 
            // renamePlaylistToolStripMenuItem
            // 
            this.renamePlaylistToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.renamePlaylistToolStripMenuItem.Name = "renamePlaylistToolStripMenuItem";
            this.renamePlaylistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.renamePlaylistToolStripMenuItem.Text = "Rename";
            this.renamePlaylistToolStripMenuItem.Click += new System.EventHandler(this.renamePlaylist);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // Panel
            // 
            this.Panel.Animated = true;
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.BorderRadius = 10;
            this.Panel.BorderThickness = 1;
            this.Panel.CheckedState.Parent = this.Panel;
            this.Panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel.CustomImages.Parent = this.Panel;
            this.Panel.DisabledState.Parent = this.Panel;
            this.Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel.FillColor = System.Drawing.Color.White;
            this.Panel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.Panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.HoverState.FillColor = System.Drawing.Color.White;
            this.Panel.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.HoverState.Parent = this.Panel;
            this.Panel.Image = global::MyMediaPlayer.Properties.Resources.music_library;
            this.Panel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Panel.ImageSize = new System.Drawing.Size(30, 30);
            this.Panel.Location = new System.Drawing.Point(26, 0);
            this.Panel.Name = "Panel";
            this.Panel.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.Panel.ShadowDecoration.Parent = this.Panel;
            this.Panel.Size = new System.Drawing.Size(524, 47);
            this.Panel.TabIndex = 3;
            this.Panel.Text = "Title goes here";
            this.Panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // musicList
            // 
            this.musicList.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.musicList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musicList.Location = new System.Drawing.Point(26, 47);
            this.musicList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.musicList.MaximumSize = new System.Drawing.Size(0, 253);
            this.musicList.Name = "musicList";
            this.musicList.Size = new System.Drawing.Size(524, 253);
            this.musicList.TabIndex = 4;
            // 
            // playButton
            // 
            this.playButton.Animated = true;
            this.playButton.BackColor = System.Drawing.Color.White;
            this.playButton.CheckedState.Parent = this.playButton;
            this.playButton.CustomImages.Parent = this.playButton;
            this.playButton.DisabledState.Parent = this.playButton;
            this.playButton.FillColor = System.Drawing.Color.White;
            this.playButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.HoverState.FillColor = System.Drawing.Color.White;
            this.playButton.HoverState.Parent = this.playButton;
            this.playButton.Image = global::MyMediaPlayer.Properties.Resources.white_play;
            this.playButton.ImageSize = new System.Drawing.Size(27, 27);
            this.playButton.Location = new System.Drawing.Point(430, 10);
            this.playButton.Name = "playButton";
            this.playButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.playButton.ShadowDecoration.Parent = this.playButton;
            this.playButton.Size = new System.Drawing.Size(27, 27);
            this.playButton.TabIndex = 5;
            // 
            // showButton
            // 
            this.showButton.Animated = true;
            this.showButton.BackColor = System.Drawing.Color.White;
            this.showButton.CheckedState.Parent = this.showButton;
            this.showButton.CustomImages.Parent = this.showButton;
            this.showButton.DisabledState.Parent = this.showButton;
            this.showButton.FillColor = System.Drawing.Color.White;
            this.showButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.showButton.ForeColor = System.Drawing.Color.White;
            this.showButton.HoverState.FillColor = System.Drawing.Color.White;
            this.showButton.HoverState.Parent = this.showButton;
            this.showButton.Image = global::MyMediaPlayer.Properties.Resources.down;
            this.showButton.Location = new System.Drawing.Point(480, 10);
            this.showButton.Name = "showButton";
            this.showButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.showButton.ShadowDecoration.Parent = this.showButton;
            this.showButton.Size = new System.Drawing.Size(27, 27);
            this.showButton.TabIndex = 6;
            // 
            // PlaylistItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.Menu;
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.musicList);
            this.Controls.Add(this.Panel);
            this.Name = "PlaylistItem";
            this.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.Size = new System.Drawing.Size(550, 300);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlaylistItem_MouseClick);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem renamePlaylistToolStripMenuItem;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Panel;
        private TrackItemList musicList;
        private ToolStripMenuItem removeToolStripMenuItem;
        private Siticone.Desktop.UI.WinForms.SiticoneButton playButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton showButton;
    }
}
