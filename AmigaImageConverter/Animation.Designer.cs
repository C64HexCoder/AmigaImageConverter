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
            colorsGrid = new ColorsGrid();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            imageSelectNum = new System.Windows.Forms.NumericUpDown();
            executeBtn = new System.Windows.Forms.Button();
            addImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageSelectNum).BeginInit();
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
            executeBtn.Location = new System.Drawing.Point(3, 489);
            executeBtn.Name = "executeBtn";
            executeBtn.Size = new System.Drawing.Size(248, 34);
            executeBtn.TabIndex = 6;
            executeBtn.Text = "Excecute";
            executeBtn.UseVisualStyleBackColor = true;
            // 
            // addImageButton
            // 
            addImageButton.Location = new System.Drawing.Point(3, 406);
            addImageButton.Name = "addImageButton";
            addImageButton.Size = new System.Drawing.Size(248, 34);
            addImageButton.TabIndex = 7;
            addImageButton.Text = "Add Image";
            addImageButton.UseVisualStyleBackColor = true;
            addImageButton.Click += addImageButton_Click;
            // 
            // Animation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(addImageButton);
            Controls.Add(executeBtn);
            Controls.Add(imageSelectNum);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(colorsGrid);
            Name = "Animation";
            Size = new System.Drawing.Size(257, 526);
            Tag = "Side Panel";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageSelectNum).EndInit();
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
    }
}
