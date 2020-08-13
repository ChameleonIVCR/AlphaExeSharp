using System;
using System.IO;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using TGASharpLib;

namespace AlphaExeC {
    //Handle form events here
    public partial class MainForm : Form {
        public MainForm() {
            //Start main form
            InitializeComponent();
        }
        
        //Write to the statusTextBox
        public void WritetoStatus(string status) {
            statusTextBox.SelectionStart = 0;
            statusTextBox.SelectionLength = 0;
            statusTextBox.SelectedText = status;
        }

        //Make a thumbnail and set it as preview
        public void getThumbnail(string path) {
            try {
                //TGA images need special loading using TGASharpLib
                if (path.ToLower().EndsWith(".tga")) {
                    var tga = new TGA(path);
                    var bitmap = (Bitmap)tga;
                    previewBox.Image = bitmap
                        .GetThumbnailImage(135, 135, ()=>false, IntPtr.Zero);

                    //Queue to the garbage collector
                    bitmap.Dispose();
                }
                else {
                    Image src = Image.FromFile(path);
                    previewBox.Image = src
                        .GetThumbnailImage(135, 135, ()=>false, IntPtr.Zero);

                    src.Dispose();
                }
            }
            //Memory overflow from big images, TODO replace with a image size check
            catch(Exception) {
                previewBox.Image = null;
            }
        }
        
        //Called when the selected item changes in the list
        private void imageListSelectedIndexChange(object sender, EventArgs e) {

            string path = System.String.Empty;

            //TODO replace with a 0 index selection
            foreach (ListViewItem item in imageList.SelectedItems) {
                path = item.Text;
            }

            //Run in a thread to avoid blocking the app as thumbnail generates
            Thread thread = new Thread(() => getThumbnail(path));
            thread.Start();
        }
        
        //Input related stuff
        
        private void inputBrowseClick(object sender, EventArgs e) {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                inputTextBot.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        
        void inputAddClick(object sender, EventArgs e) {
            string path = inputTextBot.Text;
            if (!String.IsNullOrEmpty(path)  &&  Directory.Exists(path)) {

                int filecount = 0;
                string[] filestoadd = Directory.GetFiles(path); 
                string[] formats = new string[inputFormatDropdown.Items.Count];
                if (allowMoreFormatsCheckbox.Checked == false) {
                    formats[0] = inputFormatDropdown.Text.ToLower();
                    Array.Resize(ref formats, 1);
                }
                else {
                    for(int i = 0; i < inputFormatDropdown.Items.Count; i++) {
                        formats[i] = inputFormatDropdown.Items[i].ToString().ToLower();
                    }
                }
                foreach(string item in filestoadd) {
                string itemlower = item.ToLower();
                    foreach (string format in formats) {
                        if (itemlower.EndsWith("."+format) 
                            && imageList.FindItemWithText(itemlower) == null) {
                            
                            imageList.Items.Add(item);
                            filecount++;
                            }
                    }
                }
                WritetoStatus(filecount.ToString()+" files added.\n");
            }
            else {
                //Add textbox empty warning to status
                WritetoStatus("Please select a valid folder first.\n");
            }
        }
        
        //Ouput related stuff
        
        void outputBrowseButtonClick(object sender, System.EventArgs e) {
            //TODO set output folder directly to outputTextBox after selecting folder
            
        }

		//Toolbar
        
        void convertButtonClick(object sender, EventArgs e) {
            FuncLibrary.Convert("D:\\example.tga", System.String.Empty, "JPG", true, 100);
        }
        
        void clearButtonClick(object sender, EventArgs e) {
            imageList.Items.Clear();
            previewBox.Image = null;
            statusTextBox.Clear();
        }
        
        void stopButtonClick(object sender, System.EventArgs e) {
            
        }
        
        
        void optionsButtonClick(object sender, EventArgs e) {
            
        }
        
        void helpButtonClick(object sender, System.EventArgs e) {
            
        }
        
        void aboutButtonClick(object sender, System.EventArgs e) {
            
        }
        
        void licenseButtonClick(object sender, System.EventArgs e) {
            
        }
    }
}