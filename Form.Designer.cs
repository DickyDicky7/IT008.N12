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
            this.btn_load_media = new System.Windows.Forms.Button();
            this.media_controller = new IT008.N12_015.MediaController();
            this.SuspendLayout();
            // 
            // btn_load_media
            // 
            this.btn_load_media.Location = new System.Drawing.Point(186, 74);
            this.btn_load_media.Name = "btn_load_media";
            this.btn_load_media.Size = new System.Drawing.Size(75, 23);
            this.btn_load_media.TabIndex = 2;
            this.btn_load_media.Text = "Load media";
            this.btn_load_media.UseVisualStyleBackColor = true;
            this.btn_load_media.Click += new System.EventHandler(this.btn_load_media_Click);
            // 
            // media_controller
            // 
            this.media_controller.Location = new System.Drawing.Point(242, 240);
            this.media_controller.Name = "media_controller";
            this.media_controller.Size = new System.Drawing.Size(326, 60);
            this.media_controller.TabIndex = 1;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_load_media);
            this.Controls.Add(this.media_controller);
            this.Name = "form";
            this.Text = "My Media Player";
            this.ResumeLayout(false);

        }

        #endregion
        private MediaController media_controller;
        private System.Windows.Forms.Button btn_load_media;
    }
}

