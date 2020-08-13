/*
 * Created by SharpDevelop.
 * User: Chame
 * Date: 31/05/2020
 * Time: 13:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using TGASharpLib;

namespace AlphaExeC
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		public void WritetoStatus(string status)
		{
			statusTextBox.SelectionStart = 0;
	        statusTextBox.SelectionLength = 0;
	        statusTextBox.SelectedText = status;
	 	}
		
		public void getThumbnail(string path)
		{
			try
			{
				if (path.ToLower().EndsWith(".tga"))
				{
					var tga = new TGA(path);
					var bitmap = (Bitmap)tga;
					pictureBox1.Image = bitmap.GetThumbnailImage(135, 135, ()=>false, IntPtr.Zero);
					bitmap.Dispose();
				}
				else
				{
					Image src = Image.FromFile(path);
					pictureBox1.Image = src.GetThumbnailImage(135, 135, ()=>false, IntPtr.Zero);
					src.Dispose();
				}
			}
			catch(Exception a)
			{
				pictureBox1.Image = null;
			}
		}
		
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

			var index = listView1.SelectedItems;
			string path = System.String.Empty;
			foreach ( ListViewItem item in index )
		    {
				path = item.Text;
		    }
			Thread thread = new Thread(() => getThumbnail(path));
			thread.Start();
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
			pictureBox1.Image = null;
			statusTextBox.Clear();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			FuncLibrary.Convert("D:\\example.tga", System.String.Empty, "JPG", true, 100);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
		    {
		        textBox2.Text = folderBrowserDialog1.SelectedPath;
		    }
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string path = textBox2.Text;
			if (!String.IsNullOrEmpty(path)  &&  Directory.Exists(path))
			{
				int filecount = 0;
				string[] filestoadd = Directory.GetFiles(path); 
				string[] formats = new string[comboBox2.Items.Count];
				if (checkBox4.Checked == false)
			    {
					formats[0] = comboBox2.Text.ToLower();
					Array.Resize(ref formats, 1);
			    }
				else
				{
					for(int i = 0; i < comboBox2.Items.Count; i++)
					{
						formats[i] = comboBox2.Items[i].ToString().ToLower();
					}
				}
				foreach(string item in filestoadd)
				{
				string itemlower = item.ToLower();
					foreach (string format in formats)
				    {
						if (itemlower.EndsWith("."+format) && listView1.FindItemWithText(itemlower) == null)
							{
				            listView1.Items.Add(item);
							filecount++;
							}
				    }
				}
				WritetoStatus(filecount.ToString()+" files added.\n");
			}
			else
			{
				//Add textbox empty warning to status
		        WritetoStatus("Please select a valid folder first.\n");
			}
		}
	}
}

