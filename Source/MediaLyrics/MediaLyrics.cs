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

            foreach (Label Line in Controls.OfType<Label>())
                Line.Text = String.Empty;
        }

        private void MediaLyrics_MouseWheel(object sender, MouseEventArgs e)
        {
            if (IsSync) return;

            if (e?.Delta > 0 && HasLyrics)
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

            if (e?.Delta < 0 && HasLyrics)
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
            for (CurrentIndex = FstIndex; CurrentIndex <= LstIndex; CurrentIndex++)
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
                    .FirstOrDefault()).Text = Lyrics[CurrentIndex].Item2;

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
            {
                HasLyrics = false;
                BackgroundImage = Properties.Resources.not_found;
            }
            else
            {
                IsSync = false;
                Watcher.Stop();

                FstIndex = 0;
                LstIndex = Controls.OfType<Label>().Count() - 1;

                Lyrics = File.Tag.Lyrics
                .Split(new string[] { "\n", "," }, StringSplitOptions.None)
                .Select<string, (int?, string)>(Lyric => (null, Lyric)).ToList();

                HasLyrics = true;

                BackgroundImage = null;
            }
            Render(true);
            File.Dispose();
        }

        public async void ParseStreamingLyrics(string JSONResult)
        {
            await Task.Factory.StartNew(() =>
            {
                JSONResultObject = JObject.Parse(JSONResult);

                Lyrics = JSONResultObject["data"]?["sentences"]?
                .Children().Select(Child =>
                (Child["words"].Children().First()["startTime"].Value<int?>() / 1000
                , Child["words"].Children().Select(Item => Item["data"].Value<string>())
                .Aggregate((Word, Lyric) => $"{Word} {Lyric}"))).ToList();

                IsSync = HasLyrics = Lyrics != null;
            });

            if (IsSync)
            {
                foreach (Label Line in Controls.OfType<Label>())
                    Line.Text = String.Empty;

                CurrentIndex = -1;

                Watcher.Interval = TimeSpan.FromMilliseconds(10);
                Watcher.Action = OnStreaming;
                Watcher.Start();

                BackgroundImage = null;
            }
            else
            {
                foreach (Label Line in Controls.OfType<Label>())
                    Line.Text = String.Empty;

                BackgroundImage = Properties.Resources.not_found;
            }
        }

        private async void OnStreaming()
        {
            if (IsSync)
            {
                if (CurrentIndex + 1 < Lyrics.Count &&
                await GlobalReferences.MediaController?.CheckIfRightTime
                (Lyrics[CurrentIndex + 1].Item1.Value))
                {
                    CurrentIndex++;
                    Console.WriteLine(Lyrics[CurrentIndex].Item2);
                    Task.Factory.StartNew(() =>
                    {
                        Line5.Invoke((MethodInvoker)delegate ()
                        {
                            Line5.Text = Lyrics[CurrentIndex].Item2;
                            if (CurrentIndex >= 1 && CurrentIndex <= Lyrics.Count - 2)
                            {
                                Line4.Text = Lyrics[CurrentIndex - 1].Item2;
                                Line6.Text = Lyrics[CurrentIndex + 1].Item2;
                            }
                        });
                    });
                }
            }
        }

        public void SkipCurrentIndex(int CurrentTime)
        {
            try
            {
                if (IsSync)
                    while (CurrentIndex + 1 < Lyrics.Count &&
                    Lyrics[CurrentIndex + 1].Item1 < CurrentTime) CurrentIndex++;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void BackCurrentIndex(int CurrentTime)
        {
            try
            {
                if (IsSync)
                    while (CurrentIndex - 1 >= 0 &&
                    Lyrics[CurrentIndex - 1].Item1 > CurrentTime) CurrentIndex--;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private int FstIndex;
        private int LstIndex;
        private int CurrentIndex;
        private int LineNumber = 1;
        private bool IsSync = false;
        private bool HasLyrics = false;
        private JObject JSONResultObject;
        private List<(int?, string)> Lyrics;
        private Watcher Watcher = new Watcher();
    }
}
