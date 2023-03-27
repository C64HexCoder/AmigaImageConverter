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
            components = new System.ComponentModel.Container();
            resizeGroupBox = new System.Windows.Forms.GroupBox();
            heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            colorComboBox = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            transparentCheckBox = new System.Windows.Forms.CheckBox();
            bgColorPictureBox = new System.Windows.Forms.PictureBox();
            doItButton = new System.Windows.Forms.Button();
            toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            statusStrip = new System.Windows.Forms.StatusStrip();
            imageBox = new Amiga.ImageBox();
            sidePael = new System.Windows.Forms.Panel();
            toolTip = new System.Windows.Forms.ToolTip(components);
            hScrollBar = new System.Windows.Forms.HScrollBar();
            resizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heightNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)widthNumericUpDown).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bgColorPictureBox).BeginInit();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            sidePael.SuspendLayout();
            SuspendLayout();
            // 
            // resizeGroupBox
            // 
            resizeGroupBox.Controls.Add(heightNumericUpDown);
            resizeGroupBox.Controls.Add(widthNumericUpDown);
            resizeGroupBox.Controls.Add(label2);
            resizeGroupBox.Controls.Add(label1);
            resizeGroupBox.Location = new System.Drawing.Point(2, 2);
            resizeGroupBox.Margin = new System.Windows.Forms.Padding(2);
            resizeGroupBox.Name = "resizeGroupBox";
            resizeGroupBox.Padding = new System.Windows.Forms.Padding(2);
            resizeGroupBox.Size = new System.Drawing.Size(191, 90);
            resizeGroupBox.TabIndex = 0;
            resizeGroupBox.TabStop = false;
            resizeGroupBox.Text = "Resize";
            // 
            // heightNumericUpDown
            // 
            heightNumericUpDown.Location = new System.Drawing.Point(102, 47);
            heightNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            heightNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            heightNumericUpDown.Name = "heightNumericUpDown";
            heightNumericUpDown.Size = new System.Drawing.Size(84, 23);
            heightNumericUpDown.TabIndex = 3;
            heightNumericUpDown.ValueChanged += heightNumericUpDown_ValueChanged;
            // 
            // widthNumericUpDown
            // 
            widthNumericUpDown.Location = new System.Drawing.Point(7, 47);
            widthNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            widthNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            widthNumericUpDown.Name = "widthNumericUpDown";
            widthNumericUpDown.Size = new System.Drawing.Size(84, 23);
            widthNumericUpDown.TabIndex = 2;
            widthNumericUpDown.ValueChanged += widthNumericUpDown_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(102, 31);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Height";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 31);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Width";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(colorComboBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new System.Drawing.Point(0, 95);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(191, 107);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color Quantation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(4, 63);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "Colors";
            // 
            // colorComboBox
            // 
            colorComboBox.FormattingEnabled = true;
            colorComboBox.Items.AddRange(new object[] { "2", "4", "8", "16", "32", "64", "128", "256" });
            colorComboBox.Location = new System.Drawing.Point(4, 80);
            colorComboBox.Margin = new System.Windows.Forms.Padding(2);
            colorComboBox.Name = "colorComboBox";
            colorComboBox.Size = new System.Drawing.Size(182, 23);
            colorComboBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(4, 16);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(67, 15);
            label3.TabIndex = 1;
            label3.Text = "Algorithem";
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(4, 33);
            comboBox1.Margin = new System.Windows.Forms.Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(183, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "K Means";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(transparentCheckBox);
            groupBox2.Controls.Add(bgColorPictureBox);
            groupBox2.Location = new System.Drawing.Point(0, 206);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(191, 76);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Backgrount Color";
            // 
            // transparentCheckBox
            // 
            transparentCheckBox.AutoSize = true;
            transparentCheckBox.Location = new System.Drawing.Point(4, 47);
            transparentCheckBox.Margin = new System.Windows.Forms.Padding(2);
            transparentCheckBox.Name = "transparentCheckBox";
            transparentCheckBox.Size = new System.Drawing.Size(116, 19);
            transparentCheckBox.TabIndex = 1;
            transparentCheckBox.Text = "Transparent Is BG";
            transparentCheckBox.UseVisualStyleBackColor = true;
            // 
            // bgColorPictureBox
            // 
            bgColorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            bgColorPictureBox.Location = new System.Drawing.Point(4, 23);
            bgColorPictureBox.Margin = new System.Windows.Forms.Padding(2);
            bgColorPictureBox.Name = "bgColorPictureBox";
            bgColorPictureBox.Size = new System.Drawing.Size(181, 21);
            bgColorPictureBox.TabIndex = 0;
            bgColorPictureBox.TabStop = false;
            // 
            // doItButton
            // 
            doItButton.Location = new System.Drawing.Point(111, 301);
            doItButton.Margin = new System.Windows.Forms.Padding(2);
            doItButton.Name = "doItButton";
            doItButton.Size = new System.Drawing.Size(78, 20);
            doItButton.TabIndex = 4;
            doItButton.Text = "Do it!";
            doItButton.UseVisualStyleBackColor = true;
            doItButton.Click += doItButton_Click;
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // statusStrip
            // 
            statusStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new System.Drawing.Point(0, 329);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            statusStrip.Size = new System.Drawing.Size(697, 22);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            // 
            // imageBox
            // 
            imageBox.Location = new System.Drawing.Point(5, 7);
            imageBox.Margin = new System.Windows.Forms.Padding(2);
            imageBox.Name = "imageBox";
            imageBox.ScaleFactor = 1;
            imageBox.ScaleFactorFloat = 1F;
            imageBox.Size = new System.Drawing.Size(489, 298);
            imageBox.TabIndex = 6;
            imageBox.TabStop = false;
            imageBox.MouseClick += imageBox_MouseClick;
            // 
            // sidePael
            // 
            sidePael.Controls.Add(resizeGroupBox);
            sidePael.Controls.Add(groupBox1);
            sidePael.Controls.Add(groupBox2);
            sidePael.Controls.Add(doItButton);
            sidePael.Location = new System.Drawing.Point(498, 7);
            sidePael.Margin = new System.Windows.Forms.Padding(2);
            sidePael.Name = "sidePael";
            sidePael.Size = new System.Drawing.Size(191, 323);
            sidePael.TabIndex = 7;
            // 
            // hScrollBar
            // 
            hScrollBar.LargeChange = 100;
            hScrollBar.Location = new System.Drawing.Point(5, 308);
            hScrollBar.Name = "hScrollBar";
            hScrollBar.Size = new System.Drawing.Size(489, 20);
            hScrollBar.SmallChange = 2;
            hScrollBar.TabIndex = 8;
            hScrollBar.ValueChanged += hScrollBar_ValueChanged;
            // 
            // LoadImageDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(697, 351);
            Controls.Add(hScrollBar);
            Controls.Add(sidePael);
            Controls.Add(imageBox);
            Controls.Add(statusStrip);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "LoadImageDialog";
            Text = "Load Image Dialog";
            resizeGroupBox.ResumeLayout(false);
            resizeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)heightNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)widthNumericUpDown).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bgColorPictureBox).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            sidePael.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button doItButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private Amiga.ImageBox imageBox;
        private System.Windows.Forms.Panel sidePael;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.HScrollBar hScrollBar;
    }
}