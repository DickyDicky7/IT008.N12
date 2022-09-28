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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.mediaControllerFooter = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.mediaController1 = new IT008.N12_015.MediaController();
            this.controlHeader = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.nameContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneControlBox3 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mediaItemContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.musicHeaderPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.shuffleAndPlayBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sortBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.addFolder = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonImageList = new System.Windows.Forms.ImageList(this.components);
            this.dragControl = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.borderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.sortByMenu = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.aZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaControllerFooter.SuspendLayout();
            this.controlHeader.SuspendLayout();
            this.siticoneTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.musicHeaderPanel.SuspendLayout();
            this.sortByMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mediaControllerFooter
            // 
            this.mediaControllerFooter.Controls.Add(this.mediaController1);
            this.mediaControllerFooter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.mediaControllerFooter.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.mediaControllerFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mediaControllerFooter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.mediaControllerFooter.Location = new System.Drawing.Point(0, 630);
            this.mediaControllerFooter.Name = "mediaControllerFooter";
            this.mediaControllerFooter.ShadowDecoration.Parent = this.mediaControllerFooter;
            this.mediaControllerFooter.Size = new System.Drawing.Size(1500, 170);
            this.mediaControllerFooter.TabIndex = 0;
            // 
            // mediaController1
            // 
            this.mediaController1.BackColor = System.Drawing.Color.Transparent;
            this.mediaController1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaController1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaController1.ForeColor = System.Drawing.Color.Transparent;
            this.mediaController1.Location = new System.Drawing.Point(0, 0);
            this.mediaController1.Name = "mediaController1";
            this.mediaController1.Size = new System.Drawing.Size(1500, 170);
            this.mediaController1.TabIndex = 0;
            // 
            // controlHeader
            // 
            this.controlHeader.Controls.Add(this.nameContainer);
            this.controlHeader.Controls.Add(this.siticoneControlBox3);
            this.controlHeader.Controls.Add(this.siticoneControlBox1);
            this.controlHeader.Controls.Add(this.siticoneControlBox2);
            this.controlHeader.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.controlHeader.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.controlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.controlHeader.Location = new System.Drawing.Point(0, 0);
            this.controlHeader.Name = "controlHeader";
            this.controlHeader.ShadowDecoration.Parent = this.controlHeader;
            this.controlHeader.Size = new System.Drawing.Size(1500, 38);
            this.controlHeader.TabIndex = 2;
            // 
            // nameContainer
            // 
            this.nameContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.nameContainer.Location = new System.Drawing.Point(0, 0);
            this.nameContainer.Name = "nameContainer";
            this.nameContainer.ShadowDecoration.Parent = this.nameContainer;
            this.nameContainer.Size = new System.Drawing.Size(211, 38);
            this.nameContainer.TabIndex = 3;
            // 
            // siticoneControlBox3
            // 
            this.siticoneControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox3.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.siticoneControlBox3.HoverState.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.siticoneControlBox3.Location = new System.Drawing.Point(1320, 0);
            this.siticoneControlBox3.Name = "siticoneControlBox3";
            this.siticoneControlBox3.ShadowDecoration.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.Size = new System.Drawing.Size(60, 38);
            this.siticoneControlBox3.TabIndex = 2;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.siticoneControlBox1.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.siticoneControlBox1.Location = new System.Drawing.Point(1440, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.PressedColor = System.Drawing.Color.Firebrick;
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(60, 38);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.siticoneControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.siticoneControlBox2.HoverState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.siticoneControlBox2.Location = new System.Drawing.Point(1380, 0);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(60, 38);
            this.siticoneControlBox2.TabIndex = 1;
            // 
            // siticoneTabControl1
            // 
            this.siticoneTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.siticoneTabControl1.Controls.Add(this.tabPage1);
            this.siticoneTabControl1.Controls.Add(this.tabPage2);
            this.siticoneTabControl1.Controls.Add(this.tabPage3);
            this.siticoneTabControl1.Controls.Add(this.tabPage4);
            this.siticoneTabControl1.Controls.Add(this.tabPage5);
            this.siticoneTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneTabControl1.ImageList = this.buttonImageList;
            this.siticoneTabControl1.ItemSize = new System.Drawing.Size(210, 50);
            this.siticoneTabControl1.Location = new System.Drawing.Point(0, 38);
            this.siticoneTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.siticoneTabControl1.Name = "siticoneTabControl1";
            this.siticoneTabControl1.Padding = new System.Drawing.Point(0, 0);
            this.siticoneTabControl1.SelectedIndex = 0;
            this.siticoneTabControl1.Size = new System.Drawing.Size(1500, 592);
            this.siticoneTabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.siticoneTabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.siticoneTabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.Black;
            this.siticoneTabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.siticoneTabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.siticoneTabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.siticoneTabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.Black;
            this.siticoneTabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.siticoneTabControl1.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneTabControl1.TabButtonImageOffset = new System.Drawing.Point(8, 0);
            this.siticoneTabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.siticoneTabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.siticoneTabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black;
            this.siticoneTabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(63)))), ((int)(((byte)(10)))));
            this.siticoneTabControl1.TabButtonSize = new System.Drawing.Size(210, 50);
            this.siticoneTabControl1.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.siticoneTabControl1.TabButtonTextOffset = new System.Drawing.Point(13, 0);
            this.siticoneTabControl1.TabIndex = 3;
            this.siticoneTabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabPage1.Controls.Add(this.mediaItemContainer);
            this.tabPage1.Controls.Add(this.musicHeaderPanel);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(214, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1282, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Music library";
            // 
            // mediaItemContainer
            // 
            this.mediaItemContainer.AutoScroll = true;
            this.mediaItemContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaItemContainer.Location = new System.Drawing.Point(0, 154);
            this.mediaItemContainer.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.mediaItemContainer.Name = "mediaItemContainer";
            this.mediaItemContainer.Size = new System.Drawing.Size(1282, 430);
            this.mediaItemContainer.TabIndex = 0;
            // 
            // musicHeaderPanel
            // 
            this.musicHeaderPanel.BorderColor = System.Drawing.Color.Black;
            this.musicHeaderPanel.Controls.Add(this.shuffleAndPlayBtn);
            this.musicHeaderPanel.Controls.Add(this.sortBtn);
            this.musicHeaderPanel.Controls.Add(this.addFolder);
            this.musicHeaderPanel.Controls.Add(this.label1);
            this.musicHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.musicHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.musicHeaderPanel.Name = "musicHeaderPanel";
            this.musicHeaderPanel.ShadowDecoration.Parent = this.musicHeaderPanel;
            this.musicHeaderPanel.Size = new System.Drawing.Size(1282, 154);
            this.musicHeaderPanel.TabIndex = 1;
            // 
            // shuffleAndPlayBtn
            // 
            this.shuffleAndPlayBtn.BackColor = System.Drawing.Color.Transparent;
            this.shuffleAndPlayBtn.BorderColor = System.Drawing.Color.Transparent;
            this.shuffleAndPlayBtn.BorderRadius = 5;
            this.shuffleAndPlayBtn.BorderThickness = 1;
            this.shuffleAndPlayBtn.CheckedState.Parent = this.shuffleAndPlayBtn;
            this.shuffleAndPlayBtn.CustomImages.Parent = this.shuffleAndPlayBtn;
            this.shuffleAndPlayBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.shuffleAndPlayBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.shuffleAndPlayBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.shuffleAndPlayBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.shuffleAndPlayBtn.DisabledState.Parent = this.shuffleAndPlayBtn;
            this.shuffleAndPlayBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(63)))), ((int)(((byte)(10)))));
            this.shuffleAndPlayBtn.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.shuffleAndPlayBtn.ForeColor = System.Drawing.Color.White;
            this.shuffleAndPlayBtn.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.shuffleAndPlayBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(82)))), ((int)(((byte)(35)))));
            this.shuffleAndPlayBtn.HoverState.Parent = this.shuffleAndPlayBtn;
            this.shuffleAndPlayBtn.Image = global::IT008.N12_015.Properties.Resources.white_suffle;
            this.shuffleAndPlayBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.shuffleAndPlayBtn.Location = new System.Drawing.Point(42, 77);
            this.shuffleAndPlayBtn.MinimumSize = new System.Drawing.Size(0, 45);
            this.shuffleAndPlayBtn.Name = "shuffleAndPlayBtn";
            this.shuffleAndPlayBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(100)))), ((int)(((byte)(58)))));
            this.shuffleAndPlayBtn.ShadowDecoration.Parent = this.shuffleAndPlayBtn;
            this.shuffleAndPlayBtn.Size = new System.Drawing.Size(168, 45);
            this.shuffleAndPlayBtn.TabIndex = 3;
            this.shuffleAndPlayBtn.Text = "Shuffle And Play";
            this.shuffleAndPlayBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sortBtn
            // 
            this.sortBtn.BackColor = System.Drawing.Color.Transparent;
            this.sortBtn.BorderColor = System.Drawing.Color.Transparent;
            this.sortBtn.BorderRadius = 5;
            this.sortBtn.BorderThickness = 1;
            this.sortBtn.CheckedState.Parent = this.sortBtn;
            this.sortBtn.CustomImages.Parent = this.sortBtn;
            this.sortBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sortBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sortBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sortBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sortBtn.DisabledState.Parent = this.sortBtn;
            this.sortBtn.FillColor = System.Drawing.Color.Transparent;
            this.sortBtn.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.sortBtn.ForeColor = System.Drawing.Color.Black;
            this.sortBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.sortBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.sortBtn.HoverState.Parent = this.sortBtn;
            this.sortBtn.Image = global::IT008.N12_015.Properties.Resources.down;
            this.sortBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sortBtn.ImageSize = new System.Drawing.Size(15, 15);
            this.sortBtn.Location = new System.Drawing.Point(258, 77);
            this.sortBtn.MinimumSize = new System.Drawing.Size(0, 45);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.ShadowDecoration.Parent = this.sortBtn;
            this.sortBtn.Size = new System.Drawing.Size(131, 45);
            this.sortBtn.TabIndex = 2;
            this.sortBtn.Text = "Sort By: A-Z";
            this.sortBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // addFolder
            // 
            this.addFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFolder.BackColor = System.Drawing.Color.Transparent;
            this.addFolder.BorderColor = System.Drawing.Color.Gainsboro;
            this.addFolder.BorderRadius = 5;
            this.addFolder.BorderThickness = 1;
            this.addFolder.CheckedState.Parent = this.addFolder;
            this.addFolder.CustomImages.Parent = this.addFolder;
            this.addFolder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addFolder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addFolder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addFolder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addFolder.DisabledState.Parent = this.addFolder;
            this.addFolder.FillColor = System.Drawing.Color.Transparent;
            this.addFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addFolder.ForeColor = System.Drawing.Color.Black;
            this.addFolder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.addFolder.HoverState.Parent = this.addFolder;
            this.addFolder.Image = global::IT008.N12_015.Properties.Resources.add_folder;
            this.addFolder.Location = new System.Drawing.Point(1106, 22);
            this.addFolder.Name = "addFolder";
            this.addFolder.ShadowDecoration.Parent = this.addFolder;
            this.addFolder.Size = new System.Drawing.Size(140, 45);
            this.addFolder.TabIndex = 1;
            this.addFolder.Text = "Add Folder";
            this.addFolder.Click += new System.EventHandler(this.addFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.label1.Location = new System.Drawing.Point(30, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music";
            // 
            // tabPage2
            // 
            this.tabPage2.ImageIndex = 4;
            this.tabPage2.Location = new System.Drawing.Point(214, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1282, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Video library";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(214, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1282, 554);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Play queue";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.ImageIndex = 1;
            this.tabPage4.Location = new System.Drawing.Point(214, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1282, 554);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Playlists";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.ImageIndex = 3;
            this.tabPage5.Location = new System.Drawing.Point(214, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1282, 554);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Settings";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonImageList
            // 
            this.buttonImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonImageList.ImageStream")));
            this.buttonImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonImageList.Images.SetKeyName(0, "icons8-music-64.png");
            this.buttonImageList.Images.SetKeyName(1, "icons8-music-library-64.png");
            this.buttonImageList.Images.SetKeyName(2, "icons8-playlist-64.png");
            this.buttonImageList.Images.SetKeyName(3, "icons8-settings-64.png");
            this.buttonImageList.Images.SetKeyName(4, "icons8-video-playlist-64.png");
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.controlHeader;
            // 
            // borderlessForm
            // 
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.DockForm = false;
            this.borderlessForm.DockIndicatorColor = System.Drawing.SystemColors.Window;
            // 
            // sortByMenu
            // 
            this.sortByMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.sortByMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sortByMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aZToolStripMenuItem,
            this.artistToolStripMenuItem,
            this.albumToolStripMenuItem,
            this.genreToolStripMenuItem});
            this.sortByMenu.Name = "sortByMenu";
            this.sortByMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.sortByMenu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.sortByMenu.RenderStyle.ColorTable = null;
            this.sortByMenu.RenderStyle.RoundedEdges = true;
            this.sortByMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.sortByMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sortByMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.sortByMenu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.sortByMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.sortByMenu.Size = new System.Drawing.Size(123, 100);
            // 
            // aZToolStripMenuItem
            // 
            this.aZToolStripMenuItem.Name = "aZToolStripMenuItem";
            this.aZToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.aZToolStripMenuItem.Text = "A-Z";
            this.aZToolStripMenuItem.Click += new System.EventHandler(this.aZToolStripMenuItem_Click);
            // 
            // artistToolStripMenuItem
            // 
            this.artistToolStripMenuItem.Name = "artistToolStripMenuItem";
            this.artistToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.artistToolStripMenuItem.Text = "Artist";
            this.artistToolStripMenuItem.Click += new System.EventHandler(this.artistsToolStripMenuItem_Click);
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.albumToolStripMenuItem.Text = "Album";
            this.albumToolStripMenuItem.Click += new System.EventHandler(this.albumToolStripMenuItem_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.genreToolStripMenuItem.Text = "Genre";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.siticoneTabControl1);
            this.Controls.Add(this.controlHeader);
            this.Controls.Add(this.mediaControllerFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1125, 650);
            this.Name = "form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Media Player";
            this.ResizeBegin += new System.EventHandler(this.form_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.form_ResizeEnd);
            this.Resize += new System.EventHandler(this.form_Resize);
            this.mediaControllerFooter.ResumeLayout(false);
            this.controlHeader.ResumeLayout(false);
            this.siticoneTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.musicHeaderPanel.ResumeLayout(false);
            this.musicHeaderPanel.PerformLayout();
            this.sortByMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            Common.RoundedCorner(this);
            Common.RoundedCorner(sortByMenu);
            MediaItem.MediaController = mediaController1;
            sortBtn.AutoSize = true;
            shuffleAndPlayBtn.AutoSize = true;

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel mediaControllerFooter;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlHeader;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox3;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ImageList buttonImageList;
        private System.Windows.Forms.FlowLayoutPanel mediaItemContainer;
        private Siticone.Desktop.UI.WinForms.SiticonePanel musicHeaderPanel;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel nameContainer;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addFolder;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl dragControl;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm borderlessForm;
        private MediaController mediaController1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sortBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip sortByMenu;
        private System.Windows.Forms.ToolStripMenuItem aZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private Siticone.Desktop.UI.WinForms.SiticoneButton shuffleAndPlayBtn;
    }
}

