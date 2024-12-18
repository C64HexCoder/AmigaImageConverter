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
            resizeMethodCBox = new System.Windows.Forms.ComboBox();
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
            resizeGroupBox.Controls.Add(resizeMethodCBox);
            resizeGroupBox.Controls.Add(heightNumericUpDown);
            resizeGroupBox.Controls.Add(widthNumericUpDown);
            resizeGroupBox.Controls.Add(label2);
            resizeGroupBox.Controls.Add(label1);
            resizeGroupBox.Location = new System.Drawing.Point(3, 3);
            resizeGroupBox.Name = "resizeGroupBox";
            resizeGroupBox.Size = new System.Drawing.Size(273, 150);
            resizeGroupBox.TabIndex = 0;
            resizeGroupBox.TabStop = false;
            resizeGroupBox.Text = "Resize";
            // 
            // resizeMethodCBox
            // 
            resizeMethodCBox.FormattingEnabled = true;
            resizeMethodCBox.Items.AddRange(new object[] { "Manual", "Resize to 320 Pix WIdth", "Resize to 640 Pix Width" });
            resizeMethodCBox.Location = new System.Drawing.Point(3, 35);
            resizeMethodCBox.Name = "resizeMethodCBox";
            resizeMethodCBox.Size = new System.Drawing.Size(258, 33);
            resizeMethodCBox.TabIndex = 4;
            resizeMethodCBox.SelectedIndexChanged += resizeMethodCBox_SelectedIndexChanged;
            // 
            // heightNumericUpDown
            // 
            heightNumericUpDown.Location = new System.Drawing.Point(139, 104);
            heightNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            heightNumericUpDown.Name = "heightNumericUpDown";
            heightNumericUpDown.Size = new System.Drawing.Size(120, 31);
            heightNumericUpDown.TabIndex = 3;
            toolTip.SetToolTip(heightNumericUpDown, "Press Enter to update Width");
            heightNumericUpDown.KeyDown += heightNumericUpDown_KeyDown;
            heightNumericUpDown.Leave += heightNumericUpDown_Leave;
            // 
            // widthNumericUpDown
            // 
            widthNumericUpDown.Location = new System.Drawing.Point(3, 104);
            widthNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            widthNumericUpDown.Name = "widthNumericUpDown";
            widthNumericUpDown.Size = new System.Drawing.Size(120, 31);
            widthNumericUpDown.TabIndex = 2;
            toolTip.SetToolTip(widthNumericUpDown, "Press Enter to update Height");
            widthNumericUpDown.KeyDown += widthNumericUpDown_KeyDown;
            widthNumericUpDown.Leave += widthNumericUpDown_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(139, 78);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 25);
            label2.TabIndex = 1;
            label2.Text = "Height";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(-1, 78);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 25);
            label1.TabIndex = 0;
            label1.Text = "Width";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(colorComboBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new System.Drawing.Point(0, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(273, 178);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color Quantation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 105);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 25);
            label4.TabIndex = 3;
            label4.Text = "Colors";
            // 
            // colorComboBox
            // 
            colorComboBox.FormattingEnabled = true;
            colorComboBox.Items.AddRange(new object[] { "2", "4", "8", "16", "32", "64", "128", "256" });
            colorComboBox.Location = new System.Drawing.Point(6, 133);
            colorComboBox.Name = "colorComboBox";
            colorComboBox.Size = new System.Drawing.Size(258, 33);
            colorComboBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 27);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(101, 25);
            label3.TabIndex = 1;
            label3.Text = "Algorithem";
            // 
            // comboBox1
            // 
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(6, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(260, 33);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "K Means";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(transparentCheckBox);
            groupBox2.Controls.Add(bgColorPictureBox);
            groupBox2.Location = new System.Drawing.Point(0, 343);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(273, 127);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Backgrount Color";
            // 
            // transparentCheckBox
            // 
            transparentCheckBox.AutoSize = true;
            transparentCheckBox.Location = new System.Drawing.Point(6, 78);
            transparentCheckBox.Name = "transparentCheckBox";
            transparentCheckBox.Size = new System.Drawing.Size(174, 29);
            transparentCheckBox.TabIndex = 1;
            transparentCheckBox.Text = "Transparent Is BG";
            transparentCheckBox.UseVisualStyleBackColor = true;
            // 
            // bgColorPictureBox
            // 
            bgColorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            bgColorPictureBox.Location = new System.Drawing.Point(6, 38);
            bgColorPictureBox.Name = "bgColorPictureBox";
            bgColorPictureBox.Size = new System.Drawing.Size(258, 34);
            bgColorPictureBox.TabIndex = 0;
            bgColorPictureBox.TabStop = false;
            // 
            // doItButton
            // 
            doItButton.Location = new System.Drawing.Point(159, 502);
            doItButton.Name = "doItButton";
            doItButton.Size = new System.Drawing.Size(111, 33);
            doItButton.TabIndex = 4;
            doItButton.Text = "Do it!";
            doItButton.UseVisualStyleBackColor = true;
            doItButton.Click += doItButton_Click;
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new System.Drawing.Size(179, 25);
            toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // statusStrip
            // 
            statusStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new System.Drawing.Point(0, 553);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new System.Drawing.Size(996, 32);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            // 
            // imageBox
            // 
            imageBox.AutoCenter = false;
            imageBox.AutoScaleImageBox = false;
            imageBox.HrizontalScrollBar = null;
            imageBox.Image = null;
            imageBox.Location = new System.Drawing.Point(19, 15);
            imageBox.MouseWheelZoom = false;
            imageBox.Name = "imageBox";
            imageBox.OriginalImage = null;
            imageBox.ScaleFactor = 1;
            imageBox.ScaleFactorFloat = 1F;
            imageBox.Size = new System.Drawing.Size(686, 497);
            imageBox.TabIndex = 6;
            imageBox.TabStop = false;
            imageBox.VerticalScrollBar = null;
            imageBox.MouseClick += imageBox_MouseClick;
            // 
            // sidePael
            // 
            sidePael.Controls.Add(resizeGroupBox);
            sidePael.Controls.Add(groupBox1);
            sidePael.Controls.Add(groupBox2);
            sidePael.Controls.Add(doItButton);
            sidePael.Location = new System.Drawing.Point(711, 12);
            sidePael.Name = "sidePael";
            sidePael.Size = new System.Drawing.Size(273, 538);
            sidePael.TabIndex = 7;
            // 
            // hScrollBar
            // 
            hScrollBar.LargeChange = 100;
            hScrollBar.Location = new System.Drawing.Point(7, 513);
            hScrollBar.Name = "hScrollBar";
            hScrollBar.Size = new System.Drawing.Size(699, 20);
            hScrollBar.SmallChange = 2;
            hScrollBar.TabIndex = 8;
            hScrollBar.ValueChanged += hScrollBar_ValueChanged;
            // 
            // LoadImageDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(996, 585);
            Controls.Add(hScrollBar);
            Controls.Add(sidePael);
            Controls.Add(imageBox);
            Controls.Add(statusStrip);
            DoubleBuffered = true;
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
        private System.Windows.Forms.ComboBox resizeMethodCBox;
    }
}