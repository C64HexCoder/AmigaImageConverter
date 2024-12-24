namespace AmigaImageConverter
{
    partial class ImageToSpriteControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidePael = new System.Windows.Forms.Panel();
            spritePrevPanel = new System.Windows.Forms.Panel();
            spritePreviewIB = new Amiga.ImageBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            resizeBtn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            spriteNameTb = new System.Windows.Forms.TextBox();
            spriteNum = new System.Windows.Forms.NumericUpDown();
            spriteWidtthCbox = new System.Windows.Forms.GroupBox();
            spriteWIdthCbox = new System.Windows.Forms.ComboBox();
            doItButton = new System.Windows.Forms.Button();
            sidePael.SuspendLayout();
            spritePrevPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spritePreviewIB).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)widthNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heightNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spriteNum).BeginInit();
            spriteWidtthCbox.SuspendLayout();
            SuspendLayout();
            // 
            // sidePael
            // 
            sidePael.Controls.Add(spritePrevPanel);
            sidePael.Controls.Add(groupBox1);
            sidePael.Controls.Add(label3);
            sidePael.Controls.Add(spriteNameTb);
            sidePael.Controls.Add(spriteNum);
            sidePael.Controls.Add(spriteWidtthCbox);
            sidePael.Controls.Add(doItButton);
            sidePael.Location = new System.Drawing.Point(3, 3);
            sidePael.Name = "sidePael";
            sidePael.Size = new System.Drawing.Size(273, 677);
            sidePael.TabIndex = 9;
            // 
            // spritePrevPanel
            // 
            spritePrevPanel.Controls.Add(spritePreviewIB);
            spritePrevPanel.Location = new System.Drawing.Point(0, 290);
            spritePrevPanel.Name = "spritePrevPanel";
            spritePrevPanel.Size = new System.Drawing.Size(270, 308);
            spritePrevPanel.TabIndex = 11;
            // 
            // spritePreviewIB
            // 
            spritePreviewIB.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            spritePreviewIB.AutoCenter = false;
            spritePreviewIB.AutoScaleImageBox = false;
            spritePreviewIB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            spritePreviewIB.HrizontalScrollBar = null;
            spritePreviewIB.Image = null;
            spritePreviewIB.Location = new System.Drawing.Point(3, 3);
            spritePreviewIB.MaxImageScale = 4;
            spritePreviewIB.MouseWheelZoom = true;
            spritePreviewIB.Name = "spritePreviewIB";
            spritePreviewIB.OriginalImage = null;
            spritePreviewIB.ScaleFactor = 2;
            spritePreviewIB.ScaleFactorFloat = 1F;
            spritePreviewIB.Size = new System.Drawing.Size(340, 513);
            spritePreviewIB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            spritePreviewIB.TabIndex = 6;
            spritePreviewIB.TabStop = false;
            spritePreviewIB.VerticalScrollBar = null;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(resizeBtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(widthNumericUpDown);
            groupBox1.Controls.Add(heightNumericUpDown);
            groupBox1.Location = new System.Drawing.Point(10, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(254, 151);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Image size";
            // 
            // resizeBtn
            // 
            resizeBtn.Location = new System.Drawing.Point(136, 111);
            resizeBtn.Name = "resizeBtn";
            resizeBtn.Size = new System.Drawing.Size(112, 34);
            resizeBtn.TabIndex = 4;
            resizeBtn.Text = "Resize";
            resizeBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 25);
            label1.TabIndex = 0;
            label1.Text = "Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(146, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 25);
            label2.TabIndex = 1;
            label2.Text = "Height";
            // 
            // widthNumericUpDown
            // 
            widthNumericUpDown.Location = new System.Drawing.Point(10, 53);
            widthNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            widthNumericUpDown.Name = "widthNumericUpDown";
            widthNumericUpDown.Size = new System.Drawing.Size(102, 31);
            widthNumericUpDown.TabIndex = 2;
            // 
            // heightNumericUpDown
            // 
            heightNumericUpDown.Location = new System.Drawing.Point(146, 53);
            heightNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            heightNumericUpDown.Name = "heightNumericUpDown";
            heightNumericUpDown.Size = new System.Drawing.Size(102, 31);
            heightNumericUpDown.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(10, 170);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(110, 25);
            label3.TabIndex = 9;
            label3.Text = "Sprite Name";
            // 
            // spriteNameTb
            // 
            spriteNameTb.Location = new System.Drawing.Point(10, 253);
            spriteNameTb.Name = "spriteNameTb";
            spriteNameTb.Size = new System.Drawing.Size(254, 31);
            spriteNameTb.TabIndex = 8;
            // 
            // spriteNum
            // 
            spriteNum.Location = new System.Drawing.Point(13, 604);
            spriteNum.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            spriteNum.Name = "spriteNum";
            spriteNum.Size = new System.Drawing.Size(254, 31);
            spriteNum.TabIndex = 7;
            // 
            // spriteWidtthCbox
            // 
            spriteWidtthCbox.Controls.Add(spriteWIdthCbox);
            spriteWidtthCbox.Location = new System.Drawing.Point(3, 3);
            spriteWidtthCbox.Name = "spriteWidtthCbox";
            spriteWidtthCbox.Size = new System.Drawing.Size(273, 82);
            spriteWidtthCbox.TabIndex = 0;
            spriteWidtthCbox.TabStop = false;
            spriteWidtthCbox.Text = "Sprite Width";
            // 
            // spriteWIdthCbox
            // 
            spriteWIdthCbox.FormattingEnabled = true;
            spriteWIdthCbox.Items.AddRange(new object[] { "16 pixels wide sprite", "32 pixels wide sprite", "64 pixels wide sprite" });
            spriteWIdthCbox.Location = new System.Drawing.Point(3, 35);
            spriteWIdthCbox.Name = "spriteWIdthCbox";
            spriteWIdthCbox.Size = new System.Drawing.Size(258, 33);
            spriteWIdthCbox.TabIndex = 4;
            // 
            // doItButton
            // 
            doItButton.Location = new System.Drawing.Point(156, 641);
            doItButton.Name = "doItButton";
            doItButton.Size = new System.Drawing.Size(111, 33);
            doItButton.TabIndex = 4;
            doItButton.Text = "Do it!";
            doItButton.UseVisualStyleBackColor = true;
            // 
            // ImageToSpriteControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(sidePael);
            Name = "ImageToSpriteControl";
            Size = new System.Drawing.Size(279, 683);
            sidePael.ResumeLayout(false);
            sidePael.PerformLayout();
            spritePrevPanel.ResumeLayout(false);
            spritePrevPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spritePreviewIB).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)widthNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)heightNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)spriteNum).EndInit();
            spriteWidtthCbox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel sidePael;
        private System.Windows.Forms.Panel spritePrevPanel;
        private Amiga.ImageBox spritePreviewIB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resizeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox spriteNameTb;
        private System.Windows.Forms.NumericUpDown spriteNum;
        private System.Windows.Forms.GroupBox spriteWidtthCbox;
        private System.Windows.Forms.ComboBox spriteWIdthCbox;
        private System.Windows.Forms.Button doItButton;
    }
}
