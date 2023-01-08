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
    public partial class TrackLyrics : UserControl
    {
        public TrackLyrics()
        {
            InitializeComponent();

            MouseWheel += new MouseEventHandler(TrackLyrics_MouseWheel);

            foreach (Label Line in Controls.OfType<Label>())
                Line.Text = string.Empty;
        }

        private void TrackLyrics_MouseWheel(object sender, MouseEventArgs e)
        {
            if (IsSync) return;

            if (e?.Delta > 0 && Lyrics.Count != 0)
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

            if (e?.Delta < 0 && Lyrics.Count != 0)
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

                if (FirstTime && Lyrics.Count == 0)
                    ((Label)Controls.Find($"Line{LineNumber}", false)
                    .FirstOrDefault()).Text = String.Empty;
                else
                    ((Label)Controls.Find($"Line{LineNumber}", false)
                    .FirstOrDefault()).Text = Lyrics[CurrentIndex][0];

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
            Lyrics.Clear();

            TagLib.File File = TagLib.File.Create(MediaURL);
            if (File.Tag.Lyrics == null)
            {
                BackgroundImage = Properties.Resources.not_found;
            }
            else
            {
                IsSync = false;
                Watcher.Stop();

                FstIndex = 0;
                LstIndex = Controls.OfType<Label>().Count() - 1;

                CurrentIndex = 0;
                File.Tag.Lyrics.Split(new string[] { "\n", "," }, StringSplitOptions.None)
                .ToList().ForEach(Lyric =>
                {
                    Lyrics.Add(CurrentIndex, new List<string>() { Lyric });
                    CurrentIndex++;
                });

                BackgroundImage = null;
            }

            Render(true);

            File.Dispose();
        }

        public async void ParseStreamingLyrics(string JSONResult)
        {
            await Task.Factory.StartNew(() =>
            {
                Lyrics.Clear();

                if (JSONResult == null)
                {
                    return;
                }

                JSONResultObject = JObject.Parse(JSONResult);

                JSONResultObject["data"]?["sentences"]?.Children().ToList().ForEach(Child =>
                {
                    TempTimeInSeconds = Child["words"].Children().First()["startTime"]
                    .Value<int?>() / 1000;
                    TempLyric = Child["words"].Children().Select(Item => Item["data"]
                    .Value<string>()).Aggregate((Word, Lyric) => $"{Word} {Lyric}");

                    if (Lyrics.ContainsKey(TempTimeInSeconds))
                        Lyrics[TempTimeInSeconds].Add(TempLyric);
                    else
                        Lyrics.Add(TempTimeInSeconds, new List<string>() { TempLyric });
                });

                IsSync = Lyrics.Count != 0;
            });

            if (IsSync)
            {
                foreach (Label Line in Controls.OfType<Label>())
                    Line.Text = string.Empty;

                Watcher.Interval = TimeSpan.FromMilliseconds(10);
                Watcher.Action = OnStreaming;
                Watcher.Start();

                BackgroundImage = null;
            }
            else
            {
                foreach (Label Line in Controls.OfType<Label>())
                    Line.Text = string.Empty;

                BackgroundImage = Properties.Resources.not_found;
            }
        }

        private void OnStreaming()
        {
            if (IsSync)
            {
                TempTimeInSeconds = GlobalReferences.MediaController.PlayerControlsCurrentPosition;
                if (Lyrics.ContainsKey(TempTimeInSeconds))
                {
                    Task.Factory.StartNew(() =>
                    {
                        if (IsHandleCreated)
                        {
                            Line4.BeginInvoke((MethodInvoker)delegate ()
                            {
                                Line4.Text = Lyrics[TempTimeInSeconds][0];
                                if (Lyrics[TempTimeInSeconds].Count == 2)
                                {
                                    Line5.Text = Lyrics[TempTimeInSeconds][1];
                                }
                                else
                                {
                                    Line5.Text = string.Empty;
                                }
                                //if (Lyrics[TempTimeInSeconds].Count == 3)
                                //{
                                //    Line5.Text = Lyrics[TempTimeInSeconds][1];
                                //    Line6.Text = Lyrics[TempTimeInSeconds][2];
                                //}
                                //else
                                //{
                                //    Line6.Text = string.Empty;
                                //}
                            });
                        }
                    });
                }
            }
        }

        private int FstIndex;
        private int LstIndex;
        private string TempLyric;
        private int CurrentIndex;
        private int LineNumber = 1;
        private bool IsSync = false;
        private int? TempTimeInSeconds;
        private JObject JSONResultObject;
        private readonly Watcher Watcher = new Watcher();
        private readonly Dictionary<int?, List<string>> Lyrics =
                     new Dictionary<int?, List<string>>();
    }
}
