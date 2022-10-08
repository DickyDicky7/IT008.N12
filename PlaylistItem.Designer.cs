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
            this.Playlist = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.Label = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.Thumnail = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.Menu = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.renamePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Playlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Thumnail)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Playlist
            // 
            this.Playlist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Playlist.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Playlist.BorderRadius = 10;
            this.Playlist.Controls.Add(this.Label);
            this.Playlist.Controls.Add(this.Thumnail);
            this.Playlist.Location = new System.Drawing.Point(0, 0);
            this.Playlist.Name = "Playlist";
            this.Playlist.ShadowDecoration.Parent = this.Playlist;
            this.Playlist.Size = new System.Drawing.Size(822, 60);
            this.Playlist.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.Transparent;
            this.Label.BorderRadius = 10;
            this.Label.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Label.DefaultText = "";
            this.Label.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Label.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Label.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Label.DisabledState.Parent = this.Label;
            this.Label.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Label.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.Label.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Label.FocusedState.Parent = this.Label;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Label.HoverState.Parent = this.Label;
            this.Label.Location = new System.Drawing.Point(67, 4);
            this.Label.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Label.Name = "Label";
            this.Label.PasswordChar = '\0';
            this.Label.PlaceholderText = "";
            this.Label.SelectedText = "";
            this.Label.ShadowDecoration.Parent = this.Label;
            this.Label.Size = new System.Drawing.Size(648, 31);
            this.Label.TabIndex = 0;
            this.Label.TextChanged += new System.EventHandler(this.titleLB_TextChanged);
            // 
            // Thumnail
            // 
            this.Thumnail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Thumnail.BorderRadius = 10;
            this.Thumnail.FillColor = System.Drawing.Color.Transparent;
            this.Thumnail.ImageRotate = 0F;
            this.Thumnail.InitialImage = null;
            this.Thumnail.Location = new System.Drawing.Point(0, 0);
            this.Thumnail.Name = "Thumnail";
            this.Thumnail.ShadowDecoration.Parent = this.Thumnail;
            this.Thumnail.Size = new System.Drawing.Size(60, 60);
            this.Thumnail.TabIndex = 0;
            this.Thumnail.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renamePlaylistToolStripMenuItem});
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
            this.Menu.Size = new System.Drawing.Size(179, 26);
            // 
            // renamePlaylistToolStripMenuItem
            // 
            this.renamePlaylistToolStripMenuItem.Name = "renamePlaylistToolStripMenuItem";
            this.renamePlaylistToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.renamePlaylistToolStripMenuItem.Text = "Rename Playlist";
            this.renamePlaylistToolStripMenuItem.Click += new System.EventHandler(this.renamePlaylist);
            // 
            // PlaylistItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.Menu;
            this.Controls.Add(this.Playlist);
            this.Name = "PlaylistItem";
            this.Size = new System.Drawing.Size(822, 60);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlaylistItem_MouseClick);
            this.Playlist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Thumnail)).EndInit();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel Playlist;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox Thumnail;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox Label;
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem renamePlaylistToolStripMenuItem;
    }
}
