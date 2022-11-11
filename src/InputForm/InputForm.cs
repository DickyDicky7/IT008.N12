﻿using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace IT008.N12_015.src.InputForm
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
            Result = TextBox.Text;
            Close();
        }

    }
}
