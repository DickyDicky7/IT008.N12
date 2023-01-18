using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    public static class FileSystemWatcherService
    {
        private static Dictionary<string, Dictionary<string, FileSystemWatcher>> FileSystemWatchers
                 = new Dictionary<string, Dictionary<string, FileSystemWatcher>>();

        public static void Subscribe(string Path, string FilterPattern)
        {
            if (FileSystemWatchers.ContainsKey(Path))
            {
                if (!FileSystemWatchers[Path].ContainsKey(FilterPattern))
                {
                    FileSystemWatchers[Path].Add(FilterPattern,
                    new FileSystemWatcher(Path, FilterPattern)
                    {
                        IncludeSubdirectories = false,
                        EnableRaisingEvents = true,
                        NotifyFilter
                        = NotifyFilters.DirectoryName
                        | NotifyFilters.CreationTime
                        | NotifyFilters.Attributes
                        | NotifyFilters.LastAccess
                        | NotifyFilters.LastWrite
                        | NotifyFilters.Security
                        | NotifyFilters.FileName
                        | NotifyFilters.Size,
                    });
                    //FileSystemWatchers[Path][FilterPattern].Error += (sender, e) =>
                    //{
                    //    Exception Error = e.GetException();
                    //    ModalBox.Show("Error", $@"
                    //    - {Error.Message}
                    //    - {Error.HResult}
                    //    - {Error.StackTrace}
                    //    - .");
                    //};
                }
            }
            else
            {
                FileSystemWatchers.Add(Path, new Dictionary<string, FileSystemWatcher>()
                {
                    {
                        FilterPattern
                    ,   new FileSystemWatcher(Path, FilterPattern)
                        {
                            IncludeSubdirectories = false,
                            EnableRaisingEvents = true,
                            NotifyFilter
                            = NotifyFilters.DirectoryName
                            | NotifyFilters.CreationTime
                            | NotifyFilters.Attributes
                            | NotifyFilters.LastAccess
                            | NotifyFilters.LastWrite
                            | NotifyFilters.Security
                            | NotifyFilters.FileName
                            | NotifyFilters.Size,
                        }
                    }
                });
                //FileSystemWatchers[Path][FilterPattern].Error += (sender, e) =>
                //{
                //    Exception Error = e.GetException();
                //    ModalBox.Show("Error", $@"
                //    - {Error.Message}
                //    - {Error.HResult}
                //    - {Error.StackTrace}
                //    - .");
                //};
            }
        }

        public static void Unsubscribe(string Path, string FilterPattern)
        {
            if (FileSystemWatchers.ContainsKey(Path))
            {
                if (FileSystemWatchers[Path].ContainsKey(FilterPattern))
                {
                    FileSystemWatchers[Path][FilterPattern].Dispose();
                    FileSystemWatchers[Path][FilterPattern] = null;
                    FileSystemWatchers[Path].Remove(FilterPattern);
                }
                if (FileSystemWatchers[Path].Count == 0)
                {
                    FileSystemWatchers.Remove(Path);
                }
            }
        }

        public static void Register
        (Event Event, Action<object, FileSystemEventArgs> Handler, string Path, string FilterPattern)
        {
            if (FileSystemWatchers.ContainsKey(Path))
            {
                if (FileSystemWatchers[Path].ContainsKey(FilterPattern))
                {
                    if (Event is Event.All || Event is Event.Changed)
                        FileSystemWatchers[Path][FilterPattern].Changed += new FileSystemEventHandler(Handler);
                    if (Event is Event.All || Event is Event.Created)
                        FileSystemWatchers[Path][FilterPattern].Created += new FileSystemEventHandler(Handler);
                    if (Event is Event.All || Event is Event.Deleted)
                        FileSystemWatchers[Path][FilterPattern].Deleted += new FileSystemEventHandler(Handler);
                }
            }
        }

        public enum Event
        {
            All,
            Changed,
            Created,
            Deleted,
        }
    }
}
