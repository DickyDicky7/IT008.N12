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

namespace IT008.N12_015
{
    public partial class form : Form
    {
        public form(string[] args)
        {
            InitializeComponent();
            Common.RoundedCorner(this);
            string musicPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            addMusic(musicPath);
            
            Resposive();
            //Load += new EventHandler(form_Load(args));
        }

        private void form_Resize(object sender, EventArgs e)
        {
            Resposive();
            //siticonePanel1.BackColor = Color.White;
            //siticoneTabControl1.TabButtonSize = new Size(60, 60);
        }

        private void Resposive()
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
            foreach (Control c in musicPanel.Controls)
            {
                c.Width = this.Width - siticoneTabControl1.TabButtonSize.Width - c.Padding.Left - c.Padding.Right;
            }
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

        private void addMusic(string folderPath)
        {
            string[] fileArray = Directory.GetFiles(folderPath, "*.mp3");
            foreach (string file in fileArray)
            {
                MediaItem media = new MediaItem(file);
                media.Dock = DockStyle.Top;
                media.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                musicPanel.Controls.Add(media);
            }
        }

        private void addFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    addMusic(fbd.SelectedPath);
                }
            }
        }
        
    }
}
