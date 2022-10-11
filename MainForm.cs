using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Xml.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using Siticone.Desktop.UI.WinForms;

namespace IT008.N12_015
{
    public partial class form : Form
    {
        public form(string[] args)
        {
            InitializeComponent();
            Common.RoundedCorner(this);
            settingPageInit();
            musicPageInit();
            MediaItem test = new MediaItem("heloo","test","hello","test",new TimeSpan(0,0,0));
            musicList1.addMusic(test);
            //Responsive();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor, true);

            //Load += new EventHandler(form_Load(args));
            var sci = new SoundCloudIntegration();
            siticoneTabControl1.TabPages.Add(sci.SoundCloudTabPage);

            PlaylistItem.MediaController = mediaController1;
            tabPage4.Controls.Add(new PlaylistItem(
            "C:\\Users\\User\\Music\\Playlists\\abc.wpl"
                ));
        }

        /// <summary>
        /// Cần dùng sau này!
        /// </summary>
        //private Action<object, EventArgs> form_Load(string[] args)
        //{
        //    Action<object, EventArgs> LoadHandler = new
        //    Action<object, EventArgs>((sender, e) =>
        //    {
        //        if (args.Length != 0)
        //        {
        //            MessageBox.Show(args[0], "File");
        //            MediaController.LoadMedia(args[0]);
        //        }
        //    });
        //    return LoadHandler;
        //}
        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        #region Initialize
        private void musicPageInit()
        {
            Common.RoundedCorner(this.sortByMenu);
            this.shuffleAndPlayBtn.AutoSize = true;
            this.sortBtn.AutoSize = true;
            MediaItem.MediaController = mediaController1;
            foreach (string URL in Properties.Settings.Default.musicFolder)
            {
                if(Directory.Exists(URL))
                    musicList1.addMusic(URL);
                else
                {
                    Properties.Settings.Default.musicFolder.Remove(URL);
                    Properties.Settings.Default.Save();
                }    
            }
        }
        private void settingPageInit()
        {
            string musicPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            if (Properties.Settings.Default.musicFolder.Contains(musicPath) == false)
            {
                Properties.Settings.Default.musicFolder.Add(musicPath);
                Properties.Settings.Default.Save();
            }
            foreach (string URL in Properties.Settings.Default.musicFolder)
            {
                FolderLocation musicFolder = new FolderLocation(URL);
                musicFolderPanel.Controls.Add(musicFolder);                
            }
        }
        #endregion

        #region Add_Music
        private void addFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    if(Properties.Settings.Default.musicFolder.Contains(fbd.SelectedPath) == false)
                    {
                        Properties.Settings.Default.musicFolder.Add(fbd.SelectedPath);
                        Properties.Settings.Default.Save();
                        FolderLocation folderLocation = new FolderLocation(fbd.SelectedPath);
                        musicFolderPanel.Controls.Add(folderLocation);
                        musicList1.addMusic(fbd.SelectedPath);
                    }
                }
            }
        }
        #endregion

        #region Responsive
        private void Responsive()
        {
            if(this.Width <= 1000)
            {
                siticoneTabControl1.TabButtonSize = new Size(55, 50);
                tabPage1.Text = "";
                tabPage2.Text = "";
                tabPage3.Text = "";
                tabPage4.Text = "";
                tabPage5.Text = "";
            }
            else
            {
                siticoneTabControl1.TabButtonSize = new Size(210, 50);
                tabPage1.Text = "Music library";
                tabPage2.Text = "Video library";
                tabPage3.Text = "Play queue";
                tabPage4.Text = "Playlists";
                tabPage5.Text = "Settings";
            }
            nameContainer.Width = siticoneTabControl1.TabButtonSize.Width;
            musicList1.Width = tabPage1.Width;
            foreach (Control c in musicFolderPanel.Controls)
            {
                c.Width = musicFolderPanel.Width - c.Padding.Left - c.Padding.Right - 100;
            }
            tabControlBorder.Location = new Point(siticoneTabControl1.TabButtonSize.Width,0);
            tabControlBorder.Size = new Size(1, nameContainer.Height + siticoneTabControl1.Height);
        }

        private void form_ResizeEnd(object sender, EventArgs e)
        {
            Responsive();
            siticoneTabControl1.Visible = true;
        }

        private void form_ResizeBegin(object sender, EventArgs e)
        {
            siticoneTabControl1.Visible = false;
            //Responsive();
        }
        private void form_Resize(object sender, EventArgs e)
        {
            //Responsive();
            if (WindowState == FormWindowState.Maximized || WindowState == FormWindowState.Normal)
            {
                //Responsive();
            }

        }
        #endregion

        #region Sort_Music

        private void sortBtn_Click(object sender, EventArgs e)
        {
            SiticoneButton btnSender = (SiticoneButton)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            sortByMenu.Width = sortBtn.Width;
            sortByMenu.Show(ptLowerLeft);

        }

        private void artistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList1.sortBy(MusicList.SORTBY.ARTIST);
            //var sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Artist).ToList();
            //mediaItemContainer.Controls.Clear();
            //mediaItemContainer.Controls.AddRange(sortedList.ToArray());
            sortBtn.Text = "Sort by: Artist";
        }

        private void aZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList1.sortBy(MusicList.SORTBY.AZ);
            //var sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Title).ToList();
            //mediaItemContainer.Controls.Clear();
            //mediaItemContainer.Controls.AddRange(sortedList.ToArray());
            sortBtn.Text = "Sort by: A-Z";
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList1.sortBy(MusicList.SORTBY.GENRE);
            //var sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Genre).ToList();
            //mediaItemContainer.Controls.Clear();
            //mediaItemContainer.Controls.AddRange(sortedList.ToArray());
            sortBtn.Text = "Sort by: Genre";
        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicList1.sortBy(MusicList.SORTBY.ALBUM);
            //var sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Album).ToList();
            //mediaItemContainer.Controls.Clear();
            //mediaItemContainer.Controls.AddRange(sortedList.ToArray());
            sortBtn.Text = "Sort by: Album";

        }
        #endregion

    }
}
