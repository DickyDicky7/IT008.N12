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
            InitializePlaylistItem(URL);

            //PictureBox.Image = Properties.Resources.icons8_music_library_64;





        }

        public void InitializePlaylistItem(string URL)
        {
            Stream Stream = new MemoryStream();
            Stream = File.OpenRead(URL);

            WplContent Content = new WplContent();
            WplPlaylist Playlist = Content.GetFromStream(Stream);

            Paths = Playlist.GetTracksPaths()
            .Select(Path => $"{Common.MusicFolder}{Path.Substring(2)}")
            .ToList();

            Panel.Text = Playlist.Title;

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

        public void PlaylistItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Menu.Show(this, new Point(e.X, e.Y));           // hiện menu khi click chuột phải
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
    }
}
