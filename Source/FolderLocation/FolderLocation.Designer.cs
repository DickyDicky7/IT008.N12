namespace MyMediaPlayer
{
    partial class FolderLocation
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
            this.folderURL = new System.Windows.Forms.Label();
            this.removeBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // folderURL
            // 
            this.folderURL.AutoSize = true;
            this.folderURL.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.folderURL.Location = new System.Drawing.Point(25, 9);
            this.folderURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.folderURL.Name = "folderURL";
            this.folderURL.Size = new System.Drawing.Size(59, 15);
            this.folderURL.TabIndex = 0;
            this.folderURL.Text = "folderURL";
            // 
            // removeBtn
            // 
            this.removeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeBtn.Animated = true;
            this.removeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.removeBtn.BorderRadius = 2;
            this.removeBtn.BorderThickness = 1;
            this.removeBtn.CheckedState.Parent = this.removeBtn;
            this.removeBtn.CustomImages.Parent = this.removeBtn;
            this.removeBtn.DisabledState.Parent = this.removeBtn;
            this.removeBtn.FillColor = System.Drawing.Color.White;
            this.removeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.removeBtn.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.removeBtn.HoverState.FillColor = System.Drawing.Color.White;
            this.removeBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.removeBtn.HoverState.Parent = this.removeBtn;
            this.removeBtn.Image = global::MyMediaPlayer.Properties.Resources.close;
            this.removeBtn.ImageSize = new System.Drawing.Size(14, 14);
            this.removeBtn.Location = new System.Drawing.Point(484, 6);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.removeBtn.ShadowDecoration.Parent = this.removeBtn;
            this.removeBtn.Size = new System.Drawing.Size(25, 19);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // FolderLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.folderURL);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FolderLocation";
            this.Padding = new System.Windows.Forms.Padding(22, 3, 45, 3);
            this.Size = new System.Drawing.Size(600, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label folderURL;
        private Siticone.Desktop.UI.WinForms.SiticoneButton removeBtn;
    }
}
