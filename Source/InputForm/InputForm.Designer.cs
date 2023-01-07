namespace MyMediaPlayer
{
    partial class InputForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.Title = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.TextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.OkButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimateWindow = true;
            this.BorderlessForm.ContainerControl = this;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(129, 30);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(132, 27);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title goes here";
            this.Title.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox
            // 
            this.TextBox.Animated = true;
            this.TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TextBox.BorderThickness = 2;
            this.TextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TextBox.DefaultText = "";
            this.TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox.DisabledState.Parent = this.TextBox;
            this.TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TextBox.FocusedState.FillColor = System.Drawing.Color.LightGray;
            this.TextBox.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TextBox.FocusedState.Parent = this.TextBox;
            this.TextBox.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TextBox.HoverState.FillColor = System.Drawing.Color.LightGray;
            this.TextBox.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TextBox.HoverState.Parent = this.TextBox;
            this.TextBox.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TextBox.Location = new System.Drawing.Point(50, 100);
            this.TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBox.Name = "TextBox";
            this.TextBox.PasswordChar = '\0';
            this.TextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.TextBox.PlaceholderText = "...";
            this.TextBox.SelectedText = "";
            this.TextBox.ShadowDecoration.Parent = this.TextBox;
            this.TextBox.Size = new System.Drawing.Size(300, 50);
            this.TextBox.TabIndex = 1;
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OkButton
            // 
            this.OkButton.Animated = true;
            this.OkButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.OkButton.BorderRadius = 10;
            this.OkButton.CheckedState.Parent = this.OkButton;
            this.OkButton.CustomImages.Parent = this.OkButton;
            this.OkButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OkButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OkButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OkButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OkButton.DisabledState.Parent = this.OkButton;
            this.OkButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.OkButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.OkButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.OkButton.ForeColor = System.Drawing.Color.White;
            this.OkButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.OkButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.OkButton.HoverState.ForeColor = System.Drawing.Color.White;
            this.OkButton.HoverState.Parent = this.OkButton;
            this.OkButton.Location = new System.Drawing.Point(150, 185);
            this.OkButton.Name = "OkButton";
            this.OkButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.OkButton.ShadowDecoration.Parent = this.OkButton;
            this.OkButton.Size = new System.Drawing.Size(100, 40);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "♫ OK ♪";
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm BorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticoneButton OkButton;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel Title;
    }
}