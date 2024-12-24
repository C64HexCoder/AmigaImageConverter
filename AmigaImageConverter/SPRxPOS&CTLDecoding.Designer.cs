namespace AmigaImageConverter
{
    partial class SPRxPOS_CTLDecoding
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
            sprPosHexBox = new Amiga.HexBox();
            sprCtlHexBox = new Amiga.HexBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            sprXPosNumUD = new System.Windows.Forms.NumericUpDown();
            sprYPosNumUD = new System.Windows.Forms.NumericUpDown();
            sprHeightNumUD = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            CalculateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)sprXPosNumUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sprYPosNumUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sprHeightNumUD).BeginInit();
            SuspendLayout();
            // 
            // sprPosHexBox
            // 
            sprPosHexBox.AutoSize = true;
            sprPosHexBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            sprPosHexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            sprPosHexBox.Location = new System.Drawing.Point(12, 42);
            sprPosHexBox.Name = "sprPosHexBox";
            sprPosHexBox.ReadOnly = false;
            sprPosHexBox.Size = new System.Drawing.Size(152, 62);
            sprPosHexBox.TabIndex = 0;
            sprPosHexBox.Value = 0;
            sprPosHexBox.HexBoxChanged += sprPosHexBox_HexBoxChanged;
            // 
            // sprCtlHexBox
            // 
            sprCtlHexBox.AutoSize = true;
            sprCtlHexBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            sprCtlHexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            sprCtlHexBox.Location = new System.Drawing.Point(172, 42);
            sprCtlHexBox.Name = "sprCtlHexBox";
            sprCtlHexBox.ReadOnly = false;
            sprCtlHexBox.Size = new System.Drawing.Size(152, 62);
            sprCtlHexBox.TabIndex = 1;
            sprCtlHexBox.Value = 0;
            sprCtlHexBox.HexBoxChanged += sprCtlHexBox_HexBoxChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 25);
            label1.TabIndex = 2;
            label1.Text = "SPRxPOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(172, 14);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 25);
            label2.TabIndex = 3;
            label2.Text = "SPRxCTL";
            // 
            // sprXPosNumUD
            // 
            sprXPosNumUD.Location = new System.Drawing.Point(12, 182);
            sprXPosNumUD.Maximum = new decimal(new int[] { 477, 0, 0, 0 });
            sprXPosNumUD.Name = "sprXPosNumUD";
            sprXPosNumUD.Size = new System.Drawing.Size(100, 31);
            sprXPosNumUD.TabIndex = 4;
            // 
            // sprYPosNumUD
            // 
            sprYPosNumUD.Location = new System.Drawing.Point(118, 182);
            sprYPosNumUD.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            sprYPosNumUD.Name = "sprYPosNumUD";
            sprYPosNumUD.Size = new System.Drawing.Size(100, 31);
            sprYPosNumUD.TabIndex = 5;
            // 
            // sprHeightNumUD
            // 
            sprHeightNumUD.Location = new System.Drawing.Point(224, 182);
            sprHeightNumUD.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            sprHeightNumUD.Name = "sprHeightNumUD";
            sprHeightNumUD.Size = new System.Drawing.Size(100, 31);
            sprHeightNumUD.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 154);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 25);
            label3.TabIndex = 7;
            label3.Text = "X Pos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(118, 154);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 25);
            label4.TabIndex = 8;
            label4.Text = "Y Pos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(224, 154);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(65, 25);
            label5.TabIndex = 9;
            label5.Text = "Height";
            // 
            // CalculateBtn
            // 
            CalculateBtn.Location = new System.Drawing.Point(12, 260);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new System.Drawing.Size(312, 34);
            CalculateBtn.TabIndex = 10;
            CalculateBtn.Text = "Calculate";
            CalculateBtn.UseVisualStyleBackColor = true;
            CalculateBtn.Click += CalculateBtn_Click;
            // 
            // SPRxPOS_CTLDecoding
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(337, 306);
            Controls.Add(CalculateBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(sprHeightNumUD);
            Controls.Add(sprYPosNumUD);
            Controls.Add(sprXPosNumUD);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sprCtlHexBox);
            Controls.Add(sprPosHexBox);
            Name = "SPRxPOS_CTLDecoding";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "SPRxPOS_CTLDecoding";
            ((System.ComponentModel.ISupportInitialize)sprXPosNumUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)sprYPosNumUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)sprHeightNumUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Amiga.HexBox sprPosHexBox;
        private Amiga.HexBox sprCtlHexBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sprXPosNumUD;
        private System.Windows.Forms.NumericUpDown sprYPosNumUD;
        private System.Windows.Forms.NumericUpDown sprHeightNumUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalculateBtn;
    }
}