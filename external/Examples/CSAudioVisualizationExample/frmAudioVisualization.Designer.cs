namespace CSAudioVisualizationExample
{
    partial class frmAudioVisualization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAudioVisualization));
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRecorderMode = new System.Windows.Forms.Label();
            this.cboRecorderMode = new System.Windows.Forms.ComboBox();
            this.lblAudioSource = new System.Windows.Forms.Label();
            this.cboAudioSource = new System.Windows.Forms.ComboBox();
            this.cmdOrderLicense = new System.Windows.Forms.Button();
            this.audioVisualization1 = new CSAudioVisualization.AudioVisualization();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(192, 495);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(131, 34);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(55, 495);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(131, 34);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblRecorderMode
            // 
            this.lblRecorderMode.AutoSize = true;
            this.lblRecorderMode.Location = new System.Drawing.Point(52, 34);
            this.lblRecorderMode.Name = "lblRecorderMode";
            this.lblRecorderMode.Size = new System.Drawing.Size(81, 13);
            this.lblRecorderMode.TabIndex = 47;
            this.lblRecorderMode.Text = "Recorder Mode";
            // 
            // cboRecorderMode
            // 
            this.cboRecorderMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRecorderMode.FormattingEnabled = true;
            this.cboRecorderMode.Location = new System.Drawing.Point(55, 50);
            this.cboRecorderMode.Name = "cboRecorderMode";
            this.cboRecorderMode.Size = new System.Drawing.Size(530, 21);
            this.cboRecorderMode.TabIndex = 46;
            this.cboRecorderMode.SelectedIndexChanged += new System.EventHandler(this.cboRecorderMode_SelectedIndexChanged);
            // 
            // lblAudioSource
            // 
            this.lblAudioSource.AutoSize = true;
            this.lblAudioSource.Location = new System.Drawing.Point(52, 87);
            this.lblAudioSource.Name = "lblAudioSource";
            this.lblAudioSource.Size = new System.Drawing.Size(71, 13);
            this.lblAudioSource.TabIndex = 45;
            this.lblAudioSource.Text = "Audio Source";
            // 
            // cboAudioSource
            // 
            this.cboAudioSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudioSource.FormattingEnabled = true;
            this.cboAudioSource.Location = new System.Drawing.Point(55, 103);
            this.cboAudioSource.Name = "cboAudioSource";
            this.cboAudioSource.Size = new System.Drawing.Size(530, 21);
            this.cboAudioSource.TabIndex = 44;
            // 
            // cmdOrderLicense
            // 
            this.cmdOrderLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmdOrderLicense.Image = ((System.Drawing.Image)(resources.GetObject("cmdOrderLicense.Image")));
            this.cmdOrderLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdOrderLicense.Location = new System.Drawing.Point(425, 495);
            this.cmdOrderLicense.Name = "cmdOrderLicense";
            this.cmdOrderLicense.Size = new System.Drawing.Size(160, 34);
            this.cmdOrderLicense.TabIndex = 287;
            this.cmdOrderLicense.Text = "Order a license online";
            this.cmdOrderLicense.UseVisualStyleBackColor = true;
            this.cmdOrderLicense.Click += new System.EventHandler(this.cmdOrderLicense_Click);
            // 
            // audioVisualization1
            // 
            this.audioVisualization1.AudioSource = null;
            this.audioVisualization1.BackColor = System.Drawing.Color.Black;
            this.audioVisualization1.BarCount = 50;
            this.audioVisualization1.BarSpacing = 2;
            this.audioVisualization1.ColorBase = System.Drawing.Color.Green;
            this.audioVisualization1.ColorMax = System.Drawing.Color.Red;
            this.audioVisualization1.DeviceIndex = 0;
            this.audioVisualization1.FileName = null;
            this.audioVisualization1.HighQuality = true;
            this.audioVisualization1.Interval = 40;
            this.audioVisualization1.IsXLogScale = true;
            this.audioVisualization1.Location = new System.Drawing.Point(55, 142);
            this.audioVisualization1.MaximumFrequency = 10000;
            this.audioVisualization1.MessageArgs = null;
            this.audioVisualization1.Name = "audioVisualization1";
            this.audioVisualization1.pic3DGraph = null;
            this.audioVisualization1.Size = new System.Drawing.Size(530, 325);
            this.audioVisualization1.TabIndex = 19;
            this.audioVisualization1.UseAverage = true;
            this.audioVisualization1.UserKey = "Your registration key";
            this.audioVisualization1.UserName = "Your email";
            this.audioVisualization1.VisMode = CSAudioVisualization.GraphMode.ModeSpectrum;
            // 
            // frmAudioVisualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 547);
            this.Controls.Add(this.cmdOrderLicense);
            this.Controls.Add(this.lblRecorderMode);
            this.Controls.Add(this.cboRecorderMode);
            this.Controls.Add(this.lblAudioSource);
            this.Controls.Add(this.cboAudioSource);
            this.Controls.Add(this.audioVisualization1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAudioVisualization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSAudioVisualization - Full Example";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAudioVisualization_FormClosing);
            this.Load += new System.EventHandler(this.frmAudioVisualization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private CSAudioVisualization.AudioVisualization audioVisualization1;
        private System.Windows.Forms.Label lblRecorderMode;
        private System.Windows.Forms.ComboBox cboRecorderMode;
        private System.Windows.Forms.Label lblAudioSource;
        private System.Windows.Forms.ComboBox cboAudioSource;
        private System.Windows.Forms.Button cmdOrderLicense;
    }
}

