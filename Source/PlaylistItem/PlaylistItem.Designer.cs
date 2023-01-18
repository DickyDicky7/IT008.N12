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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Menu = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.RenamePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.PlayButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.DataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ImageScalingSize = new System.Drawing.Size(15, 15);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RenamePlaylistToolStripMenuItem,
            this.RemoveToolStripMenuItem});
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
            this.Menu.Size = new System.Drawing.Size(181, 70);
            // 
            // RenamePlaylistToolStripMenuItem
            // 
            this.RenamePlaylistToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.RenamePlaylistToolStripMenuItem.Name = "RenamePlaylistToolStripMenuItem";
            this.RenamePlaylistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RenamePlaylistToolStripMenuItem.Text = "Rename";
            this.RenamePlaylistToolStripMenuItem.Click += new System.EventHandler(this.RenamePlaylist);
            // 
            // RemoveToolStripMenuItem
            // 
            this.RemoveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem";
            this.RemoveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RemoveToolStripMenuItem.Text = "Remove";
            this.RemoveToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // Panel
            // 
            this.Panel.Animated = true;
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.BorderThickness = 1;
            this.Panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel.FillColor = System.Drawing.Color.White;
            this.Panel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.Panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.HoverState.FillColor = System.Drawing.Color.White;
            this.Panel.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.Image = global::MyMediaPlayer.Properties.Resources.music_library;
            this.Panel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Panel.ImageSize = new System.Drawing.Size(30, 30);
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.Panel.ShadowDecoration.BorderRadius = 10;
            this.Panel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.Panel.Size = new System.Drawing.Size(550, 47);
            this.Panel.TabIndex = 3;
            this.Panel.Text = "Title goes here";
            this.Panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseClick);
            // 
            // PlayButton
            // 
            this.PlayButton.Animated = true;
            this.PlayButton.BackColor = System.Drawing.Color.White;
            this.PlayButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.PlayButton.BorderThickness = 1;
            this.PlayButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.PlayButton.FillColor = System.Drawing.Color.White;
            this.PlayButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.HoverState.FillColor = System.Drawing.Color.White;
            this.PlayButton.Image = global::MyMediaPlayer.Properties.Resources.white_play;
            this.PlayButton.Location = new System.Drawing.Point(523, 47);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.PlayButton.Size = new System.Drawing.Size(27, 123);
            this.PlayButton.TabIndex = 5;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.ColumnHeadersHeight = 35;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.FileType});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.DataGridView.Location = new System.Drawing.Point(0, 47);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowTemplate.Height = 30;
            this.DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridView.Size = new System.Drawing.Size(550, 123);
            this.DataGridView.TabIndex = 7;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.LightGray;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView.ThemeStyle.HeaderStyle.Height = 35;
            this.DataGridView.ThemeStyle.ReadOnly = true;
            this.DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.DataGridView.ThemeStyle.RowsStyle.Height = 30;
            this.DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // FileName
            // 
            this.FileName.FillWeight = 149.2385F;
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FileType
            // 
            this.FileType.FillWeight = 50.76141F;
            this.FileType.HeaderText = "File Type";
            this.FileType.Name = "FileType";
            this.FileType.ReadOnly = true;
            this.FileType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PlaylistItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.Panel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Name = "PlaylistItem";
            this.Size = new System.Drawing.Size(550, 170);
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem RenamePlaylistToolStripMenuItem;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Panel;
        private ToolStripMenuItem RemoveToolStripMenuItem;
        private Siticone.Desktop.UI.WinForms.SiticoneButton PlayButton;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView DataGridView;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn FileType;
    }
}
