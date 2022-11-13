using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Xml.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace IT008.N12_015
{
    /// <summary>
    /// Common functions, ultilities
    /// </summary>
    class Common
    {
        /// <summary>
        /// Get image from a media file 
        /// </summary>
        /// <param name="MediaURL">Media's file path</param>
        public static Image GetImage(string MediaURL)
        {
            TagLib.File Media = TagLib.File.Create(MediaURL);
            MemoryStream Stream = new MemoryStream();
            TagLib.IPicture Picture = Media.Tag.Pictures.FirstOrDefault();
            if (Picture == null)
                return Properties.Resources.disc;
            byte[] MetaData = Picture.Data.Data;
            Stream.Write(MetaData, 0, Convert.ToInt32(MetaData.Length));
            Image Image = new Bitmap(Stream, false);
            Stream.Dispose();
            return Image;
        }

        /// <summary>
        /// Get media's title
        /// </summary>
        /// <param name="MediaURL">Media's file path</param>
        /// <returns></returns>
        public static string GetTitle(string MediaURL)
        {
            TagLib.File Media = TagLib.File.Create(MediaURL);
            if (Media.Tag.IsEmpty)
                return MediaURL.Substring(MediaURL.LastIndexOf('\\') + 1);
            return Media.Tag.Title;
        }

        /// <summary>
        /// Get media's artists
        /// </summary>
        /// <param name="MediaURL">Media's file path</param>
        /// <returns></returns>
        public static string GetPerformers(string MediaURL)
        {
            TagLib.File Media = TagLib.File.Create(MediaURL);
            if (Media.Tag.IsEmpty)
                return "-- Unknown --";
            else
            if (Media.Tag.Performers.Length == 1)
                return $"-- {Media.Tag.Performers.First()} --";
            else
                return
                $"-- {Media.Tag.Performers.Aggregate((Performers, Performer) => $"{Performers} & Performer")} --";
        }

        /// <summary>
        /// Get media's total duration in seconds
        /// </summary>
        /// <param name="MediaURL">Media's file path</param>
        /// <returns></returns>
        public static int GetDurationInSeconds(string MediaURL)
        {
            TagLib.File Media = TagLib.File.Create(MediaURL);
            return (int)Media.Properties.Duration.TotalSeconds;
        }

        /// <summary>
        /// Rounded control corner
        /// </summary>
        /// <param name="control">Control need to be rounded corner</param>
        public static void RoundedCorner(Control control)
        {
            int buildNumber = Environment.OSVersion.Version.Build;
            if (buildNumber >= WINDOW11_BUILD_NUMBER)
            {
                var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
                var preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
                DwmSetWindowAttribute(control.Handle, attribute, ref preference, sizeof(uint));
            }
            
        }

        public static async Task SetInterval(Action action, TimeSpan timeout)
        {
            await Task.Delay(timeout).ConfigureAwait(false);
            action();
            SetInterval(action, timeout);
        }

        public static async Task SetTimeout(Action action, TimeSpan timeout)
        {
            await Task.Delay(timeout).ConfigureAwait(false);
            action();
        }
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;
            System.Reflection.PropertyInfo aProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            aProp.SetValue(c, true, null);
        }

        #region Rounded_corner
        public enum DWMWINDOWATTRIBUTE
        {
            DWMWA_WINDOW_CORNER_PREFERENCE = 33
        }

        // The DWM_WINDOW_CORNER_PREFERENCE enum for DwmSetWindowAttribute's third parameter, which tells the function
        // what value of the enum to set.
        // Copied from dwmapi.h
        public enum DWM_WINDOW_CORNER_PREFERENCE
        {
            DWMWCP_DEFAULT = 0,
            DWMWCP_DONOTROUND = 1,
            DWMWCP_ROUND = 2,
            DWMWCP_ROUNDSMALL = 3
        }

        // Import dwmapi.dll and define DwmSetWindowAttribute in C# corresponding to the native function.
        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        internal static extern void DwmSetWindowAttribute(IntPtr hwnd,
                                                         DWMWINDOWATTRIBUTE attribute,
                                                         ref DWM_WINDOW_CORNER_PREFERENCE pvAttribute,
                                                         uint cbAttribute);
        #endregion

        public const int WINDOW11_BUILD_NUMBER = 22000;

        public static Color Black { get; } = ColorTranslator.FromHtml("#161A1D");

        public static Color White { get; } = ColorTranslator.FromHtml("#FFFFFF");

        public static Color LightRed { get; } = ColorTranslator.FromHtml("#BA181B");

        public static Color DarkRed { get; } = ColorTranslator.FromHtml("#660708");

        public static Color Gray { get; } = ColorTranslator.FromHtml("#D3D3D3");

        /// <summary>
        /// Music Folder's path: %HOMEPATH%\Music 
        /// </summary>
        public static string MusicFolder = 
        Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

        /// <summary>
        /// Playlists Folder's path: %HOMEPATH%\Music\Playlists
        /// </summary>
        public static string PlaylistsFolder = $"{MusicFolder}\\Playlists";
    }
}