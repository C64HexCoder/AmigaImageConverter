namespace AmigaImageConverter
{
    partial class Animation
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
            components = new System.ComponentModel.Container();
            colorsGrid = new ColorsGrid();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            imageSelectNum = new System.Windows.Forms.NumericUpDown();
            executeBtn = new System.Windows.Forms.Button();
            addImageButton = new System.Windows.Forms.Button();
            maxSpriteHeightNumeric = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            equalizeButton = new System.Windows.Forms.Button();
            heightNumeric = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            toolTip = new System.Windows.Forms.ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageSelectNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxSpriteHeightNumeric).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heightNumeric).BeginInit();
            SuspendLayout();
            // 
            // colorsGrid
            // 
            colorsGrid.Location = new System.Drawing.Point(3, 3);
            colorsGrid.Name = "colorsGrid";
            colorsGrid.NumOfColors = 4;
            colorsGrid.paletteFormat = ColorsGrid.PaletteFormat.TwelveBit;
            colorsGrid.Size = new System.Drawing.Size(248, 272);
            colorsGrid.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(3, 330);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(251, 33);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 371);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 25);
            label1.TabIndex = 3;
            label1.Text = "Split";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(56, 369);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(198, 31);
            numericUpDown1.TabIndex = 4;
            // 
            // imageSelectNum
            // 
            imageSelectNum.Location = new System.Drawing.Point(3, 293);
            imageSelectNum.Name = "imageSelectNum";
            imageSelectNum.Size = new System.Drawing.Size(248, 31);
            imageSelectNum.TabIndex = 5;
            imageSelectNum.ValueChanged += imageSelectNum_ValueChanged;
            // 
            // executeBtn
            // 
            executeBtn.Location = new System.Drawing.Point(3, 633);
            executeBtn.Name = "executeBtn";
            executeBtn.Size = new System.Drawing.Size(248, 34);
            executeBtn.TabIndex = 6;
            executeBtn.Text = "Excecute";
            executeBtn.UseVisualStyleBackColor = true;
            executeBtn.Click += executeBtn_Click;
            // 
            // addImageButton
            // 
            addImageButton.Location = new System.Drawing.Point(3, 580);
            addImageButton.Name = "addImageButton";
            addImageButton.Size = new System.Drawing.Size(248, 34);
            addImageButton.TabIndex = 7;
            addImageButton.Text = "Add Image";
            addImageButton.UseVisualStyleBackColor = true;
            addImageButton.Click += addImageButton_Click;
            // 
            // maxSpriteHeightNumeric
            // 
            maxSpriteHeightNumeric.Location = new System.Drawing.Point(127, 70);
            maxSpriteHeightNumeric.Name = "maxSpriteHeightNumeric";
            maxSpriteHeightNumeric.ReadOnly = true;
            maxSpriteHeightNumeric.Size = new System.Drawing.Size(112, 31);
            maxSpriteHeightNumeric.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 72);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(103, 25);
            label2.TabIndex = 9;
            label2.Text = "Max Height";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(equalizeButton);
            groupBox1.Controls.Add(heightNumeric);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(maxSpriteHeightNumeric);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new System.Drawing.Point(3, 406);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(245, 156);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sprite Height";
            // 
            // equalizeButton
            // 
            equalizeButton.Location = new System.Drawing.Point(127, 116);
            equalizeButton.Name = "equalizeButton";
            equalizeButton.Size = new System.Drawing.Size(112, 34);
            equalizeButton.TabIndex = 12;
            equalizeButton.Text = "Equalize";
            toolTip.SetToolTip(equalizeButton, "Equalize all sprites height");
            equalizeButton.UseVisualStyleBackColor = true;
            equalizeButton.Click += equalizeButton_Click;
            // 
            // heightNumeric
            // 
            heightNumeric.Location = new System.Drawing.Point(127, 30);
            heightNumeric.Name = "heightNumeric";
            heightNumeric.ReadOnly = true;
            heightNumeric.Size = new System.Drawing.Size(112, 31);
            heightNumeric.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 32);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 25);
            label3.TabIndex = 11;
            label3.Text = "Height";
            // 
            // Animation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(groupBox1);
            Controls.Add(addImageButton);
            Controls.Add(executeBtn);
            Controls.Add(imageSelectNum);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(colorsGrid);
            Name = "Animation";
            Size = new System.Drawing.Size(257, 670);
            Tag = "Side Panel";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageSelectNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxSpriteHeightNumeric).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)heightNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown imageSelectNum;
        private System.Windows.Forms.Button executeBtn;
        public ColorsGrid colorsGrid;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.NumericUpDown maxSpriteHeightNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown heightNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button equalizeButton;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
