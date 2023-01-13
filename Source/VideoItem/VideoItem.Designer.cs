namespace MyMediaPlayer
{
    partial class VideoItem
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
            this.Label = new System.Windows.Forms.Label();
            this.ToolTip = new Siticone.Desktop.UI.WinForms.SiticoneHtmlToolTip();
            this.PictureBox = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.BorderThickness = 1;
            this.Panel.Controls.Add(this.PictureBox);
            this.Panel.Controls.Add(this.Label);
            this.Panel.FillColor = System.Drawing.Color.White;
            this.Panel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.Location = new System.Drawing.Point(1, 1);
            this.Panel.Name = "Panel";
            this.Panel.ShadowDecoration.BorderRadius = 0;
            this.Panel.ShadowDecoration.Enabled = true;
            this.Panel.Size = new System.Drawing.Size(98, 143);
            this.Panel.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label.BackColor = System.Drawing.Color.White;
            this.Label.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Label.Location = new System.Drawing.Point(1, 90);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(96, 52);
            this.Label.TabIndex = 1;
            this.Label.Text = "Title";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToolTip
            // 
            this.ToolTip.AllowLinksHandling = true;
            this.ToolTip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ToolTip.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.ToolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.ToolTip.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.ToolTip.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.ToolTip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.BackColor = System.Drawing.Color.White;
            this.PictureBox.Image = global::MyMediaPlayer.Properties.Resources.video_thumbnail;
            this.PictureBox.ImageRotate = 0F;
            this.PictureBox.Location = new System.Drawing.Point(1, 1);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(96, 87);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // VideoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Panel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VideoItem";
            this.Size = new System.Drawing.Size(100, 145);
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel Panel;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox PictureBox;
        private System.Windows.Forms.Label Label;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlToolTip ToolTip;
    }
}
