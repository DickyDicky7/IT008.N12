﻿using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public partial class Pagination : UserControl
    {
        public Pagination()
        {
            InitializeComponent();
        }

        public int CurrentPageNumber
        {
            get => int.Parse(DisplayPanel.Text);
            set
            {
                if (IsHandleCreated)
                {
                    if (InvokeRequired)
                    {
                        DisplayPanel.Invoke
                        ((MethodInvoker)delegate () { DisplayPanel.Text = value.ToString(); });
                        Console.WriteLine("1");
                    }
                    else
                    {
                        DisplayPanel.Text = value.ToString();
                        Console.WriteLine("2");
                    }
                }
            }
        }

        public EventHandler BackPageButton_Click
        {
            set => BackPageButton.Click += value;
        }

        public EventHandler NextPageButton_Click
        {
            set => NextPageButton.Click += value;
        }
    }
}
