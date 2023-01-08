namespace MyMediaPlayer
{
    partial class ZingMP3IntegrationSearchResult
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
            this.PictureBox = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.Panel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ImagePanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.ImageRotate = 0F;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.ShadowDecoration.Parent = this.PictureBox;
            this.PictureBox.Size = new System.Drawing.Size(0, 0);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // Panel
            // 
            this.Panel.Animated = true;
            this.Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.BorderRadius = 10;
            this.Panel.BorderThickness = 1;
            this.Panel.CheckedState.Parent = this.Panel;
            this.Panel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.CustomImages.Parent = this.Panel;
            this.Panel.DisabledState.Parent = this.Panel;
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.FillColor = System.Drawing.Color.White;
            this.Panel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.Panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.Panel.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.Panel.HoverState.Parent = this.Panel;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.Panel.ShadowDecoration.Parent = this.Panel;
            this.Panel.Size = new System.Drawing.Size(550, 60);
            this.Panel.TabIndex = 1;
            this.Panel.Text = "Helooooooooo";
            this.Panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Panel.TextOffset = new System.Drawing.Point(100, 0);
            this.Panel.Click += new System.EventHandler(this.Panel_Click);
            // 
            // ImagePanel
            // 
            this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImagePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ImagePanel.BorderRadius = 10;
            this.ImagePanel.BorderThickness = 1;
            this.ImagePanel.CustomizableEdges.BottomRight = false;
            this.ImagePanel.CustomizableEdges.TopRight = false;
            this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ImagePanel.Location = new System.Drawing.Point(0, 0);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.ShadowDecoration.Parent = this.ImagePanel;
            this.ImagePanel.Size = new System.Drawing.Size(60, 60);
            this.ImagePanel.TabIndex = 2;
            // 
            // ZingMP3SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.PictureBox);
            this.Name = "ZingMP3SearchResult";
            this.Size = new System.Drawing.Size(550, 60);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePictureBox PictureBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Panel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel ImagePanel;
    }
}
