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
            SuspendLayout();
            // 
            // spriteGrid
            // 
            spriteGrid.CellWidthHeight = 20;
            spriteGrid.ColorProvider = null;
            spriteGrid.IsMulticolor = false;
            spriteGrid.Location = new System.Drawing.Point(12, 12);
            spriteGrid.Name = "spriteGrid";
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
            clearButton.Location = new System.Drawing.Point(523, 47);
            clearButton.Name = "clearButton";
            clearButton.Size = new System.Drawing.Size(112, 34);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // C64Sprite
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 520);
            Controls.Add(clearButton);
            Controls.Add(multiColorCheckBox);
            Controls.Add(spritePalette1);
            Controls.Add(spriteGrid);
            Name = "C64Sprite";
            Text = "C64Sprite";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private C64.Controls.Sprite spriteGrid;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private C64.Controls.SpritePalette spritePalette1;
        private System.Windows.Forms.CheckBox multiColorCheckBox;
        private System.Windows.Forms.Button clearButton;
    }
}
