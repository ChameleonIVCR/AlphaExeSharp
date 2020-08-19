using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace AlphaExeC {
    //Handle form events here
    public partial class MainForm : Form {
        private static Dictionary<int, ConvertImage.ImportedImage> imageStash;
        private static ImageList thumbnailList;
        private static int counter = 0;
        
        public MainForm() {
            //Start main form
            InitializeComponent();
            imageStash = new Dictionary<int, ConvertImage.ImportedImage>();
            thumbnailList = new ImageList();
            thumbnailList.ImageSize = new Size(64, 64);
            //temporary fix until we have config class.
            inputFormatDropdown.SelectedIndex = 0;
            outputFormatDropdown.SelectedIndex = 0;
        }
        
        //Called when the selected item changes in the list
        private void imageListSelectedIndexChange(object sender, EventArgs e) {

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
                //formats[0] = inputFormatDropdown.Text.ToLower();
                formats[0] = "png";
                Array.Resize(ref formats, 1);
                
                foreach(string item in filestoadd) {
                string itemlower = item.ToLower();
                    foreach (string format in formats) {
                        if (itemlower.EndsWith("."+format) && imageList.FindItemWithText(itemlower) == null) {
                        
                            imageStash.Add(counter, new ConvertImage.ImportedImage(item));
                            thumbnailList.Images.Add(imageStash[counter].fetchThumbnail());
                            counter++;
                        }
                    }
                }
                imageList.LargeImageList = thumbnailList;
                for (int j = 0; j < thumbnailList.Images.Count; j++)
                {
                    ListViewItem item = new ListViewItem(Path.GetFileNameWithoutExtension(imageStash[j].getPath()));
                    item.ImageIndex = j;
                    imageList.Items.Add(item);
                }
                //imageList.LargeImageList = thumbnailList;
            }
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
//                string selectedImagePath = imageList.SelectedItems[0].Text;
//                FuncLibrary.Convert(selectedImagePath, outputPath, outputFormatDropdown.SelectedItem.ToString(), true, 100);
                ConvertImage.ImportedImage.setConversionVariables(outputPath, "jpg", 80);
                foreach(KeyValuePair<int, ConvertImage.ImportedImage> kvp in imageStash){
                    Console.WriteLine(kvp.Value.getPath());
                    kvp.Value.convert();
                }
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
            thumbnailList.Images.Clear();
            imageStash.Clear();
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