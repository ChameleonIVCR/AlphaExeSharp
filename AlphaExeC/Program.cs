using System;
using System.Windows.Forms;
using AlphaExeC.utils;

namespace AlphaExeC {
    internal sealed class Program {
        private static Configuration config;
        
        public static Configuration getConfiguration(){
            return config;
        }
        
    [STAThread]
        private static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Start the form
            config = new Configuration("main");
            Application.Run(new MainForm());
        }

    }
}