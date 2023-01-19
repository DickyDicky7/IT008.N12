using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using WinFormAnimation;
using System.Threading;
using PlaylistsNET.Utils;
using PlaylistsNET.Models;
using PlaylistsNET.Content;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public partial class PlaylistItem : UserControl, IMediaItemList
    {
        public PlaylistItem(string URL)
        {
            InitializeComponent();
            this.URL = URL;
            Render();
            DataGridView.CellMouseClick += (sender, e) =>
            {
                if (e.RowIndex is -1)
                    return;
                else
                if (e.Button is MouseButtons.Left)
                {
                    GlobalReferences.MediaController.LoadMediaItemList(this);
                    #region Testing
                    //Old code
                    //UpdateCurrentIndex(null);
                    CurrentIndex = e.RowIndex;
                    #endregion
                    Play();
                }
                else
                if (e.Button is MouseButtons.Right)
                {
                    RowIndex = e.RowIndex;
                    ChildMenu.Show(MousePosition);
                }
            };
        }

        private List<string> Paths;
        private readonly string URL;
        private int? RowIndex = null;

        private void Render()
        {
            using (Stream Stream = File.OpenRead(URL))
            {
                WplContent Content = new WplContent();
                WplPlaylist Playlist = Content.GetFromStream(Stream);
                Paths = Playlist.GetTracksPaths().ToList();
                Panel.Text = Playlist.Title;
            }

            for (int k = 0; k < DataGridView.Rows.Count; k++) DataGridView.Rows[k].Dispose();
            DataGridView.Rows.Clear();

            Paths.ForEach(Path =>
            {
                string FileType =
                Common.AudioFileExtensions.Any
                (Extension => Path.Contains(Extension.Substring(1))) ? "Audio" :
                Common.VideoFileExtensions.Any
                (Extension => Path.Contains(Extension.Substring(1))) ? "Video" : "_____";

                string FileName =
                FileType is "Audio" ? Common.GetTitle(Path) : Path.Split('\\').Last();

                DataGridView.Rows.Add(new string[] { FileName, FileType });
            });

            DataGridView.ClearSelection();
        }

        public void RenamePlaylist(object sender, EventArgs e)
        {
        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(URL))
            {
                File.Delete(URL);
            }
            else
            {
                this.Parent.Controls.Remove(this);
                this.Dispose();
            }
        }

        private void ChildRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RowIndex != null)
            {
                MediaController.RemoveFromPlaylist(Panel.Text, Paths[RowIndex.Value]);
                RowIndex = null;
            }
        }

        private void Panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Menu.Show(MousePosition);
            }
        }

        private int CurrentIndex = -1;

        private Action Play => () =>
        {
            DataGridView.Rows[CurrentIndex].Selected = true;

            if (DataGridView.Rows[CurrentIndex].Cells[1].Value is "Audio")
                GlobalReferences.MediaController.LoadLocalTrack(Paths[CurrentIndex]);
            else
            if (DataGridView.Rows[CurrentIndex].Cells[1].Value is "Video")
                GlobalReferences.MediaController.LoadLocalVideo(Paths[CurrentIndex]);
        };

        public Action Stop => () =>
        {
            #region Testing
            DataGridView.ClearSelection();
            #endregion
            CurrentIndex = -1;
        };

        public Action Clear => () =>
        {
            for (int k = 0; k < DataGridView.Rows.Count; k++) DataGridView.Rows[k].Dispose();
            DataGridView.Rows.Clear();

            ChildRemoveToolStripMenuItem.Click += null;
            RemoveToolStripMenuItem.Click += null;
            DataGridView.CellMouseClick += null;
            PlayButton.Click += null;
            Panel.MouseClick += null;
        };

        public Action PlayBack => () =>
        {
            CurrentIndex = CurrentIndex - 1 <= -1 ? CurrentIndex : CurrentIndex - 1;
            Play();
        };

        public Action PlayNext => () =>
        {
            CurrentIndex = CurrentIndex + 1 >= Paths.Count ? CurrentIndex : CurrentIndex + 1;
            Play();
        };

        public Action GenerateShuffleList => () => { };

        public void UpdateCurrentIndex(IMediaItem MediaItem)
        {
            CurrentIndex = DataGridView.Rows.IndexOf(DataGridView.SelectedRows[0]);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            GlobalReferences.MediaController.LoadMediaItemList(this);
            PlayNext();
        }
    }
}
