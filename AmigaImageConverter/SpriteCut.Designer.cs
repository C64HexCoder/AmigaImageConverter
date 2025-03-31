namespace AmigaImageConverter
{
    partial class SpriteCut
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
            imageCutGB = new System.Windows.Forms.GroupBox();
            spriteCutPreviewIB = new Amiga.ImageBox();
            label6 = new System.Windows.Forms.Label();
            spritePerImageCutNud = new System.Windows.Forms.NumericUpDown();
            dimantionGB = new System.Windows.Forms.GroupBox();
            heightNumUD = new System.Windows.Forms.NumericUpDown();
            widthNumUD = new System.Windows.Forms.NumericUpDown();
            spriteNameSCTB = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            spriteCutSaveButton = new System.Windows.Forms.Button();
            spriteSelectorNud = new System.Windows.Forms.NumericUpDown();
            comboBox1 = new System.Windows.Forms.ComboBox();
            cutSpriteBtn = new System.Windows.Forms.Button();
            imageCutGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spriteCutPreviewIB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spritePerImageCutNud).BeginInit();
            dimantionGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heightNumUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)widthNumUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spriteSelectorNud).BeginInit();
            SuspendLayout();
            // 
            // imageCutGB
            // 
            imageCutGB.AutoSize = true;
            imageCutGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            imageCutGB.Controls.Add(spriteCutPreviewIB);
            imageCutGB.Controls.Add(label6);
            imageCutGB.Controls.Add(spritePerImageCutNud);
            imageCutGB.Controls.Add(dimantionGB);
            imageCutGB.Controls.Add(spriteNameSCTB);
            imageCutGB.Controls.Add(label5);
            imageCutGB.Controls.Add(spriteCutSaveButton);
            imageCutGB.Controls.Add(spriteSelectorNud);
            imageCutGB.Controls.Add(comboBox1);
            imageCutGB.Controls.Add(cutSpriteBtn);
            imageCutGB.Location = new System.Drawing.Point(3, 3);
            imageCutGB.Name = "imageCutGB";
            imageCutGB.Size = new System.Drawing.Size(225, 730);
            imageCutGB.TabIndex = 8;
            imageCutGB.TabStop = false;
            imageCutGB.Tag = "";
            imageCutGB.Text = "Sprite Cutter";
            // 
            // spriteCutPreviewIB
            // 
            spriteCutPreviewIB.AutoCenter = false;
            spriteCutPreviewIB.AutoScaleImageBox = false;
            spriteCutPreviewIB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            spriteCutPreviewIB.HrizontalScrollBar = null;
            spriteCutPreviewIB.Image = null;
            spriteCutPreviewIB.Location = new System.Drawing.Point(6, 318);
            spriteCutPreviewIB.MaxImageScale = 4;
            spriteCutPreviewIB.MouseWheelZoom = false;
            spriteCutPreviewIB.Name = "spriteCutPreviewIB";
            spriteCutPreviewIB.OriginalImage = null;
            spriteCutPreviewIB.ScaleFactor = 1;
            spriteCutPreviewIB.ScaleFactorFloat = 1F;
            spriteCutPreviewIB.Size = new System.Drawing.Size(213, 305);
            spriteCutPreviewIB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            spriteCutPreviewIB.TabIndex = 15;
            spriteCutPreviewIB.TabStop = false;
            spriteCutPreviewIB.VerticalScrollBar = null;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 136);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(150, 25);
            label6.TabIndex = 14;
            label6.Text = "Sprites Per Image";
            // 
            // spritePerImageCutNud
            // 
            spritePerImageCutNud.Location = new System.Drawing.Point(6, 163);
            spritePerImageCutNud.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            spritePerImageCutNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            spritePerImageCutNud.Name = "spritePerImageCutNud";
            spritePerImageCutNud.Size = new System.Drawing.Size(213, 31);
            spritePerImageCutNud.TabIndex = 13;
            spritePerImageCutNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dimantionGB
            // 
            dimantionGB.Controls.Add(heightNumUD);
            dimantionGB.Controls.Add(widthNumUD);
            dimantionGB.Location = new System.Drawing.Point(6, 200);
            dimantionGB.Name = "dimantionGB";
            dimantionGB.Size = new System.Drawing.Size(213, 72);
            dimantionGB.TabIndex = 12;
            dimantionGB.TabStop = false;
            dimantionGB.Text = "Dimension";
            // 
            // heightNumUD
            // 
            heightNumUD.Location = new System.Drawing.Point(119, 35);
            heightNumUD.Name = "heightNumUD";
            heightNumUD.Size = new System.Drawing.Size(77, 31);
            heightNumUD.TabIndex = 1;
            // 
            // widthNumUD
            // 
            widthNumUD.Location = new System.Drawing.Point(15, 35);
            widthNumUD.Name = "widthNumUD";
            widthNumUD.Size = new System.Drawing.Size(80, 31);
            widthNumUD.TabIndex = 0;
            // 
            // spriteNameSCTB
            // 
            spriteNameSCTB.Location = new System.Drawing.Point(6, 100);
            spriteNameSCTB.Name = "spriteNameSCTB";
            spriteNameSCTB.Size = new System.Drawing.Size(213, 31);
            spriteNameSCTB.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 74);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(111, 25);
            label5.TabIndex = 10;
            label5.Text = "Sprite name:";
            // 
            // spriteCutSaveButton
            // 
            spriteCutSaveButton.Enabled = false;
            spriteCutSaveButton.Location = new System.Drawing.Point(6, 666);
            spriteCutSaveButton.Name = "spriteCutSaveButton";
            spriteCutSaveButton.Size = new System.Drawing.Size(213, 34);
            spriteCutSaveButton.TabIndex = 6;
            spriteCutSaveButton.Text = "Save";
            spriteCutSaveButton.UseVisualStyleBackColor = true;
            spriteCutSaveButton.Click += SpriteSaveBtn_Click;
            // 
            // spriteSelectorNud
            // 
            spriteSelectorNud.Enabled = false;
            spriteSelectorNud.Location = new System.Drawing.Point(6, 629);
            spriteSelectorNud.Name = "spriteSelectorNud";
            spriteSelectorNud.Size = new System.Drawing.Size(213, 31);
            spriteSelectorNud.TabIndex = 4;
            spriteSelectorNud.ValueChanged += spriteSelectorNud_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "OCS/ECS 16 Pixels", "AGA 32 Pixels", "AGA 64 Pixels" });
            comboBox1.Location = new System.Drawing.Point(6, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(213, 33);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Select sprite width";
            // 
            // cutSpriteBtn
            // 
            cutSpriteBtn.Location = new System.Drawing.Point(6, 278);
            cutSpriteBtn.Name = "cutSpriteBtn";
            cutSpriteBtn.Size = new System.Drawing.Size(213, 34);
            cutSpriteBtn.TabIndex = 1;
            cutSpriteBtn.Text = "Cut it!";
            cutSpriteBtn.UseVisualStyleBackColor = true;
            cutSpriteBtn.Click += cutSpriteBtn_Click;
            // 
            // SpriteCut
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(imageCutGB);
            Name = "SpriteCut";
            Size = new System.Drawing.Size(231, 736);
            Tag = "Side Panel";
            imageCutGB.ResumeLayout(false);
            imageCutGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spriteCutPreviewIB).EndInit();
            ((System.ComponentModel.ISupportInitialize)spritePerImageCutNud).EndInit();
            dimantionGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)heightNumUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)widthNumUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)spriteSelectorNud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox imageCutGB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox dimantionGB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cutSpriteBtn;
        public System.Windows.Forms.NumericUpDown heightNumUD;
        public System.Windows.Forms.NumericUpDown widthNumUD;
        public System.Windows.Forms.TextBox spriteNameSCTB;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.NumericUpDown spritePerImageCutNud;
        public System.Windows.Forms.Button spriteCutSaveButton;
        public System.Windows.Forms.NumericUpDown spriteSelectorNud;
        private Amiga.ImageBox spriteCutPreviewIB;
    }
}
