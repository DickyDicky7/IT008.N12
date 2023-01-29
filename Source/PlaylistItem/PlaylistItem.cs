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
            this.Name = URL;
            Render();
            DataGridView.CellMouseClick += DataGridView_CellMouseClick;
        }

        private void DataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex is -1)
            {
                return;
            }
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
        }

        private List<string> Paths;
        private readonly string URL;
        private int? RowIndex = null;

        public void Render()
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

        private void RenamePlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (InputForm InputForm = new InputForm("New Playlist's name"))
            {
                InputForm.ShowDialog();
                if (string.IsNullOrEmpty(InputForm.Result)
                 || string.IsNullOrWhiteSpace(InputForm.Result)) return;
                MediaController.RenamePlaylist(Panel.Text, InputForm.Result);
            }
        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Clear();
            this.Dispose();
            if (File.Exists(URL))
            {
                File.Delete(URL);
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
            RenamePlaylistToolStripMenuItem.Click -= RenamePlaylistToolStripMenuItem_Click;
            ChildRemoveToolStripMenuItem.Click -= ChildRemoveToolStripMenuItem_Click;
            RemoveToolStripMenuItem.Click -= RemoveToolStripMenuItem_Click;
            DataGridView.CellMouseClick -= DataGridView_CellMouseClick;
            PlayButton.Click -= PlayButton_Click;
            Panel.MouseClick -= Panel_MouseClick;

            for (int k = 0; k < DataGridView.Rows.Count; k++) DataGridView.Rows[k].Dispose();
            DataGridView.Rows.Clear();

            RenamePlaylistToolStripMenuItem.Dispose();
            ChildRemoveToolStripMenuItem.Dispose();
            RemoveToolStripMenuItem.Dispose();
            DataGridView.Dispose();
            PlayButton.Dispose();
            Panel.Dispose();

            RenamePlaylistToolStripMenuItem = null;
            ChildRemoveToolStripMenuItem = null;
            RemoveToolStripMenuItem = null;
            DataGridView = null;
            PlayButton = null;
            Panel = null;

            Menu.Dispose();
            ChildMenu.Dispose();

            Menu = null;
            ChildMenu = null;
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
