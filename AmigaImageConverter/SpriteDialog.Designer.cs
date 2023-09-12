namespace AmigaImageConverter
{
    partial class SpriteDialog
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
            label1 = new System.Windows.Forms.Label();
            spriteSizeComboBox = new System.Windows.Forms.ComboBox();
            okBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(286, 25);
            label1.TabIndex = 0;
            label1.Text = "The Image is to wide to fit a sprite.";
            // 
            // spriteSizeComboBox
            // 
            spriteSizeComboBox.FormattingEnabled = true;
            spriteSizeComboBox.Items.AddRange(new object[] { "16 Pixels Wide", "32 Pixels Wide", "64 Pixels Wide" });
            spriteSizeComboBox.Location = new System.Drawing.Point(12, 49);
            spriteSizeComboBox.Name = "spriteSizeComboBox";
            spriteSizeComboBox.Size = new System.Drawing.Size(286, 33);
            spriteSizeComboBox.TabIndex = 2;
            spriteSizeComboBox.Text = "Select Sprite Width";
            // 
            // okBtn
            // 
            okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            okBtn.Location = new System.Drawing.Point(183, 107);
            okBtn.Name = "okBtn";
            okBtn.Size = new System.Drawing.Size(112, 34);
            okBtn.TabIndex = 3;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // SpriteDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(307, 153);
            Controls.Add(okBtn);
            Controls.Add(spriteSizeComboBox);
            Controls.Add(label1);
            Name = "SpriteDialog";
            Text = "SpriteDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox spriteSizeComboBox;
        private System.Windows.Forms.Button okBtn;
    }
}