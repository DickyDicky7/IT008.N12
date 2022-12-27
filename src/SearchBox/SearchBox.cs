﻿using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
//using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public partial class SearchBox : UserControl
    {
        public SearchBox()
        {
            InitializeComponent();

            Watcher.Interval = TimeSpan.FromMilliseconds(100);
            Watcher.Action = UpdateSearchBox;

            TextBox.TextChanged += new EventHandler(TextBox_TextChanged);
            Load += new EventHandler(SearchBox_Load);
        }

        private void UpdateSearchBox()
        {
            if (LastMod != null)
            {
                if (DateTime.Now.Subtract(LastMod.Value) >= TimeSpan.FromSeconds(3))
                {
                    TextBox.BeginInvoke((MethodInvoker)async delegate ()
                    {
                        if (Integration != null)
                        {
                            //o = JObject
                            //.Parse(await Integration.Search(TextBox.Text, true));
                            //IList<string> l =
                            //o["data"]["songs"].Select(t => t["title"].ToString())
                            //.ToList();
                            //MessageBox.Show(l.Aggregate((acc,s) => $"{acc};{s}"));
                            SearchResultList.LoadSearchResults
                            (await Integration.Search(TextBox.Text, true));
                            //MessageBox.Show
                            //(await Integration.Search(TextBox.Text, true));
                        }
                        TextBox.Text = "";
                    });
                    LastMod = null;
                }
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            LastMod = DateTime.Now;
        }

        private void SearchBox_Load(object sender, EventArgs e)
        {
            Watcher.Start();
        }

        public void Stop()
        {
            Watcher.Stop();
        }

        private DateTime? LastMod;

        private readonly Watcher Watcher = new Watcher();

        public IIntegration Integration { get; set; } = null;

        //JObject o;

        public SearchResultList SearchResultList;
    }
}
