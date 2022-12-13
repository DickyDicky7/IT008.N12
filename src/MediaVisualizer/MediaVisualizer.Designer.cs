namespace IT008.N12_015
{
    partial class MediaVisualizer
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
            this.MediaStatus = new CSharp.Winform.UI.Label();
            this.MediaArtist = new CSharp.Winform.UI.Label();
            this.panel1 = new CSharp.Winform.UI.Panel();
            this.MediaTitle = new IT008.N12_015.AnimateLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBox.Location = new System.Drawing.Point(0, 277);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(133, 123);
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
            this.Visualizer.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Visualizer.MaximumFrequency = 10000;
            this.Visualizer.MessageArgs = null;
            this.Visualizer.Name = "Visualizer";
            this.Visualizer.pic3DGraph = null;
            this.Visualizer.Size = new System.Drawing.Size(600, 277);
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
            // MediaStatus
            // 
            this.MediaStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MediaStatus.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MediaStatus.ForeColor = System.Drawing.Color.Transparent;
            this.MediaStatus.Location = new System.Drawing.Point(147, 277);
            this.MediaStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MediaStatus.Name = "MediaStatus";
            this.MediaStatus.Size = new System.Drawing.Size(453, 37);
            this.MediaStatus.TabIndex = 3;
            this.MediaStatus.Text = "MediaStatus";
            this.MediaStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MediaArtist
            // 
            this.MediaArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MediaArtist.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.MediaArtist.ForeColor = System.Drawing.Color.Transparent;
            this.MediaArtist.Location = new System.Drawing.Point(147, 351);
            this.MediaArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MediaArtist.Name = "MediaArtist";
            this.MediaArtist.Size = new System.Drawing.Size(453, 37);
            this.MediaArtist.TabIndex = 5;
            this.MediaArtist.Text = "-- MediaArtist --";
            this.MediaArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 123);
            this.panel1.TabIndex = 6;
            // 
            // MediaTitle
            // 
            this.MediaTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MediaTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.MediaTitle.ForeColor = System.Drawing.Color.Transparent;
            this.MediaTitle.Location = new System.Drawing.Point(147, 314);
            this.MediaTitle.Margin = new System.Windows.Forms.Padding(4);
            this.MediaTitle.Name = "MediaTitle";
            this.MediaTitle.Size = new System.Drawing.Size(453, 37);
            this.MediaTitle.Slide = true;
            this.MediaTitle.SlideTime = 15;
            this.MediaTitle.TabIndex = 4;
            this.MediaTitle.Text = "MediaTitle";
            // 
            // MediaVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.MediaArtist);
            this.Controls.Add(this.MediaTitle);
            this.Controls.Add(this.MediaStatus);
            this.Controls.Add(this.Visualizer);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MediaVisualizer";
            this.Size = new System.Drawing.Size(600, 400);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PictureBox;
        private CSAudioVisualization.AudioVisualization Visualizer;
        private Siticone.Desktop.UI.WinForms.SiticoneColorTransition ColorTransitionB;
        private Siticone.Desktop.UI.WinForms.SiticoneColorTransition ColorTransitionM;
        private CSharp.Winform.UI.Label MediaStatus;
        private AnimateLabel MediaTitle;
        private CSharp.Winform.UI.Label MediaArtist;
        private CSharp.Winform.UI.Panel panel1;
    }
}
