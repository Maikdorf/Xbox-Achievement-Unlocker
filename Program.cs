using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xbox_Achievement_Unlocker.Class.Objects;
using static System.Windows.Forms.DataFormats;

namespace Xbox_Achievement_Unlocker
{
    static class Program
    {
        public static StartApp startApp = new();
        public static MainWindow mainWindow = new();
        public static Main main = new();
        private static Color _primaryColor = Color.FromArgb(0, 111, 219);
        private static Color _primaryDarkColor = Color.FromArgb(0, 56, 110);
        private static Color _primaryLigthColor = Color.FromArgb(64, 147, 228);
        private static Color _darkColor = Color.FromArgb(0, 0, 0);
        private static Color _ligthColor = Color.FromArgb(255, 255, 255);
        public static Color PrimaryColor { get => _primaryColor; set => _primaryColor = value; }
        public static Color PrimaryDarkColor { get => _primaryDarkColor; set => _primaryDarkColor = value; }
        public static Color PrimaryLigthColor { get => _primaryLigthColor; set => _primaryLigthColor = value; }
        public static Color DarkColor { get => _darkColor; set => _darkColor = value; }
        public static Color LigthColor { get => _ligthColor; set => _ligthColor = value; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainWindow);
        }
    }
}
