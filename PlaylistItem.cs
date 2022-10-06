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
using PlaylistsNET.Content;
using PlaylistsNET.Models;

namespace IT008.N12_015
{
    public partial class PlaylistItem : UserControl
    {
        #region Propreties

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

        #endregion

        public PlaylistItem(string URL)
        {
            InitializeComponent();
            InitializePlaylistItem(URL);
        }

        private void InitializePlaylistItem(string URL)
        {
            /*
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(URL);
            writer.Flush();
            stream.Position = 0;
            WplContent content = new WplContent();
            WplPlaylist playlist = content.GetFromStream(stream);

            List<string> paths = playlist.GetTracksPaths();*/       
            Stream stream = new MemoryStream();
            stream = File.OpenRead(URL);
            WplContent content = new WplContent();
            WplPlaylist playlist = content.GetFromStream(stream);

            //List<string> paths = playlist.GetTracksPaths();
            titleLB.Text = playlist.Title;
            Thumbnail = Properties.Resources.icons8_music_library_64;
        }

        public string playlistName;
        public string playlistPath;

        public void CreatePlaylistObject()
        {
            playlistName = "Playlist_" + titleLB.Text;
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
            var bm = new Bitmap(@fbd.SelectedPath, false);
            fbd.Dispose();
            Thumbnail = bm;
        }

        private void Thumnail_Click(object sender, EventArgs e)
        {
            
        }
    }
}
