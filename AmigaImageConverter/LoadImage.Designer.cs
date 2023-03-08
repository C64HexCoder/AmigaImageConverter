namespace AmigaImageConverter
{
    partial class LoadImageDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.resizeGroupBox = new System.Windows.Forms.GroupBox();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.transparentCheckBox = new System.Windows.Forms.CheckBox();
            this.bgColorPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.imageBox = new Amiga.ImageBox();
            this.sidePael = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.resizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgColorPictureBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.sidePael.SuspendLayout();
            this.SuspendLayout();
            // 
            // resizeGroupBox
            // 
            this.resizeGroupBox.Controls.Add(this.heightNumericUpDown);
            this.resizeGroupBox.Controls.Add(this.widthNumericUpDown);
            this.resizeGroupBox.Controls.Add(this.label2);
            this.resizeGroupBox.Controls.Add(this.label1);
            this.resizeGroupBox.Location = new System.Drawing.Point(3, 3);
            this.resizeGroupBox.Name = "resizeGroupBox";
            this.resizeGroupBox.Size = new System.Drawing.Size(273, 150);
            this.resizeGroupBox.TabIndex = 0;
            this.resizeGroupBox.TabStop = false;
            this.resizeGroupBox.Text = "Resize";
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.Location = new System.Drawing.Point(146, 79);
            this.heightNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.heightNumericUpDown.TabIndex = 3;
            this.heightNumericUpDown.ValueChanged += new System.EventHandler(this.heightNumericUpDown_ValueChanged);
            // 
            // widthNumericUpDown
            // 
            this.widthNumericUpDown.Location = new System.Drawing.Point(10, 79);
            this.widthNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.widthNumericUpDown.TabIndex = 2;
            this.widthNumericUpDown.ValueChanged += new System.EventHandler(this.widthNumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.colorComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Quantation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Colors";
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256"});
            this.colorComboBox.Location = new System.Drawing.Point(6, 133);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(258, 33);
            this.colorComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Algorithem";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "K Means";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.transparentCheckBox);
            this.groupBox2.Controls.Add(this.bgColorPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(0, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 127);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backgrount Color";
            // 
            // transparentCheckBox
            // 
            this.transparentCheckBox.AutoSize = true;
            this.transparentCheckBox.Location = new System.Drawing.Point(6, 79);
            this.transparentCheckBox.Name = "transparentCheckBox";
            this.transparentCheckBox.Size = new System.Drawing.Size(174, 29);
            this.transparentCheckBox.TabIndex = 1;
            this.transparentCheckBox.Text = "Transparent Is BG";
            this.transparentCheckBox.UseVisualStyleBackColor = true;
            // 
            // bgColorPictureBox
            // 
            this.bgColorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bgColorPictureBox.Location = new System.Drawing.Point(6, 39);
            this.bgColorPictureBox.Name = "bgColorPictureBox";
            this.bgColorPictureBox.Size = new System.Drawing.Size(258, 34);
            this.bgColorPictureBox.TabIndex = 0;
            this.bgColorPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(158, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Do it!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 553);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(996, 32);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(7, 12);
            this.imageBox.Name = "imageBox";
            this.imageBox.ScaleFactor = 1;
            this.imageBox.ScaleFactorFloat = 1F;
            this.imageBox.Size = new System.Drawing.Size(699, 538);
            this.imageBox.TabIndex = 6;
            this.imageBox.TabStop = false;
            this.imageBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imageBox_MouseClick);
            // 
            // sidePael
            // 
            this.sidePael.Controls.Add(this.resizeGroupBox);
            this.sidePael.Controls.Add(this.groupBox1);
            this.sidePael.Controls.Add(this.groupBox2);
            this.sidePael.Controls.Add(this.button1);
            this.sidePael.Location = new System.Drawing.Point(712, 12);
            this.sidePael.Name = "sidePael";
            this.sidePael.Size = new System.Drawing.Size(273, 538);
            this.sidePael.TabIndex = 7;
            // 
            // LoadImageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(996, 585);
            this.Controls.Add(this.sidePael);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.statusStrip);
            this.Name = "LoadImageDialog";
            this.Text = "Load Image Dialog";
            this.resizeGroupBox.ResumeLayout(false);
            this.resizeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgColorPictureBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.sidePael.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox resizeGroupBox;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox bgColorPictureBox;
        private System.Windows.Forms.CheckBox transparentCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private Amiga.ImageBox imageBox;
        private System.Windows.Forms.Panel sidePael;
        private System.Windows.Forms.ToolTip toolTip;
    }
}