namespace AmigaImageConverter
{
    partial class ColorOptions
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
            groupBox3 = new System.Windows.Forms.GroupBox();
            colorRegistersCombo = new System.Windows.Forms.ComboBox();
            bitsPpCombo = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(colorRegistersCombo);
            groupBox3.Controls.Add(bitsPpCombo);
            groupBox3.Location = new System.Drawing.Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(239, 117);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Color Options";
            // 
            // colorRegistersCombo
            // 
            colorRegistersCombo.FormattingEnabled = true;
            colorRegistersCombo.Items.AddRange(new object[] { "$180 - $19E (0-15)", "$1A0 - $1Be (16-31)" });
            colorRegistersCombo.Location = new System.Drawing.Point(6, 68);
            colorRegistersCombo.Name = "colorRegistersCombo";
            colorRegistersCombo.Size = new System.Drawing.Size(218, 33);
            colorRegistersCombo.TabIndex = 2;
            colorRegistersCombo.Tag = "colorRegister";
            // 
            // bitsPpCombo
            // 
            bitsPpCombo.FormattingEnabled = true;
            bitsPpCombo.Items.AddRange(new object[] { "4 Bit", "8 Bit" });
            bitsPpCombo.Location = new System.Drawing.Point(6, 30);
            bitsPpCombo.Name = "bitsPpCombo";
            bitsPpCombo.Size = new System.Drawing.Size(218, 33);
            bitsPpCombo.TabIndex = 0;
            bitsPpCombo.Tag = "bpp";
            // 
            // button1
            // 
            button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            button1.Location = new System.Drawing.Point(18, 135);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(218, 34);
            button1.TabIndex = 10;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // ColorOptions
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(253, 182);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Name = "ColorOptions";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "ColorOptions";
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox colorRegistersCombo;
        private System.Windows.Forms.ComboBox bitsPpCombo;
        private System.Windows.Forms.Button button1;
    }
}