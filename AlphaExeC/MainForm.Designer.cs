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
		    this.licenseButton = new System.Windows.Forms.Button();
		    this.aboutButton = new System.Windows.Forms.Button();
		    this.helpButton = new System.Windows.Forms.Button();
		    this.optionsButton = new System.Windows.Forms.Button();
		    this.clearButton = new System.Windows.Forms.Button();
		    this.stopButton = new System.Windows.Forms.Button();
		    this.convertButton = new System.Windows.Forms.Button();
		    this.topsplitContainer1 = new System.Windows.Forms.SplitContainer();
		    this.inputgroupBox1 = new System.Windows.Forms.GroupBox();
		    this.inputsplitContainer = new System.Windows.Forms.SplitContainer();
		    this.inputAddButton = new System.Windows.Forms.Button();
		    this.inputBrowseButton = new System.Windows.Forms.Button();
		    this.label3 = new System.Windows.Forms.Label();
		    this.inputTextBot = new System.Windows.Forms.TextBox();
		    this.allowMoreFormatsCheckbox = new System.Windows.Forms.CheckBox();
		    this.inputFormatDropdown = new System.Windows.Forms.ComboBox();
		    this.label4 = new System.Windows.Forms.Label();
		    this.outputgroupBox2 = new System.Windows.Forms.GroupBox();
		    this.outputsplitContainer = new System.Windows.Forms.SplitContainer();
		    this.writeToInputFolderCheckbox = new System.Windows.Forms.CheckBox();
		    this.outputBrowseButton = new System.Windows.Forms.Button();
		    this.label1 = new System.Windows.Forms.Label();
		    this.outputTextBox = new System.Windows.Forms.TextBox();
		    this.onlyAlphaChCheckbox = new System.Windows.Forms.CheckBox();
		    this.outputFormatDropdown = new System.Windows.Forms.ComboBox();
		    this.label2 = new System.Windows.Forms.Label();
		    this.progressBar1 = new System.Windows.Forms.ProgressBar();
		    this.imageList = new System.Windows.Forms.ListView();
		    this.file = new System.Windows.Forms.ColumnHeader();
		    this.statusTextBox = new System.Windows.Forms.RichTextBox();
		    this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
		    this.previewBox = new System.Windows.Forms.PictureBox();
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
		    ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
		    this.SuspendLayout();
		    // 
		    // panel1
		    // 
		    this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
		    		    		    | System.Windows.Forms.AnchorStyles.Right)));
		    this.panel1.Controls.Add(this.licenseButton);
		    this.panel1.Controls.Add(this.aboutButton);
		    this.panel1.Controls.Add(this.helpButton);
		    this.panel1.Controls.Add(this.optionsButton);
		    this.panel1.Controls.Add(this.clearButton);
		    this.panel1.Controls.Add(this.stopButton);
		    this.panel1.Controls.Add(this.convertButton);
		    this.panel1.Location = new System.Drawing.Point(12, 121);
		    this.panel1.Name = "panel1";
		    this.panel1.Size = new System.Drawing.Size(1121, 29);
		    this.panel1.TabIndex = 4;
		    // 
		    // licenseButton
		    // 
		    this.licenseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
		    this.licenseButton.Location = new System.Drawing.Point(1043, 3);
		    this.licenseButton.Name = "licenseButton";
		    this.licenseButton.Size = new System.Drawing.Size(75, 23);
		    this.licenseButton.TabIndex = 6;
		    this.licenseButton.Text = "License";
		    this.licenseButton.UseVisualStyleBackColor = true;
		    this.licenseButton.Click += new System.EventHandler(this.licenseButtonClick);
		    // 
		    // aboutButton
		    // 
		    this.aboutButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
		    this.aboutButton.Location = new System.Drawing.Point(865, 3);
		    this.aboutButton.Name = "aboutButton";
		    this.aboutButton.Size = new System.Drawing.Size(75, 23);
		    this.aboutButton.TabIndex = 5;
		    this.aboutButton.Text = "About";
		    this.aboutButton.UseVisualStyleBackColor = true;
		    this.aboutButton.Click += new System.EventHandler(this.aboutButtonClick);
		    // 
		    // helpButton
		    // 
		    this.helpButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
		    this.helpButton.Location = new System.Drawing.Point(689, 3);
		    this.helpButton.Name = "helpButton";
		    this.helpButton.Size = new System.Drawing.Size(75, 23);
		    this.helpButton.TabIndex = 4;
		    this.helpButton.Text = "Help";
		    this.helpButton.UseVisualStyleBackColor = true;
		    this.helpButton.Click += new System.EventHandler(this.helpButtonClick);
		    // 
		    // optionsButton
		    // 
		    this.optionsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
		    this.optionsButton.Location = new System.Drawing.Point(520, 3);
		    this.optionsButton.Name = "optionsButton";
		    this.optionsButton.Size = new System.Drawing.Size(75, 23);
		    this.optionsButton.TabIndex = 3;
		    this.optionsButton.Text = "Options";
		    this.optionsButton.UseVisualStyleBackColor = true;
		    this.optionsButton.Click += new System.EventHandler(this.optionsButtonClick);
		    // 
		    // clearButton
		    // 
		    this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
		    this.clearButton.Location = new System.Drawing.Point(353, 3);
		    this.clearButton.Name = "clearButton";
		    this.clearButton.Size = new System.Drawing.Size(75, 23);
		    this.clearButton.TabIndex = 2;
		    this.clearButton.Text = "Clear";
		    this.clearButton.UseVisualStyleBackColor = true;
		    this.clearButton.Click += new System.EventHandler(this.clearButtonClick);
		    // 
		    // stopButton
		    // 
		    this.stopButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
		    this.stopButton.Enabled = false;
		    this.stopButton.Location = new System.Drawing.Point(171, 3);
		    this.stopButton.Name = "stopButton";
		    this.stopButton.Size = new System.Drawing.Size(75, 23);
		    this.stopButton.TabIndex = 1;
		    this.stopButton.Text = "Stop";
		    this.stopButton.UseVisualStyleBackColor = true;
		    this.stopButton.Click += new System.EventHandler(this.stopButtonClick);
		    // 
		    // convertButton
		    // 
		    this.convertButton.Location = new System.Drawing.Point(6, 3);
		    this.convertButton.Name = "convertButton";
		    this.convertButton.Size = new System.Drawing.Size(75, 23);
		    this.convertButton.TabIndex = 0;
		    this.convertButton.Text = "Convert";
		    this.convertButton.UseVisualStyleBackColor = true;
		    this.convertButton.Click += new System.EventHandler(this.convertButtonClick);
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
		    this.inputsplitContainer.Panel1.Controls.Add(this.inputAddButton);
		    this.inputsplitContainer.Panel1.Controls.Add(this.inputBrowseButton);
		    this.inputsplitContainer.Panel1.Controls.Add(this.label3);
		    this.inputsplitContainer.Panel1.Controls.Add(this.inputTextBot);
		    // 
		    // inputsplitContainer.Panel2
		    // 
		    this.inputsplitContainer.Panel2.Controls.Add(this.allowMoreFormatsCheckbox);
		    this.inputsplitContainer.Panel2.Controls.Add(this.inputFormatDropdown);
		    this.inputsplitContainer.Panel2.Controls.Add(this.label4);
		    this.inputsplitContainer.Size = new System.Drawing.Size(530, 76);
		    this.inputsplitContainer.SplitterDistance = 37;
		    this.inputsplitContainer.SplitterWidth = 1;
		    this.inputsplitContainer.TabIndex = 0;
		    // 
		    // inputAddButton
		    // 
		    this.inputAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		    this.inputAddButton.Location = new System.Drawing.Point(395, 6);
		    this.inputAddButton.Name = "inputAddButton";
		    this.inputAddButton.Size = new System.Drawing.Size(120, 21);
		    this.inputAddButton.TabIndex = 7;
		    this.inputAddButton.Text = "Add";
		    this.inputAddButton.UseVisualStyleBackColor = true;
		    this.inputAddButton.Click += new System.EventHandler(this.inputAddClick);
		    // 
		    // inputBrowseButton
		    // 
		    this.inputBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		    this.inputBrowseButton.Location = new System.Drawing.Point(347, 7);
		    this.inputBrowseButton.Name = "inputBrowseButton";
		    this.inputBrowseButton.Size = new System.Drawing.Size(30, 21);
		    this.inputBrowseButton.TabIndex = 6;
		    this.inputBrowseButton.Text = "...";
		    this.inputBrowseButton.UseVisualStyleBackColor = true;
		    this.inputBrowseButton.Click += new System.EventHandler(this.inputBrowseClick);
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
		    // inputTextBot
		    // 
		    this.inputTextBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		    this.inputTextBot.Location = new System.Drawing.Point(100, 7);
		    this.inputTextBot.Name = "inputTextBot";
		    this.inputTextBot.Size = new System.Drawing.Size(241, 20);
		    this.inputTextBot.TabIndex = 4;
		    // 
		    // allowMoreFormatsCheckbox
		    // 
		    this.allowMoreFormatsCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		    this.allowMoreFormatsCheckbox.Location = new System.Drawing.Point(395, 7);
		    this.allowMoreFormatsCheckbox.Name = "allowMoreFormatsCheckbox";
		    this.allowMoreFormatsCheckbox.Size = new System.Drawing.Size(135, 24);
		    this.allowMoreFormatsCheckbox.TabIndex = 8;
		    this.allowMoreFormatsCheckbox.Text = "Allow multiple formats";
		    this.allowMoreFormatsCheckbox.UseVisualStyleBackColor = true;
		    // 
		    // inputFormatDropdown
		    // 
		    this.inputFormatDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		    this.inputFormatDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		    this.inputFormatDropdown.FormattingEnabled = true;
		    this.inputFormatDropdown.Items.AddRange(new object[] {
		    		    		    "PNG",
		    		    		    "TGA",
		    		    		    "TIFF",
		    		    		    "VTF",
		    		    		    "DDS",
		    		    		    "WebP",
		    		    		    "SGI"});
		    this.inputFormatDropdown.Location = new System.Drawing.Point(100, 8);
		    this.inputFormatDropdown.Name = "inputFormatDropdown";
		    this.inputFormatDropdown.Size = new System.Drawing.Size(277, 21);
		    this.inputFormatDropdown.TabIndex = 6;
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
		    this.outputgroupBox2.Size = new System.Drawing.Size(619, 95);
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
		    this.outputsplitContainer.Panel1.Controls.Add(this.writeToInputFolderCheckbox);
		    this.outputsplitContainer.Panel1.Controls.Add(this.outputBrowseButton);
		    this.outputsplitContainer.Panel1.Controls.Add(this.label1);
		    this.outputsplitContainer.Panel1.Controls.Add(this.outputTextBox);
		    // 
		    // outputsplitContainer.Panel2
		    // 
		    this.outputsplitContainer.Panel2.Controls.Add(this.onlyAlphaChCheckbox);
		    this.outputsplitContainer.Panel2.Controls.Add(this.outputFormatDropdown);
		    this.outputsplitContainer.Panel2.Controls.Add(this.label2);
		    this.outputsplitContainer.Size = new System.Drawing.Size(591, 76);
		    this.outputsplitContainer.SplitterDistance = 37;
		    this.outputsplitContainer.SplitterWidth = 1;
		    this.outputsplitContainer.TabIndex = 0;
		    // 
		    // writeToInputFolderCheckbox
		    // 
		    this.writeToInputFolderCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		    this.writeToInputFolderCheckbox.Location = new System.Drawing.Point(393, 6);
		    this.writeToInputFolderCheckbox.Name = "writeToInputFolderCheckbox";
		    this.writeToInputFolderCheckbox.Size = new System.Drawing.Size(140, 24);
		    this.writeToInputFolderCheckbox.TabIndex = 3;
		    this.writeToInputFolderCheckbox.Text = "Write to input folder";
		    this.writeToInputFolderCheckbox.UseVisualStyleBackColor = true;
		    // 
		    // outputBrowseButton
		    // 
		    this.outputBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		    this.outputBrowseButton.Location = new System.Drawing.Point(345, 7);
		    this.outputBrowseButton.Name = "outputBrowseButton";
		    this.outputBrowseButton.Size = new System.Drawing.Size(30, 21);
		    this.outputBrowseButton.TabIndex = 2;
		    this.outputBrowseButton.Text = "...";
		    this.outputBrowseButton.UseVisualStyleBackColor = true;
		    this.outputBrowseButton.Click += new System.EventHandler(this.outputBrowseButtonClick);
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
		    // outputTextBox
		    // 
		    this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		    this.outputTextBox.Location = new System.Drawing.Point(98, 7);
		    this.outputTextBox.Name = "outputTextBox";
		    this.outputTextBox.Size = new System.Drawing.Size(241, 20);
		    this.outputTextBox.TabIndex = 0;
		    // 
		    // onlyAlphaChCheckbox
		    // 
		    this.onlyAlphaChCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		    this.onlyAlphaChCheckbox.Location = new System.Drawing.Point(393, 5);
		    this.onlyAlphaChCheckbox.Name = "onlyAlphaChCheckbox";
		    this.onlyAlphaChCheckbox.Size = new System.Drawing.Size(140, 24);
		    this.onlyAlphaChCheckbox.TabIndex = 5;
		    this.onlyAlphaChCheckbox.Text = "Only alpha channel";
		    this.onlyAlphaChCheckbox.UseVisualStyleBackColor = true;
		    // 
		    // outputFormatDropdown
		    // 
		    this.outputFormatDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		    this.outputFormatDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
		    this.outputFormatDropdown.FormattingEnabled = true;
		    this.outputFormatDropdown.Items.AddRange(new object[] {
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
		    this.outputFormatDropdown.Location = new System.Drawing.Point(98, 6);
		    this.outputFormatDropdown.Name = "outputFormatDropdown";
		    this.outputFormatDropdown.Size = new System.Drawing.Size(277, 21);
		    this.outputFormatDropdown.TabIndex = 2;
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
		    // imageList
		    // 
		    this.imageList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
		    		    		    | System.Windows.Forms.AnchorStyles.Left) 
		    		    		    | System.Windows.Forms.AnchorStyles.Right)));
		    this.imageList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
		    		    		    this.file});
		    this.imageList.GridLines = true;
		    this.imageList.Location = new System.Drawing.Point(12, 157);
		    this.imageList.MultiSelect = false;
		    this.imageList.Name = "imageList";
		    this.imageList.Size = new System.Drawing.Size(1120, 326);
		    this.imageList.TabIndex = 8;
		    this.imageList.UseCompatibleStateImageBehavior = false;
		    this.imageList.View = System.Windows.Forms.View.Details;
		    this.imageList.SelectedIndexChanged += new System.EventHandler(this.imageListSelectedIndexChange);
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
		    // previewBox
		    // 
		    this.previewBox.Location = new System.Drawing.Point(12, 489);
		    this.previewBox.Name = "previewBox";
		    this.previewBox.Size = new System.Drawing.Size(135, 135);
		    this.previewBox.TabIndex = 10;
		    this.previewBox.TabStop = false;
		    // 
		    // MainForm
		    // 
		    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		    this.ClientSize = new System.Drawing.Size(1145, 665);
		    this.Controls.Add(this.previewBox);
		    this.Controls.Add(this.statusTextBox);
		    this.Controls.Add(this.imageList);
		    this.Controls.Add(this.progressBar1);
		    this.Controls.Add(this.panel1);
		    this.Controls.Add(this.topsplitContainer1);
		    this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
		    this.MinimumSize = new System.Drawing.Size(1161, 700);
		    this.Name = "MainForm";
		    this.Text = "AlphaExeC";
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
		    ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
		    this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox previewBox;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.ColumnHeader file;
		private System.Windows.Forms.ListView imageList;
		private System.Windows.Forms.RichTextBox statusTextBox;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox outputFormatDropdown;
		private System.Windows.Forms.CheckBox onlyAlphaChCheckbox;
		private System.Windows.Forms.TextBox outputTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button outputBrowseButton;
		private System.Windows.Forms.CheckBox writeToInputFolderCheckbox;
		private System.Windows.Forms.SplitContainer outputsplitContainer;
		private System.Windows.Forms.GroupBox outputgroupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox inputFormatDropdown;
		private System.Windows.Forms.CheckBox allowMoreFormatsCheckbox;
		private System.Windows.Forms.TextBox inputTextBot;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button inputBrowseButton;
		private System.Windows.Forms.Button inputAddButton;
		private System.Windows.Forms.SplitContainer inputsplitContainer;
		private System.Windows.Forms.GroupBox inputgroupBox1;
		private System.Windows.Forms.SplitContainer topsplitContainer1;
		private System.Windows.Forms.Button convertButton;
		private System.Windows.Forms.Button stopButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button optionsButton;
		private System.Windows.Forms.Button helpButton;
		private System.Windows.Forms.Button aboutButton;
		private System.Windows.Forms.Button licenseButton;
		private System.Windows.Forms.Panel panel1;
	}
}
