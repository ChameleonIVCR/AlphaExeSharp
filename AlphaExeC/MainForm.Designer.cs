/*
 * Created by SharpDevelop.
 * User: Chame
 * Date: 31/05/2020
 * Time: 13:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AlphaExeC
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button10 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.topsplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.inputgroupBox1 = new System.Windows.Forms.GroupBox();
			this.inputsplitContainer = new System.Windows.Forms.SplitContainer();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.outputgroupBox2 = new System.Windows.Forms.GroupBox();
			this.outputsplitContainer = new System.Windows.Forms.SplitContainer();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.listView1 = new System.Windows.Forms.ListView();
			this.file = new System.Windows.Forms.ColumnHeader();
			this.statusTextBox = new System.Windows.Forms.RichTextBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.topsplitContainer1)).BeginInit();
			this.topsplitContainer1.Panel1.SuspendLayout();
			this.topsplitContainer1.Panel2.SuspendLayout();
			this.topsplitContainer1.SuspendLayout();
			this.inputgroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.inputsplitContainer)).BeginInit();
			this.inputsplitContainer.Panel1.SuspendLayout();
			this.inputsplitContainer.Panel2.SuspendLayout();
			this.inputsplitContainer.SuspendLayout();
			this.outputgroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.outputsplitContainer)).BeginInit();
			this.outputsplitContainer.Panel1.SuspendLayout();
			this.outputsplitContainer.Panel2.SuspendLayout();
			this.outputsplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.button10);
			this.panel1.Controls.Add(this.button9);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Location = new System.Drawing.Point(12, 121);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1121, 29);
			this.panel1.TabIndex = 4;
			// 
			// button10
			// 
			this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button10.Location = new System.Drawing.Point(1043, 3);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(75, 23);
			this.button10.TabIndex = 6;
			this.button10.Text = "License";
			this.button10.UseVisualStyleBackColor = true;
			// 
			// button9
			// 
			this.button9.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button9.Location = new System.Drawing.Point(865, 3);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(75, 23);
			this.button9.TabIndex = 5;
			this.button9.Text = "About";
			this.button9.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this.button8.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button8.Location = new System.Drawing.Point(689, 3);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 4;
			this.button8.Text = "Help";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button7.Location = new System.Drawing.Point(520, 3);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 3;
			this.button7.Text = "Options";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button6.Location = new System.Drawing.Point(353, 3);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 2;
			this.button6.Text = "Clear";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button5
			// 
			this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button5.Enabled = false;
			this.button5.Location = new System.Drawing.Point(171, 3);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 1;
			this.button5.Text = "Stop";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(6, 3);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 0;
			this.button4.Text = "Convert";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// topsplitContainer1
			// 
			this.topsplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.topsplitContainer1.IsSplitterFixed = true;
			this.topsplitContainer1.Location = new System.Drawing.Point(12, 12);
			this.topsplitContainer1.Name = "topsplitContainer1";
			// 
			// topsplitContainer1.Panel1
			// 
			this.topsplitContainer1.Panel1.Controls.Add(this.inputgroupBox1);
			// 
			// topsplitContainer1.Panel2
			// 
			this.topsplitContainer1.Panel2.Controls.Add(this.outputgroupBox2);
			this.topsplitContainer1.Size = new System.Drawing.Size(1118, 102);
			this.topsplitContainer1.SplitterDistance = 557;
			this.topsplitContainer1.SplitterWidth = 1;
			this.topsplitContainer1.TabIndex = 3;
			// 
			// inputgroupBox1
			// 
			this.inputgroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.inputgroupBox1.Controls.Add(this.inputsplitContainer);
			this.inputgroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputgroupBox1.Location = new System.Drawing.Point(3, 3);
			this.inputgroupBox1.Name = "inputgroupBox1";
			this.inputgroupBox1.Size = new System.Drawing.Size(553, 95);
			this.inputgroupBox1.TabIndex = 0;
			this.inputgroupBox1.TabStop = false;
			this.inputgroupBox1.Text = "Input";
			// 
			// inputsplitContainer
			// 
			this.inputsplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.inputsplitContainer.IsSplitterFixed = true;
			this.inputsplitContainer.Location = new System.Drawing.Point(3, 16);
			this.inputsplitContainer.Name = "inputsplitContainer";
			this.inputsplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// inputsplitContainer.Panel1
			// 
			this.inputsplitContainer.Panel1.Controls.Add(this.button3);
			this.inputsplitContainer.Panel1.Controls.Add(this.button2);
			this.inputsplitContainer.Panel1.Controls.Add(this.label3);
			this.inputsplitContainer.Panel1.Controls.Add(this.textBox2);
			// 
			// inputsplitContainer.Panel2
			// 
			this.inputsplitContainer.Panel2.Controls.Add(this.checkBox4);
			this.inputsplitContainer.Panel2.Controls.Add(this.comboBox2);
			this.inputsplitContainer.Panel2.Controls.Add(this.label4);
			this.inputsplitContainer.Size = new System.Drawing.Size(530, 76);
			this.inputsplitContainer.SplitterDistance = 37;
			this.inputsplitContainer.SplitterWidth = 1;
			this.inputsplitContainer.TabIndex = 0;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(395, 6);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 21);
			this.button3.TabIndex = 7;
			this.button3.Text = "Add";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(347, 7);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(30, 21);
			this.button2.TabIndex = 6;
			this.button2.Text = "...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(5, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Input Folder:";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(100, 7);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(241, 20);
			this.textBox2.TabIndex = 4;
			// 
			// checkBox4
			// 
			this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox4.Location = new System.Drawing.Point(395, 7);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(135, 24);
			this.checkBox4.TabIndex = 8;
			this.checkBox4.Text = "Allow multiple formats";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
									"PNG",
									"TGA",
									"TIFF",
									"VTF",
									"DDS",
									"WebP",
									"SGI"});
			this.comboBox2.Location = new System.Drawing.Point(100, 8);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(277, 21);
			this.comboBox2.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(5, 11);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Input Format:";
			// 
			// outputgroupBox2
			// 
			this.outputgroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.outputgroupBox2.Controls.Add(this.outputsplitContainer);
			this.outputgroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.outputgroupBox2.Location = new System.Drawing.Point(4, 3);
			this.outputgroupBox2.Name = "outputgroupBox2";
			this.outputgroupBox2.Size = new System.Drawing.Size(589, 95);
			this.outputgroupBox2.TabIndex = 1;
			this.outputgroupBox2.TabStop = false;
			this.outputgroupBox2.Text = "Output";
			// 
			// outputsplitContainer
			// 
			this.outputsplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.outputsplitContainer.IsSplitterFixed = true;
			this.outputsplitContainer.Location = new System.Drawing.Point(3, 16);
			this.outputsplitContainer.Name = "outputsplitContainer";
			this.outputsplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// outputsplitContainer.Panel1
			// 
			this.outputsplitContainer.Panel1.Controls.Add(this.checkBox1);
			this.outputsplitContainer.Panel1.Controls.Add(this.button1);
			this.outputsplitContainer.Panel1.Controls.Add(this.label1);
			this.outputsplitContainer.Panel1.Controls.Add(this.textBox1);
			// 
			// outputsplitContainer.Panel2
			// 
			this.outputsplitContainer.Panel2.Controls.Add(this.checkBox2);
			this.outputsplitContainer.Panel2.Controls.Add(this.comboBox1);
			this.outputsplitContainer.Panel2.Controls.Add(this.label2);
			this.outputsplitContainer.Size = new System.Drawing.Size(561, 76);
			this.outputsplitContainer.SplitterDistance = 37;
			this.outputsplitContainer.SplitterWidth = 1;
			this.outputsplitContainer.TabIndex = 0;
			// 
			// checkBox1
			// 
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(393, 6);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(140, 24);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "Write to input folder";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(345, 7);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(30, 21);
			this.button1.TabIndex = 2;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Output Folder:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(98, 7);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(241, 20);
			this.textBox1.TabIndex = 0;
			// 
			// checkBox2
			// 
			this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox2.Location = new System.Drawing.Point(393, 5);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(140, 24);
			this.checkBox2.TabIndex = 5;
			this.checkBox2.Text = "Only alpha channel";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"TGA",
									"PNG",
									"TIFF",
									"GIF",
									"JPG",
									"BMP",
									"VTF",
									"DDS",
									"WFM",
									"EMF"});
			this.comboBox1.Location = new System.Drawing.Point(98, 6);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(277, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Output Format:";
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(12, 630);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(1121, 23);
			this.progressBar1.TabIndex = 6;
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.file});
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(12, 157);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(1120, 326);
			this.listView1.TabIndex = 8;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// file
			// 
			this.file.Text = "File";
			this.file.Width = 1102;
			// 
			// statusTextBox
			// 
			this.statusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.statusTextBox.Font = new System.Drawing.Font("DejaVu Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusTextBox.Location = new System.Drawing.Point(153, 489);
			this.statusTextBox.Name = "statusTextBox";
			this.statusTextBox.ReadOnly = true;
			this.statusTextBox.Size = new System.Drawing.Size(980, 135);
			this.statusTextBox.TabIndex = 9;
			this.statusTextBox.Text = "Waiting...";
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.Description = "Select an input folder to import images from.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 489);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(135, 135);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1145, 665);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.statusTextBox);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.topsplitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1161, 700);
			this.Name = "MainForm";
			this.Text = "AlphaExeC";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.topsplitContainer1.Panel1.ResumeLayout(false);
			this.topsplitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.topsplitContainer1)).EndInit();
			this.topsplitContainer1.ResumeLayout(false);
			this.inputgroupBox1.ResumeLayout(false);
			this.inputsplitContainer.Panel1.ResumeLayout(false);
			this.inputsplitContainer.Panel1.PerformLayout();
			this.inputsplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.inputsplitContainer)).EndInit();
			this.inputsplitContainer.ResumeLayout(false);
			this.outputgroupBox2.ResumeLayout(false);
			this.outputsplitContainer.Panel1.ResumeLayout(false);
			this.outputsplitContainer.Panel1.PerformLayout();
			this.outputsplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.outputsplitContainer)).EndInit();
			this.outputsplitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.ColumnHeader file;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.RichTextBox statusTextBox;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.SplitContainer outputsplitContainer;
		private System.Windows.Forms.GroupBox outputgroupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.SplitContainer inputsplitContainer;
		private System.Windows.Forms.GroupBox inputgroupBox1;
		private System.Windows.Forms.SplitContainer topsplitContainer1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Panel panel1;
		
		
		void ListBox1SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, System.EventArgs e)
		{
			
		}
		

	
	}
}
