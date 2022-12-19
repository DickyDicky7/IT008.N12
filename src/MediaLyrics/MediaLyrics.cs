using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using FluentTransitions;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public partial class MediaLyrics : UserControl
    {
        public MediaLyrics()
        {
            InitializeComponent();
            MouseWheel += new MouseEventHandler(MediaLyrics_MouseWheel);
        }

        private void MediaLyrics_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && HasLyrics)
            {
                //MessageBox.Show("@@@");
                if (FstIndex - 9 >= 0)
                {
                    FstIndex -= 9;
                    LstIndex -= 9;
                    Render();
                }
                else
                {
                    if (FstIndex != 0)
                    {
                        FstIndex = 0;
                        LstIndex = 8;
                        Render();
                    }
                }
            }

            if (e.Delta < 0 && HasLyrics)
            {
                //MessageBox.Show("###");
                if (LstIndex + 9 <= Lyrics.Length - 1)
                {
                    FstIndex += 9;
                    LstIndex += 9;
                    Render();
                }
                else
                {
                    if (LstIndex != Lyrics.Length - 1)
                    {
                        FstIndex = Lyrics.Length - 9;
                        LstIndex = Lyrics.Length - 1;
                        Render();
                    }
                }
            }
        }

        private void Render(bool FirstTime = false)
        {
            for (i = FstIndex; i <= LstIndex; i++)
            {
                if (!FirstTime)
                {
                    ((Label)Controls.Find($"Line{LineNumber}", false)
                    .FirstOrDefault()).Left = -
                    ((Label)Controls.Find($"Line{LineNumber}", false)
                    .FirstOrDefault()).Size.Width;
                }

                if (FirstTime && !HasLyrics)
                    ((Label)Controls.Find($"Line{LineNumber}", false)
                    .FirstOrDefault()).Text = String.Empty;
                else
                    ((Label)Controls.Find($"Line{LineNumber}", false)
                    .FirstOrDefault()).Text = Lyrics[i];

                if (!FirstTime)
                {
                    Transition.With(((Label)Controls.Find($"Line{LineNumber}", false)
                    .FirstOrDefault()), "Left", 0)
                    .EaseInEaseOut(TimeSpan.FromSeconds(0.1 * LineNumber));
                }

                LineNumber++;
            }
            LineNumber = 1;
        }

        public void GetLyrics(string MediaURL)
        {
            TagLib.File File = TagLib.File.Create(MediaURL);
            if (File.Tag.Lyrics == null)
                HasLyrics = false;
            else
            {
                Lyrics = File.Tag.Lyrics
                .Split(new string[] { "\n", "," }, StringSplitOptions.None);
                HasLyrics = true;
            }
            Render(true);
            File.Dispose();
        }

        private int i;
        private string[] Lyrics;
        private int FstIndex = 0;
        private int LstIndex = 8;
        private int LineNumber = 1;
        private bool HasLyrics = false;
    }
}
