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
            numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            executeBtn = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
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
            // numericUpDown2
            // 
            numericUpDown2.Location = new System.Drawing.Point(3, 293);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new System.Drawing.Size(248, 31);
            numericUpDown2.TabIndex = 5;
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
            // button1
            // 
            button1.Location = new System.Drawing.Point(3, 406);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(248, 34);
            button1.TabIndex = 7;
            button1.Text = "Add Image";
            button1.UseVisualStyleBackColor = true;
            // 
            // Animation
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(button1);
            Controls.Add(executeBtn);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(colorsGrid);
            Name = "Animation";
            Size = new System.Drawing.Size(257, 526);
            Tag = "Side Panel";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button executeBtn;
        public ColorsGrid colorsGrid;
        private System.Windows.Forms.Button button1;
    }
}
