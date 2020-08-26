
using System;
using System.Drawing;
using System.Windows.Forms;
using AlphaExeC.utils;

namespace AlphaExeC {
    public partial class Options : Form {
        public Options() {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //load config
            Configuration config = Program.getConfiguration();
            pixelFormatDropdown.SelectedIndex = config.PixelFormat;
            qualityNumberInput.Value = config.Quality;
            qualityBar.Value = config.Quality;
            alphaCheckBox.Checked = config.AllowAllInputFormats;
            replaceRGBwithA.Checked = config.ReplaceRGBwithA;
            rgbDropdown.SelectedIndex = config.DXTRgbFormat;
            aDropdown.SelectedIndex = config.DXTAlphaFormat;
            dxtCompressionDropdown.SelectedIndex = config.DXTCompression;
        }
        
        private void qualityNumberInputChanged(object sender, EventArgs e) {
            qualityBar.Value = (int) qualityNumberInput.Value;
        }
        
        private void qualityBarScroll(object sender, System.EventArgs e) {
            qualityNumberInput.Value = qualityBar.Value;
        }
        private void SaveButtonClick(object sender, EventArgs e) {
            Configuration config = Program.getConfiguration();
            config.PixelFormat = pixelFormatDropdown.SelectedIndex;
            config.Quality = (int) qualityNumberInput.Value;
            config.AllowAllInputFormats = alphaCheckBox.Checked;
            config.ReplaceRGBwithA = replaceRGBwithA.Checked;
            config.DXTRgbFormat = rgbDropdown.SelectedIndex;
            config.DXTAlphaFormat = aDropdown.SelectedIndex;
            config.DXTCompression = dxtCompressionDropdown.SelectedIndex;
            this.Close();
        }
    }
}
