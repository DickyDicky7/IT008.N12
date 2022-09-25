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
            new SiticoneDragControl(controlHeader);
            nameContainer.Width = siticoneTabControl1.TabButtonSize.Width;
            string musicPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            addMusic(musicPath);
            //Load += new EventHandler(form_Load(args));
        }

        private void form_Resize(object sender, EventArgs e)
        {
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
                musicPanel.Controls.Add(new MediaItem(file));
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
