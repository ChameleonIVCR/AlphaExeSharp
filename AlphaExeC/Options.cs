
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlphaExeC {
    public partial class Options : Form {
        public Options() {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        
        private void qualityNumberInputChanged(object sender, EventArgs e) {
            qualityBar.Value = (int) qualityNumberInput.Value;
        }
        
        private void qualityBarScroll(object sender, System.EventArgs e) {
            qualityNumberInput.Value = qualityBar.Value;
        }
    }
}
