namespace MyMediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.mediaControllerFooter = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.mediaController = new MyMediaPlayer.MediaController();
            this.controlHeader = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.nameContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.minimizeControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.exitControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.maximizeControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.tabControl = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.musicLibraryTabPage = new System.Windows.Forms.TabPage();
            this.musicList = new MyMediaPlayer.MusicList();
            this.musicHeaderPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.shuffleAndPlayBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sortBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.addFolder = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.musicLabel = new System.Windows.Forms.Label();
            this.videoLibraryTabPage = new System.Windows.Forms.TabPage();
            this.playQueueTabPage = new System.Windows.Forms.TabPage();
            this.PlayQMusicList = new MyMediaPlayer.MusicList();
            this.playQueueHeaderPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.playQueueClearButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.playQueueHeaderLabel = new System.Windows.Forms.Label();
            this.playlistsTabPage = new System.Windows.Forms.TabPage();
            this.playlistsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.playlistsHeaderPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.playlistsHeaderLabel = new System.Windows.Forms.Label();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.musicFolderContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.musicFolderPanel = new System.Windows.Forms.Panel();
            this.addMusicFolderSTBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.musicLocationLb = new System.Windows.Forms.Label();
            this.settingsIconPictureBox = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.settingHeaderPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.settingLabel = new System.Windows.Forms.Label();
            this.librariesLb = new System.Windows.Forms.Label();
            this.onlineStoreTabPage = new System.Windows.Forms.TabPage();
            this.onlineStoreBodyPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.searchResultList = new MyMediaPlayer.SearchResultList();
            this.onlineStoreSearchBox = new MyMediaPlayer.SearchBox();
            this.onlineStoreHeaderPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.onlineStoreHeaderLabel = new System.Windows.Forms.Label();
            this.buttonImageList = new System.Windows.Forms.ImageList();
            this.dragControl = new Siticone.Desktop.UI.WinForms.SiticoneDragControl();
            this.borderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm();
            this.sortByMenu = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.aZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlBorder = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.visualizeContainer = new System.Windows.Forms.Panel();
            this.exitButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.mediaVisualizer = new MyMediaPlayer.MediaVisualizer();
            this.mediaLyrics = new MyMediaPlayer.MediaLyrics();
            this.mediaControllerFooter.SuspendLayout();
            this.controlHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.musicLibraryTabPage.SuspendLayout();
            this.musicHeaderPanel.SuspendLayout();
            this.playQueueTabPage.SuspendLayout();
            this.playQueueHeaderPanel.SuspendLayout();
            this.playlistsTabPage.SuspendLayout();
            this.playlistsHeaderPanel.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.musicFolderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsIconPictureBox)).BeginInit();
            this.settingHeaderPanel.SuspendLayout();
            this.onlineStoreTabPage.SuspendLayout();
            this.onlineStoreBodyPanel.SuspendLayout();
            this.onlineStoreHeaderPanel.SuspendLayout();
            this.sortByMenu.SuspendLayout();
            this.visualizeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mediaControllerFooter
            // 
            this.mediaControllerFooter.Controls.Add(this.mediaController);
            this.mediaControllerFooter.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.mediaControllerFooter.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.mediaControllerFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mediaControllerFooter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.mediaControllerFooter.Location = new System.Drawing.Point(0, 490);
            this.mediaControllerFooter.Margin = new System.Windows.Forms.Padding(2);
            this.mediaControllerFooter.MaximumSize = new System.Drawing.Size(3000, 150);
            this.mediaControllerFooter.Name = "mediaControllerFooter";
            this.mediaControllerFooter.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.mediaControllerFooter.ShadowDecoration.Parent = this.mediaControllerFooter;
            this.mediaControllerFooter.Size = new System.Drawing.Size(1040, 150);
            this.mediaControllerFooter.TabIndex = 0;
            // 
            // mediaController
            // 
            this.mediaController.BackColor = System.Drawing.Color.White;
            this.mediaController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaController.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaController.ForeColor = System.Drawing.Color.Transparent;
            this.mediaController.Location = new System.Drawing.Point(0, 1);
            this.mediaController.Margin = new System.Windows.Forms.Padding(2);
            this.mediaController.MaximumSize = new System.Drawing.Size(3000, 150);
            this.mediaController.Name = "mediaController";
            this.mediaController.Size = new System.Drawing.Size(1040, 149);
            this.mediaController.TabIndex = 0;
            // 
            // controlHeader
            // 
            this.controlHeader.Controls.Add(this.nameContainer);
            this.controlHeader.Controls.Add(this.minimizeControlBox);
            this.controlHeader.Controls.Add(this.exitControlBox);
            this.controlHeader.Controls.Add(this.maximizeControlBox);
            this.controlHeader.CustomBorderColor = System.Drawing.Color.White;
            this.controlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlHeader.FillColor = System.Drawing.Color.White;
            this.controlHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.controlHeader.Location = new System.Drawing.Point(0, 0);
            this.controlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.controlHeader.Name = "controlHeader";
            this.controlHeader.ShadowDecoration.Parent = this.controlHeader;
            this.controlHeader.Size = new System.Drawing.Size(1040, 31);
            this.controlHeader.TabIndex = 2;
            // 
            // nameContainer
            // 
            this.nameContainer.CustomBorderColor = System.Drawing.Color.White;
            this.nameContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameContainer.FillColor = System.Drawing.Color.White;
            this.nameContainer.Location = new System.Drawing.Point(0, 0);
            this.nameContainer.Margin = new System.Windows.Forms.Padding(2);
            this.nameContainer.Name = "nameContainer";
            this.nameContainer.ShadowDecoration.Parent = this.nameContainer;
            this.nameContainer.Size = new System.Drawing.Size(158, 31);
            this.nameContainer.TabIndex = 3;
            // 
            // minimizeControlBox
            // 
            this.minimizeControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeControlBox.Animated = true;
            this.minimizeControlBox.BackColor = System.Drawing.Color.White;
            this.minimizeControlBox.BorderColor = System.Drawing.Color.Transparent;
            this.minimizeControlBox.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.minimizeControlBox.FillColor = System.Drawing.Color.Transparent;
            this.minimizeControlBox.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.minimizeControlBox.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.minimizeControlBox.HoverState.Parent = this.minimizeControlBox;
            this.minimizeControlBox.IconColor = System.Drawing.Color.LightGray;
            this.minimizeControlBox.Location = new System.Drawing.Point(905, 0);
            this.minimizeControlBox.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeControlBox.Name = "minimizeControlBox";
            this.minimizeControlBox.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.minimizeControlBox.ShadowDecoration.Parent = this.minimizeControlBox;
            this.minimizeControlBox.Size = new System.Drawing.Size(45, 31);
            this.minimizeControlBox.TabIndex = 2;
            // 
            // exitControlBox
            // 
            this.exitControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitControlBox.Animated = true;
            this.exitControlBox.BackColor = System.Drawing.Color.White;
            this.exitControlBox.BorderColor = System.Drawing.Color.Transparent;
            this.exitControlBox.FillColor = System.Drawing.Color.Transparent;
            this.exitControlBox.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.exitControlBox.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.exitControlBox.HoverState.Parent = this.exitControlBox;
            this.exitControlBox.IconColor = System.Drawing.Color.LightGray;
            this.exitControlBox.Location = new System.Drawing.Point(995, 0);
            this.exitControlBox.Margin = new System.Windows.Forms.Padding(2);
            this.exitControlBox.Name = "exitControlBox";
            this.exitControlBox.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.exitControlBox.ShadowDecoration.Parent = this.exitControlBox;
            this.exitControlBox.Size = new System.Drawing.Size(45, 31);
            this.exitControlBox.TabIndex = 0;
            // 
            // maximizeControlBox
            // 
            this.maximizeControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeControlBox.Animated = true;
            this.maximizeControlBox.BackColor = System.Drawing.Color.White;
            this.maximizeControlBox.BorderColor = System.Drawing.Color.Transparent;
            this.maximizeControlBox.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.maximizeControlBox.FillColor = System.Drawing.Color.Transparent;
            this.maximizeControlBox.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.maximizeControlBox.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(160)))), ((int)(((byte)(164)))));
            this.maximizeControlBox.HoverState.Parent = this.maximizeControlBox;
            this.maximizeControlBox.IconColor = System.Drawing.Color.LightGray;
            this.maximizeControlBox.Location = new System.Drawing.Point(950, 0);
            this.maximizeControlBox.Margin = new System.Windows.Forms.Padding(2);
            this.maximizeControlBox.Name = "maximizeControlBox";
            this.maximizeControlBox.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(160)))), ((int)(((byte)(164)))));
            this.maximizeControlBox.ShadowDecoration.Parent = this.maximizeControlBox;
            this.maximizeControlBox.Size = new System.Drawing.Size(45, 31);
            this.maximizeControlBox.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.musicLibraryTabPage);
            this.tabControl.Controls.Add(this.videoLibraryTabPage);
            this.tabControl.Controls.Add(this.playQueueTabPage);
            this.tabControl.Controls.Add(this.playlistsTabPage);
            this.tabControl.Controls.Add(this.settingsTabPage);
            this.tabControl.Controls.Add(this.onlineStoreTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl.ImageList = this.buttonImageList;
            this.tabControl.ItemSize = new System.Drawing.Size(210, 50);
            this.tabControl.Location = new System.Drawing.Point(0, 31);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1040, 459);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.LightGray;
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.White;
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.tabControl.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tabControl.TabButtonImageOffset = new System.Drawing.Point(8, 0);
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.LightGray;
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.tabControl.TabButtonSize = new System.Drawing.Size(210, 50);
            this.tabControl.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tabControl.TabButtonTextOffset = new System.Drawing.Point(13, 0);
            this.tabControl.TabIndex = 3;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.White;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.siticoneTabControl1_SelectedIndexChanged);
            // 
            // musicLibraryTabPage
            // 
            this.musicLibraryTabPage.BackColor = System.Drawing.Color.White;
            this.musicLibraryTabPage.Controls.Add(this.musicList);
            this.musicLibraryTabPage.Controls.Add(this.musicHeaderPanel);
            this.musicLibraryTabPage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.musicLibraryTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.musicLibraryTabPage.ImageIndex = 0;
            this.musicLibraryTabPage.Location = new System.Drawing.Point(214, 4);
            this.musicLibraryTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.musicLibraryTabPage.Name = "musicLibraryTabPage";
            this.musicLibraryTabPage.Size = new System.Drawing.Size(822, 451);
            this.musicLibraryTabPage.TabIndex = 0;
            this.musicLibraryTabPage.Text = "Music library";
            // 
            // musicList
            // 
            this.musicList.AutoSize = true;
            this.musicList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.musicList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musicList.Location = new System.Drawing.Point(0, 125);
            this.musicList.Margin = new System.Windows.Forms.Padding(2);
            this.musicList.Name = "musicList";
            this.musicList.Size = new System.Drawing.Size(822, 326);
            this.musicList.TabIndex = 2;
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
            this.musicHeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.musicHeaderPanel.Name = "musicHeaderPanel";
            this.musicHeaderPanel.ShadowDecoration.Parent = this.musicHeaderPanel;
            this.musicHeaderPanel.Size = new System.Drawing.Size(822, 125);
            this.musicHeaderPanel.TabIndex = 1;
            // 
            // shuffleAndPlayBtn
            // 
            this.shuffleAndPlayBtn.Animated = true;
            this.shuffleAndPlayBtn.BackColor = System.Drawing.Color.White;
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
            this.shuffleAndPlayBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.shuffleAndPlayBtn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.shuffleAndPlayBtn.ForeColor = System.Drawing.Color.White;
            this.shuffleAndPlayBtn.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.shuffleAndPlayBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.shuffleAndPlayBtn.HoverState.Parent = this.shuffleAndPlayBtn;
            this.shuffleAndPlayBtn.Image = global::MyMediaPlayer.Properties.Resources.white_suffle;
            this.shuffleAndPlayBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.shuffleAndPlayBtn.Location = new System.Drawing.Point(32, 63);
            this.shuffleAndPlayBtn.Margin = new System.Windows.Forms.Padding(2);
            this.shuffleAndPlayBtn.MinimumSize = new System.Drawing.Size(0, 37);
            this.shuffleAndPlayBtn.Name = "shuffleAndPlayBtn";
            this.shuffleAndPlayBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.shuffleAndPlayBtn.ShadowDecoration.Parent = this.shuffleAndPlayBtn;
            this.shuffleAndPlayBtn.Size = new System.Drawing.Size(138, 37);
            this.shuffleAndPlayBtn.TabIndex = 3;
            this.shuffleAndPlayBtn.Text = "Shuffle And Play";
            this.shuffleAndPlayBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.shuffleAndPlayBtn.Click += new System.EventHandler(this.shuffleAndPlayBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Animated = true;
            this.sortBtn.BackColor = System.Drawing.Color.White;
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
            this.sortBtn.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.sortBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.sortBtn.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.sortBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.sortBtn.HoverState.Parent = this.sortBtn;
            this.sortBtn.Image = global::MyMediaPlayer.Properties.Resources.down;
            this.sortBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sortBtn.ImageSize = new System.Drawing.Size(15, 15);
            this.sortBtn.Location = new System.Drawing.Point(190, 63);
            this.sortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sortBtn.MinimumSize = new System.Drawing.Size(0, 37);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.sortBtn.ShadowDecoration.Parent = this.sortBtn;
            this.sortBtn.Size = new System.Drawing.Size(98, 37);
            this.sortBtn.TabIndex = 2;
            this.sortBtn.Text = "Sort By: A-Z";
            this.sortBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // addFolder
            // 
            this.addFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFolder.Animated = true;
            this.addFolder.BackColor = System.Drawing.Color.White;
            this.addFolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
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
            this.addFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.addFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.addFolder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.addFolder.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.addFolder.HoverState.Parent = this.addFolder;
            this.addFolder.Image = global::MyMediaPlayer.Properties.Resources.add_folder;
            this.addFolder.Location = new System.Drawing.Point(690, 18);
            this.addFolder.Margin = new System.Windows.Forms.Padding(2);
            this.addFolder.Name = "addFolder";
            this.addFolder.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.addFolder.ShadowDecoration.Parent = this.addFolder;
            this.addFolder.Size = new System.Drawing.Size(105, 37);
            this.addFolder.TabIndex = 1;
            this.addFolder.Text = "Add Folder";
            this.addFolder.Click += new System.EventHandler(this.addFolder_Click);
            // 
            // musicLabel
            // 
            this.musicLabel.AutoSize = true;
            this.musicLabel.BackColor = System.Drawing.Color.White;
            this.musicLabel.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.musicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.musicLabel.Location = new System.Drawing.Point(23, -2);
            this.musicLabel.Name = "musicLabel";
            this.musicLabel.Size = new System.Drawing.Size(127, 54);
            this.musicLabel.TabIndex = 0;
            this.musicLabel.Text = "Music";
            // 
            // videoLibraryTabPage
            // 
            this.videoLibraryTabPage.BackColor = System.Drawing.Color.White;
            this.videoLibraryTabPage.ImageIndex = 4;
            this.videoLibraryTabPage.Location = new System.Drawing.Point(214, 4);
            this.videoLibraryTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.videoLibraryTabPage.Name = "videoLibraryTabPage";
            this.videoLibraryTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.videoLibraryTabPage.Size = new System.Drawing.Size(822, 451);
            this.videoLibraryTabPage.TabIndex = 1;
            this.videoLibraryTabPage.Text = "Video library";
            // 
            // playQueueTabPage
            // 
            this.playQueueTabPage.BackColor = System.Drawing.Color.White;
            this.playQueueTabPage.Controls.Add(this.PlayQMusicList);
            this.playQueueTabPage.Controls.Add(this.playQueueHeaderPanel);
            this.playQueueTabPage.ImageIndex = 2;
            this.playQueueTabPage.Location = new System.Drawing.Point(214, 4);
            this.playQueueTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.playQueueTabPage.Name = "playQueueTabPage";
            this.playQueueTabPage.Size = new System.Drawing.Size(822, 451);
            this.playQueueTabPage.TabIndex = 2;
            this.playQueueTabPage.Text = "Play queue";
            // 
            // PlayQMusicList
            // 
            this.PlayQMusicList.AutoSize = true;
            this.PlayQMusicList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlayQMusicList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayQMusicList.Location = new System.Drawing.Point(0, 125);
            this.PlayQMusicList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayQMusicList.Name = "PlayQMusicList";
            this.PlayQMusicList.Size = new System.Drawing.Size(822, 326);
            this.PlayQMusicList.TabIndex = 4;
            // 
            // playQueueHeaderPanel
            // 
            this.playQueueHeaderPanel.BorderColor = System.Drawing.Color.Black;
            this.playQueueHeaderPanel.Controls.Add(this.playQueueClearButton);
            this.playQueueHeaderPanel.Controls.Add(this.playQueueHeaderLabel);
            this.playQueueHeaderPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.playQueueHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.playQueueHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.playQueueHeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.playQueueHeaderPanel.Name = "playQueueHeaderPanel";
            this.playQueueHeaderPanel.ShadowDecoration.Parent = this.playQueueHeaderPanel;
            this.playQueueHeaderPanel.Size = new System.Drawing.Size(822, 125);
            this.playQueueHeaderPanel.TabIndex = 3;
            // 
            // playQueueClearButton
            // 
            this.playQueueClearButton.Animated = true;
            this.playQueueClearButton.BackColor = System.Drawing.Color.White;
            this.playQueueClearButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.playQueueClearButton.BorderRadius = 5;
            this.playQueueClearButton.BorderThickness = 1;
            this.playQueueClearButton.CheckedState.Parent = this.playQueueClearButton;
            this.playQueueClearButton.CustomImages.Parent = this.playQueueClearButton;
            this.playQueueClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.playQueueClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.playQueueClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.playQueueClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.playQueueClearButton.DisabledState.Parent = this.playQueueClearButton;
            this.playQueueClearButton.FillColor = System.Drawing.Color.Transparent;
            this.playQueueClearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.playQueueClearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.playQueueClearButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.playQueueClearButton.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.playQueueClearButton.HoverState.Parent = this.playQueueClearButton;
            this.playQueueClearButton.Image = global::MyMediaPlayer.Properties.Resources.icons8_trash_can_50;
            this.playQueueClearButton.Location = new System.Drawing.Point(32, 71);
            this.playQueueClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.playQueueClearButton.Name = "playQueueClearButton";
            this.playQueueClearButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.playQueueClearButton.ShadowDecoration.Parent = this.playQueueClearButton;
            this.playQueueClearButton.Size = new System.Drawing.Size(65, 32);
            this.playQueueClearButton.TabIndex = 2;
            this.playQueueClearButton.Text = "Clear";
            this.playQueueClearButton.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // playQueueHeaderLabel
            // 
            this.playQueueHeaderLabel.AutoSize = true;
            this.playQueueHeaderLabel.BackColor = System.Drawing.Color.White;
            this.playQueueHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.playQueueHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.playQueueHeaderLabel.Location = new System.Drawing.Point(23, -2);
            this.playQueueHeaderLabel.Name = "playQueueHeaderLabel";
            this.playQueueHeaderLabel.Size = new System.Drawing.Size(223, 54);
            this.playQueueHeaderLabel.TabIndex = 0;
            this.playQueueHeaderLabel.Text = "Play Queue";
            // 
            // playlistsTabPage
            // 
            this.playlistsTabPage.BackColor = System.Drawing.Color.White;
            this.playlistsTabPage.Controls.Add(this.playlistsPanel);
            this.playlistsTabPage.Controls.Add(this.playlistsHeaderPanel);
            this.playlistsTabPage.ImageIndex = 1;
            this.playlistsTabPage.Location = new System.Drawing.Point(214, 4);
            this.playlistsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.playlistsTabPage.Name = "playlistsTabPage";
            this.playlistsTabPage.Size = new System.Drawing.Size(822, 451);
            this.playlistsTabPage.TabIndex = 3;
            this.playlistsTabPage.Text = "Playlists";
            // 
            // playlistsPanel
            // 
            this.playlistsPanel.AutoScroll = true;
            this.playlistsPanel.BackColor = System.Drawing.Color.White;
            this.playlistsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playlistsPanel.Location = new System.Drawing.Point(0, 63);
            this.playlistsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.playlistsPanel.Name = "playlistsPanel";
            this.playlistsPanel.Size = new System.Drawing.Size(822, 388);
            this.playlistsPanel.TabIndex = 0;
            // 
            // playlistsHeaderPanel
            // 
            this.playlistsHeaderPanel.BackColor = System.Drawing.Color.White;
            this.playlistsHeaderPanel.BorderColor = System.Drawing.Color.Black;
            this.playlistsHeaderPanel.Controls.Add(this.playlistsHeaderLabel);
            this.playlistsHeaderPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.playlistsHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.playlistsHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.playlistsHeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.playlistsHeaderPanel.Name = "playlistsHeaderPanel";
            this.playlistsHeaderPanel.ShadowDecoration.Parent = this.playlistsHeaderPanel;
            this.playlistsHeaderPanel.Size = new System.Drawing.Size(822, 63);
            this.playlistsHeaderPanel.TabIndex = 4;
            // 
            // playlistsHeaderLabel
            // 
            this.playlistsHeaderLabel.AutoSize = true;
            this.playlistsHeaderLabel.BackColor = System.Drawing.Color.White;
            this.playlistsHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.playlistsHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.playlistsHeaderLabel.Location = new System.Drawing.Point(23, -2);
            this.playlistsHeaderLabel.Name = "playlistsHeaderLabel";
            this.playlistsHeaderLabel.Size = new System.Drawing.Size(162, 54);
            this.playlistsHeaderLabel.TabIndex = 0;
            this.playlistsHeaderLabel.Text = "Playlists";
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.BackColor = System.Drawing.Color.White;
            this.settingsTabPage.Controls.Add(this.musicFolderContainer);
            this.settingsTabPage.Controls.Add(this.settingHeaderPanel);
            this.settingsTabPage.ImageIndex = 3;
            this.settingsTabPage.Location = new System.Drawing.Point(214, 4);
            this.settingsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(34, 0, 50, 0);
            this.settingsTabPage.Size = new System.Drawing.Size(822, 451);
            this.settingsTabPage.TabIndex = 4;
            this.settingsTabPage.Text = "Settings";
            // 
            // musicFolderContainer
            // 
            this.musicFolderContainer.BorderColor = System.Drawing.Color.Black;
            this.musicFolderContainer.BorderRadius = 10;
            this.musicFolderContainer.BorderThickness = 1;
            this.musicFolderContainer.Controls.Add(this.musicFolderPanel);
            this.musicFolderContainer.Controls.Add(this.addMusicFolderSTBtn);
            this.musicFolderContainer.Controls.Add(this.musicLocationLb);
            this.musicFolderContainer.Controls.Add(this.settingsIconPictureBox);
            this.musicFolderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.musicFolderContainer.Location = new System.Drawing.Point(34, 123);
            this.musicFolderContainer.Name = "musicFolderContainer";
            this.musicFolderContainer.Padding = new System.Windows.Forms.Padding(10);
            this.musicFolderContainer.ShadowDecoration.Parent = this.musicFolderContainer;
            this.musicFolderContainer.Size = new System.Drawing.Size(738, 182);
            this.musicFolderContainer.TabIndex = 6;
            // 
            // musicFolderPanel
            // 
            this.musicFolderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.musicFolderPanel.Location = new System.Drawing.Point(10, 48);
            this.musicFolderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.musicFolderPanel.Name = "musicFolderPanel";
            this.musicFolderPanel.Size = new System.Drawing.Size(718, 124);
            this.musicFolderPanel.TabIndex = 9;
            // 
            // addMusicFolderSTBtn
            // 
            this.addMusicFolderSTBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addMusicFolderSTBtn.BackColor = System.Drawing.Color.White;
            this.addMusicFolderSTBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.addMusicFolderSTBtn.BorderRadius = 5;
            this.addMusicFolderSTBtn.BorderThickness = 1;
            this.addMusicFolderSTBtn.CheckedState.Parent = this.addMusicFolderSTBtn;
            this.addMusicFolderSTBtn.CustomImages.Parent = this.addMusicFolderSTBtn;
            this.addMusicFolderSTBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addMusicFolderSTBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addMusicFolderSTBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addMusicFolderSTBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addMusicFolderSTBtn.DisabledState.Parent = this.addMusicFolderSTBtn;
            this.addMusicFolderSTBtn.FillColor = System.Drawing.Color.Transparent;
            this.addMusicFolderSTBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addMusicFolderSTBtn.ForeColor = System.Drawing.Color.Black;
            this.addMusicFolderSTBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.addMusicFolderSTBtn.HoverState.Parent = this.addMusicFolderSTBtn;
            this.addMusicFolderSTBtn.Image = global::MyMediaPlayer.Properties.Resources.add_folder;
            this.addMusicFolderSTBtn.Location = new System.Drawing.Point(627, 12);
            this.addMusicFolderSTBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addMusicFolderSTBtn.Name = "addMusicFolderSTBtn";
            this.addMusicFolderSTBtn.ShadowDecoration.Parent = this.addMusicFolderSTBtn;
            this.addMusicFolderSTBtn.Size = new System.Drawing.Size(98, 32);
            this.addMusicFolderSTBtn.TabIndex = 8;
            this.addMusicFolderSTBtn.Text = "Add Folder";
            this.addMusicFolderSTBtn.Click += new System.EventHandler(this.addFolder_Click);
            // 
            // musicLocationLb
            // 
            this.musicLocationLb.AutoSize = true;
            this.musicLocationLb.Location = new System.Drawing.Point(37, 18);
            this.musicLocationLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.musicLocationLb.Name = "musicLocationLb";
            this.musicLocationLb.Size = new System.Drawing.Size(161, 19);
            this.musicLocationLb.TabIndex = 7;
            this.musicLocationLb.Text = "Music library locations";
            // 
            // settingsIconPictureBox
            // 
            this.settingsIconPictureBox.Image = global::MyMediaPlayer.Properties.Resources.folder;
            this.settingsIconPictureBox.ImageRotate = 0F;
            this.settingsIconPictureBox.Location = new System.Drawing.Point(11, 12);
            this.settingsIconPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.settingsIconPictureBox.Name = "settingsIconPictureBox";
            this.settingsIconPictureBox.ShadowDecoration.Parent = this.settingsIconPictureBox;
            this.settingsIconPictureBox.Size = new System.Drawing.Size(21, 24);
            this.settingsIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsIconPictureBox.TabIndex = 6;
            this.settingsIconPictureBox.TabStop = false;
            // 
            // settingHeaderPanel
            // 
            this.settingHeaderPanel.Controls.Add(this.settingLabel);
            this.settingHeaderPanel.Controls.Add(this.librariesLb);
            this.settingHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingHeaderPanel.Location = new System.Drawing.Point(34, 0);
            this.settingHeaderPanel.Name = "settingHeaderPanel";
            this.settingHeaderPanel.ShadowDecoration.Parent = this.settingHeaderPanel;
            this.settingHeaderPanel.Size = new System.Drawing.Size(738, 123);
            this.settingHeaderPanel.TabIndex = 4;
            // 
            // settingLabel
            // 
            this.settingLabel.AutoSize = true;
            this.settingLabel.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.settingLabel.Location = new System.Drawing.Point(-9, 0);
            this.settingLabel.Name = "settingLabel";
            this.settingLabel.Size = new System.Drawing.Size(167, 54);
            this.settingLabel.TabIndex = 1;
            this.settingLabel.Text = "Settings";
            // 
            // librariesLb
            // 
            this.librariesLb.AutoSize = true;
            this.librariesLb.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.librariesLb.Location = new System.Drawing.Point(6, 67);
            this.librariesLb.Name = "librariesLb";
            this.librariesLb.Size = new System.Drawing.Size(85, 28);
            this.librariesLb.TabIndex = 3;
            this.librariesLb.Text = "Libraries";
            // 
            // onlineStoreTabPage
            // 
            this.onlineStoreTabPage.BackColor = System.Drawing.Color.White;
            this.onlineStoreTabPage.Controls.Add(this.onlineStoreBodyPanel);
            this.onlineStoreTabPage.Controls.Add(this.onlineStoreHeaderPanel);
            this.onlineStoreTabPage.ImageIndex = 5;
            this.onlineStoreTabPage.Location = new System.Drawing.Point(214, 4);
            this.onlineStoreTabPage.Name = "onlineStoreTabPage";
            this.onlineStoreTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.onlineStoreTabPage.Size = new System.Drawing.Size(822, 451);
            this.onlineStoreTabPage.TabIndex = 5;
            this.onlineStoreTabPage.Text = "Online Store";
            // 
            // onlineStoreBodyPanel
            // 
            this.onlineStoreBodyPanel.Controls.Add(this.searchResultList);
            this.onlineStoreBodyPanel.Controls.Add(this.onlineStoreSearchBox);
            this.onlineStoreBodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onlineStoreBodyPanel.Location = new System.Drawing.Point(3, 66);
            this.onlineStoreBodyPanel.Name = "onlineStoreBodyPanel";
            this.onlineStoreBodyPanel.ShadowDecoration.Parent = this.onlineStoreBodyPanel;
            this.onlineStoreBodyPanel.Size = new System.Drawing.Size(816, 382);
            this.onlineStoreBodyPanel.TabIndex = 6;
            // 
            // searchResultList
            // 
            this.searchResultList.AutoScroll = true;
            this.searchResultList.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.searchResultList.Location = new System.Drawing.Point(108, 69);
            this.searchResultList.Margin = new System.Windows.Forms.Padding(4);
            this.searchResultList.Name = "searchResultList";
            this.searchResultList.Size = new System.Drawing.Size(400, 400);
            this.searchResultList.TabIndex = 1;
            // 
            // onlineStoreSearchBox
            // 
            this.onlineStoreSearchBox.Integration = null;
            this.onlineStoreSearchBox.Location = new System.Drawing.Point(69, 26);
            this.onlineStoreSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.onlineStoreSearchBox.Name = "onlineStoreSearchBox";
            this.onlineStoreSearchBox.Size = new System.Drawing.Size(500, 35);
            this.onlineStoreSearchBox.TabIndex = 0;
            // 
            // onlineStoreHeaderPanel
            // 
            this.onlineStoreHeaderPanel.BackColor = System.Drawing.Color.White;
            this.onlineStoreHeaderPanel.BorderColor = System.Drawing.Color.Black;
            this.onlineStoreHeaderPanel.Controls.Add(this.onlineStoreHeaderLabel);
            this.onlineStoreHeaderPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.onlineStoreHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.onlineStoreHeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.onlineStoreHeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.onlineStoreHeaderPanel.Name = "onlineStoreHeaderPanel";
            this.onlineStoreHeaderPanel.ShadowDecoration.Parent = this.onlineStoreHeaderPanel;
            this.onlineStoreHeaderPanel.Size = new System.Drawing.Size(816, 63);
            this.onlineStoreHeaderPanel.TabIndex = 5;
            // 
            // onlineStoreHeaderLabel
            // 
            this.onlineStoreHeaderLabel.AutoSize = true;
            this.onlineStoreHeaderLabel.BackColor = System.Drawing.Color.White;
            this.onlineStoreHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.onlineStoreHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.onlineStoreHeaderLabel.Location = new System.Drawing.Point(23, -2);
            this.onlineStoreHeaderLabel.Name = "onlineStoreHeaderLabel";
            this.onlineStoreHeaderLabel.Size = new System.Drawing.Size(243, 54);
            this.onlineStoreHeaderLabel.TabIndex = 0;
            this.onlineStoreHeaderLabel.Text = "Online Store";
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
            this.buttonImageList.Images.SetKeyName(5, "streaming.png");
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.controlHeader;
            // 
            // borderlessForm
            // 
            this.borderlessForm.AnimateWindow = true;
            this.borderlessForm.AnimationType = Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm.AnimateWindowType.AW_HOR_POSITIVE;
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.DockIndicatorColor = System.Drawing.SystemColors.Window;
            this.borderlessForm.HasFormShadow = false;
            this.borderlessForm.ShadowColor = System.Drawing.Color.Transparent;
            // 
            // sortByMenu
            // 
            this.sortByMenu.BackColor = System.Drawing.Color.White;
            this.sortByMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sortByMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sortByMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aZToolStripMenuItem,
            this.artistToolStripMenuItem,
            this.albumToolStripMenuItem,
            this.genreToolStripMenuItem});
            this.sortByMenu.Name = "sortByMenu";
            this.sortByMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.sortByMenu.RenderStyle.BorderColor = System.Drawing.Color.White;
            this.sortByMenu.RenderStyle.ColorTable = null;
            this.sortByMenu.RenderStyle.RoundedEdges = true;
            this.sortByMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.sortByMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.sortByMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.sortByMenu.RenderStyle.SeparatorColor = System.Drawing.Color.White;
            this.sortByMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.sortByMenu.Size = new System.Drawing.Size(111, 92);
            // 
            // aZToolStripMenuItem
            // 
            this.aZToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.aZToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.aZToolStripMenuItem.Name = "aZToolStripMenuItem";
            this.aZToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.aZToolStripMenuItem.Text = "A-Z";
            this.aZToolStripMenuItem.Click += new System.EventHandler(this.aZToolStripMenuItem_Click);
            // 
            // artistToolStripMenuItem
            // 
            this.artistToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.artistToolStripMenuItem.Name = "artistToolStripMenuItem";
            this.artistToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.artistToolStripMenuItem.Text = "Artist";
            this.artistToolStripMenuItem.Click += new System.EventHandler(this.artistsToolStripMenuItem_Click);
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.albumToolStripMenuItem.Text = "Album";
            this.albumToolStripMenuItem.Click += new System.EventHandler(this.albumToolStripMenuItem_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.genreToolStripMenuItem.Text = "Genre";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // tabControlBorder
            // 
            this.tabControlBorder.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.tabControlBorder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.tabControlBorder.Location = new System.Drawing.Point(0, 0);
            this.tabControlBorder.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlBorder.Name = "tabControlBorder";
            this.tabControlBorder.ShadowDecoration.Parent = this.tabControlBorder;
            this.tabControlBorder.Size = new System.Drawing.Size(0, 0);
            this.tabControlBorder.TabIndex = 4;
            // 
            // visualizeContainer
            // 
            this.visualizeContainer.Controls.Add(this.exitButton);
            this.visualizeContainer.Controls.Add(this.mediaVisualizer);
            this.visualizeContainer.Controls.Add(this.mediaLyrics);
            this.visualizeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualizeContainer.Location = new System.Drawing.Point(0, 31);
            this.visualizeContainer.Margin = new System.Windows.Forms.Padding(2);
            this.visualizeContainer.Name = "visualizeContainer";
            this.visualizeContainer.Size = new System.Drawing.Size(1040, 459);
            this.visualizeContainer.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.DisabledState.Parent = this.exitButton;
            this.exitButton.FillColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Image = global::MyMediaPlayer.Properties.Resources.close;
            this.exitButton.Location = new System.Drawing.Point(0, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(39, 37);
            this.exitButton.TabIndex = 2;
            this.exitButton.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // mediaVisualizer
            // 
            this.mediaVisualizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaVisualizer.Location = new System.Drawing.Point(0, 0);
            this.mediaVisualizer.Margin = new System.Windows.Forms.Padding(4);
            this.mediaVisualizer.Name = "mediaVisualizer";
            this.mediaVisualizer.Size = new System.Drawing.Size(640, 459);
            this.mediaVisualizer.TabIndex = 1;
            // 
            // mediaLyrics
            // 
            this.mediaLyrics.AutoScroll = true;
            this.mediaLyrics.BackColor = System.Drawing.Color.White;
            this.mediaLyrics.Dock = System.Windows.Forms.DockStyle.Right;
            this.mediaLyrics.Location = new System.Drawing.Point(640, 0);
            this.mediaLyrics.Margin = new System.Windows.Forms.Padding(4);
            this.mediaLyrics.MaximumSize = new System.Drawing.Size(300, 270);
            this.mediaLyrics.MinimumSize = new System.Drawing.Size(400, 353);
            this.mediaLyrics.Name = "mediaLyrics";
            this.mediaLyrics.Size = new System.Drawing.Size(400, 353);
            this.mediaLyrics.TabIndex = 3;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.visualizeContainer);
            this.Controls.Add(this.tabControlBorder);
            this.Controls.Add(this.controlHeader);
            this.Controls.Add(this.mediaControllerFooter);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 528);
            this.Name = "form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Media Player";
            this.ResizeBegin += new System.EventHandler(this.form_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.form_ResizeEnd);
            this.Resize += new System.EventHandler(this.form_Resize);
            this.mediaControllerFooter.ResumeLayout(false);
            this.controlHeader.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.musicLibraryTabPage.ResumeLayout(false);
            this.musicLibraryTabPage.PerformLayout();
            this.musicHeaderPanel.ResumeLayout(false);
            this.musicHeaderPanel.PerformLayout();
            this.playQueueTabPage.ResumeLayout(false);
            this.playQueueTabPage.PerformLayout();
            this.playQueueHeaderPanel.ResumeLayout(false);
            this.playQueueHeaderPanel.PerformLayout();
            this.playlistsTabPage.ResumeLayout(false);
            this.playlistsHeaderPanel.ResumeLayout(false);
            this.playlistsHeaderPanel.PerformLayout();
            this.settingsTabPage.ResumeLayout(false);
            this.musicFolderContainer.ResumeLayout(false);
            this.musicFolderContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsIconPictureBox)).EndInit();
            this.settingHeaderPanel.ResumeLayout(false);
            this.settingHeaderPanel.PerformLayout();
            this.onlineStoreTabPage.ResumeLayout(false);
            this.onlineStoreBodyPanel.ResumeLayout(false);
            this.onlineStoreHeaderPanel.ResumeLayout(false);
            this.onlineStoreHeaderPanel.PerformLayout();
            this.sortByMenu.ResumeLayout(false);
            this.visualizeContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel mediaControllerFooter;
        private Siticone.Desktop.UI.WinForms.SiticonePanel controlHeader;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox minimizeControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox exitControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox maximizeControlBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTabControl tabControl;
        private System.Windows.Forms.TabPage musicLibraryTabPage;
        private System.Windows.Forms.TabPage videoLibraryTabPage;
        private System.Windows.Forms.TabPage playQueueTabPage;
        private System.Windows.Forms.TabPage playlistsTabPage;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.ImageList buttonImageList;
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
        private MediaController mediaController;
        private Siticone.Desktop.UI.WinForms.SiticonePanel tabControlBorder;
        private System.Windows.Forms.Label settingLabel;
        private System.Windows.Forms.Label librariesLb;
        private Siticone.Desktop.UI.WinForms.SiticonePanel settingHeaderPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel musicFolderContainer;
        private MusicList musicList;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox settingsIconPictureBox;
        private System.Windows.Forms.Label musicLocationLb;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addMusicFolderSTBtn;
        private System.Windows.Forms.FlowLayoutPanel playlistsPanel;
        private System.Windows.Forms.Panel visualizeContainer;
        private Siticone.Desktop.UI.WinForms.SiticoneButton exitButton;
        private MediaVisualizer mediaVisualizer;
        private MusicList PlayQMusicList;
        private Siticone.Desktop.UI.WinForms.SiticonePanel playQueueHeaderPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton playQueueClearButton;
        private System.Windows.Forms.Label playQueueHeaderLabel;
        private System.Windows.Forms.Panel musicFolderPanel;
        private MediaLyrics mediaLyrics;
        private Siticone.Desktop.UI.WinForms.SiticonePanel playlistsHeaderPanel;
        private System.Windows.Forms.Label playlistsHeaderLabel;
        private System.Windows.Forms.TabPage onlineStoreTabPage;
        private Siticone.Desktop.UI.WinForms.SiticonePanel onlineStoreHeaderPanel;
        private System.Windows.Forms.Label onlineStoreHeaderLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel onlineStoreBodyPanel;
        private SearchBox onlineStoreSearchBox;
        private SearchResultList searchResultList;
    }
}

