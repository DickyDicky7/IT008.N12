namespace MyMediaPlayer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mediaControllerFooter = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.mediaController = new MyMediaPlayer.MediaController();
            this.controlHeader = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.nameContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.minimizeControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.exitControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.maximizeControlBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.tabControl = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.musicLibraryTabPage = new System.Windows.Forms.TabPage();
            this.musicList = new MyMediaPlayer.TrackItemList();
            this.musicHeaderPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.shuffleAndPlayBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.sortBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.addMusicFolderBtn1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.musicLabel = new System.Windows.Forms.Label();
            this.videoLibraryTabPage = new System.Windows.Forms.TabPage();
            this.videoItemList = new MyMediaPlayer.VideoItemList();
            this.videoHeaderPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.videoHeaderLabel = new System.Windows.Forms.Label();
            this.playQueueTabPage = new System.Windows.Forms.TabPage();
            this.PlayQMusicList = new MyMediaPlayer.TrackItemList();
            this.playQueueHeaderPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.playQueueClearButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.playQueueHeaderLabel = new System.Windows.Forms.Label();
            this.playlistsTabPage = new System.Windows.Forms.TabPage();
            this.playlistItemList = new MyMediaPlayer.PlaylistItemList();
            this.playlistsHeaderPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.playlistsHeaderLabel = new System.Windows.Forms.Label();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.videosFolderContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.videosFolderPanel = new System.Windows.Forms.Panel();
            this.addVideosFolderBtn2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.videosLocationLb = new System.Windows.Forms.Label();
            this.settingsIconPictureBox2 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.musicFolderContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.musicFolderPanel = new System.Windows.Forms.Panel();
            this.addMusicFolderBtn2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.musicLocationLb = new System.Windows.Forms.Label();
            this.settingsIconPictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.settingHeaderPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.settingLabel = new System.Windows.Forms.Label();
            this.librariesLb = new System.Windows.Forms.Label();
            this.onlineStoreTabPage = new System.Windows.Forms.TabPage();
            this.onlineStoreBodyPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.integrationSearchResultList = new MyMediaPlayer.ZingMP3IntegrationSearchResultList();
            this.onlineStoreIntegrationSearchBox = new MyMediaPlayer.IntegrationSearchBox();
            this.onlineStoreHeaderPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.onlineStoreHeaderLabel = new System.Windows.Forms.Label();
            this.buttonImageList = new System.Windows.Forms.ImageList(this.components);
            this.dragControl = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.borderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.sortByMenu = new Siticone.Desktop.UI.WinForms.SiticoneContextMenuStrip();
            this.aZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlBorder = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.visualizeContainer = new System.Windows.Forms.Panel();
            this.exitButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.trackVisualizer = new MyMediaPlayer.TrackVisualizer();
            this.trackLyrics = new MyMediaPlayer.TrackLyrics();
            this.mediaControllerFooter.SuspendLayout();
            this.controlHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.musicLibraryTabPage.SuspendLayout();
            this.musicHeaderPanel.SuspendLayout();
            this.videoLibraryTabPage.SuspendLayout();
            this.videoHeaderPanel.SuspendLayout();
            this.playQueueTabPage.SuspendLayout();
            this.playQueueHeaderPanel.SuspendLayout();
            this.playlistsTabPage.SuspendLayout();
            this.playlistsHeaderPanel.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.videosFolderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsIconPictureBox2)).BeginInit();
            this.musicFolderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsIconPictureBox1)).BeginInit();
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
            this.minimizeControlBox.IconColor = System.Drawing.Color.LightGray;
            this.minimizeControlBox.Location = new System.Drawing.Point(905, 0);
            this.minimizeControlBox.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeControlBox.Name = "minimizeControlBox";
            this.minimizeControlBox.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
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
            this.exitControlBox.IconColor = System.Drawing.Color.LightGray;
            this.exitControlBox.Location = new System.Drawing.Point(995, 0);
            this.exitControlBox.Margin = new System.Windows.Forms.Padding(2);
            this.exitControlBox.Name = "exitControlBox";
            this.exitControlBox.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
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
            this.maximizeControlBox.IconColor = System.Drawing.Color.LightGray;
            this.maximizeControlBox.Location = new System.Drawing.Point(950, 0);
            this.maximizeControlBox.Margin = new System.Windows.Forms.Padding(2);
            this.maximizeControlBox.Name = "maximizeControlBox";
            this.maximizeControlBox.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(160)))), ((int)(((byte)(164)))));
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
            this.tabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
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
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.White;
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.tabControl.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tabControl.TabButtonImageOffset = new System.Drawing.Point(8, 0);
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.LightGray;
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.tabControl.TabButtonSize = new System.Drawing.Size(210, 50);
            this.tabControl.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tabControl.TabButtonTextOffset = new System.Drawing.Point(13, 0);
            this.tabControl.TabIndex = 3;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.White;
            // 
            // musicLibraryTabPage
            // 
            this.musicLibraryTabPage.BackColor = System.Drawing.Color.White;
            this.musicLibraryTabPage.Controls.Add(this.musicList);
            this.musicLibraryTabPage.Controls.Add(this.musicHeaderPanel);
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
            this.musicHeaderPanel.Controls.Add(this.addMusicFolderBtn1);
            this.musicHeaderPanel.Controls.Add(this.musicLabel);
            this.musicHeaderPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.musicHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.musicHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.musicHeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.musicHeaderPanel.Name = "musicHeaderPanel";
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
            this.shuffleAndPlayBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.shuffleAndPlayBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.shuffleAndPlayBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.shuffleAndPlayBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.shuffleAndPlayBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.shuffleAndPlayBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.shuffleAndPlayBtn.ForeColor = System.Drawing.Color.White;
            this.shuffleAndPlayBtn.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.shuffleAndPlayBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.shuffleAndPlayBtn.Image = ((System.Drawing.Image)(resources.GetObject("shuffleAndPlayBtn.Image")));
            this.shuffleAndPlayBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.shuffleAndPlayBtn.Location = new System.Drawing.Point(32, 63);
            this.shuffleAndPlayBtn.Margin = new System.Windows.Forms.Padding(2);
            this.shuffleAndPlayBtn.MinimumSize = new System.Drawing.Size(0, 37);
            this.shuffleAndPlayBtn.Name = "shuffleAndPlayBtn";
            this.shuffleAndPlayBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.shuffleAndPlayBtn.Size = new System.Drawing.Size(138, 37);
            this.shuffleAndPlayBtn.TabIndex = 3;
            this.shuffleAndPlayBtn.Text = "Shuffle And Play";
            this.shuffleAndPlayBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.shuffleAndPlayBtn.Click += new System.EventHandler(this.ShuffleAndPlayBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Animated = true;
            this.sortBtn.BackColor = System.Drawing.Color.White;
            this.sortBtn.BorderColor = System.Drawing.Color.Transparent;
            this.sortBtn.BorderRadius = 5;
            this.sortBtn.BorderThickness = 1;
            this.sortBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sortBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sortBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sortBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sortBtn.FillColor = System.Drawing.Color.Transparent;
            this.sortBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.sortBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.sortBtn.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.sortBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.sortBtn.Image = global::MyMediaPlayer.Properties.Resources.down;
            this.sortBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sortBtn.ImageSize = new System.Drawing.Size(15, 15);
            this.sortBtn.Location = new System.Drawing.Point(190, 63);
            this.sortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sortBtn.MinimumSize = new System.Drawing.Size(0, 37);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.sortBtn.Size = new System.Drawing.Size(101, 37);
            this.sortBtn.TabIndex = 2;
            this.sortBtn.Text = "Sort By: A-Z";
            this.sortBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // addMusicFolderBtn1
            // 
            this.addMusicFolderBtn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addMusicFolderBtn1.Animated = true;
            this.addMusicFolderBtn1.BackColor = System.Drawing.Color.White;
            this.addMusicFolderBtn1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.addMusicFolderBtn1.BorderRadius = 5;
            this.addMusicFolderBtn1.BorderThickness = 1;
            this.addMusicFolderBtn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addMusicFolderBtn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addMusicFolderBtn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addMusicFolderBtn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addMusicFolderBtn1.FillColor = System.Drawing.Color.Transparent;
            this.addMusicFolderBtn1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.addMusicFolderBtn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.addMusicFolderBtn1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.addMusicFolderBtn1.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.addMusicFolderBtn1.Image = ((System.Drawing.Image)(resources.GetObject("addMusicFolderBtn1.Image")));
            this.addMusicFolderBtn1.Location = new System.Drawing.Point(690, 18);
            this.addMusicFolderBtn1.Margin = new System.Windows.Forms.Padding(2);
            this.addMusicFolderBtn1.Name = "addMusicFolderBtn1";
            this.addMusicFolderBtn1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.addMusicFolderBtn1.Size = new System.Drawing.Size(105, 37);
            this.addMusicFolderBtn1.TabIndex = 1;
            this.addMusicFolderBtn1.Text = "Add Folder";
            this.addMusicFolderBtn1.Click += new System.EventHandler(this.AddMusicFolder_Click);
            // 
            // musicLabel
            // 
            this.musicLabel.AutoSize = true;
            this.musicLabel.BackColor = System.Drawing.Color.White;
            this.musicLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 30F);
            this.musicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.musicLabel.Location = new System.Drawing.Point(23, -2);
            this.musicLabel.Name = "musicLabel";
            this.musicLabel.Size = new System.Drawing.Size(129, 54);
            this.musicLabel.TabIndex = 0;
            this.musicLabel.Text = "Music";
            // 
            // videoLibraryTabPage
            // 
            this.videoLibraryTabPage.BackColor = System.Drawing.Color.White;
            this.videoLibraryTabPage.Controls.Add(this.videoItemList);
            this.videoLibraryTabPage.Controls.Add(this.videoHeaderPanel);
            this.videoLibraryTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.videoLibraryTabPage.ImageIndex = 4;
            this.videoLibraryTabPage.Location = new System.Drawing.Point(214, 4);
            this.videoLibraryTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.videoLibraryTabPage.Name = "videoLibraryTabPage";
            this.videoLibraryTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.videoLibraryTabPage.Size = new System.Drawing.Size(822, 451);
            this.videoLibraryTabPage.TabIndex = 1;
            this.videoLibraryTabPage.Text = "Video library";
            // 
            // videoItemList
            // 
            this.videoItemList.AutoScroll = true;
            this.videoItemList.BackColor = System.Drawing.Color.White;
            this.videoItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoItemList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoItemList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.videoItemList.Location = new System.Drawing.Point(2, 65);
            this.videoItemList.Name = "videoItemList";
            this.videoItemList.Size = new System.Drawing.Size(818, 384);
            this.videoItemList.TabIndex = 7;
            // 
            // videoHeaderPanel
            // 
            this.videoHeaderPanel.BackColor = System.Drawing.Color.White;
            this.videoHeaderPanel.BorderColor = System.Drawing.Color.Black;
            this.videoHeaderPanel.Controls.Add(this.videoHeaderLabel);
            this.videoHeaderPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.videoHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.videoHeaderPanel.Location = new System.Drawing.Point(2, 2);
            this.videoHeaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.videoHeaderPanel.Name = "videoHeaderPanel";
            this.videoHeaderPanel.Size = new System.Drawing.Size(818, 63);
            this.videoHeaderPanel.TabIndex = 6;
            // 
            // videoHeaderLabel
            // 
            this.videoHeaderLabel.AutoSize = true;
            this.videoHeaderLabel.BackColor = System.Drawing.Color.White;
            this.videoHeaderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 30F);
            this.videoHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.videoHeaderLabel.Location = new System.Drawing.Point(23, -2);
            this.videoHeaderLabel.Name = "videoHeaderLabel";
            this.videoHeaderLabel.Size = new System.Drawing.Size(128, 54);
            this.videoHeaderLabel.TabIndex = 0;
            this.videoHeaderLabel.Text = "Video";
            // 
            // playQueueTabPage
            // 
            this.playQueueTabPage.BackColor = System.Drawing.Color.White;
            this.playQueueTabPage.Controls.Add(this.PlayQMusicList);
            this.playQueueTabPage.Controls.Add(this.playQueueHeaderPanel);
            this.playQueueTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
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
            this.playQueueClearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.playQueueClearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.playQueueClearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.playQueueClearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.playQueueClearButton.FillColor = System.Drawing.Color.Transparent;
            this.playQueueClearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.playQueueClearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.playQueueClearButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.playQueueClearButton.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.playQueueClearButton.Image = global::MyMediaPlayer.Properties.Resources.trash_can;
            this.playQueueClearButton.ImageSize = new System.Drawing.Size(25, 25);
            this.playQueueClearButton.Location = new System.Drawing.Point(32, 71);
            this.playQueueClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.playQueueClearButton.Name = "playQueueClearButton";
            this.playQueueClearButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.playQueueClearButton.Size = new System.Drawing.Size(70, 35);
            this.playQueueClearButton.TabIndex = 2;
            this.playQueueClearButton.Text = "Clear";
            this.playQueueClearButton.Click += new System.EventHandler(this.PlayQueueClearButton_Click);
            // 
            // playQueueHeaderLabel
            // 
            this.playQueueHeaderLabel.AutoSize = true;
            this.playQueueHeaderLabel.BackColor = System.Drawing.Color.White;
            this.playQueueHeaderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 30F);
            this.playQueueHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.playQueueHeaderLabel.Location = new System.Drawing.Point(23, -2);
            this.playQueueHeaderLabel.Name = "playQueueHeaderLabel";
            this.playQueueHeaderLabel.Size = new System.Drawing.Size(226, 54);
            this.playQueueHeaderLabel.TabIndex = 0;
            this.playQueueHeaderLabel.Text = "Play Queue";
            // 
            // playlistsTabPage
            // 
            this.playlistsTabPage.BackColor = System.Drawing.Color.White;
            this.playlistsTabPage.Controls.Add(this.playlistItemList);
            this.playlistsTabPage.Controls.Add(this.playlistsHeaderPanel);
            this.playlistsTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.playlistsTabPage.ImageIndex = 1;
            this.playlistsTabPage.Location = new System.Drawing.Point(214, 4);
            this.playlistsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.playlistsTabPage.Name = "playlistsTabPage";
            this.playlistsTabPage.Size = new System.Drawing.Size(822, 451);
            this.playlistsTabPage.TabIndex = 3;
            this.playlistsTabPage.Text = "Playlists";
            // 
            // playlistItemList
            // 
            this.playlistItemList.AutoScroll = true;
            this.playlistItemList.BackColor = System.Drawing.Color.White;
            this.playlistItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playlistItemList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.playlistItemList.Location = new System.Drawing.Point(0, 63);
            this.playlistItemList.Margin = new System.Windows.Forms.Padding(4);
            this.playlistItemList.Name = "playlistItemList";
            this.playlistItemList.Size = new System.Drawing.Size(822, 388);
            this.playlistItemList.TabIndex = 5;
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
            this.playlistsHeaderPanel.Size = new System.Drawing.Size(822, 63);
            this.playlistsHeaderPanel.TabIndex = 4;
            // 
            // playlistsHeaderLabel
            // 
            this.playlistsHeaderLabel.AutoSize = true;
            this.playlistsHeaderLabel.BackColor = System.Drawing.Color.White;
            this.playlistsHeaderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 30F);
            this.playlistsHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.playlistsHeaderLabel.Location = new System.Drawing.Point(23, -2);
            this.playlistsHeaderLabel.Name = "playlistsHeaderLabel";
            this.playlistsHeaderLabel.Size = new System.Drawing.Size(165, 54);
            this.playlistsHeaderLabel.TabIndex = 0;
            this.playlistsHeaderLabel.Text = "Playlists";
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.AutoScroll = true;
            this.settingsTabPage.BackColor = System.Drawing.Color.White;
            this.settingsTabPage.Controls.Add(this.videosFolderContainer);
            this.settingsTabPage.Controls.Add(this.musicFolderContainer);
            this.settingsTabPage.Controls.Add(this.settingHeaderPanel);
            this.settingsTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.settingsTabPage.ImageIndex = 3;
            this.settingsTabPage.Location = new System.Drawing.Point(214, 4);
            this.settingsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(34, 0, 50, 0);
            this.settingsTabPage.Size = new System.Drawing.Size(822, 451);
            this.settingsTabPage.TabIndex = 4;
            this.settingsTabPage.Text = "Settings";
            // 
            // videosFolderContainer
            // 
            this.videosFolderContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videosFolderContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.videosFolderContainer.BorderRadius = 10;
            this.videosFolderContainer.BorderThickness = 1;
            this.videosFolderContainer.Controls.Add(this.videosFolderPanel);
            this.videosFolderContainer.Controls.Add(this.addVideosFolderBtn2);
            this.videosFolderContainer.Controls.Add(this.videosLocationLb);
            this.videosFolderContainer.Controls.Add(this.settingsIconPictureBox2);
            this.videosFolderContainer.Location = new System.Drawing.Point(35, 320);
            this.videosFolderContainer.Name = "videosFolderContainer";
            this.videosFolderContainer.Padding = new System.Windows.Forms.Padding(10);
            this.videosFolderContainer.Size = new System.Drawing.Size(618, 182);
            this.videosFolderContainer.TabIndex = 7;
            // 
            // videosFolderPanel
            // 
            this.videosFolderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.videosFolderPanel.Location = new System.Drawing.Point(10, 48);
            this.videosFolderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.videosFolderPanel.Name = "videosFolderPanel";
            this.videosFolderPanel.Size = new System.Drawing.Size(598, 124);
            this.videosFolderPanel.TabIndex = 9;
            // 
            // addVideosFolderBtn2
            // 
            this.addVideosFolderBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addVideosFolderBtn2.Animated = true;
            this.addVideosFolderBtn2.BackColor = System.Drawing.Color.White;
            this.addVideosFolderBtn2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.addVideosFolderBtn2.BorderRadius = 5;
            this.addVideosFolderBtn2.BorderThickness = 1;
            this.addVideosFolderBtn2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addVideosFolderBtn2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addVideosFolderBtn2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addVideosFolderBtn2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addVideosFolderBtn2.FillColor = System.Drawing.Color.White;
            this.addVideosFolderBtn2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.addVideosFolderBtn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.addVideosFolderBtn2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.addVideosFolderBtn2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.addVideosFolderBtn2.HoverState.FillColor = System.Drawing.Color.White;
            this.addVideosFolderBtn2.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.addVideosFolderBtn2.Image = ((System.Drawing.Image)(resources.GetObject("addVideosFolderBtn2.Image")));
            this.addVideosFolderBtn2.Location = new System.Drawing.Point(506, 12);
            this.addVideosFolderBtn2.Margin = new System.Windows.Forms.Padding(2);
            this.addVideosFolderBtn2.Name = "addVideosFolderBtn2";
            this.addVideosFolderBtn2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.addVideosFolderBtn2.Size = new System.Drawing.Size(98, 32);
            this.addVideosFolderBtn2.TabIndex = 8;
            this.addVideosFolderBtn2.Text = "Add Folder";
            this.addVideosFolderBtn2.Click += new System.EventHandler(this.AddVideosFolder_Click);
            // 
            // videosLocationLb
            // 
            this.videosLocationLb.AutoSize = true;
            this.videosLocationLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.videosLocationLb.Location = new System.Drawing.Point(37, 18);
            this.videosLocationLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.videosLocationLb.Name = "videosLocationLb";
            this.videosLocationLb.Size = new System.Drawing.Size(163, 19);
            this.videosLocationLb.TabIndex = 7;
            this.videosLocationLb.Text = "Videos Library Locations";
            // 
            // settingsIconPictureBox2
            // 
            this.settingsIconPictureBox2.Image = global::MyMediaPlayer.Properties.Resources.folder;
            this.settingsIconPictureBox2.ImageRotate = 0F;
            this.settingsIconPictureBox2.Location = new System.Drawing.Point(11, 12);
            this.settingsIconPictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.settingsIconPictureBox2.Name = "settingsIconPictureBox2";
            this.settingsIconPictureBox2.Size = new System.Drawing.Size(24, 26);
            this.settingsIconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsIconPictureBox2.TabIndex = 6;
            this.settingsIconPictureBox2.TabStop = false;
            // 
            // musicFolderContainer
            // 
            this.musicFolderContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicFolderContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.musicFolderContainer.BorderRadius = 10;
            this.musicFolderContainer.BorderThickness = 1;
            this.musicFolderContainer.Controls.Add(this.musicFolderPanel);
            this.musicFolderContainer.Controls.Add(this.addMusicFolderBtn2);
            this.musicFolderContainer.Controls.Add(this.musicLocationLb);
            this.musicFolderContainer.Controls.Add(this.settingsIconPictureBox1);
            this.musicFolderContainer.Location = new System.Drawing.Point(34, 123);
            this.musicFolderContainer.Name = "musicFolderContainer";
            this.musicFolderContainer.Padding = new System.Windows.Forms.Padding(10);
            this.musicFolderContainer.Size = new System.Drawing.Size(618, 182);
            this.musicFolderContainer.TabIndex = 6;
            // 
            // musicFolderPanel
            // 
            this.musicFolderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.musicFolderPanel.Location = new System.Drawing.Point(10, 48);
            this.musicFolderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.musicFolderPanel.Name = "musicFolderPanel";
            this.musicFolderPanel.Size = new System.Drawing.Size(598, 124);
            this.musicFolderPanel.TabIndex = 9;
            // 
            // addMusicFolderBtn2
            // 
            this.addMusicFolderBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addMusicFolderBtn2.Animated = true;
            this.addMusicFolderBtn2.BackColor = System.Drawing.Color.White;
            this.addMusicFolderBtn2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.addMusicFolderBtn2.BorderRadius = 5;
            this.addMusicFolderBtn2.BorderThickness = 1;
            this.addMusicFolderBtn2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addMusicFolderBtn2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addMusicFolderBtn2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addMusicFolderBtn2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addMusicFolderBtn2.FillColor = System.Drawing.Color.White;
            this.addMusicFolderBtn2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.addMusicFolderBtn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.addMusicFolderBtn2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.addMusicFolderBtn2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.addMusicFolderBtn2.HoverState.FillColor = System.Drawing.Color.White;
            this.addMusicFolderBtn2.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.addMusicFolderBtn2.Image = ((System.Drawing.Image)(resources.GetObject("addMusicFolderBtn2.Image")));
            this.addMusicFolderBtn2.Location = new System.Drawing.Point(506, 12);
            this.addMusicFolderBtn2.Margin = new System.Windows.Forms.Padding(2);
            this.addMusicFolderBtn2.Name = "addMusicFolderBtn2";
            this.addMusicFolderBtn2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.addMusicFolderBtn2.Size = new System.Drawing.Size(98, 32);
            this.addMusicFolderBtn2.TabIndex = 8;
            this.addMusicFolderBtn2.Text = "Add Folder";
            this.addMusicFolderBtn2.Click += new System.EventHandler(this.AddMusicFolder_Click);
            // 
            // musicLocationLb
            // 
            this.musicLocationLb.AutoSize = true;
            this.musicLocationLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.musicLocationLb.Location = new System.Drawing.Point(37, 18);
            this.musicLocationLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.musicLocationLb.Name = "musicLocationLb";
            this.musicLocationLb.Size = new System.Drawing.Size(159, 19);
            this.musicLocationLb.TabIndex = 7;
            this.musicLocationLb.Text = "Music Library Locations";
            // 
            // settingsIconPictureBox1
            // 
            this.settingsIconPictureBox1.Image = global::MyMediaPlayer.Properties.Resources.folder;
            this.settingsIconPictureBox1.ImageRotate = 0F;
            this.settingsIconPictureBox1.Location = new System.Drawing.Point(11, 12);
            this.settingsIconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.settingsIconPictureBox1.Name = "settingsIconPictureBox1";
            this.settingsIconPictureBox1.Size = new System.Drawing.Size(24, 26);
            this.settingsIconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsIconPictureBox1.TabIndex = 6;
            this.settingsIconPictureBox1.TabStop = false;
            // 
            // settingHeaderPanel
            // 
            this.settingHeaderPanel.Controls.Add(this.settingLabel);
            this.settingHeaderPanel.Controls.Add(this.librariesLb);
            this.settingHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingHeaderPanel.Location = new System.Drawing.Point(34, 0);
            this.settingHeaderPanel.Name = "settingHeaderPanel";
            this.settingHeaderPanel.Size = new System.Drawing.Size(721, 123);
            this.settingHeaderPanel.TabIndex = 4;
            // 
            // settingLabel
            // 
            this.settingLabel.AutoSize = true;
            this.settingLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 30F);
            this.settingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.settingLabel.Location = new System.Drawing.Point(-9, 0);
            this.settingLabel.Name = "settingLabel";
            this.settingLabel.Size = new System.Drawing.Size(168, 54);
            this.settingLabel.TabIndex = 1;
            this.settingLabel.Text = "Settings";
            // 
            // librariesLb
            // 
            this.librariesLb.AutoSize = true;
            this.librariesLb.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.librariesLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.librariesLb.Location = new System.Drawing.Point(6, 67);
            this.librariesLb.Name = "librariesLb";
            this.librariesLb.Size = new System.Drawing.Size(88, 28);
            this.librariesLb.TabIndex = 3;
            this.librariesLb.Text = "Libraries";
            // 
            // onlineStoreTabPage
            // 
            this.onlineStoreTabPage.BackColor = System.Drawing.Color.White;
            this.onlineStoreTabPage.Controls.Add(this.onlineStoreBodyPanel);
            this.onlineStoreTabPage.Controls.Add(this.onlineStoreHeaderPanel);
            this.onlineStoreTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
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
            this.onlineStoreBodyPanel.Controls.Add(this.integrationSearchResultList);
            this.onlineStoreBodyPanel.Controls.Add(this.onlineStoreIntegrationSearchBox);
            this.onlineStoreBodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onlineStoreBodyPanel.Location = new System.Drawing.Point(3, 66);
            this.onlineStoreBodyPanel.Name = "onlineStoreBodyPanel";
            this.onlineStoreBodyPanel.Size = new System.Drawing.Size(816, 382);
            this.onlineStoreBodyPanel.TabIndex = 6;
            // 
            // integrationSearchResultList
            // 
            this.integrationSearchResultList.AutoScroll = true;
            this.integrationSearchResultList.BackColor = System.Drawing.Color.White;
            this.integrationSearchResultList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.integrationSearchResultList.Location = new System.Drawing.Point(0, 92);
            this.integrationSearchResultList.Margin = new System.Windows.Forms.Padding(4);
            this.integrationSearchResultList.Name = "integrationSearchResultList";
            this.integrationSearchResultList.NumberOfItems = null;
            this.integrationSearchResultList.Size = new System.Drawing.Size(816, 290);
            this.integrationSearchResultList.TabIndex = 1;
            // 
            // onlineStoreIntegrationSearchBox
            // 
            this.onlineStoreIntegrationSearchBox.BackColor = System.Drawing.Color.White;
            this.onlineStoreIntegrationSearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.onlineStoreIntegrationSearchBox.Integration = null;
            this.onlineStoreIntegrationSearchBox.IntegrationSearchResultList = null;
            this.onlineStoreIntegrationSearchBox.Location = new System.Drawing.Point(0, 0);
            this.onlineStoreIntegrationSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.onlineStoreIntegrationSearchBox.Name = "onlineStoreIntegrationSearchBox";
            this.onlineStoreIntegrationSearchBox.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.onlineStoreIntegrationSearchBox.Size = new System.Drawing.Size(816, 78);
            this.onlineStoreIntegrationSearchBox.TabIndex = 2;
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
            this.onlineStoreHeaderPanel.Size = new System.Drawing.Size(816, 63);
            this.onlineStoreHeaderPanel.TabIndex = 5;
            // 
            // onlineStoreHeaderLabel
            // 
            this.onlineStoreHeaderLabel.AutoSize = true;
            this.onlineStoreHeaderLabel.BackColor = System.Drawing.Color.White;
            this.onlineStoreHeaderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 30F);
            this.onlineStoreHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.onlineStoreHeaderLabel.Location = new System.Drawing.Point(23, -2);
            this.onlineStoreHeaderLabel.Name = "onlineStoreHeaderLabel";
            this.onlineStoreHeaderLabel.Size = new System.Drawing.Size(246, 54);
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
            this.dragControl.DockIndicatorTransparencyValue = 0.6D;
            this.dragControl.DragStartTransparencyValue = 0.6D;
            this.dragControl.TargetControl = this.controlHeader;
            this.dragControl.UseTransparentDrag = true;
            // 
            // borderlessForm
            // 
            this.borderlessForm.AnimateWindow = true;
            this.borderlessForm.AnimationType = Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm.AnimateWindowType.AW_HOR_POSITIVE;
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessForm.DragStartTransparencyValue = 0.6D;
            this.borderlessForm.TransparentWhileDrag = true;
            // 
            // sortByMenu
            // 
            this.sortByMenu.BackColor = System.Drawing.Color.White;
            this.sortByMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
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
            this.aZToolStripMenuItem.Click += new System.EventHandler(this.AZToolStripMenuItem_Click);
            // 
            // artistToolStripMenuItem
            // 
            this.artistToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.artistToolStripMenuItem.Name = "artistToolStripMenuItem";
            this.artistToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.artistToolStripMenuItem.Text = "Artist";
            this.artistToolStripMenuItem.Click += new System.EventHandler(this.ArtistsToolStripMenuItem_Click);
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.albumToolStripMenuItem.Text = "Album";
            this.albumToolStripMenuItem.Click += new System.EventHandler(this.AlbumToolStripMenuItem_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.genreToolStripMenuItem.Text = "Genre";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.GenreToolStripMenuItem_Click);
            // 
            // tabControlBorder
            // 
            this.tabControlBorder.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.tabControlBorder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.tabControlBorder.Location = new System.Drawing.Point(0, 0);
            this.tabControlBorder.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlBorder.Name = "tabControlBorder";
            this.tabControlBorder.Size = new System.Drawing.Size(0, 0);
            this.tabControlBorder.TabIndex = 4;
            // 
            // visualizeContainer
            // 
            this.visualizeContainer.Controls.Add(this.exitButton);
            this.visualizeContainer.Controls.Add(this.trackVisualizer);
            this.visualizeContainer.Controls.Add(this.trackLyrics);
            this.visualizeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualizeContainer.Location = new System.Drawing.Point(0, 31);
            this.visualizeContainer.Margin = new System.Windows.Forms.Padding(2);
            this.visualizeContainer.Name = "visualizeContainer";
            this.visualizeContainer.Size = new System.Drawing.Size(1040, 459);
            this.visualizeContainer.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.FillColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = global::MyMediaPlayer.Properties.Resources.close;
            this.exitButton.Location = new System.Drawing.Point(0, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(39, 37);
            this.exitButton.TabIndex = 2;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // trackVisualizer
            // 
            this.trackVisualizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackVisualizer.Location = new System.Drawing.Point(0, 0);
            this.trackVisualizer.Margin = new System.Windows.Forms.Padding(4);
            this.trackVisualizer.Name = "trackVisualizer";
            this.trackVisualizer.Size = new System.Drawing.Size(640, 459);
            this.trackVisualizer.TabIndex = 1;
            // 
            // trackLyrics
            // 
            this.trackLyrics.AutoScroll = true;
            this.trackLyrics.BackColor = System.Drawing.Color.White;
            this.trackLyrics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.trackLyrics.Dock = System.Windows.Forms.DockStyle.Right;
            this.trackLyrics.Location = new System.Drawing.Point(640, 0);
            this.trackLyrics.Margin = new System.Windows.Forms.Padding(4);
            this.trackLyrics.MaximumSize = new System.Drawing.Size(300, 270);
            this.trackLyrics.MinimumSize = new System.Drawing.Size(400, 353);
            this.trackLyrics.Name = "trackLyrics";
            this.trackLyrics.Size = new System.Drawing.Size(400, 353);
            this.trackLyrics.TabIndex = 3;
            // 
            // MainForm
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
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 528);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Media Player";
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.mediaControllerFooter.ResumeLayout(false);
            this.controlHeader.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.musicLibraryTabPage.ResumeLayout(false);
            this.musicLibraryTabPage.PerformLayout();
            this.musicHeaderPanel.ResumeLayout(false);
            this.musicHeaderPanel.PerformLayout();
            this.videoLibraryTabPage.ResumeLayout(false);
            this.videoHeaderPanel.ResumeLayout(false);
            this.videoHeaderPanel.PerformLayout();
            this.playQueueTabPage.ResumeLayout(false);
            this.playQueueTabPage.PerformLayout();
            this.playQueueHeaderPanel.ResumeLayout(false);
            this.playQueueHeaderPanel.PerformLayout();
            this.playlistsTabPage.ResumeLayout(false);
            this.playlistsHeaderPanel.ResumeLayout(false);
            this.playlistsHeaderPanel.PerformLayout();
            this.settingsTabPage.ResumeLayout(false);
            this.videosFolderContainer.ResumeLayout(false);
            this.videosFolderContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsIconPictureBox2)).EndInit();
            this.musicFolderContainer.ResumeLayout(false);
            this.musicFolderContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsIconPictureBox1)).EndInit();
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
        private Siticone.Desktop.UI.WinForms.SiticoneButton addMusicFolderBtn1;
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
        private TrackItemList musicList;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox settingsIconPictureBox1;
        private System.Windows.Forms.Label musicLocationLb;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addMusicFolderBtn2;
        private System.Windows.Forms.Panel visualizeContainer;
        private Siticone.Desktop.UI.WinForms.SiticoneButton exitButton;
        private TrackVisualizer trackVisualizer;
        private TrackItemList PlayQMusicList;
        private Siticone.Desktop.UI.WinForms.SiticonePanel playQueueHeaderPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton playQueueClearButton;
        private System.Windows.Forms.Label playQueueHeaderLabel;
        private System.Windows.Forms.Panel musicFolderPanel;
        private TrackLyrics trackLyrics;
        private Siticone.Desktop.UI.WinForms.SiticonePanel playlistsHeaderPanel;
        private System.Windows.Forms.Label playlistsHeaderLabel;
        private System.Windows.Forms.TabPage onlineStoreTabPage;
        private Siticone.Desktop.UI.WinForms.SiticonePanel onlineStoreHeaderPanel;
        private System.Windows.Forms.Label onlineStoreHeaderLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel onlineStoreBodyPanel;
        private ZingMP3IntegrationSearchResultList integrationSearchResultList;
        private IntegrationSearchBox onlineStoreIntegrationSearchBox;
        private Siticone.Desktop.UI.WinForms.SiticonePanel videosFolderContainer;
        private System.Windows.Forms.Panel videosFolderPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addVideosFolderBtn2;
        private System.Windows.Forms.Label videosLocationLb;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox settingsIconPictureBox2;
        private Siticone.Desktop.UI.WinForms.SiticonePanel videoHeaderPanel;
        private System.Windows.Forms.Label videoHeaderLabel;
        private VideoItemList videoItemList;
        private PlaylistItemList playlistItemList;
    }
}

