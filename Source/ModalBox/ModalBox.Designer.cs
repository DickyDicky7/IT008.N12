namespace MyMediaPlayer
{
    partial class ModalBox
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
            this.components = new System.ComponentModel.Container();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MessageTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.OkButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.BorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.ExitControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TitleLabel.Location = new System.Drawing.Point(100, 30);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(300, 30);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Message\'s Title goes here";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MessageTextBox.DefaultText = "";
            this.MessageTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MessageTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MessageTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MessageTextBox.DisabledState.Parent = this.MessageTextBox;
            this.MessageTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MessageTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MessageTextBox.FocusedState.Parent = this.MessageTextBox;
            this.MessageTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MessageTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MessageTextBox.HoverState.Parent = this.MessageTextBox;
            this.MessageTextBox.Location = new System.Drawing.Point(50, 75);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.PasswordChar = '\0';
            this.MessageTextBox.PlaceholderText = "";
            this.MessageTextBox.SelectedText = "";
            this.MessageTextBox.ShadowDecoration.Parent = this.MessageTextBox;
            this.MessageTextBox.Size = new System.Drawing.Size(400, 150);
            this.MessageTextBox.TabIndex = 2;
            // 
            // OkButton
            // 
            this.OkButton.CheckedState.Parent = this.OkButton;
            this.OkButton.CustomImages.Parent = this.OkButton;
            this.OkButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OkButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OkButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OkButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OkButton.DisabledState.Parent = this.OkButton;
            this.OkButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OkButton.ForeColor = System.Drawing.Color.White;
            this.OkButton.HoverState.Parent = this.OkButton;
            this.OkButton.Location = new System.Drawing.Point(215, 250);
            this.OkButton.Name = "OkButton";
            this.OkButton.ShadowDecoration.Parent = this.OkButton;
            this.OkButton.Size = new System.Drawing.Size(70, 30);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "siticoneButton2";
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimateWindow = true;
            this.BorderlessForm.ContainerControl = this;
            // 
            // ExitControlBox
            // 
            this.ExitControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitControlBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.ExitControlBox.HoverState.Parent = this.ExitControlBox;
            this.ExitControlBox.IconColor = System.Drawing.Color.White;
            this.ExitControlBox.Location = new System.Drawing.Point(450, 0);
            this.ExitControlBox.Name = "ExitControlBox";
            this.ExitControlBox.ShadowDecoration.Parent = this.ExitControlBox;
            this.ExitControlBox.Size = new System.Drawing.Size(50, 30);
            this.ExitControlBox.TabIndex = 4;
            // 
            // ModalBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.ExitControlBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox MessageTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton OkButton;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm BorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox ExitControlBox;
    }
}
