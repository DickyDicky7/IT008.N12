namespace IT008.N12_015
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
            this.folderURL.Location = new System.Drawing.Point(33, 7);
            this.folderURL.Name = "folderURL";
            this.folderURL.Size = new System.Drawing.Size(68, 16);
            this.folderURL.TabIndex = 0;
            this.folderURL.Text = "folderURL";
            // 
            // removeBtn
            // 
            this.removeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.removeBtn.BorderRadius = 2;
            this.removeBtn.BorderThickness = 1;
            this.removeBtn.CheckedState.Parent = this.removeBtn;
            this.removeBtn.CustomImages.Parent = this.removeBtn;
            this.removeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.removeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.removeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.removeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.removeBtn.DisabledState.Parent = this.removeBtn;
            this.removeBtn.FillColor = System.Drawing.Color.White;
            this.removeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.HoverState.Parent = this.removeBtn;
            this.removeBtn.Image = global::IT008.N12_015.Properties.Resources.close;
            this.removeBtn.ImageSize = new System.Drawing.Size(14, 14);
            this.removeBtn.Location = new System.Drawing.Point(745, 3);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.ShadowDecoration.Parent = this.removeBtn;
            this.removeBtn.Size = new System.Drawing.Size(33, 23);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // FolderLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.folderURL);
            this.Name = "FolderLocation";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 5, 0);
            this.Size = new System.Drawing.Size(800, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label folderURL;
        private Siticone.Desktop.UI.WinForms.SiticoneButton removeBtn;
    }
}
