namespace MyMediaPlayer
{
    partial class TrackVisualizer
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Visualizer = new CSAudioVisualization.AudioVisualization();
            this.ColorTransitionB = new Siticone.Desktop.UI.WinForms.SiticoneColorTransition(this.components);
            this.ColorTransitionM = new Siticone.Desktop.UI.WinForms.SiticoneColorTransition(this.components);
            this.TrackStatus = new System.Windows.Forms.Label();
            this.TrackArtist = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.TrackTitle = new MyMediaPlayer.AnimateLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBox.Location = new System.Drawing.Point(0, 0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(100, 100);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // Visualizer
            // 
            this.Visualizer.AudioSource = null;
            this.Visualizer.BarCount = 50;
            this.Visualizer.BarSpacing = 2;
            this.Visualizer.ColorBase = System.Drawing.Color.DarkRed;
            this.Visualizer.ColorMax = System.Drawing.Color.Snow;
            this.Visualizer.DeviceIndex = 0;
            this.Visualizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Visualizer.FileName = null;
            this.Visualizer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Visualizer.HighQuality = true;
            this.Visualizer.Interval = 40;
            this.Visualizer.IsXLogScale = true;
            this.Visualizer.Location = new System.Drawing.Point(0, 0);
            this.Visualizer.Margin = new System.Windows.Forms.Padding(4);
            this.Visualizer.MaximumFrequency = 10000;
            this.Visualizer.MessageArgs = null;
            this.Visualizer.Name = "Visualizer";
            this.Visualizer.pic3DGraph = null;
            this.Visualizer.Size = new System.Drawing.Size(450, 225);
            this.Visualizer.TabIndex = 2;
            this.Visualizer.UseAverage = true;
            this.Visualizer.UserKey = "Your registration key";
            this.Visualizer.UserName = "Your email";
            this.Visualizer.VisMode = CSAudioVisualization.GraphMode.ModeSpectrum;
            // 
            // ColorTransitionB
            // 
            this.ColorTransitionB.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // ColorTransitionM
            // 
            this.ColorTransitionM.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // TrackStatus
            // 
            this.TrackStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.TrackStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Italic);
            this.TrackStatus.ForeColor = System.Drawing.Color.Transparent;
            this.TrackStatus.Location = new System.Drawing.Point(100, 0);
            this.TrackStatus.Name = "TrackStatus";
            this.TrackStatus.Size = new System.Drawing.Size(350, 26);
            this.TrackStatus.TabIndex = 3;
            this.TrackStatus.Text = "MediaStatus";
            this.TrackStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TrackArtist
            // 
            this.TrackArtist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TrackArtist.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Underline);
            this.TrackArtist.ForeColor = System.Drawing.Color.Transparent;
            this.TrackArtist.Location = new System.Drawing.Point(100, 70);
            this.TrackArtist.Name = "TrackArtist";
            this.TrackArtist.Size = new System.Drawing.Size(350, 30);
            this.TrackArtist.TabIndex = 5;
            this.TrackArtist.Text = "-- MediaArtist --";
            this.TrackArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.TrackTitle);
            this.Panel.Controls.Add(this.TrackStatus);
            this.Panel.Controls.Add(this.TrackArtist);
            this.Panel.Controls.Add(this.PictureBox);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Panel.Location = new System.Drawing.Point(0, 225);
            this.Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(450, 100);
            this.Panel.TabIndex = 6;
            // 
            // TrackTitle
            // 
            this.TrackTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.TrackTitle.ForeColor = System.Drawing.Color.Transparent;
            this.TrackTitle.Location = new System.Drawing.Point(100, 26);
            this.TrackTitle.Name = "TrackTitle";
            this.TrackTitle.Size = new System.Drawing.Size(350, 44);
            this.TrackTitle.Slide = true;
            this.TrackTitle.SlideTime = 15;
            this.TrackTitle.TabIndex = 4;
            this.TrackTitle.Text = "MediaTitle";
            // 
            // TrackVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Visualizer);
            this.Controls.Add(this.Panel);
            this.Name = "TrackVisualizer";
            this.Size = new System.Drawing.Size(450, 325);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PictureBox;
        private CSAudioVisualization.AudioVisualization Visualizer;
        private Siticone.Desktop.UI.WinForms.SiticoneColorTransition ColorTransitionB;
        private Siticone.Desktop.UI.WinForms.SiticoneColorTransition ColorTransitionM;
        private System.Windows.Forms.Label TrackStatus;
        private AnimateLabel TrackTitle;
        private System.Windows.Forms.Label TrackArtist;
        private System.Windows.Forms.Panel Panel;
    }
}
