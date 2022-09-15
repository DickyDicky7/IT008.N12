namespace IT008.N12_015
{
    partial class form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.av = new CSAudioVisualization.AudioVisualization();
            this.MediaController = new IT008.N12_015.MediaController();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(305, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 600);
            this.panel1.TabIndex = 4;
            // 
            // av
            // 
            this.av.AudioSource = null;
            this.av.BarCount = 50;
            this.av.BarSpacing = 2;
            this.av.ColorBase = System.Drawing.Color.DarkRed;
            this.av.ColorMax = System.Drawing.Color.Snow;
            this.av.DeviceIndex = 0;
            this.av.FileName = null;
            this.av.HighQuality = true;
            this.av.Interval = 40;
            this.av.IsXLogScale = true;
            this.av.Location = new System.Drawing.Point(511, 12);
            this.av.MaximumFrequency = 10000;
            this.av.MessageArgs = null;
            this.av.Name = "av";
            this.av.pic3DGraph = null;
            this.av.Size = new System.Drawing.Size(461, 310);
            this.av.TabIndex = 0;
            this.av.UseAverage = true;
            this.av.UserKey = "Your registration key";
            this.av.UserName = "Your email";
            this.av.VisMode = CSAudioVisualization.GraphMode.ModeSpectrum;
            // 
            // MediaController
            // 
            this.MediaController.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MediaController.Location = new System.Drawing.Point(292, 305);
            this.MediaController.Name = "MediaController";
            this.MediaController.Size = new System.Drawing.Size(400, 50);
            this.MediaController.TabIndex = 5;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.av);
            this.Controls.Add(this.MediaController);
            this.Controls.Add(this.panel1);
            this.Name = "form";
            this.Text = "My Media Player";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MediaController MediaController;
        private CSAudioVisualization.AudioVisualization av;
    }
}

