﻿using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TGASharpLib;

namespace AlphaExeC {
    //Handle form events here
    public partial class MainForm : Form {
        public MainForm() {
            //Start main form
            InitializeComponent();
            inputFormatDropdown.SelectedIndex = 0;
            outputFormatDropdown.SelectedIndex = 0;
        }
        
        //Called when the selected item changes in the list
        private void imageListSelectedIndexChange(object sender, EventArgs e) {

//            string path = System.String.Empty;
//
//            foreach (ListViewItem item in imageList.SelectedItems) {
//                path = item.Text;
//            }
//
//            //Run in a thread to avoid blocking the app as thumbnail generates
//            Thread thread = new Thread(() => getThumbnail(path));
//            thread.Start();
        }
        
        //Input related stuff
        
        void inputBrowseClick(object sender, EventArgs e) {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                inputTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        
        void inputAddClick(object sender, EventArgs e) {
            string path = inputTextBox.Text;
            if (!String.IsNullOrEmpty(path)  &&  Directory.Exists(path)) {

                string[] filestoadd = Directory.GetFiles(path); 
                string[] formats = new string[inputFormatDropdown.Items.Count];
                //TODO get this from configuration
//                if (allowMoreFormatsCheckbox.Checked == false) {
                    formats[0] = inputFormatDropdown.Text.ToLower();
                    Array.Resize(ref formats, 1);
//                }
//                else {
//                    for(int i = 0; i < inputFormatDropdown.Items.Count; i++) {
//                        formats[i] = inputFormatDropdown.Items[i].ToString().ToLower();
//                    }
                foreach(string item in filestoadd) {
                string itemlower = item.ToLower();
                    foreach (string format in formats) {
                        if (itemlower.EndsWith("."+format) 
                            && imageList.FindItemWithText(itemlower) == null) {
                            
                            imageList.Items.Add(item);
                        }
                    }
                }
//                WritetoStatus(filecount.ToString()+" files added.\n");
            }
//            else {
                //Add textbox empty warning to status
//                WritetoStatus("Please select a valid folder first.\n");
//            }
        }
        
        //Ouput related stuff
        
        void outputBrowseButtonClick(object sender, System.EventArgs e) {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                outputTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

		//Toolbar
        
        void convertButtonClick(object sender, EventArgs e) {
            try {
                string outputPath = outputTextBox.Text;
//                if (writeToInputFolderCheckbox.Checked) {
//                    outputPath = inputTextBox.Text;
//                } else {
//                    outputPath = outputTextBox.Text;
//                }
                string selectedImagePath = imageList.SelectedItems[0].Text;
                FuncLibrary.Convert(selectedImagePath, outputPath, outputFormatDropdown.SelectedItem.ToString(), true, 100);
                //TODO better error handling
            } catch (ArgumentException) {
                MessageBox.Show("You need to specify one image", "Error");

            } catch (NullReferenceException) {
                MessageBox.Show("Specify output.", "Error");

            } catch (Exception error) {
                MessageBox.Show(error.Message, "Error");
            }
        }
        
        void clearButtonClick(object sender, EventArgs e) {
            imageList.Items.Clear();
//            previewBox.Image = null;
//            statusTextBox.Clear();
        }
        
        void stopButtonClick(object sender, System.EventArgs e) {
            
        }
        
        
        void optionsButtonClick(object sender, EventArgs e) {
		    new Options().ShowDialog();
        }
        
        void helpButtonClick(object sender, System.EventArgs e) {
            new AlphaExeC.ui.Help().ShowDialog();
        }
        
        void aboutButtonClick(object sender, System.EventArgs e) {
            new AlphaExeC.ui.About().ShowDialog();
        }
        
        void licenseButtonClick(object sender, System.EventArgs e) {
            
        }
    }
}