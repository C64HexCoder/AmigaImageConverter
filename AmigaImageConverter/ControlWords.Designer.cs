namespace AmigaImageConverter
{
    partial class ControlWords
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
            AttachedCB = new System.Windows.Forms.CheckBox();
            SPRxPOSTB = new System.Windows.Forms.TextBox();
            SPRxCTLTB = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            PositionAddressingCB = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            CalculateComWordsBT = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            nameTb = new System.Windows.Forms.TextBox();
            doubleScanCB = new System.Windows.Forms.CheckBox();
            xPosNum = new System.Windows.Forms.NumericUpDown();
            yPosNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)xPosNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yPosNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(142, 25);
            label1.TabIndex = 0;
            label1.Text = "Sprite X Position";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 56);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(141, 25);
            label2.TabIndex = 2;
            label2.Text = "Sprite Y Position";
            // 
            // AttachedCB
            // 
            AttachedCB.AutoSize = true;
            AttachedCB.Enabled = false;
            AttachedCB.Location = new System.Drawing.Point(322, 15);
            AttachedCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AttachedCB.Name = "AttachedCB";
            AttachedCB.Size = new System.Drawing.Size(168, 29);
            AttachedCB.TabIndex = 4;
            AttachedCB.Text = "Attached Sprites";
            AttachedCB.UseVisualStyleBackColor = true;
            // 
            // SPRxPOSTB
            // 
            SPRxPOSTB.BackColor = System.Drawing.SystemColors.Control;
            SPRxPOSTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            SPRxPOSTB.Cursor = System.Windows.Forms.Cursors.No;
            SPRxPOSTB.Enabled = false;
            SPRxPOSTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 177);
            SPRxPOSTB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            SPRxPOSTB.Location = new System.Drawing.Point(18, 292);
            SPRxPOSTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SPRxPOSTB.Name = "SPRxPOSTB";
            SPRxPOSTB.ReadOnly = true;
            SPRxPOSTB.Size = new System.Drawing.Size(111, 34);
            SPRxPOSTB.TabIndex = 5;
            SPRxPOSTB.Text = "$0000";
            // 
            // SPRxCTLTB
            // 
            SPRxCTLTB.BackColor = System.Drawing.SystemColors.Control;
            SPRxCTLTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            SPRxCTLTB.Cursor = System.Windows.Forms.Cursors.No;
            SPRxCTLTB.Enabled = false;
            SPRxCTLTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 177);
            SPRxCTLTB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            SPRxCTLTB.Location = new System.Drawing.Point(160, 292);
            SPRxCTLTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SPRxCTLTB.Name = "SPRxCTLTB";
            SPRxCTLTB.ReadOnly = true;
            SPRxCTLTB.Size = new System.Drawing.Size(111, 34);
            SPRxCTLTB.TabIndex = 6;
            SPRxCTLTB.Text = "$0000";
            // 
            // button1
            // 
            button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            button1.Location = new System.Drawing.Point(450, 291);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(111, 46);
            button1.TabIndex = 7;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 177);
            label3.Location = new System.Drawing.Point(29, 264);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 20);
            label3.TabIndex = 8;
            label3.Text = "SPRxPOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(167, 264);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(79, 25);
            label4.TabIndex = 9;
            label4.Text = "SPRxCTL";
            // 
            // PositionAddressingCB
            // 
            PositionAddressingCB.FormattingEnabled = true;
            PositionAddressingCB.Items.AddRange(new object[] { "Relative to visible screen", "Absolute position" });
            PositionAddressingCB.Location = new System.Drawing.Point(19, 134);
            PositionAddressingCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PositionAddressingCB.Name = "PositionAddressingCB";
            PositionAddressingCB.Size = new System.Drawing.Size(282, 33);
            PositionAddressingCB.TabIndex = 10;
            PositionAddressingCB.Text = "Relative to visible screen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(14, 105);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(170, 25);
            label5.TabIndex = 11;
            label5.Text = "Position Addressing";
            // 
            // CalculateComWordsBT
            // 
            CalculateComWordsBT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            CalculateComWordsBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 177);
            CalculateComWordsBT.ForeColor = System.Drawing.SystemColors.Highlight;
            CalculateComWordsBT.Location = new System.Drawing.Point(18, 199);
            CalculateComWordsBT.Margin = new System.Windows.Forms.Padding(2);
            CalculateComWordsBT.Name = "CalculateComWordsBT";
            CalculateComWordsBT.Size = new System.Drawing.Size(281, 45);
            CalculateComWordsBT.TabIndex = 12;
            CalculateComWordsBT.Text = "Calculate Command Words";
            CalculateComWordsBT.UseVisualStyleBackColor = false;
            CalculateComWordsBT.Click += CalculateComWordsBT_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(318, 104);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(114, 25);
            label6.TabIndex = 13;
            label6.Text = "Sprite Name:";
            // 
            // nameTb
            // 
            nameTb.Location = new System.Drawing.Point(322, 134);
            nameTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            nameTb.Name = "nameTb";
            nameTb.Size = new System.Drawing.Size(238, 31);
            nameTb.TabIndex = 14;
            nameTb.Text = "Sprite";
            nameTb.KeyDown += NameTb_KeyDown;
            // 
            // doubleScanCB
            // 
            doubleScanCB.AutoSize = true;
            doubleScanCB.Enabled = false;
            doubleScanCB.Location = new System.Drawing.Point(322, 54);
            doubleScanCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            doubleScanCB.Name = "doubleScanCB";
            doubleScanCB.Size = new System.Drawing.Size(138, 29);
            doubleScanCB.TabIndex = 15;
            doubleScanCB.Text = "Double Scan";
            doubleScanCB.UseVisualStyleBackColor = true;
            // 
            // xPosNum
            // 
            xPosNum.Location = new System.Drawing.Point(162, 18);
            xPosNum.Name = "xPosNum";
            xPosNum.Size = new System.Drawing.Size(137, 31);
            xPosNum.TabIndex = 16;
            xPosNum.ValueChanged += xPosNum_ValueChanged;
            // 
            // yPosNum
            // 
            yPosNum.Location = new System.Drawing.Point(162, 55);
            yPosNum.Name = "yPosNum";
            yPosNum.Size = new System.Drawing.Size(137, 31);
            yPosNum.TabIndex = 17;
            yPosNum.ValueChanged += yPosNum_ValueChanged;
            // 
            // Control_Words
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(574, 352);
            Controls.Add(yPosNum);
            Controls.Add(xPosNum);
            Controls.Add(doubleScanCB);
            Controls.Add(nameTb);
            Controls.Add(label6);
            Controls.Add(CalculateComWordsBT);
            Controls.Add(label5);
            Controls.Add(PositionAddressingCB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(SPRxCTLTB);
            Controls.Add(SPRxPOSTB);
            Controls.Add(AttachedCB);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Control_Words";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Control_Words";
            ((System.ComponentModel.ISupportInitialize)xPosNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)yPosNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AttachedCB;
        private System.Windows.Forms.TextBox SPRxPOSTB;
        private System.Windows.Forms.TextBox SPRxCTLTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PositionAddressingCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalculateComWordsBT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.CheckBox doubleScanCB;
        private System.Windows.Forms.NumericUpDown xPosNum;
        private System.Windows.Forms.NumericUpDown yPosNum;
    }
}