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
    }
}
