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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ResizeBtn = new System.Windows.Forms.Button();
            this.ratioCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // widthNumericUpDown
            // 
            this.widthNumericUpDown.Location = new System.Drawing.Point(21, 48);
            this.widthNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Size = new System.Drawing.Size(114, 31);
            this.widthNumericUpDown.TabIndex = 2;
            this.widthNumericUpDown.ValueChanged += new System.EventHandler(this.widthNumericUpDown_ValueChanged);
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.Location = new System.Drawing.Point(176, 48);
            this.heightNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(114, 31);
            this.heightNumericUpDown.TabIndex = 3;
            this.heightNumericUpDown.ValueChanged += new System.EventHandler(this.heightNumericUpDown_ValueChanged);
            // 
            // ResizeBtn
            // 
            this.ResizeBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ResizeBtn.Location = new System.Drawing.Point(182, 102);
            this.ResizeBtn.Name = "ResizeBtn";
            this.ResizeBtn.Size = new System.Drawing.Size(112, 34);
            this.ResizeBtn.TabIndex = 4;
            this.ResizeBtn.Text = "Resize";
            this.ResizeBtn.UseVisualStyleBackColor = true;
            this.ResizeBtn.Click += new System.EventHandler(this.ResizeBtn_Click);
            // 
            // ratioCheckBox
            // 
            this.ratioCheckBox.AutoSize = true;
            this.ratioCheckBox.Checked = true;
            this.ratioCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ratioCheckBox.Location = new System.Drawing.Point(21, 85);
            this.ratioCheckBox.Name = "ratioCheckBox";
            this.ratioCheckBox.Size = new System.Drawing.Size(123, 29);
            this.ratioCheckBox.TabIndex = 5;
            this.ratioCheckBox.Text = "Keep Ratio";
            this.ratioCheckBox.UseVisualStyleBackColor = true;
            // 
            // Resize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(306, 148);
            this.Controls.Add(this.ratioCheckBox);
            this.Controls.Add(this.ResizeBtn);
            this.Controls.Add(this.heightNumericUpDown);
            this.Controls.Add(this.widthNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Resize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resize";
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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