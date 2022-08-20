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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.wordAlienCB = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.byteRbox = new System.Windows.Forms.RadioButton();
            this.wordRbox = new System.Windows.Forms.RadioButton();
            this.longRbox = new System.Windows.Forms.RadioButton();
            this.OKBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.sequentialRB);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(161, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Format";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 71);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.sequentialRB.Location = new System.Drawing.Point(8, 32);
            this.sequentialRB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sequentialRB.Name = "sequentialRB";
            this.sequentialRB.Size = new System.Drawing.Size(119, 29);
            this.sequentialRB.TabIndex = 0;
            this.sequentialRB.TabStop = true;
            this.sequentialRB.Text = "Sequential";
            this.sequentialRB.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(227, 16);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 29);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Add info file";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // wordAlienCB
            // 
            this.wordAlienCB.AutoSize = true;
            this.wordAlienCB.Location = new System.Drawing.Point(227, 55);
            this.wordAlienCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.groupBox2.Location = new System.Drawing.Point(382, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 152);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save As";
            // 
            // byteRbox
            // 
            this.byteRbox.AutoSize = true;
            this.byteRbox.Location = new System.Drawing.Point(12, 33);
            this.byteRbox.Name = "byteRbox";
            this.byteRbox.Size = new System.Drawing.Size(71, 29);
            this.byteRbox.TabIndex = 0;
            this.byteRbox.TabStop = true;
            this.byteRbox.Text = "Byte";
            this.byteRbox.UseVisualStyleBackColor = true;
            // 
            // wordRbox
            // 
            this.wordRbox.AutoSize = true;
            this.wordRbox.Location = new System.Drawing.Point(12, 68);
            this.wordRbox.Name = "wordRbox";
            this.wordRbox.Size = new System.Drawing.Size(81, 29);
            this.wordRbox.TabIndex = 1;
            this.wordRbox.TabStop = true;
            this.wordRbox.Text = "Word";
            this.wordRbox.UseVisualStyleBackColor = true;
            // 
            // longRbox
            // 
            this.longRbox.AutoSize = true;
            this.longRbox.Location = new System.Drawing.Point(12, 103);
            this.longRbox.Name = "longRbox";
            this.longRbox.Size = new System.Drawing.Size(77, 29);
            this.longRbox.TabIndex = 2;
            this.longRbox.TabStop = true;
            this.longRbox.Text = "Long";
            this.longRbox.UseVisualStyleBackColor = true;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(429, 208);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(112, 34);
            this.OKBtn.TabIndex = 4;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(14, 208);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 34);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 254);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.wordAlienCB);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.RadioButton sequentialRB;
        private System.Windows.Forms.CheckBox wordAlienCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton longRbox;
        private System.Windows.Forms.RadioButton wordRbox;
        private System.Windows.Forms.RadioButton byteRbox;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}