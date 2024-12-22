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
            label1 = new System.Windows.Forms.Label();
            bankNumUD = new System.Windows.Forms.NumericUpDown();
            chipsetCB = new System.Windows.Forms.ComboBox();
            colorRegistersCombo = new System.Windows.Forms.ComboBox();
            bitsPpCombo = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bankNumUD).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(bankNumUD);
            groupBox3.Controls.Add(chipsetCB);
            groupBox3.Controls.Add(colorRegistersCombo);
            groupBox3.Controls.Add(bitsPpCombo);
            groupBox3.Location = new System.Drawing.Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(229, 189);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Color Options";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 111);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 25);
            label1.TabIndex = 5;
            label1.Text = "Bank";
            // 
            // bankNumUD
            // 
            bankNumUD.Enabled = false;
            bankNumUD.Location = new System.Drawing.Point(66, 109);
            bankNumUD.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            bankNumUD.Name = "bankNumUD";
            bankNumUD.Size = new System.Drawing.Size(158, 31);
            bankNumUD.TabIndex = 4;
            bankNumUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chipsetCB
            // 
            chipsetCB.FormattingEnabled = true;
            chipsetCB.Items.AddRange(new object[] { "OCS/ECS", "AGA" });
            chipsetCB.Location = new System.Drawing.Point(6, 30);
            chipsetCB.Name = "chipsetCB";
            chipsetCB.Size = new System.Drawing.Size(218, 33);
            chipsetCB.TabIndex = 3;
            chipsetCB.Tag = "bpp";
            chipsetCB.SelectedIndexChanged += chipsetCB_SelectedIndexChanged;
            // 
            // colorRegistersCombo
            // 
            colorRegistersCombo.FormattingEnabled = true;
            colorRegistersCombo.Items.AddRange(new object[] { "$180 - $19E (0-15)", "$1A0 - $1Be (16-31)" });
            colorRegistersCombo.Location = new System.Drawing.Point(6, 146);
            colorRegistersCombo.Name = "colorRegistersCombo";
            colorRegistersCombo.Size = new System.Drawing.Size(218, 33);
            colorRegistersCombo.TabIndex = 2;
            colorRegistersCombo.Tag = "colorRegister";
            // 
            // bitsPpCombo
            // 
            bitsPpCombo.Enabled = false;
            bitsPpCombo.FormattingEnabled = true;
            bitsPpCombo.Items.AddRange(new object[] { "4 bpp (12 bits)", "8 bpp (24 bits)" });
            bitsPpCombo.Location = new System.Drawing.Point(6, 69);
            bitsPpCombo.Name = "bitsPpCombo";
            bitsPpCombo.Size = new System.Drawing.Size(218, 33);
            bitsPpCombo.TabIndex = 0;
            bitsPpCombo.Tag = "bpp";
            // 
            // button1
            // 
            button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            button1.Location = new System.Drawing.Point(18, 225);
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
            ClientSize = new System.Drawing.Size(253, 271);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Name = "ColorOptions";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "ColorOptions";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bankNumUD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox colorRegistersCombo;
        private System.Windows.Forms.ComboBox bitsPpCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox chipsetCB;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown bankNumUD;
    }
}