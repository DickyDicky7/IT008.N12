namespace IT008.N12_015
{
    partial class MediaController
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
            this.BtnBack = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.BtnPlay = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.BtnNext = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.GradientPanel = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.siticoneCircleButton1 = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.siticoneCircleButton2 = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.TrackBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.GradientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBack.AutoRoundedCorners = true;
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.BorderRadius = 20;
            this.BtnBack.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnBack.CheckedState.Parent = this.BtnBack;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.CustomImages.Parent = this.BtnBack;
            this.BtnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBack.DisabledState.Parent = this.BtnBack;
            this.BtnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.HoverState.Parent = this.BtnBack;
            this.BtnBack.Image = global::IT008.N12_015.Properties.Resources.previous_song;
            this.BtnBack.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnBack.Location = new System.Drawing.Point(472, 20);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.ShadowDecoration.Enabled = true;
            this.BtnBack.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.BtnBack.ShadowDecoration.Parent = this.BtnBack;
            this.BtnBack.Size = new System.Drawing.Size(47, 43);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnBack.UseTransparentBackground = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPlay.AutoRoundedCorners = true;
            this.BtnPlay.BackColor = System.Drawing.Color.Transparent;
            this.BtnPlay.BorderRadius = 26;
            this.BtnPlay.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnPlay.CheckedState.Image = global::IT008.N12_015.Properties.Resources.pause;
            this.BtnPlay.CheckedState.Parent = this.BtnPlay;
            this.BtnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlay.CustomImages.Parent = this.BtnPlay;
            this.BtnPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPlay.DisabledState.Parent = this.BtnPlay;
            this.BtnPlay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.BtnPlay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnPlay.ForeColor = System.Drawing.Color.White;
            this.BtnPlay.HoverState.Parent = this.BtnPlay;
            this.BtnPlay.Image = global::IT008.N12_015.Properties.Resources.play;
            this.BtnPlay.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnPlay.Location = new System.Drawing.Point(527, 7);
            this.BtnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.ShadowDecoration.Enabled = true;
            this.BtnPlay.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.BtnPlay.ShadowDecoration.Parent = this.BtnPlay;
            this.BtnPlay.Size = new System.Drawing.Size(60, 55);
            this.BtnPlay.TabIndex = 4;
            this.BtnPlay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnPlay.UseTransparentBackground = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNext.AutoRoundedCorners = true;
            this.BtnNext.BackColor = System.Drawing.Color.Transparent;
            this.BtnNext.BorderRadius = 20;
            this.BtnNext.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.BtnNext.CheckedState.Parent = this.BtnNext;
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext.CustomImages.Parent = this.BtnNext;
            this.BtnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnNext.DisabledState.Parent = this.BtnNext;
            this.BtnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.BtnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnNext.ForeColor = System.Drawing.Color.White;
            this.BtnNext.HoverState.Parent = this.BtnNext;
            this.BtnNext.Image = global::IT008.N12_015.Properties.Resources.next_song;
            this.BtnNext.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnNext.Location = new System.Drawing.Point(595, 20);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.ShadowDecoration.Enabled = true;
            this.BtnNext.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.BtnNext.ShadowDecoration.Parent = this.BtnNext;
            this.BtnNext.Size = new System.Drawing.Size(47, 43);
            this.BtnNext.TabIndex = 5;
            this.BtnNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnNext.UseTransparentBackground = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // GradientPanel
            // 
            this.GradientPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GradientPanel.Controls.Add(this.siticoneCircleButton1);
            this.GradientPanel.Controls.Add(this.siticoneCircleButton2);
            this.GradientPanel.Controls.Add(this.BtnPlay);
            this.GradientPanel.Controls.Add(this.BtnBack);
            this.GradientPanel.Controls.Add(this.BtnNext);
            this.GradientPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GradientPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GradientPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.GradientPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.GradientPanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.GradientPanel.Location = new System.Drawing.Point(0, 26);
            this.GradientPanel.Margin = new System.Windows.Forms.Padding(4);
            this.GradientPanel.Name = "GradientPanel";
            this.GradientPanel.ShadowDecoration.Enabled = true;
            this.GradientPanel.ShadowDecoration.Parent = this.GradientPanel;
            this.GradientPanel.Size = new System.Drawing.Size(1112, 81);
            this.GradientPanel.TabIndex = 9;
            this.GradientPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GradientPanel_Paint);
            // 
            // siticoneCircleButton1
            // 
            this.siticoneCircleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneCircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCircleButton1.BackgroundImage = global::IT008.N12_015.Properties.Resources.forward_10s;
            this.siticoneCircleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.siticoneCircleButton1.CheckedState.Parent = this.siticoneCircleButton1;
            this.siticoneCircleButton1.CustomImages.Parent = this.siticoneCircleButton1;
            this.siticoneCircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneCircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneCircleButton1.DisabledState.Parent = this.siticoneCircleButton1;
            this.siticoneCircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneCircleButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneCircleButton1.HoverState.Parent = this.siticoneCircleButton1;
            this.siticoneCircleButton1.Location = new System.Drawing.Point(666, 20);
            this.siticoneCircleButton1.Name = "siticoneCircleButton1";
            this.siticoneCircleButton1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCircleButton1.ShadowDecoration.Parent = this.siticoneCircleButton1;
            this.siticoneCircleButton1.Size = new System.Drawing.Size(51, 46);
            this.siticoneCircleButton1.TabIndex = 9;
            this.siticoneCircleButton1.Click += new System.EventHandler(this.BtnNext10s_Click);
            // 
            // siticoneCircleButton2
            // 
            this.siticoneCircleButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siticoneCircleButton2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCircleButton2.BackgroundImage = global::IT008.N12_015.Properties.Resources.replay_10s;
            this.siticoneCircleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.siticoneCircleButton2.CheckedState.Parent = this.siticoneCircleButton2;
            this.siticoneCircleButton2.CustomImages.Parent = this.siticoneCircleButton2;
            this.siticoneCircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneCircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneCircleButton2.DisabledState.Parent = this.siticoneCircleButton2;
            this.siticoneCircleButton2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneCircleButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneCircleButton2.HoverState.Parent = this.siticoneCircleButton2;
            this.siticoneCircleButton2.Location = new System.Drawing.Point(723, 20);
            this.siticoneCircleButton2.Name = "siticoneCircleButton2";
            this.siticoneCircleButton2.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCircleButton2.ShadowDecoration.Parent = this.siticoneCircleButton2;
            this.siticoneCircleButton2.Size = new System.Drawing.Size(51, 46);
            this.siticoneCircleButton2.TabIndex = 10;
            this.siticoneCircleButton2.Click += new System.EventHandler(this.BtnBack10s_Click);
            // 
            // TrackBar
            // 
            this.TrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TrackBar.FillColor = System.Drawing.Color.Gainsboro;
            this.TrackBar.HoverState.FillColor = System.Drawing.Color.DarkGray;
            this.TrackBar.HoverState.Parent = this.TrackBar;
            this.TrackBar.HoverState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TrackBar.Location = new System.Drawing.Point(0, -1);
            this.TrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.Size = new System.Drawing.Size(1112, 27);
            this.TrackBar.TabIndex = 10;
            this.TrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.TrackBar.Value = 0;
            this.TrackBar.Click += new System.EventHandler(this.Panel_Click);
            // 
            // MediaController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.TrackBar);
            this.Controls.Add(this.GradientPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MediaController";
            this.Size = new System.Drawing.Size(1112, 107);
            this.Click += new System.EventHandler(this.BtnPlay_Click);
            this.GradientPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnBack;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnPlay;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnNext;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel GradientPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar TrackBar;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton siticoneCircleButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton siticoneCircleButton1;
    }
}
