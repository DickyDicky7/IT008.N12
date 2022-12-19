namespace MyMediaPlayer
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
            this.TrackBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.Panel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.DurationLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.VolumeMeter = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.BtnNext10s = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.BtnBack10s = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.BtnNext = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.BtnBack = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.BtnPlay = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.TimeStamp = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.MediaTitle = new MyMediaPlayer.AnimateLabel();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrackBar
            // 
            this.TrackBar.BackColor = System.Drawing.Color.White;
            this.TrackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrackBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TrackBar.FillColor = System.Drawing.Color.LightGray;
            this.TrackBar.HoverState.Parent = this.TrackBar;
            this.TrackBar.Location = new System.Drawing.Point(0, 0);
            this.TrackBar.MaximumSize = new System.Drawing.Size(3000, 50);
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.Size = new System.Drawing.Size(1040, 50);
            this.TrackBar.TabIndex = 10;
            this.TrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.TrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBar_Scroll);
            this.TrackBar.MouseLeave += new System.EventHandler(this.TrackBar_MouseLeave);
            this.TrackBar.MouseHover += new System.EventHandler(this.TrackBar_MouseHover);
            this.TrackBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TrackBar_MouseMove);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.BorderColor = System.Drawing.Color.Transparent;
            this.Panel.Controls.Add(this.DurationLabel);
            this.Panel.Controls.Add(this.VolumeMeter);
            this.Panel.Controls.Add(this.MediaTitle);
            this.Panel.Controls.Add(this.BtnNext10s);
            this.Panel.Controls.Add(this.BtnBack10s);
            this.Panel.Controls.Add(this.BtnNext);
            this.Panel.Controls.Add(this.BtnBack);
            this.Panel.Controls.Add(this.BtnPlay);
            this.Panel.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel.FillColor = System.Drawing.Color.Transparent;
            this.Panel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel.ForeColor = System.Drawing.Color.Transparent;
            this.Panel.Location = new System.Drawing.Point(0, 50);
            this.Panel.MaximumSize = new System.Drawing.Size(3000, 100);
            this.Panel.Name = "Panel";
            this.Panel.ShadowDecoration.Parent = this.Panel;
            this.Panel.Size = new System.Drawing.Size(1040, 100);
            this.Panel.TabIndex = 11;
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = false;
            this.DurationLabel.BackColor = System.Drawing.Color.Transparent;
            this.DurationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.DurationLabel.Location = new System.Drawing.Point(655, 40);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(100, 20);
            this.DurationLabel.TabIndex = 7;
            this.DurationLabel.Text = "xx:yy";
            this.DurationLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VolumeMeter
            // 
            this.VolumeMeter.BackColor = System.Drawing.Color.Transparent;
            this.VolumeMeter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VolumeMeter.FillColor = System.Drawing.Color.LightGray;
            this.VolumeMeter.HoverState.Parent = this.VolumeMeter;
            this.VolumeMeter.Location = new System.Drawing.Point(770, 40);
            this.VolumeMeter.Name = "VolumeMeter";
            this.VolumeMeter.Size = new System.Drawing.Size(100, 20);
            this.VolumeMeter.Style = Siticone.Desktop.UI.WinForms.Enums.TrackBarStyle.Metro;
            this.VolumeMeter.TabIndex = 6;
            this.VolumeMeter.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.VolumeMeter.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VolumeMeter_Scroll);
            // 
            // BtnNext10s
            // 
            this.BtnNext10s.Animated = true;
            this.BtnNext10s.BackColor = System.Drawing.Color.Transparent;
            this.BtnNext10s.BorderColor = System.Drawing.Color.Transparent;
            this.BtnNext10s.CheckedState.Parent = this.BtnNext10s;
            this.BtnNext10s.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext10s.CustomBorderColor = System.Drawing.Color.Transparent;
            this.BtnNext10s.CustomImages.Parent = this.BtnNext10s;
            this.BtnNext10s.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnNext10s.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnNext10s.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnNext10s.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnNext10s.DisabledState.Parent = this.BtnNext10s;
            this.BtnNext10s.FillColor = System.Drawing.Color.Transparent;
            this.BtnNext10s.FocusedColor = System.Drawing.Color.Transparent;
            this.BtnNext10s.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnNext10s.ForeColor = System.Drawing.Color.Transparent;
            this.BtnNext10s.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.BtnNext10s.HoverState.Parent = this.BtnNext10s;
            this.BtnNext10s.Image = global::MyMediaPlayer.Properties.Resources.forward_10s;
            this.BtnNext10s.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnNext10s.Location = new System.Drawing.Point(225, 30);
            this.BtnNext10s.Name = "BtnNext10s";
            this.BtnNext10s.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.BtnNext10s.ShadowDecoration.Parent = this.BtnNext10s;
            this.BtnNext10s.Size = new System.Drawing.Size(40, 40);
            this.BtnNext10s.TabIndex = 4;
            this.BtnNext10s.Click += new System.EventHandler(this.BtnNext10s_Click);
            // 
            // BtnBack10s
            // 
            this.BtnBack10s.Animated = true;
            this.BtnBack10s.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack10s.BorderColor = System.Drawing.Color.Transparent;
            this.BtnBack10s.CheckedState.Parent = this.BtnBack10s;
            this.BtnBack10s.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack10s.CustomBorderColor = System.Drawing.Color.Transparent;
            this.BtnBack10s.CustomImages.Parent = this.BtnBack10s;
            this.BtnBack10s.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack10s.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack10s.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBack10s.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBack10s.DisabledState.Parent = this.BtnBack10s;
            this.BtnBack10s.FillColor = System.Drawing.Color.Transparent;
            this.BtnBack10s.FocusedColor = System.Drawing.Color.Transparent;
            this.BtnBack10s.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnBack10s.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBack10s.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.BtnBack10s.HoverState.Parent = this.BtnBack10s;
            this.BtnBack10s.Image = global::MyMediaPlayer.Properties.Resources.replay_10s;
            this.BtnBack10s.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnBack10s.Location = new System.Drawing.Point(180, 30);
            this.BtnBack10s.Name = "BtnBack10s";
            this.BtnBack10s.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.BtnBack10s.ShadowDecoration.Parent = this.BtnBack10s;
            this.BtnBack10s.Size = new System.Drawing.Size(40, 40);
            this.BtnBack10s.TabIndex = 3;
            this.BtnBack10s.Click += new System.EventHandler(this.BtnBack10s_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Animated = true;
            this.BtnNext.BackColor = System.Drawing.Color.Transparent;
            this.BtnNext.BorderColor = System.Drawing.Color.Transparent;
            this.BtnNext.CheckedState.Parent = this.BtnNext;
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext.CustomBorderColor = System.Drawing.Color.Transparent;
            this.BtnNext.CustomImages.Parent = this.BtnNext;
            this.BtnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnNext.DisabledState.Parent = this.BtnNext;
            this.BtnNext.FillColor = System.Drawing.Color.Transparent;
            this.BtnNext.FocusedColor = System.Drawing.Color.Transparent;
            this.BtnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnNext.ForeColor = System.Drawing.Color.Transparent;
            this.BtnNext.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.BtnNext.HoverState.Parent = this.BtnNext;
            this.BtnNext.Image = global::MyMediaPlayer.Properties.Resources.next_song;
            this.BtnNext.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnNext.Location = new System.Drawing.Point(125, 30);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.BtnNext.ShadowDecoration.Parent = this.BtnNext;
            this.BtnNext.Size = new System.Drawing.Size(40, 40);
            this.BtnNext.TabIndex = 2;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Animated = true;
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.BorderColor = System.Drawing.Color.Transparent;
            this.BtnBack.CheckedState.Parent = this.BtnBack;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.CustomBorderColor = System.Drawing.Color.Transparent;
            this.BtnBack.CustomImages.Parent = this.BtnBack;
            this.BtnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBack.DisabledState.Parent = this.BtnBack;
            this.BtnBack.FillColor = System.Drawing.Color.Transparent;
            this.BtnBack.FocusedColor = System.Drawing.Color.Transparent;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnBack.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBack.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.BtnBack.HoverState.Parent = this.BtnBack;
            this.BtnBack.Image = global::MyMediaPlayer.Properties.Resources.previous_song;
            this.BtnBack.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnBack.Location = new System.Drawing.Point(80, 30);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.BtnBack.ShadowDecoration.Parent = this.BtnBack;
            this.BtnBack.Size = new System.Drawing.Size(40, 40);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Animated = true;
            this.BtnPlay.BackColor = System.Drawing.Color.Transparent;
            this.BtnPlay.BorderColor = System.Drawing.Color.Transparent;
            this.BtnPlay.CheckedState.Parent = this.BtnPlay;
            this.BtnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlay.CustomBorderColor = System.Drawing.Color.Transparent;
            this.BtnPlay.CustomImages.Parent = this.BtnPlay;
            this.BtnPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPlay.DisabledState.Parent = this.BtnPlay;
            this.BtnPlay.FillColor = System.Drawing.Color.Transparent;
            this.BtnPlay.FocusedColor = System.Drawing.Color.Transparent;
            this.BtnPlay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnPlay.ForeColor = System.Drawing.Color.Transparent;
            this.BtnPlay.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.BtnPlay.HoverState.Parent = this.BtnPlay;
            this.BtnPlay.Image = global::MyMediaPlayer.Properties.Resources.play;
            this.BtnPlay.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnPlay.Location = new System.Drawing.Point(15, 25);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.BtnPlay.ShadowDecoration.Parent = this.BtnPlay;
            this.BtnPlay.Size = new System.Drawing.Size(50, 50);
            this.BtnPlay.TabIndex = 0;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // TimeStamp
            // 
            this.TimeStamp.AutoSize = false;
            this.TimeStamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.TimeStamp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStamp.ForeColor = System.Drawing.Color.White;
            this.TimeStamp.Location = new System.Drawing.Point(0, 0);
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.Size = new System.Drawing.Size(60, 18);
            this.TimeStamp.TabIndex = 8;
            this.TimeStamp.Text = "xx:yy";
            this.TimeStamp.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MediaTitle
            // 
            this.MediaTitle.BackColor = System.Drawing.Color.Transparent;
            this.MediaTitle.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.MediaTitle.Location = new System.Drawing.Point(280, 28);
            this.MediaTitle.Name = "MediaTitle";
            this.MediaTitle.Size = new System.Drawing.Size(360, 40);
            this.MediaTitle.Slide = true;
            this.MediaTitle.SlideTime = 15;
            this.MediaTitle.TabIndex = 5;
            this.MediaTitle.Text = "MediaTitle";
            this.MediaTitle.Click += new System.EventHandler(this.MediaTitle_Click);
            // 
            // MediaController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TimeStamp);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.TrackBar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximumSize = new System.Drawing.Size(3000, 150);
            this.Name = "MediaController";
            this.Size = new System.Drawing.Size(1040, 150);
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar TrackBar;
        private Siticone.Desktop.UI.WinForms.SiticonePanel Panel;
        private AnimateLabel MediaTitle;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnNext10s;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnBack10s;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnNext;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnBack;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnPlay;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar VolumeMeter;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel DurationLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel TimeStamp;
    }
}
