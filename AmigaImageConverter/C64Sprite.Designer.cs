namespace AmigaImageConverter
{
    partial class C64Sprite
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
            spriteGrid = new C64.Controls.Sprite();
            helpProvider1 = new System.Windows.Forms.HelpProvider();
            spritePalette1 = new C64.Controls.SpritePalette();
            multiColorCheckBox = new System.Windows.Forms.CheckBox();
            clearButton = new System.Windows.Forms.Button();
            showGridButton = new System.Windows.Forms.CheckBox();
            saveButton = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new System.Windows.Forms.GroupBox();
            bankNumber = new System.Windows.Forms.NumericUpDown();
            spriteAddressHb = new C64.Controls.HexBox();
            label1 = new System.Windows.Forms.Label();
            spriteNumber = new System.Windows.Forms.NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bankNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spriteNumber).BeginInit();
            SuspendLayout();
            // 
            // spriteGrid
            // 
            spriteGrid.CellWidthHeight = 20;
            spriteGrid.ColorProvider = null;
            spriteGrid.GridColor = System.Drawing.Color.DarkOrange;
            spriteGrid.IsMulticolor = false;
            spriteGrid.Location = new System.Drawing.Point(12, 12);
            spriteGrid.Name = "spriteGrid";
            spriteGrid.ShowGrid = true;
            spriteGrid.Size = new System.Drawing.Size(481, 421);
            spriteGrid.TabIndex = 0;
            // 
            // spritePalette1
            // 
            spritePalette1.AutoSize = true;
            spritePalette1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            spritePalette1.Location = new System.Drawing.Point(12, 439);
            spritePalette1.Name = "spritePalette1";
            spritePalette1.SelectedSlotIndex = 0;
            spritePalette1.Size = new System.Drawing.Size(476, 59);
            spritePalette1.TabIndex = 1;
            // 
            // multiColorCheckBox
            // 
            multiColorCheckBox.AutoSize = true;
            multiColorCheckBox.Location = new System.Drawing.Point(523, 12);
            multiColorCheckBox.Name = "multiColorCheckBox";
            multiColorCheckBox.Size = new System.Drawing.Size(126, 29);
            multiColorCheckBox.TabIndex = 2;
            multiColorCheckBox.Text = "Multi Color";
            multiColorCheckBox.UseVisualStyleBackColor = true;
            multiColorCheckBox.CheckedChanged += multiColorCheckBox_CheckedChanged;
            // 
            // clearButton
            // 
            clearButton.Location = new System.Drawing.Point(523, 373);
            clearButton.Name = "clearButton";
            clearButton.Size = new System.Drawing.Size(112, 34);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // showGridButton
            // 
            showGridButton.AutoSize = true;
            showGridButton.Location = new System.Drawing.Point(523, 47);
            showGridButton.Name = "showGridButton";
            showGridButton.Size = new System.Drawing.Size(120, 29);
            showGridButton.TabIndex = 4;
            showGridButton.Text = "Show Grid";
            showGridButton.UseVisualStyleBackColor = true;
            showGridButton.CheckedChanged += showGridButton_CheckedChanged;
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(676, 474);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(112, 34);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save As ...";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bankNumber);
            groupBox1.Controls.Add(spriteAddressHb);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(spriteNumber);
            groupBox1.Location = new System.Drawing.Point(523, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(239, 205);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sprite Address";
            // 
            // bankNumber
            // 
            bankNumber.Location = new System.Drawing.Point(6, 67);
            bankNumber.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            bankNumber.Name = "bankNumber";
            bankNumber.Size = new System.Drawing.Size(227, 31);
            bankNumber.TabIndex = 3;
            bankNumber.ValueChanged += bankNumber_ValueChanged;
            // 
            // spriteAddressHb
            // 
            spriteAddressHb.AutoSize = true;
            spriteAddressHb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            spriteAddressHb.Location = new System.Drawing.Point(57, 141);
            spriteAddressHb.Name = "spriteAddressHb";
            spriteAddressHb.Size = new System.Drawing.Size(121, 57);
            spriteAddressHb.TabIndex = 2;
            spriteAddressHb.Value = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(128, 25);
            label1.TabIndex = 1;
            label1.Text = "Sprite Number";
            // 
            // spriteNumber
            // 
            spriteNumber.Location = new System.Drawing.Point(6, 104);
            spriteNumber.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            spriteNumber.Name = "spriteNumber";
            spriteNumber.Size = new System.Drawing.Size(227, 31);
            spriteNumber.TabIndex = 0;
            spriteNumber.ValueChanged += spriteNumber_ValueChanged;
            // 
            // C64Sprite
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 520);
            Controls.Add(groupBox1);
            Controls.Add(saveButton);
            Controls.Add(showGridButton);
            Controls.Add(clearButton);
            Controls.Add(multiColorCheckBox);
            Controls.Add(spritePalette1);
            Controls.Add(spriteGrid);
            Name = "C64Sprite";
            Text = "C64Sprite";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bankNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)spriteNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private C64.Controls.Sprite spriteGrid;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private C64.Controls.SpritePalette spritePalette1;
        private System.Windows.Forms.CheckBox multiColorCheckBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox showGridButton;
        private System.Windows.Forms.Button saveButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spriteNumber;
        private C64.Controls.HexBox spriteAddressHb;
        private System.Windows.Forms.NumericUpDown bankNumber;
    }
}
