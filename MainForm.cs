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
            string musicPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            addMusic(musicPath);
            Common.RoundedCorner(this.sortByMenu);
            Common.RoundedCorner(this);
            this.shuffleAndPlayBtn.AutoSize = true;
            this.sortBtn.AutoSize = true;
            MediaItem.MediaController = mediaController1;
            Responsive();
            //Load += new EventHandler(form_Load(args));
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
        private void form_FormClosing(object sender, EventArgs e)
        {
        }

        #region Add_Music
        List<MediaItem> mediaItems = new List<MediaItem>();
        private void addMusic(string folderPath)
        {
            string[] fileArray = Directory.GetFiles(folderPath, "*.mp3");
            int i = 0;
            foreach (string file in fileArray)
            {
                i++;
                MediaItem media = new MediaItem(file);
                media.Dock = DockStyle.Top;
                media.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                mediaItems.Add(media);
                mediaItemContainer.Controls.Add(media);
            }
        }

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
                        TestMusicFolder.Text += fbd.SelectedPath;
                        addMusic(fbd.SelectedPath);
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
            foreach (Control c in mediaItemContainer.Controls)
            {
                c.Width = this.Width - siticoneTabControl1.TabButtonSize.Width - c.Padding.Left - c.Padding.Right;
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
        }
        private void form_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized || WindowState == FormWindowState.Normal)
            {
                Responsive();
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
            var sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Artist).ToList();
            mediaItemContainer.Controls.Clear();
            mediaItemContainer.Controls.AddRange(sortedList.ToArray());
            sortBtn.Text = "Sort by: Artist";
        }

        private void aZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Title).ToList();
            mediaItemContainer.Controls.Clear();
            mediaItemContainer.Controls.AddRange(sortedList.ToArray());
            sortBtn.Text = "Sort by: A-Z";
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Genre).ToList();
            mediaItemContainer.Controls.Clear();
            mediaItemContainer.Controls.AddRange(sortedList.ToArray());
            sortBtn.Text = "Sort by: Genre";
        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sortedList = mediaItems.OrderBy(mediaItem => mediaItem.Album).ToList();
            mediaItemContainer.Controls.Clear();
            mediaItemContainer.Controls.AddRange(sortedList.ToArray());
            sortBtn.Text = "Sort by: Album";

        }
        #endregion

    }
}
