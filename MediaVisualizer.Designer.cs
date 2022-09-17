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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Visualizer = new CSAudioVisualization.AudioVisualization();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(0, 225);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(100, 100);
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
            this.Visualizer.FileName = null;
            this.Visualizer.HighQuality = true;
            this.Visualizer.Interval = 40;
            this.Visualizer.IsXLogScale = true;
            this.Visualizer.Location = new System.Drawing.Point(0, 0);
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
            // MediaVisualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Visualizer);
            this.Controls.Add(this.PictureBox);
            this.Name = "MediaVisualizer";
            this.Size = new System.Drawing.Size(450, 450);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PictureBox;
        private CSAudioVisualization.AudioVisualization Visualizer;
    }
}
