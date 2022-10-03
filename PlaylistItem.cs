using WMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static ReaLTaiizor.Drawing.Poison.PoisonPaint.ForeColor;
using System.Security.Policy;
using Siticone.Desktop.UI.WinForms;
using System.Numerics;
using AxWMPLib;

namespace IT008.N12_015
{
    public partial class PlaylistItem : UserControl
    {
        #region Propreties

        private String url;
        private Image _thumbnail;
        private String _title;
        
        public String Title
        {
            get { return _title; }
            set { _title = value; titleLB.Text = value; }
        }

        public Image Thumbnail
        {
            get { return _thumbnail; }
            set { _thumbnail = value; }
        }

        public String URL
        {
            get { return url; }
            set { url = value; }
        }

        #endregion

        public PlaylistItem(string URL)
        {
            InitializeComponent();
            this.URL = URL;
            InitializePlaylistItem(URL);
        }

        private void InitializePlaylistItem(string URL)
        {
            TagLib.File file = TagLib.File.Create(URL);
            var mStream = new MemoryStream();
            var firstPicture = file.Tag.Pictures.FirstOrDefault();
            if (firstPicture != null)
            {
                byte[] pData = firstPicture.Data.Data;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                var bm = new Bitmap(mStream, false);
                mStream.Dispose();
                this.Thumbnail = bm;
            }
            else
            {
                this.Thumbnail = Properties.Resources."icons8-video-playlist-64.png";
            }
            this.Title = file.Tag.Title;
        }

        public string playlistName;
        public string playlistPath;

        //public static MediaController MediaController { get; set; }

        public void CreatePlaylistObject()
        {
            playlistName = titleLB.Text;
            string musicPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            playlistPath = musicPath + "\\Playlists\\Playlist_" + titleLB.Text;
        }
   
        public void ShowPlaylistSong(string name, string path)
        {
            
        }
         
        private void PlayList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void PlaylistItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Menu.Show(this, new Point(e.X, e.Y));
            }
            else if (e.Button == MouseButtons.Left)
            {
                CreatePlaylistObject();
                MediaController.LoadPlaylist(playlistName, playlistPath);
            }
        }

        private void PlayList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titleLB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void renameTitle(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.ShowDialog(); 
            titleLB.Text = fbd.SelectedPath;
        }

        private void changeThumnail(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            Thumnail.Image = Image.FromFile(fbd.SelectedPath);
        }

        private void Thumnail_Click(object sender, EventArgs e)
        {

        }
    }
}
