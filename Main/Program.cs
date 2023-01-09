using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyMediaPlayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                if (((Exception)e.ExceptionObject).HResult != unchecked((int)0x8001010A))
                    ModalBox.Show("Error", ((Exception)e.ExceptionObject).Message);
            };

            Application.ThreadException += (s, e) =>
            {
                if (e.Exception.HResult != unchecked((int)0x8001010A))
                    ModalBox.Show("Error", e.Exception.Message);
            };

            Application.Run(new MainForm(args));
        }
    }
}
