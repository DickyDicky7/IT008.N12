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

namespace Common
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
            byte[] MetaData = Picture.Data.Data;
            Stream.Write(MetaData, 0, Convert.ToInt32(MetaData.Length));
            Image Image = new Bitmap(Stream, false);
            Stream.Dispose();
            return Image;
        }

        public static string GetTitle(string MediaURL)
        {
            TagLib.File Media = TagLib.File.Create(MediaURL);
            return Media.Tag.Title;
        }

        public static string[] GetPerformers(string MediaURL)
        {
            TagLib.File Media = TagLib.File.Create(MediaURL);
            return Media.Tag.Performers;
        }
    }
}