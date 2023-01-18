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
        private static Dictionary<string, FileSystemWatcher> FileSystemWatchers
                 = new Dictionary<string, FileSystemWatcher>();

        public static void Subscribe(string Path)
        {
            FileSystemWatchers.Add(Path, new FileSystemWatcher(Path)
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
            FileSystemWatchers[Path].Error += (sender, e) =>
            {
                Exception Error = e.GetException();
                ModalBox.Show("Error", $@"
                - {Error.Message}
                - {Error.HResult}
                - {Error.StackTrace}
                - .");
            };
        }

        public static void Unsubscribe(string Path)
        {
            if (FileSystemWatchers.ContainsKey(Path))
            {
                FileSystemWatchers[Path].Dispose();
                FileSystemWatchers[Path] = null;
                FileSystemWatchers.Remove(Path);
            }
        }

        public static void Register
        (Event Event, Action<object, FileSystemEventArgs> Handler, string Path)
        {
            if (FileSystemWatchers.ContainsKey(Path))
            {
                if (Event is Event.All || Event is Event.Changed)
                    FileSystemWatchers[Path].Changed += new FileSystemEventHandler(Handler);
                if (Event is Event.All || Event is Event.Created)
                    FileSystemWatchers[Path].Created += new FileSystemEventHandler(Handler);
                if (Event is Event.All || Event is Event.Deleted)
                    FileSystemWatchers[Path].Deleted += new FileSystemEventHandler(Handler);
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
