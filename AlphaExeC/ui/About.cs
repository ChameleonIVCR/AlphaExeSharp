
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlphaExeC.ui {
    public partial class About : Form {
        public About() {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        
        void chameLabelClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/ChameleonIVCR");
        }
        
        void zonalLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/iamawesome99");
        }
        
        void viruzLabelClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/Viruzaum");
        }
        
        void githubLabelClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ChameleonIVCR/AlphaExeSharp");
        }
    }
}
