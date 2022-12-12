using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace IT008.N12_015
{
    public partial class InputForm : Form
    {
        public InputForm(string Title)
        {
            InitializeComponent();

            this.Title.Text = Title;
            this.Title.Location = new Point
            ((this.Size.Width - this.Title.Size.Width) / 2, this.Title.Location.Y);
        }

        public string Result = null;

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(TextBox.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên playlist");
            }
            else
            {
                Result = TextBox.Text;
                Close();
            }    
        }

    }
}
