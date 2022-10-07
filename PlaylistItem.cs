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
        private String url;

        public String Title
        {
            get { return _title; }
            set { _title = value; Label.Text = value; }
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

        public void InitializePlaylistItem(string URL)
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

            List<string> paths = playlist.GetTracksPaths();

            Label.Text = playlist.Title;
            
            if (playlist.ItemCount > 0)
            {
                if (playlist.ItemCount < 4)
                {
                    string path = paths[0];
                    if (File.Exists(path))
                    {
                        TagLib.File file = TagLib.File.Create(path);
                        if (file.Tag.Pictures.Length >= 1)
                        {
                            byte[] bin = file.Tag.Pictures[0].Data.Data;
                            MemoryStream ms = new MemoryStream(bin);          // set thumnail là image của file đầu tiên trong playlist
                            Image image = Image.FromStream(ms);
                            Thumnail.Image = image;
                        }
                    }
                }
                else 
                {
                    Bitmap bitmap = new Bitmap(Thumnail.Width, Thumnail.Height);
                    Graphics graphics = Graphics.FromImage(bitmap);
                    graphics.Clear(Color.White);
                    graphics.DrawImage(Image.FromFile(paths[0]), 0, 0, 30, 30);
                    graphics.DrawImage(Image.FromFile(paths[1]), 30, 0, 30, 30);         // merge 4 images
                    graphics.DrawImage(Image.FromFile(paths[2]), 0, 30, 30, 30);
                    graphics.DrawImage(Image.FromFile(paths[3]), 30, 30, 30, 30);
                    Thumnail.Image = bitmap;
                }
            }
            else Thumbnail = Properties.Resources.icons8_music_library_64;         // nếu playlist rỗng thì set thumnail là icon music library
        }

        public string playlistName;
        public string playlistPath;

        public void CreatePlaylistObject()
        {
            playlistName = "Playlist_" + Label.Text;
            string musicPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            playlistPath = musicPath + "\\Playlists\\Playlist_" + Label.Text;
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
            Label.Text = InputBox();
            
            Stream stream = new MemoryStream();
            stream = File.OpenRead(URL);
            WplContent content = new WplContent();                                // đổi tên playlist
            WplPlaylist playlist = content.GetFromStream(stream);
            
            playlist.Title = Label.Text;
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
    }
}
