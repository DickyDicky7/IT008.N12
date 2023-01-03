using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using FluentTransitions;
using Newtonsoft.Json.Linq;
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
                if (LstIndex + 9 <= Lyrics.Count - 1)
                {
                    FstIndex += 9;
                    LstIndex += 9;
                    Render();
                }
                else
                {
                    if (LstIndex != Lyrics.Count - 1)
                    {
                        FstIndex = Lyrics.Count - 9;
                        LstIndex = Lyrics.Count - 1;
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
                    .FirstOrDefault()).Text = Lyrics[i].Item2;

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
                .Split(new string[] { "\n", "," }, StringSplitOptions.None)
                .Select<string, (int?, string)>(Lyric => (null, Lyric)).ToList();
                HasLyrics = true;
            }
            Render(true);
            File.Dispose();
        }

        private int i;
        private int FstIndex = 0;
        private int LstIndex = 8;
        private int LineNumber = 1;
        private bool HasLyrics = false;
        private JObject JSONResultObject;
        private List<(int?, string)> Lyrics;

        public async void ParseStreamingLyrics(string JSONResult)
        {
            await Task.Factory.StartNew(() =>
            {
                JSONResultObject = JObject.Parse(JSONResult);

                Lyrics = JSONResultObject["data"]?["sentences"]?.Children().Select(Child =>
                (Child["words"].Children().First()["startTime"].Value<int?>(),
                Child["words"].Children().Select(Item =>
                Item["data"].Value<string>()).Aggregate
                ((Word, Lyric) => $"{Word} {Lyric}")))
                .ToList();

                HasLyrics = Lyrics != null;
            });

            Render(true);
        }
    }
}
