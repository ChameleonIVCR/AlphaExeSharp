
namespace AlphaExeC.ui
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viruzLabel = new System.Windows.Forms.LinkLabel();
            this.zonalLabel = new System.Windows.Forms.LinkLabel();
            this.chameLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viruzLabel);
            this.groupBox1.Controls.Add(this.zonalLabel);
            this.groupBox1.Controls.Add(this.chameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Developers";
            // 
            // viruzLabel
            // 
            this.viruzLabel.Location = new System.Drawing.Point(7, 58);
            this.viruzLabel.Name = "viruzLabel";
            this.viruzLabel.Size = new System.Drawing.Size(99, 19);
            this.viruzLabel.TabIndex = 2;
            this.viruzLabel.TabStop = true;
            this.viruzLabel.Text = "Viruzaum";
            this.viruzLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viruzLabelClicked);
            // 
            // zonalLabel
            // 
            this.zonalLabel.Location = new System.Drawing.Point(7, 39);
            this.zonalLabel.Name = "zonalLabel";
            this.zonalLabel.Size = new System.Drawing.Size(99, 19);
            this.zonalLabel.TabIndex = 1;
            this.zonalLabel.TabStop = true;
            this.zonalLabel.Text = "Iamawesome99";
            this.zonalLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.zonalLabelLinkClicked);
            // 
            // chameLabel
            // 
            this.chameLabel.Location = new System.Drawing.Point(7, 20);
            this.chameLabel.Name = "chameLabel";
            this.chameLabel.Size = new System.Drawing.Size(54, 19);
            this.chameLabel.TabIndex = 0;
            this.chameLabel.TabStop = true;
            this.chameLabel.Text = "Chame";
            this.chameLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.chameLabelClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AlphaExeSharp";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(7, 43);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(134, 19);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Colaborate in GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLabelClicked);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "AlphaExeSharp v13082020";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 190);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel zonalLabel;
        private System.Windows.Forms.LinkLabel viruzLabel;
        private System.Windows.Forms.LinkLabel chameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
