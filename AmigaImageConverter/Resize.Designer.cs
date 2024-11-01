namespace AmigaImageConverter
{
    partial class Resize
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
            label2 = new System.Windows.Forms.Label();
            widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ResizeBtn = new System.Windows.Forms.Button();
            ratioCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)widthNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heightNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 25);
            label1.TabIndex = 0;
            label1.Text = "Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(176, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 25);
            label2.TabIndex = 1;
            label2.Text = "Height";
            // 
            // widthNumericUpDown
            // 
            widthNumericUpDown.Location = new System.Drawing.Point(21, 48);
            widthNumericUpDown.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            widthNumericUpDown.Name = "widthNumericUpDown";
            widthNumericUpDown.Size = new System.Drawing.Size(114, 31);
            widthNumericUpDown.TabIndex = 2;
            widthNumericUpDown.ValueChanged += widthNumericUpDown_ValueChanged;
            // 
            // heightNumericUpDown
            // 
            heightNumericUpDown.Location = new System.Drawing.Point(176, 48);
            heightNumericUpDown.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            heightNumericUpDown.Name = "heightNumericUpDown";
            heightNumericUpDown.Size = new System.Drawing.Size(114, 31);
            heightNumericUpDown.TabIndex = 3;
            heightNumericUpDown.ValueChanged += heightNumericUpDown_ValueChanged;
            // 
            // ResizeBtn
            // 
            ResizeBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            ResizeBtn.Location = new System.Drawing.Point(182, 102);
            ResizeBtn.Name = "ResizeBtn";
            ResizeBtn.Size = new System.Drawing.Size(112, 34);
            ResizeBtn.TabIndex = 4;
            ResizeBtn.Text = "Resize";
            ResizeBtn.UseVisualStyleBackColor = true;
            ResizeBtn.Click += ResizeBtn_Click;
            // 
            // ratioCheckBox
            // 
            ratioCheckBox.AutoSize = true;
            ratioCheckBox.Checked = true;
            ratioCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            ratioCheckBox.Location = new System.Drawing.Point(21, 85);
            ratioCheckBox.Name = "ratioCheckBox";
            ratioCheckBox.Size = new System.Drawing.Size(123, 29);
            ratioCheckBox.TabIndex = 5;
            ratioCheckBox.Text = "Keep Ratio";
            ratioCheckBox.UseVisualStyleBackColor = true;
            // 
            // Resize
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            ClientSize = new System.Drawing.Size(306, 148);
            Controls.Add(ratioCheckBox);
            Controls.Add(ResizeBtn);
            Controls.Add(heightNumericUpDown);
            Controls.Add(widthNumericUpDown);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Resize";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Resize";
            ((System.ComponentModel.ISupportInitialize)widthNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)heightNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.Button ResizeBtn;
        private System.Windows.Forms.CheckBox ratioCheckBox;
    }
}