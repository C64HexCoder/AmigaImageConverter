namespace AmigaImageConverter
{
    partial class Settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.sequentialRB = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.colorRegistersCombo = new System.Windows.Forms.ComboBox();
            this.bitsPpCombo = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.wordAlienCB = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.longRbox = new System.Windows.Forms.RadioButton();
            this.wordRbox = new System.Windows.Forms.RadioButton();
            this.byteRbox = new System.Windows.Forms.RadioButton();
            this.OKBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.previewScalingNud = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAliment = new System.Windows.Forms.TabPage();
            this.AligmentGb = new System.Windows.Forms.GroupBox();
            this.alignLongRb = new System.Windows.Forms.RadioButton();
            this.alignWordRb = new System.Windows.Forms.RadioButton();
            this.alignByteRb = new System.Windows.Forms.RadioButton();
            this.tabFormat = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.numInARowNud = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewScalingNud)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabAliment.SuspendLayout();
            this.AligmentGb.SuspendLayout();
            this.tabFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInARowNud)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.sequentialRB);
            this.groupBox1.Location = new System.Drawing.Point(9, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Format";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 72);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(124, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Interleaved";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // sequentialRB
            // 
            this.sequentialRB.AutoSize = true;
            this.sequentialRB.Checked = true;
            this.sequentialRB.Location = new System.Drawing.Point(9, 32);
            this.sequentialRB.Name = "sequentialRB";
            this.sequentialRB.Size = new System.Drawing.Size(119, 29);
            this.sequentialRB.TabIndex = 0;
            this.sequentialRB.TabStop = true;
            this.sequentialRB.Text = "Sequential";
            this.sequentialRB.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.colorRegistersCombo);
            this.groupBox3.Controls.Add(this.bitsPpCombo);
            this.groupBox3.Location = new System.Drawing.Point(9, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 117);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color Options";
            // 
            // colorRegistersCombo
            // 
            this.colorRegistersCombo.FormattingEnabled = true;
            this.colorRegistersCombo.Items.AddRange(new object[] {
            "$180 - $19E (0-15)",
            "$1A0 - $1Be (16-31)"});
            this.colorRegistersCombo.Location = new System.Drawing.Point(6, 68);
            this.colorRegistersCombo.Name = "colorRegistersCombo";
            this.colorRegistersCombo.Size = new System.Drawing.Size(218, 33);
            this.colorRegistersCombo.TabIndex = 2;
            this.colorRegistersCombo.Tag = "colorRegister";
            this.colorRegistersCombo.SelectedIndexChanged += new System.EventHandler(this.bitsPpCombo_SelectedIndexChanged);
            // 
            // bitsPpCombo
            // 
            this.bitsPpCombo.FormattingEnabled = true;
            this.bitsPpCombo.Items.AddRange(new object[] {
            "4 Bit",
            "8 Bit"});
            this.bitsPpCombo.Location = new System.Drawing.Point(6, 30);
            this.bitsPpCombo.Name = "bitsPpCombo";
            this.bitsPpCombo.Size = new System.Drawing.Size(218, 33);
            this.bitsPpCombo.TabIndex = 0;
            this.bitsPpCombo.Tag = "bpp";
            this.bitsPpCombo.SelectedIndexChanged += new System.EventHandler(this.bitsPpCombo_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 29);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Add info file";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // wordAlienCB
            // 
            this.wordAlienCB.AutoSize = true;
            this.wordAlienCB.Location = new System.Drawing.Point(9, 181);
            this.wordAlienCB.Name = "wordAlienCB";
            this.wordAlienCB.Size = new System.Drawing.Size(126, 29);
            this.wordAlienCB.TabIndex = 2;
            this.wordAlienCB.Text = "Word Alien";
            this.wordAlienCB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.longRbox);
            this.groupBox2.Controls.Add(this.wordRbox);
            this.groupBox2.Controls.Add(this.byteRbox);
            this.groupBox2.Location = new System.Drawing.Point(7, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 152);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save As";
            // 
            // longRbox
            // 
            this.longRbox.AutoSize = true;
            this.longRbox.Location = new System.Drawing.Point(11, 103);
            this.longRbox.Name = "longRbox";
            this.longRbox.Size = new System.Drawing.Size(77, 29);
            this.longRbox.TabIndex = 2;
            this.longRbox.TabStop = true;
            this.longRbox.Text = "Long";
            this.longRbox.UseVisualStyleBackColor = true;
            this.longRbox.CheckedChanged += new System.EventHandler(this.longRbox_CheckedChanged);
            // 
            // wordRbox
            // 
            this.wordRbox.AutoSize = true;
            this.wordRbox.Location = new System.Drawing.Point(11, 68);
            this.wordRbox.Name = "wordRbox";
            this.wordRbox.Size = new System.Drawing.Size(81, 29);
            this.wordRbox.TabIndex = 1;
            this.wordRbox.TabStop = true;
            this.wordRbox.Text = "Word";
            this.wordRbox.UseVisualStyleBackColor = true;
            this.wordRbox.CheckedChanged += new System.EventHandler(this.wordRbox_CheckedChanged);
            // 
            // byteRbox
            // 
            this.byteRbox.AutoSize = true;
            this.byteRbox.Location = new System.Drawing.Point(11, 33);
            this.byteRbox.Name = "byteRbox";
            this.byteRbox.Size = new System.Drawing.Size(71, 29);
            this.byteRbox.TabIndex = 0;
            this.byteRbox.TabStop = true;
            this.byteRbox.Text = "Byte";
            this.byteRbox.UseVisualStyleBackColor = true;
            this.byteRbox.CheckedChanged += new System.EventHandler(this.byteRbox_CheckedChanged);
            // 
            // OKBtn
            // 
            this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBtn.Location = new System.Drawing.Point(633, 333);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(111, 33);
            this.OKBtn.TabIndex = 4;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(5, 333);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(111, 33);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Preview scaling";
            // 
            // previewScalingNud
            // 
            this.previewScalingNud.Location = new System.Drawing.Point(7, 34);
            this.previewScalingNud.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.previewScalingNud.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.previewScalingNud.Name = "previewScalingNud";
            this.previewScalingNud.Size = new System.Drawing.Size(180, 31);
            this.previewScalingNud.TabIndex = 9;
            this.previewScalingNud.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.previewScalingNud.ValueChanged += new System.EventHandler(this.previewScalingNud_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAliment);
            this.tabControl1.Controls.Add(this.tabFormat);
            this.tabControl1.Controls.Add(this.tabDisplay);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(747, 327);
            this.tabControl1.TabIndex = 12;
            // 
            // tabAliment
            // 
            this.tabAliment.Controls.Add(this.AligmentGb);
            this.tabAliment.Controls.Add(this.wordAlienCB);
            this.tabAliment.Controls.Add(this.groupBox2);
            this.tabAliment.Location = new System.Drawing.Point(4, 34);
            this.tabAliment.Name = "tabAliment";
            this.tabAliment.Padding = new System.Windows.Forms.Padding(3);
            this.tabAliment.Size = new System.Drawing.Size(739, 289);
            this.tabAliment.TabIndex = 0;
            this.tabAliment.Text = "Aliment";
            this.tabAliment.UseVisualStyleBackColor = true;
            // 
            // AligmentGb
            // 
            this.AligmentGb.Controls.Add(this.alignLongRb);
            this.AligmentGb.Controls.Add(this.alignWordRb);
            this.AligmentGb.Controls.Add(this.alignByteRb);
            this.AligmentGb.Location = new System.Drawing.Point(182, 9);
            this.AligmentGb.Name = "AligmentGb";
            this.AligmentGb.Size = new System.Drawing.Size(159, 152);
            this.AligmentGb.TabIndex = 12;
            this.AligmentGb.TabStop = false;
            this.AligmentGb.Text = "Aligns As";
            // 
            // alignLongRb
            // 
            this.alignLongRb.AutoSize = true;
            this.alignLongRb.Location = new System.Drawing.Point(11, 103);
            this.alignLongRb.Name = "alignLongRb";
            this.alignLongRb.Size = new System.Drawing.Size(77, 29);
            this.alignLongRb.TabIndex = 2;
            this.alignLongRb.Text = "Long";
            this.alignLongRb.UseVisualStyleBackColor = true;
            this.alignLongRb.CheckedChanged += new System.EventHandler(this.alignLongRb_CheckedChanged);
            // 
            // alignWordRb
            // 
            this.alignWordRb.AutoSize = true;
            this.alignWordRb.Location = new System.Drawing.Point(11, 68);
            this.alignWordRb.Name = "alignWordRb";
            this.alignWordRb.Size = new System.Drawing.Size(81, 29);
            this.alignWordRb.TabIndex = 1;
            this.alignWordRb.Text = "Word";
            this.alignWordRb.UseVisualStyleBackColor = true;
            this.alignWordRb.CheckedChanged += new System.EventHandler(this.alignWordRb_CheckedChanged);
            // 
            // alignByteRb
            // 
            this.alignByteRb.AutoSize = true;
            this.alignByteRb.Location = new System.Drawing.Point(11, 33);
            this.alignByteRb.Name = "alignByteRb";
            this.alignByteRb.Size = new System.Drawing.Size(71, 29);
            this.alignByteRb.TabIndex = 0;
            this.alignByteRb.Text = "Byte";
            this.alignByteRb.UseVisualStyleBackColor = true;
            this.alignByteRb.CheckedChanged += new System.EventHandler(this.alignByteRb_CheckedChanged);
            // 
            // tabFormat
            // 
            this.tabFormat.Controls.Add(this.label1);
            this.tabFormat.Controls.Add(this.numInARowNud);
            this.tabFormat.Controls.Add(this.groupBox5);
            this.tabFormat.Controls.Add(this.groupBox1);
            this.tabFormat.Controls.Add(this.groupBox3);
            this.tabFormat.Location = new System.Drawing.Point(4, 34);
            this.tabFormat.Name = "tabFormat";
            this.tabFormat.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormat.Size = new System.Drawing.Size(739, 289);
            this.tabFormat.TabIndex = 1;
            this.tabFormat.Text = "Format";
            this.tabFormat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Numbers in a Row";
            // 
            // numInARowNud
            // 
            this.numInARowNud.Location = new System.Drawing.Point(269, 211);
            this.numInARowNud.Name = "numInARowNud";
            this.numInARowNud.Size = new System.Drawing.Size(180, 31);
            this.numInARowNud.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton4);
            this.groupBox5.Controls.Add(this.radioButton3);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Location = new System.Drawing.Point(269, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(188, 150);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Padding";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 101);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(77, 29);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Long";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(81, 29);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Word";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Byte";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tabDisplay
            // 
            this.tabDisplay.Controls.Add(this.checkBox1);
            this.tabDisplay.Controls.Add(this.label2);
            this.tabDisplay.Controls.Add(this.previewScalingNud);
            this.tabDisplay.Location = new System.Drawing.Point(4, 34);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplay.Size = new System.Drawing.Size(739, 289);
            this.tabDisplay.TabIndex = 2;
            this.tabDisplay.Text = "Display";
            this.tabDisplay.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 378);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewScalingNud)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabAliment.ResumeLayout(false);
            this.tabAliment.PerformLayout();
            this.AligmentGb.ResumeLayout(false);
            this.AligmentGb.PerformLayout();
            this.tabFormat.ResumeLayout(false);
            this.tabFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInARowNud)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabDisplay.ResumeLayout(false);
            this.tabDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.RadioButton sequentialRB;
        private System.Windows.Forms.CheckBox wordAlienCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button cancelBtn;
        public System.Windows.Forms.RadioButton longRbox;
        public System.Windows.Forms.RadioButton wordRbox;
        public System.Windows.Forms.RadioButton byteRbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox colorRegistersCombo;
        private System.Windows.Forms.ComboBox bitsPpCombo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown previewScalingNud;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAliment;
        private System.Windows.Forms.TabPage tabFormat;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numInARowNud;
        public System.Windows.Forms.GroupBox AligmentGb;
        public System.Windows.Forms.RadioButton alignLongRb;
        public System.Windows.Forms.RadioButton alignWordRb;
        public System.Windows.Forms.RadioButton alignByteRb;
    }
}