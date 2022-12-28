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
            this.TextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SuspendLayout();
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
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.TextBox.Size = new System.Drawing.Size(500, 35);
            this.TextBox.TabIndex = 0;
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBox);
            this.Name = "SearchBox";
            this.Size = new System.Drawing.Size(500, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBox;
    }
}
