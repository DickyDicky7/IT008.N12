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
                return Properties.Resources.mp3;
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

        /// <summary>
        /// Darker Blue
        /// </summary>
        public static Color _1D3557_ { get; } = ColorTranslator.FromHtml("#1D3557");

        /// <summary>
        /// Blue
        /// </summary>
        public static Color _457B9D_ { get; } = ColorTranslator.FromHtml("#457B9D");

        /// <summary>
        /// Lighter Blue
        /// </summary>
        public static Color _A8DADC_ { get; } = ColorTranslator.FromHtml("#A8DADC");

        /// <summary>
        /// White
        /// </summary>
        public static Color _F1FAEE_ { get; } = ColorTranslator.FromHtml("#F1FAEE");

        /// <summary>
        /// Red
        /// </summary>
        public static Color _E63946_ { get; } = ColorTranslator.FromHtml("#E63946");



    }
}