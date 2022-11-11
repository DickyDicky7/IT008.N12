using System;
using System.Windows.Forms;

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
            this.Menu = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.renamePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.musicList = new IT008.N12_015.MusicList();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renamePlaylistToolStripMenuItem,
            this.removeToolStripMenuItem});
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
            this.Menu.Size = new System.Drawing.Size(211, 76);
            // 
            // renamePlaylistToolStripMenuItem
            // 
            this.renamePlaylistToolStripMenuItem.Name = "renamePlaylistToolStripMenuItem";
            this.renamePlaylistToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.renamePlaylistToolStripMenuItem.Text = "Rename";
            this.renamePlaylistToolStripMenuItem.Click += new System.EventHandler(this.renamePlaylist);
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
            this.Panel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.Panel.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.HoverState.Parent = this.Panel;
            this.Panel.Image = global::IT008.N12_015.Properties.Resources.icons8_music_library_64;
            this.Panel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Panel.ImageSize = new System.Drawing.Size(30, 30);
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel.Name = "Panel";
            this.Panel.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.Panel.ShadowDecoration.Parent = this.Panel;
            this.Panel.Size = new System.Drawing.Size(733, 58);
            this.Panel.TabIndex = 3;
            this.Panel.Text = "Title goes here";
            this.Panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // musicList
            // 
            this.musicList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.musicList.Location = new System.Drawing.Point(0, 58);
            this.musicList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.musicList.Name = "musicList";
            this.musicList.Size = new System.Drawing.Size(733, 311);
            this.musicList.TabIndex = 4;
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // PlaylistItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.Menu;
            this.Controls.Add(this.musicList);
            this.Controls.Add(this.Panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PlaylistItem";
            this.Size = new System.Drawing.Size(733, 369);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlaylistItem_MouseClick);
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem renamePlaylistToolStripMenuItem;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Panel;
        private MusicList musicList;
        private ToolStripMenuItem removeToolStripMenuItem;
    }
}
