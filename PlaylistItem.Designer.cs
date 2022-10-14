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
            this.Label = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.Panel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.PictureBox = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.Menu.SuspendLayout();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
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
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.Transparent;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.Label.Location = new System.Drawing.Point(130, 35);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(144, 30);
            this.Label.TabIndex = 1;
            this.Label.Text = "Title goes here";
            this.Label.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.Label);
            this.Panel.Controls.Add(this.PictureBox);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.ShadowDecoration.Parent = this.Panel;
            this.Panel.Size = new System.Drawing.Size(700, 100);
            this.Panel.TabIndex = 3;
            // 
            // PictureBox
            // 
            this.PictureBox.ImageRotate = 0F;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.ShadowDecoration.Parent = this.PictureBox;
            this.PictureBox.Size = new System.Drawing.Size(110, 100);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            // 
            // PlaylistItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.Menu;
            this.Controls.Add(this.Panel);
            this.Name = "PlaylistItem";
            this.Size = new System.Drawing.Size(700, 100);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlaylistItem_MouseClick);
            this.Menu.ResumeLayout(false);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem renamePlaylistToolStripMenuItem;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel Label;
        private Siticone.Desktop.UI.WinForms.SiticonePanel Panel;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox PictureBox;
    }
}
