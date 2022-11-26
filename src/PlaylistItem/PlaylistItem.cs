using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using PlaylistsNET.Utils;
using PlaylistsNET.Models;
using PlaylistsNET.Content;
using System.Windows.Forms;
using System.ComponentModel;
using WinFormAnimation_NET5;
using IT008.N12_015.src.Util;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace IT008.N12_015
{
    public partial class PlaylistItem : UserControl
    {
        #region Propreties

        private Image _thumbnail;
        private String _title;
        private String url;

        public String Title
        {
            get { return _title; }
            set { _title = value; Panel.Text = value; }
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

        private List<string> Paths;

        private readonly Watcher Watcher = new Watcher();

        public static MediaController MediaController { get; set; }

        private readonly Random Random = new Random();

        #endregion

        public PlaylistItem(string URL)
        {
            InitializeComponent();
            this.URL = URL;
            this.Name = URL;
            InitializePlaylistItem(URL);

            //PictureBox.Image = Properties.Resources.icons8_music_library_64;
            playButton.Click += (sender, e) =>
            {
                MediaController.LoadMusicList(this.musicList);
            };

            foreach (string Path in Paths)
            {
                MediaItem mediaItem = new MediaItem(Path);
                mediaItem.Height = 30;
                mediaItem.addDeleteToMenu();
                mediaItem.PlayListName = Panel.Text;
                musicList.addMusic(mediaItem);
            }
            //MessageBox.Show(musicList.Size.Height.ToString());
            Common.RoundedCorner(Menu);
            this.Size = new Size(this.Size.Width, Panel.Size.Height);
            musicList.test();
            musicList.Hide();
            //this.BackColor = Color.Black;
        }

        public void InitializePlaylistItem(string URL)
        {
            Stream Stream = new MemoryStream();
            Stream = File.OpenRead(URL);

            WplContent Content = new WplContent();
            WplPlaylist Playlist = Content.GetFromStream(Stream);
            // substring 2 chi the :> 
            Paths = Playlist.GetTracksPaths()
            //.Select(Path => $"{Path.Substring(2)}")
            .ToList();

            Panel.Text = Playlist.Title;

            //Stream.Close();
            Stream.Dispose();
        }

        public string playlistName;
        public string playlistPath;

        public void CreatePlaylistObject()
        {
            playlistName = Panel.Text;
            string musicPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            playlistPath = $"{musicPath}\\Playlists\\{playlistName}.wpl";
        }

        private void PlayList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Reset()
        {
            musicList.Clear();
            Paths.Clear();
            InitializePlaylistItem(URL);
            foreach (string Path in Paths)
            {
                MediaItem mediaItem = new MediaItem(Path);
                mediaItem.Height = 30;
                mediaItem.addDeleteToMenu();
                musicList.addMusic(mediaItem);
                mediaItem.PlayListName = Panel.Text;
            }
            //MessageBox.Show(musicList.Size.Height.ToString());
            Common.RoundedCorner(Menu);
            this.Size = new Size(this.Size.Width, Panel.Size.Height);
            musicList.test();
            musicList.Hide();
            //this.BackColor = Color.Black;
            IsExpanded = false;
        }

        public void PlaylistItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Menu.Show(this, new Point(e.X, e.Y));           // hiện menu khi click chuột phải
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (IsExpanded)
                {
                    this.Size = new Size(this.Size.Width, Panel.Size.Height);
                    if (AdjacentOne != null)
                        AdjacentOne.Location = new Point
                        (AdjacentOne.Location.X,
                         AdjacentOne.Location.Y - musicList.Size.Height);
                    musicList.Hide();
                    IsExpanded = false;
                }
                else
                {
                    this.Size = new Size
                    (this.Size.Width, Panel.Size.Height + musicList.Size.Height);
                    if (AdjacentOne != null)
                        AdjacentOne.Location = new Point
                        (AdjacentOne.Location.X,
                         AdjacentOne.Location.Y + musicList.Size.Height);
                    musicList.Show();
                    IsExpanded = true;
                }
                CreatePlaylistObject();
                //MediaController.LoadPlaylist(this);
            }
        }

       // private int CurrentIndex = -1;

        //public void Stop()
        //{
        //    CurrentIndex = -1;
        //}

        //public void PlayNext()
        //{
        //    CurrentIndex++;
        //    if (CurrentIndex < Paths.Count)
        //    {
        //        musicList.Signal(CurrentIndex);
        //    }
        //}

        private void PlayList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titleLB_TextChanged(object sender, EventArgs e)
        {

        }

        public void renamePlaylist(object sender, EventArgs e)
        {
            Panel.Text = InputBox();

            Stream stream = new MemoryStream();         // đổi tên playlist
            stream = File.OpenRead(URL);
            WplContent content = new WplContent();
            WplPlaylist playlist = content.GetFromStream(stream);
            //playlist.Title.ReplaceWith = Label.Text;

            playlist.FileName = Panel.Text;
        }

        public static string InputBox() // tạo dialog để nhập tên
        {
            Form form = new Form();
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            TextBox textBox = new TextBox();
            System.Windows.Forms.Button buttonOk = new System.Windows.Forms.Button();
            System.Windows.Forms.Button buttonCancel = new System.Windows.Forms.Button();

            form.Text = "Rename Playlist";
            label.Text = "Enter new name:";

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            return dialogResult == DialogResult.OK ? textBox.Text : "";
        }

        public new event MouseEventHandler MouseClick
        {
            add
            {
                base.MouseClick += value;
                void Recursive(Control control, MouseEventHandler e)
                {
                    foreach (Control c in control.Controls)
                    {
                        c.MouseClick += e;
                        Recursive(c, e);
                    }
                }
                Recursive(this, value);
            }
            remove
            {
                base.MouseClick -= value;
                void Recursive(Control control, MouseEventHandler e)
                {
                    foreach (Control c in control.Controls)
                    {
                        c.MouseClick -= e;
                        Recursive(c, e);
                    }
                }
                Recursive(this, value);
            }
        }

        public PlaylistItem AdjacentOne = null;

        private bool IsExpanded = false;

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(URL);
                MediaItem.removeFromAllMenu(Panel.Text);
            }
            catch { }
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }
    }
}
