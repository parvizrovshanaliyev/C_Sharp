

using System;
using System.Net.Mime;

namespace WindowsFormsApp.TransferDataBetweenForms3
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MediaTypeNames.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            MediaTypeNames.Application.EnableVisualStyles();
            MediaTypeNames.Application.SetCompatibleTextRenderingDefault(false);
            MediaTypeNames.Application.Run(new Login());
        }
    }
}
