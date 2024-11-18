namespace AmigaImageConverter
{
    partial class ImageSaveDialog
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
            groupBox2 = new System.Windows.Forms.GroupBox();
            longRbox = new System.Windows.Forms.RadioButton();
            wordRbox = new System.Windows.Forms.RadioButton();
            byteRbox = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            dataPerRowNud = new System.Windows.Forms.NumericUpDown();
            groupBox1 = new System.Windows.Forms.GroupBox();
            interleavedRB = new System.Windows.Forms.RadioButton();
            sequentialRB = new System.Windows.Forms.RadioButton();
            groupBox3 = new System.Windows.Forms.GroupBox();
            colorRegistersCombo = new System.Windows.Forms.ComboBox();
            bitsPpCombo = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            arrayNameTextBox = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataPerRowNud).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(longRbox);
            groupBox2.Controls.Add(wordRbox);
            groupBox2.Controls.Add(byteRbox);
            groupBox2.Location = new System.Drawing.Point(306, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(159, 141);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data Type";
            // 
            // longRbox
            // 
            longRbox.AutoSize = true;
            longRbox.Location = new System.Drawing.Point(11, 103);
            longRbox.Name = "longRbox";
            longRbox.Size = new System.Drawing.Size(77, 29);
            longRbox.TabIndex = 2;
            longRbox.Text = "Long";
            longRbox.UseVisualStyleBackColor = true;
            longRbox.CheckedChanged += longRbox_CheckedChanged;
            // 
            // wordRbox
            // 
            wordRbox.AutoSize = true;
            wordRbox.Checked = true;
            wordRbox.Location = new System.Drawing.Point(11, 68);
            wordRbox.Name = "wordRbox";
            wordRbox.Size = new System.Drawing.Size(81, 29);
            wordRbox.TabIndex = 1;
            wordRbox.TabStop = true;
            wordRbox.Text = "Word";
            wordRbox.UseVisualStyleBackColor = true;
            wordRbox.CheckedChanged += wordRbox_CheckedChanged;
            // 
            // byteRbox
            // 
            byteRbox.AutoSize = true;
            byteRbox.Location = new System.Drawing.Point(11, 33);
            byteRbox.Name = "byteRbox";
            byteRbox.Size = new System.Drawing.Size(71, 29);
            byteRbox.TabIndex = 0;
            byteRbox.Text = "Byte";
            byteRbox.UseVisualStyleBackColor = true;
            byteRbox.CheckedChanged += byteRbox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(306, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(157, 25);
            label1.TabIndex = 18;
            label1.Text = "Numbers in a Row";
            // 
            // dataPerRowNud
            // 
            dataPerRowNud.Location = new System.Drawing.Point(306, 37);
            dataPerRowNud.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            dataPerRowNud.Name = "dataPerRowNud";
            dataPerRowNud.Size = new System.Drawing.Size(180, 31);
            dataPerRowNud.TabIndex = 17;
            dataPerRowNud.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(interleavedRB);
            groupBox1.Controls.Add(sequentialRB);
            groupBox1.Location = new System.Drawing.Point(12, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(266, 141);
            groupBox1.TabIndex = 15;
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
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(colorRegistersCombo);
            groupBox3.Controls.Add(bitsPpCombo);
            groupBox3.Location = new System.Drawing.Point(12, 237);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(266, 117);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Color Options";
            groupBox3.Visible = false;
            // 
            // colorRegistersCombo
            // 
            colorRegistersCombo.FormattingEnabled = true;
            colorRegistersCombo.Items.AddRange(new object[] { "$180 - $19E (0-15)", "$1A0 - $1Be (16-31)" });
            colorRegistersCombo.Location = new System.Drawing.Point(6, 68);
            colorRegistersCombo.Name = "colorRegistersCombo";
            colorRegistersCombo.Size = new System.Drawing.Size(254, 33);
            colorRegistersCombo.TabIndex = 2;
            colorRegistersCombo.Tag = "colorRegister";
            // 
            // bitsPpCombo
            // 
            bitsPpCombo.DisplayMember = "BitValue";
            bitsPpCombo.FormattingEnabled = true;
            bitsPpCombo.Items.AddRange(new object[] { "4 Bit", "8 Bit" });
            bitsPpCombo.Location = new System.Drawing.Point(6, 30);
            bitsPpCombo.Name = "bitsPpCombo";
            bitsPpCombo.Size = new System.Drawing.Size(254, 33);
            bitsPpCombo.TabIndex = 0;
            bitsPpCombo.Tag = "bpp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(106, 25);
            label2.TabIndex = 22;
            label2.Text = "Array Name";
            // 
            // arrayNameTextBox
            // 
            arrayNameTextBox.Location = new System.Drawing.Point(12, 37);
            arrayNameTextBox.Name = "arrayNameTextBox";
            arrayNameTextBox.Size = new System.Drawing.Size(266, 31);
            arrayNameTextBox.TabIndex = 23;
            arrayNameTextBox.TextChanged += arrayNameTextBox_TextChanged;
            // 
            // button1
            // 
            button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            button1.Location = new System.Drawing.Point(371, 309);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 34);
            button1.TabIndex = 24;
            button1.Text = "Save it!";
            button1.UseVisualStyleBackColor = true;
            // 
            // ImageSaveDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(495, 355);
            Controls.Add(button1);
            Controls.Add(arrayNameTextBox);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(dataPerRowNud);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "ImageSaveDialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Image Save Options";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataPerRowNud).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton longRbox;
        public System.Windows.Forms.RadioButton wordRbox;
        public System.Windows.Forms.RadioButton byteRbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown dataPerRowNud;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton interleavedRB;
        public System.Windows.Forms.RadioButton sequentialRB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox colorRegistersCombo;
        private System.Windows.Forms.ComboBox bitsPpCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox arrayNameTextBox;
        private System.Windows.Forms.Button button1;
    }
}