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
            OKBtn = new System.Windows.Forms.Button();
            cancelBtn = new System.Windows.Forms.Button();
            tabDisplay = new System.Windows.Forms.TabPage();
            groupBox4 = new System.Windows.Forms.GroupBox();
            scaleToMaxCheckBox = new System.Windows.Forms.CheckBox();
            previewScalingNud = new System.Windows.Forms.NumericUpDown();
            tabFormat = new System.Windows.Forms.TabPage();
            checkBox1 = new System.Windows.Forms.CheckBox();
            AligmentGb = new System.Windows.Forms.GroupBox();
            alignLongRb = new System.Windows.Forms.RadioButton();
            alignWordRb = new System.Windows.Forms.RadioButton();
            alignByteRb = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            longRbox = new System.Windows.Forms.RadioButton();
            wordRbox = new System.Windows.Forms.RadioButton();
            byteRbox = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            numInARowNud = new System.Windows.Forms.NumericUpDown();
            groupBox1 = new System.Windows.Forms.GroupBox();
            interleavedRB = new System.Windows.Forms.RadioButton();
            sequentialRB = new System.Windows.Forms.RadioButton();
            groupBox3 = new System.Windows.Forms.GroupBox();
            colorRegistersCombo = new System.Windows.Forms.ComboBox();
            bitsPpCombo = new System.Windows.Forms.ComboBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabFileExt = new System.Windows.Forms.TabPage();
            groupBox5 = new System.Windows.Forms.GroupBox();
            groupBox6 = new System.Windows.Forms.GroupBox();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton4 = new System.Windows.Forms.RadioButton();
            radioButton5 = new System.Windows.Forms.RadioButton();
            tabDisplay.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)previewScalingNud).BeginInit();
            tabFormat.SuspendLayout();
            AligmentGb.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numInARowNud).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabFileExt.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // OKBtn
            // 
            OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            OKBtn.Location = new System.Drawing.Point(633, 333);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new System.Drawing.Size(111, 33);
            OKBtn.TabIndex = 4;
            OKBtn.Text = "OK";
            OKBtn.UseVisualStyleBackColor = true;
            OKBtn.Click += OKBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new System.Drawing.Point(5, 333);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new System.Drawing.Size(111, 33);
            cancelBtn.TabIndex = 5;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // tabDisplay
            // 
            tabDisplay.Controls.Add(groupBox4);
            tabDisplay.Location = new System.Drawing.Point(4, 34);
            tabDisplay.Name = "tabDisplay";
            tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            tabDisplay.Size = new System.Drawing.Size(739, 289);
            tabDisplay.TabIndex = 2;
            tabDisplay.Text = "Display";
            tabDisplay.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(scaleToMaxCheckBox);
            groupBox4.Controls.Add(previewScalingNud);
            groupBox4.Location = new System.Drawing.Point(7, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(300, 112);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Preview Scaling";
            // 
            // scaleToMaxCheckBox
            // 
            scaleToMaxCheckBox.AutoSize = true;
            scaleToMaxCheckBox.Checked = true;
            scaleToMaxCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            scaleToMaxCheckBox.Location = new System.Drawing.Point(6, 30);
            scaleToMaxCheckBox.Name = "scaleToMaxCheckBox";
            scaleToMaxCheckBox.Size = new System.Drawing.Size(139, 29);
            scaleToMaxCheckBox.TabIndex = 0;
            scaleToMaxCheckBox.Text = "Scale To Max";
            scaleToMaxCheckBox.UseVisualStyleBackColor = true;
            scaleToMaxCheckBox.CheckedChanged += scaleToMaxCheckBox_CheckedChanged;
            scaleToMaxCheckBox.CheckStateChanged += autoCheckBox_CheckStateChanged;
            // 
            // previewScalingNud
            // 
            previewScalingNud.Location = new System.Drawing.Point(6, 65);
            previewScalingNud.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            previewScalingNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            previewScalingNud.Name = "previewScalingNud";
            previewScalingNud.Size = new System.Drawing.Size(180, 31);
            previewScalingNud.TabIndex = 9;
            previewScalingNud.Value = new decimal(new int[] { 2, 0, 0, 0 });
            previewScalingNud.ValueChanged += previewScalingNud_ValueChanged;
            // 
            // tabFormat
            // 
            tabFormat.Controls.Add(checkBox1);
            tabFormat.Controls.Add(AligmentGb);
            tabFormat.Controls.Add(groupBox2);
            tabFormat.Controls.Add(label1);
            tabFormat.Controls.Add(numInARowNud);
            tabFormat.Controls.Add(groupBox1);
            tabFormat.Controls.Add(groupBox3);
            tabFormat.Location = new System.Drawing.Point(4, 34);
            tabFormat.Name = "tabFormat";
            tabFormat.Padding = new System.Windows.Forms.Padding(3);
            tabFormat.Size = new System.Drawing.Size(739, 289);
            tabFormat.TabIndex = 1;
            tabFormat.Text = "Save Format";
            tabFormat.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(473, 211);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(136, 29);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Add info file";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // AligmentGb
            // 
            AligmentGb.Controls.Add(alignLongRb);
            AligmentGb.Controls.Add(alignWordRb);
            AligmentGb.Controls.Add(alignByteRb);
            AligmentGb.Location = new System.Drawing.Point(450, 25);
            AligmentGb.Name = "AligmentGb";
            AligmentGb.Size = new System.Drawing.Size(159, 152);
            AligmentGb.TabIndex = 13;
            AligmentGb.TabStop = false;
            AligmentGb.Text = "Aligns As";
            AligmentGb.Visible = false;
            // 
            // alignLongRb
            // 
            alignLongRb.AutoSize = true;
            alignLongRb.Location = new System.Drawing.Point(11, 103);
            alignLongRb.Name = "alignLongRb";
            alignLongRb.Size = new System.Drawing.Size(77, 29);
            alignLongRb.TabIndex = 2;
            alignLongRb.Text = "Long";
            alignLongRb.UseVisualStyleBackColor = true;
            alignLongRb.CheckedChanged += alignLongRb_CheckedChanged_1;
            // 
            // alignWordRb
            // 
            alignWordRb.AutoSize = true;
            alignWordRb.Location = new System.Drawing.Point(11, 68);
            alignWordRb.Name = "alignWordRb";
            alignWordRb.Size = new System.Drawing.Size(81, 29);
            alignWordRb.TabIndex = 1;
            alignWordRb.Text = "Word";
            alignWordRb.UseVisualStyleBackColor = true;
            alignWordRb.CheckedChanged += alignWordRb_CheckedChanged_1;
            // 
            // alignByteRb
            // 
            alignByteRb.AutoSize = true;
            alignByteRb.Location = new System.Drawing.Point(11, 33);
            alignByteRb.Name = "alignByteRb";
            alignByteRb.Size = new System.Drawing.Size(71, 29);
            alignByteRb.TabIndex = 0;
            alignByteRb.Text = "Byte";
            alignByteRb.UseVisualStyleBackColor = true;
            alignByteRb.CheckedChanged += alignByteRb_CheckedChanged_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(longRbox);
            groupBox2.Controls.Add(wordRbox);
            groupBox2.Controls.Add(byteRbox);
            groupBox2.Location = new System.Drawing.Point(269, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(159, 152);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Save As";
            // 
            // longRbox
            // 
            longRbox.AutoSize = true;
            longRbox.Location = new System.Drawing.Point(11, 103);
            longRbox.Name = "longRbox";
            longRbox.Size = new System.Drawing.Size(77, 29);
            longRbox.TabIndex = 2;
            longRbox.TabStop = true;
            longRbox.Text = "Long";
            longRbox.UseVisualStyleBackColor = true;
            // 
            // wordRbox
            // 
            wordRbox.AutoSize = true;
            wordRbox.Location = new System.Drawing.Point(11, 68);
            wordRbox.Name = "wordRbox";
            wordRbox.Size = new System.Drawing.Size(81, 29);
            wordRbox.TabIndex = 1;
            wordRbox.TabStop = true;
            wordRbox.Text = "Word";
            wordRbox.UseVisualStyleBackColor = true;
            // 
            // byteRbox
            // 
            byteRbox.AutoSize = true;
            byteRbox.Location = new System.Drawing.Point(11, 33);
            byteRbox.Name = "byteRbox";
            byteRbox.Size = new System.Drawing.Size(71, 29);
            byteRbox.TabIndex = 0;
            byteRbox.TabStop = true;
            byteRbox.Text = "Byte";
            byteRbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(269, 181);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(157, 25);
            label1.TabIndex = 11;
            label1.Text = "Numbers in a Row";
            // 
            // numInARowNud
            // 
            numInARowNud.Location = new System.Drawing.Point(269, 211);
            numInARowNud.Name = "numInARowNud";
            numInARowNud.Size = new System.Drawing.Size(180, 31);
            numInARowNud.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(interleavedRB);
            groupBox1.Controls.Add(sequentialRB);
            groupBox1.Location = new System.Drawing.Point(9, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(239, 131);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Image Format";
            // 
            // interleavedRB
            // 
            interleavedRB.AutoSize = true;
            interleavedRB.Location = new System.Drawing.Point(9, 72);
            interleavedRB.Name = "interleavedRB";
            interleavedRB.Size = new System.Drawing.Size(124, 29);
            interleavedRB.TabIndex = 1;
            interleavedRB.Text = "Interleaved";
            interleavedRB.UseVisualStyleBackColor = true;
            interleavedRB.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // sequentialRB
            // 
            sequentialRB.AutoSize = true;
            sequentialRB.Checked = true;
            sequentialRB.Location = new System.Drawing.Point(9, 32);
            sequentialRB.Name = "sequentialRB";
            sequentialRB.Size = new System.Drawing.Size(119, 29);
            sequentialRB.TabIndex = 0;
            sequentialRB.TabStop = true;
            sequentialRB.Text = "Sequential";
            sequentialRB.UseVisualStyleBackColor = true;
            sequentialRB.CheckedChanged += sequentialRB_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(colorRegistersCombo);
            groupBox3.Controls.Add(bitsPpCombo);
            groupBox3.Location = new System.Drawing.Point(9, 153);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(239, 117);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Color Options";
            // 
            // colorRegistersCombo
            // 
            colorRegistersCombo.FormattingEnabled = true;
            colorRegistersCombo.Items.AddRange(new object[] { "$180 - $19E (0-15)", "$1A0 - $1Be (16-31)" });
            colorRegistersCombo.Location = new System.Drawing.Point(6, 68);
            colorRegistersCombo.Name = "colorRegistersCombo";
            colorRegistersCombo.Size = new System.Drawing.Size(218, 33);
            colorRegistersCombo.TabIndex = 2;
            colorRegistersCombo.Tag = "colorRegister";
            colorRegistersCombo.SelectedIndexChanged += bitsPpCombo_SelectedIndexChanged;
            // 
            // bitsPpCombo
            // 
            bitsPpCombo.FormattingEnabled = true;
            bitsPpCombo.Items.AddRange(new object[] { "4 Bit", "8 Bit" });
            bitsPpCombo.Location = new System.Drawing.Point(6, 30);
            bitsPpCombo.Name = "bitsPpCombo";
            bitsPpCombo.Size = new System.Drawing.Size(218, 33);
            bitsPpCombo.TabIndex = 0;
            bitsPpCombo.Tag = "bpp";
            bitsPpCombo.SelectedIndexChanged += bitsPpCombo_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabFormat);
            tabControl1.Controls.Add(tabDisplay);
            tabControl1.Controls.Add(tabFileExt);
            tabControl1.Location = new System.Drawing.Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(747, 327);
            tabControl1.TabIndex = 12;
            // 
            // tabFileExt
            // 
            tabFileExt.Controls.Add(groupBox6);
            tabFileExt.Controls.Add(groupBox5);
            tabFileExt.Location = new System.Drawing.Point(4, 34);
            tabFileExt.Name = "tabFileExt";
            tabFileExt.Size = new System.Drawing.Size(739, 289);
            tabFileExt.TabIndex = 3;
            tabFileExt.Text = "File Extensions";
            tabFileExt.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(radioButton5);
            groupBox5.Controls.Add(radioButton2);
            groupBox5.Controls.Add(radioButton1);
            groupBox5.Location = new System.Drawing.Point(7, 13);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(175, 161);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "C/C++";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(radioButton4);
            groupBox6.Controls.Add(radioButton3);
            groupBox6.Location = new System.Drawing.Point(188, 13);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new System.Drawing.Size(175, 161);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Assembler";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(6, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(49, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = ".c";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(6, 65);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(71, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = ".cpp";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new System.Drawing.Point(6, 30);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(141, 29);
            radioButton3.TabIndex = 1;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new System.Drawing.Point(6, 65);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new System.Drawing.Size(141, 29);
            radioButton4.TabIndex = 2;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new System.Drawing.Point(6, 100);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new System.Drawing.Size(51, 29);
            radioButton5.TabIndex = 2;
            radioButton5.TabStop = true;
            radioButton5.Text = ".h";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(751, 378);
            Controls.Add(tabControl1);
            Controls.Add(cancelBtn);
            Controls.Add(OKBtn);
            Name = "Settings";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Settings";
            tabDisplay.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)previewScalingNud).EndInit();
            tabFormat.ResumeLayout(false);
            tabFormat.PerformLayout();
            AligmentGb.ResumeLayout(false);
            AligmentGb.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numInARowNud).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabFileExt.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox scaleToMaxCheckBox;
        public System.Windows.Forms.NumericUpDown previewScalingNud;
        private System.Windows.Forms.TabPage tabFormat;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton longRbox;
        public System.Windows.Forms.RadioButton wordRbox;
        public System.Windows.Forms.RadioButton byteRbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numInARowNud;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton interleavedRB;
        public System.Windows.Forms.RadioButton sequentialRB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox colorRegistersCombo;
        private System.Windows.Forms.ComboBox bitsPpCombo;
        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.GroupBox AligmentGb;
        public System.Windows.Forms.RadioButton alignLongRb;
        public System.Windows.Forms.RadioButton alignWordRb;
        public System.Windows.Forms.RadioButton alignByteRb;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabFileExt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}