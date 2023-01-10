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

            Application.ThreadException += (sender, e) =>
            {
                if (e.Exception.HResult != unchecked((int)0x8001010A))
                    ModalBox.Show("Error", $@"{e.Exception.Message},
                    {e.Exception.StackTrace}");
            };

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.Automatic);

            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                if (((Exception)e.ExceptionObject).HResult != unchecked((int)0x8001010A))
                    ModalBox.Show("Error", @$"{((Exception)e.ExceptionObject).Message}
                    , {((Exception)e.ExceptionObject).StackTrace}");
            };

            AppDomain.CurrentDomain.FirstChanceException += (sender, e) =>
            {
                Console.WriteLine(@$"{e.Exception.Message}
                , {e.Exception.StackTrace}
                , {e.Exception.Source}
                , {e.Exception.HResult}");
            };

            Application.Run(new MainForm(args));
        }
    }
}
