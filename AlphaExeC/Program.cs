using System;
using System.Windows.Forms;

namespace AlphaExeC {
    internal sealed class Program {
    [STAThread]
        private static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Start the form
            Application.Run(new MainForm());
        }

    }
}