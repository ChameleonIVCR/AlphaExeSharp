
namespace AlphaExeC
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.alphaCheckBox = new System.Windows.Forms.CheckBox();
            this.pixelFormatDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qualityNumberInput = new System.Windows.Forms.NumericUpDown();
            this.qualityBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dxtCompressionDropdown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.aDropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rgbDropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qualityNumberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.alphaCheckBox);
            this.groupBox1.Controls.Add(this.pixelFormatDropdown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.qualityNumberInput);
            this.groupBox1.Controls.Add(this.qualityBar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(187, 94);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Replace RGB with A";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // alphaCheckBox
            // 
            this.alphaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaCheckBox.Location = new System.Drawing.Point(6, 94);
            this.alphaCheckBox.Name = "alphaCheckBox";
            this.alphaCheckBox.Size = new System.Drawing.Size(160, 24);
            this.alphaCheckBox.TabIndex = 5;
            this.alphaCheckBox.Text = "Allow multiple input formats";
            this.alphaCheckBox.UseVisualStyleBackColor = true;
            // 
            // pixelFormatDropdown
            // 
            this.pixelFormatDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pixelFormatDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pixelFormatDropdown.FormattingEnabled = true;
            this.pixelFormatDropdown.Items.AddRange(new object[] {
                                    "32 bits ARGB -- DEFAULT",
                                    "64 bits ARGB",
                                    "64 bits PARGB",
                                    "48 bits RGB",
                                    "32 bits PARG",
                                    "32 bits RGB",
                                    "24 bits RGB",
                                    "16 bits ARGB",
                                    "16 bits RGB",
                                    "16 bits Grayscale",
                                    "8 bits Indexed",
                                    "4 bits Indexed"});
            this.pixelFormatDropdown.Location = new System.Drawing.Point(116, 58);
            this.pixelFormatDropdown.Name = "pixelFormatDropdown";
            this.pixelFormatDropdown.Size = new System.Drawing.Size(202, 21);
            this.pixelFormatDropdown.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pixel Format";
            // 
            // qualityNumberInput
            // 
            this.qualityNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualityNumberInput.Location = new System.Drawing.Point(56, 19);
            this.qualityNumberInput.Minimum = new decimal(new int[] {
                                    10,
                                    0,
                                    0,
                                    0});
            this.qualityNumberInput.Name = "qualityNumberInput";
            this.qualityNumberInput.Size = new System.Drawing.Size(45, 20);
            this.qualityNumberInput.TabIndex = 2;
            this.qualityNumberInput.Value = new decimal(new int[] {
                                    80,
                                    0,
                                    0,
                                    0});
            this.qualityNumberInput.ValueChanged += new System.EventHandler(this.qualityNumberInputChanged);
            // 
            // qualityBar
            // 
            this.qualityBar.LargeChange = 10;
            this.qualityBar.Location = new System.Drawing.Point(107, 19);
            this.qualityBar.Maximum = 100;
            this.qualityBar.Minimum = 10;
            this.qualityBar.Name = "qualityBar";
            this.qualityBar.Size = new System.Drawing.Size(220, 45);
            this.qualityBar.TabIndex = 1;
            this.qualityBar.TickFrequency = 5;
            this.qualityBar.Value = 80;
            this.qualityBar.Scroll += new System.EventHandler(this.qualityBarScroll);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quality";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dxtCompressionDropdown);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.aDropdown);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rgbDropdown);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DXT";
            // 
            // dxtCompressionDropdown
            // 
            this.dxtCompressionDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dxtCompressionDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dxtCompressionDropdown.FormattingEnabled = true;
            this.dxtCompressionDropdown.Items.AddRange(new object[] {
                                    "Optimal -- DEFAULT",
                                    "Low",
                                    "Medium",
                                    "High"});
            this.dxtCompressionDropdown.Location = new System.Drawing.Point(116, 83);
            this.dxtCompressionDropdown.Name = "dxtCompressionDropdown";
            this.dxtCompressionDropdown.Size = new System.Drawing.Size(202, 21);
            this.dxtCompressionDropdown.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "DXT Compression";
            // 
            // aDropdown
            // 
            this.aDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDropdown.FormattingEnabled = true;
            this.aDropdown.Items.AddRange(new object[] {
                                    "BGRA -- DEFAULT",
                                    "DXT5",
                                    "DXT3",
                                    "DXT1",
                                    "RGBA"});
            this.aDropdown.Location = new System.Drawing.Point(116, 51);
            this.aDropdown.Name = "aDropdown";
            this.aDropdown.Size = new System.Drawing.Size(202, 21);
            this.aDropdown.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "A Format";
            // 
            // rgbDropdown
            // 
            this.rgbDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rgbDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbDropdown.FormattingEnabled = true;
            this.rgbDropdown.Items.AddRange(new object[] {
                                    "DXT5 -- DEFAULT",
                                    "DXT3",
                                    "DXT1",
                                    "BGRA",
                                    "RGBA"});
            this.rgbDropdown.Location = new System.Drawing.Point(116, 19);
            this.rgbDropdown.Name = "rgbDropdown";
            this.rgbDropdown.Size = new System.Drawing.Size(202, 21);
            this.rgbDropdown.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "RGB Format";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(193, 283);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(74, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(273, 283);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(359, 318);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qualityNumberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualityBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dxtCompressionDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox rgbDropdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox aDropdown;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox alphaCheckBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox pixelFormatDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown qualityNumberInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar qualityBar;
    }
}
