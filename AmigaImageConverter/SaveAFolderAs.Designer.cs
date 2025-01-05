namespace AmigaImageConverter
{
    partial class SaveAFolderAs
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            folderSelectBtn = new System.Windows.Forms.Button();
            folderNameTextBox = new System.Windows.Forms.TextBox();
            fileFormatComboBox = new System.Windows.Forms.ComboBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            fileExtensionComboBox = new System.Windows.Forms.ComboBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            executeBtn = new System.Windows.Forms.Button();
            progressBar = new System.Windows.Forms.ProgressBar();
            spriteWidthGB = new System.Windows.Forms.GroupBox();
            spriteWidthComboBox = new System.Windows.Forms.ComboBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            relativeCheckBox = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            yPosNumUpDown = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            xPosNumUpDown = new System.Windows.Forms.NumericUpDown();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            spriteWidthGB.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yPosNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xPosNumUpDown).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(folderSelectBtn);
            groupBox1.Controls.Add(folderNameTextBox);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(776, 115);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Folder";
            // 
            // folderSelectBtn
            // 
            folderSelectBtn.AutoSize = true;
            folderSelectBtn.Location = new System.Drawing.Point(653, 74);
            folderSelectBtn.Name = "folderSelectBtn";
            folderSelectBtn.Size = new System.Drawing.Size(123, 35);
            folderSelectBtn.TabIndex = 1;
            folderSelectBtn.Text = "Select Folder";
            folderSelectBtn.UseVisualStyleBackColor = true;
            folderSelectBtn.Click += folderSelectBtn_Click;
            // 
            // folderNameTextBox
            // 
            folderNameTextBox.Location = new System.Drawing.Point(6, 32);
            folderNameTextBox.Name = "folderNameTextBox";
            folderNameTextBox.Size = new System.Drawing.Size(770, 31);
            folderNameTextBox.TabIndex = 0;
            folderNameTextBox.Text = "Choose a Folder in which the Sprite Images (IFF) exists";
            // 
            // fileFormatComboBox
            // 
            fileFormatComboBox.FormattingEnabled = true;
            fileFormatComboBox.Items.AddRange(new object[] { "Assembly Source File", "C?CPP Source File", "Binary File" });
            fileFormatComboBox.Location = new System.Drawing.Point(6, 30);
            fileFormatComboBox.Name = "fileFormatComboBox";
            fileFormatComboBox.Size = new System.Drawing.Size(274, 33);
            fileFormatComboBox.TabIndex = 1;
            fileFormatComboBox.SelectedIndexChanged += fileFormatComboBox_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(fileFormatComboBox);
            groupBox2.Location = new System.Drawing.Point(18, 133);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(291, 76);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "File Format";
            // 
            // fileExtensionComboBox
            // 
            fileExtensionComboBox.FormattingEnabled = true;
            fileExtensionComboBox.Location = new System.Drawing.Point(0, 30);
            fileExtensionComboBox.Name = "fileExtensionComboBox";
            fileExtensionComboBox.Size = new System.Drawing.Size(188, 33);
            fileExtensionComboBox.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(fileExtensionComboBox);
            groupBox3.Location = new System.Drawing.Point(315, 133);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(195, 76);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Extension";
            // 
            // executeBtn
            // 
            executeBtn.Location = new System.Drawing.Point(676, 316);
            executeBtn.Name = "executeBtn";
            executeBtn.Size = new System.Drawing.Size(112, 34);
            executeBtn.TabIndex = 5;
            executeBtn.Text = "Execute";
            executeBtn.UseVisualStyleBackColor = true;
            executeBtn.Click += executeBtn_Click;
            // 
            // progressBar
            // 
            progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            progressBar.Location = new System.Drawing.Point(0, 372);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(800, 34);
            progressBar.TabIndex = 6;
            // 
            // spriteWidthGB
            // 
            spriteWidthGB.Controls.Add(spriteWidthComboBox);
            spriteWidthGB.Location = new System.Drawing.Point(516, 133);
            spriteWidthGB.Name = "spriteWidthGB";
            spriteWidthGB.Size = new System.Drawing.Size(272, 76);
            spriteWidthGB.TabIndex = 7;
            spriteWidthGB.TabStop = false;
            spriteWidthGB.Text = "Sprite Width";
            // 
            // spriteWidthComboBox
            // 
            spriteWidthComboBox.FormattingEnabled = true;
            spriteWidthComboBox.Items.AddRange(new object[] { "16 Pixels", "32 Pixels", "64 Pixels" });
            spriteWidthComboBox.Location = new System.Drawing.Point(6, 30);
            spriteWidthComboBox.Name = "spriteWidthComboBox";
            spriteWidthComboBox.Size = new System.Drawing.Size(260, 33);
            spriteWidthComboBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(relativeCheckBox);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(yPosNumUpDown);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(xPosNumUpDown);
            groupBox4.Location = new System.Drawing.Point(24, 215);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(426, 147);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sprite Position";
            // 
            // relativeCheckBox
            // 
            relativeCheckBox.AutoSize = true;
            relativeCheckBox.Location = new System.Drawing.Point(6, 106);
            relativeCheckBox.Name = "relativeCheckBox";
            relativeCheckBox.Size = new System.Drawing.Size(251, 29);
            relativeCheckBox.TabIndex = 4;
            relativeCheckBox.Text = "Proporsional To DIWSTART";
            relativeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(230, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 25);
            label2.TabIndex = 3;
            label2.Text = "Y Pos";
            // 
            // yPosNumUpDown
            // 
            yPosNumUpDown.Location = new System.Drawing.Point(230, 60);
            yPosNumUpDown.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            yPosNumUpDown.Name = "yPosNumUpDown";
            yPosNumUpDown.Size = new System.Drawing.Size(180, 31);
            yPosNumUpDown.TabIndex = 2;
            yPosNumUpDown.ValueChanged += yPosNumUpDown_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 25);
            label1.TabIndex = 1;
            label1.Text = "X Pos";
            // 
            // xPosNumUpDown
            // 
            xPosNumUpDown.Location = new System.Drawing.Point(6, 60);
            xPosNumUpDown.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            xPosNumUpDown.Name = "xPosNumUpDown";
            xPosNumUpDown.Size = new System.Drawing.Size(180, 31);
            xPosNumUpDown.TabIndex = 0;
            xPosNumUpDown.ValueChanged += xPosNumUpDown_ValueChanged;
            // 
            // SaveAFolderAs
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 406);
            Controls.Add(groupBox4);
            Controls.Add(spriteWidthGB);
            Controls.Add(progressBar);
            Controls.Add(executeBtn);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SaveAFolderAs";
            Text = "Save All Images in A Folder As ...";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            spriteWidthGB.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yPosNumUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)xPosNumUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button folderSelectBtn;
        private System.Windows.Forms.TextBox folderNameTextBox;
        private System.Windows.Forms.ComboBox fileFormatComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox fileExtensionComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox spriteWidthGB;
        private System.Windows.Forms.ComboBox spriteWidthComboBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown xPosNumUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown yPosNumUpDown;
        private System.Windows.Forms.CheckBox relativeCheckBox;
    }
}