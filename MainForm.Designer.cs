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
            this.minimizeControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.exitControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.maximizeControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mediaItemContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.musicHeaderPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.shuffleAndPlayBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sortBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.addFolder = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.musicLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.settingLabel = new System.Windows.Forms.Label();
            this.buttonImageList = new System.Windows.Forms.ImageList(this.components);
            this.dragControl = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.borderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.sortByMenu = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.aZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlBorder = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.librariesLb = new System.Windows.Forms.Label();
            this.settingHeaderPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.musicFolderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.musicFolderContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.mediaControllerFooter.SuspendLayout();
            this.controlHeader.SuspendLayout();
            this.siticoneTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.musicHeaderPanel.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.sortByMenu.SuspendLayout();
            this.settingHeaderPanel.SuspendLayout();
            this.musicFolderContainer.SuspendLayout();
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
            this.controlHeader.Controls.Add(this.minimizeControlBox);
            this.controlHeader.Controls.Add(this.exitControlBox);
            this.controlHeader.Controls.Add(this.maximizeControlBox);
            this.controlHeader.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
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
            this.nameContainer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.nameContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.nameContainer.Location = new System.Drawing.Point(0, 0);
            this.nameContainer.Name = "nameContainer";
            this.nameContainer.ShadowDecoration.Parent = this.nameContainer;
            this.nameContainer.Size = new System.Drawing.Size(211, 38);
            this.nameContainer.TabIndex = 3;
            // 
            // minimizeControlBox
            // 
            this.minimizeControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeControlBox.BackColor = System.Drawing.Color.Transparent;
            this.minimizeControlBox.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimizeControlBox.FillColor = System.Drawing.Color.Transparent;
            this.minimizeControlBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.minimizeControlBox.HoverState.Parent = this.minimizeControlBox;
            this.minimizeControlBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.minimizeControlBox.Location = new System.Drawing.Point(1320, 0);
            this.minimizeControlBox.Name = "minimizeControlBox";
            this.minimizeControlBox.ShadowDecoration.Parent = this.minimizeControlBox;
            this.minimizeControlBox.Size = new System.Drawing.Size(60, 38);
            this.minimizeControlBox.TabIndex = 2;
            // 
            // exitControlBox
            // 
            this.exitControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitControlBox.BackColor = System.Drawing.Color.Transparent;
            this.exitControlBox.FillColor = System.Drawing.Color.Transparent;
            this.exitControlBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.exitControlBox.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.exitControlBox.HoverState.Parent = this.exitControlBox;
            this.exitControlBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.exitControlBox.Location = new System.Drawing.Point(1440, 0);
            this.exitControlBox.Name = "exitControlBox";
            this.exitControlBox.PressedColor = System.Drawing.Color.Firebrick;
            this.exitControlBox.ShadowDecoration.Parent = this.exitControlBox;
            this.exitControlBox.Size = new System.Drawing.Size(60, 38);
            this.exitControlBox.TabIndex = 0;
            // 
            // maximizeControlBox
            // 
            this.maximizeControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeControlBox.BackColor = System.Drawing.Color.Transparent;
            this.maximizeControlBox.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.maximizeControlBox.FillColor = System.Drawing.Color.Transparent;
            this.maximizeControlBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.maximizeControlBox.HoverState.Parent = this.maximizeControlBox;
            this.maximizeControlBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.maximizeControlBox.Location = new System.Drawing.Point(1380, 0);
            this.maximizeControlBox.Name = "maximizeControlBox";
            this.maximizeControlBox.ShadowDecoration.Parent = this.maximizeControlBox;
            this.maximizeControlBox.Size = new System.Drawing.Size(60, 38);
            this.maximizeControlBox.TabIndex = 1;
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
            this.mediaItemContainer.Margin = new System.Windows.Forms.Padding(0);
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
            this.musicHeaderPanel.Controls.Add(this.musicLabel);
            this.musicHeaderPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.musicHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.musicHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.musicHeaderPanel.Margin = new System.Windows.Forms.Padding(0);
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
            // musicLabel
            // 
            this.musicLabel.AutoSize = true;
            this.musicLabel.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.musicLabel.Location = new System.Drawing.Point(30, 0);
            this.musicLabel.Name = "musicLabel";
            this.musicLabel.Size = new System.Drawing.Size(158, 67);
            this.musicLabel.TabIndex = 0;
            this.musicLabel.Text = "Music";
            // 
            // tabPage2
            // 
            this.tabPage2.ImageIndex = 4;
            this.tabPage2.Location = new System.Drawing.Point(214, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1282, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Video library";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(214, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1282, 584);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Play queue";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.ImageIndex = 1;
            this.tabPage4.Location = new System.Drawing.Point(214, 4);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1282, 584);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Playlists";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabPage5.Controls.Add(this.musicFolderContainer);
            this.tabPage5.Controls.Add(this.settingHeaderPanel);
            this.tabPage5.ImageIndex = 3;
            this.tabPage5.Location = new System.Drawing.Point(214, 4);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(30, 0, 50, 0);
            this.tabPage5.Size = new System.Drawing.Size(1282, 584);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Settings";
            // 
            // settingLabel
            // 
            this.settingLabel.AutoSize = true;
            this.settingLabel.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.settingLabel.Location = new System.Drawing.Point(0, 0);
            this.settingLabel.Name = "settingLabel";
            this.settingLabel.Size = new System.Drawing.Size(206, 67);
            this.settingLabel.TabIndex = 1;
            this.settingLabel.Text = "Settings";
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
            // tabControlBorder
            // 
            this.tabControlBorder.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.tabControlBorder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.tabControlBorder.Location = new System.Drawing.Point(0, 0);
            this.tabControlBorder.Name = "tabControlBorder";
            this.tabControlBorder.ShadowDecoration.Parent = this.tabControlBorder;
            this.tabControlBorder.Size = new System.Drawing.Size(0, 0);
            this.tabControlBorder.TabIndex = 4;
            // 
            // librariesLb
            // 
            this.librariesLb.AutoSize = true;
            this.librariesLb.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.librariesLb.Location = new System.Drawing.Point(6, 67);
            this.librariesLb.Name = "librariesLb";
            this.librariesLb.Size = new System.Drawing.Size(109, 35);
            this.librariesLb.TabIndex = 3;
            this.librariesLb.Text = "Libraries";
            // 
            // settingHeaderPanel
            // 
            this.settingHeaderPanel.Controls.Add(this.settingLabel);
            this.settingHeaderPanel.Controls.Add(this.librariesLb);
            this.settingHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingHeaderPanel.Location = new System.Drawing.Point(30, 0);
            this.settingHeaderPanel.Name = "settingHeaderPanel";
            this.settingHeaderPanel.ShadowDecoration.Parent = this.settingHeaderPanel;
            this.settingHeaderPanel.Size = new System.Drawing.Size(1202, 123);
            this.settingHeaderPanel.TabIndex = 4;
            // 
            // musicFolderPanel
            // 
            this.musicFolderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.musicFolderPanel.Location = new System.Drawing.Point(10, 78);
            this.musicFolderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.musicFolderPanel.Name = "musicFolderPanel";
            this.musicFolderPanel.Size = new System.Drawing.Size(1182, 156);
            this.musicFolderPanel.TabIndex = 5;
            // 
            // musicFolderContainer
            // 
            this.musicFolderContainer.BorderColor = System.Drawing.Color.Gainsboro;
            this.musicFolderContainer.BorderRadius = 10;
            this.musicFolderContainer.BorderThickness = 1;
            this.musicFolderContainer.Controls.Add(this.musicFolderPanel);
            this.musicFolderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.musicFolderContainer.Location = new System.Drawing.Point(30, 123);
            this.musicFolderContainer.Name = "musicFolderContainer";
            this.musicFolderContainer.Padding = new System.Windows.Forms.Padding(10);
            this.musicFolderContainer.ShadowDecoration.Parent = this.musicFolderContainer;
            this.musicFolderContainer.Size = new System.Drawing.Size(1202, 244);
            this.musicFolderContainer.TabIndex = 6;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.tabControlBorder);
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
            this.tabPage5.ResumeLayout(false);
            this.sortByMenu.ResumeLayout(false);
            this.settingHeaderPanel.ResumeLayout(false);
            this.settingHeaderPanel.PerformLayout();
            this.musicFolderContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel mediaControllerFooter;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlHeader;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimizeControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox exitControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox maximizeControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ImageList buttonImageList;
        private System.Windows.Forms.FlowLayoutPanel mediaItemContainer;
        private Siticone.Desktop.UI.WinForms.SiticonePanel musicHeaderPanel;
        private System.Windows.Forms.Label musicLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel nameContainer;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addFolder;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl dragControl;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm borderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sortBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip sortByMenu;
        private System.Windows.Forms.ToolStripMenuItem aZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private Siticone.Desktop.UI.WinForms.SiticoneButton shuffleAndPlayBtn;
        private MediaController mediaController1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel tabControlBorder;
        private System.Windows.Forms.Label settingLabel;
        private System.Windows.Forms.Label librariesLb;
        private Siticone.Desktop.UI.WinForms.SiticonePanel settingHeaderPanel;
        private System.Windows.Forms.FlowLayoutPanel musicFolderPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel musicFolderContainer;
    }
}

