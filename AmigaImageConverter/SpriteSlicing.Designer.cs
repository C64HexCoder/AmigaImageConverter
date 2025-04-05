namespace AmigaImageConverter
{
    partial class SpriteSlicing
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
            SlicingGb = new System.Windows.Forms.GroupBox();
            spriteNameTxtbox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            SpriteSaveBtn = new System.Windows.Forms.Button();
            spritePerImageUDN = new System.Windows.Forms.NumericUpDown();
            spriteSelectNud = new System.Windows.Forms.NumericUpDown();
            sprImageBox = new Amiga.ImageBox();
            spriteWidthCb = new System.Windows.Forms.ComboBox();
            SliceBtn = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            numOfRawsNud = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            ImagesPerRawNud = new System.Windows.Forms.NumericUpDown();
            SlicingGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spritePerImageUDN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spriteSelectNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sprImageBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOfRawsNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImagesPerRawNud).BeginInit();
            SuspendLayout();
            // 
            // SlicingGb
            // 
            SlicingGb.AutoSize = true;
            SlicingGb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            SlicingGb.Controls.Add(spriteNameTxtbox);
            SlicingGb.Controls.Add(label4);
            SlicingGb.Controls.Add(label3);
            SlicingGb.Controls.Add(SpriteSaveBtn);
            SlicingGb.Controls.Add(spritePerImageUDN);
            SlicingGb.Controls.Add(spriteSelectNud);
            SlicingGb.Controls.Add(sprImageBox);
            SlicingGb.Controls.Add(spriteWidthCb);
            SlicingGb.Controls.Add(SliceBtn);
            SlicingGb.Controls.Add(label2);
            SlicingGb.Controls.Add(numOfRawsNud);
            SlicingGb.Controls.Add(label1);
            SlicingGb.Controls.Add(ImagesPerRawNud);
            SlicingGb.Location = new System.Drawing.Point(3, 3);
            SlicingGb.Name = "SlicingGb";
            SlicingGb.Size = new System.Drawing.Size(225, 727);
            SlicingGb.TabIndex = 1;
            SlicingGb.TabStop = false;
            SlicingGb.Text = "Slicing";
            // 
            // spriteNameTxtbox
            // 
            spriteNameTxtbox.Location = new System.Drawing.Point(6, 222);
            spriteNameTxtbox.Name = "spriteNameTxtbox";
            spriteNameTxtbox.Size = new System.Drawing.Size(213, 31);
            spriteNameTxtbox.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 194);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(111, 25);
            label4.TabIndex = 10;
            label4.Text = "Sprite name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 133);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(150, 25);
            label3.TabIndex = 9;
            label3.Text = "Sprites Per Image";
            // 
            // SpriteSaveBtn
            // 
            SpriteSaveBtn.Enabled = false;
            SpriteSaveBtn.Location = new System.Drawing.Point(6, 663);
            SpriteSaveBtn.Name = "SpriteSaveBtn";
            SpriteSaveBtn.Size = new System.Drawing.Size(213, 34);
            SpriteSaveBtn.TabIndex = 6;
            SpriteSaveBtn.Text = "Save";
            SpriteSaveBtn.UseVisualStyleBackColor = true;
            SpriteSaveBtn.Click += SpriteSaveBtn_Click;
            // 
            // spritePerImageUDN
            // 
            spritePerImageUDN.Location = new System.Drawing.Point(6, 160);
            spritePerImageUDN.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            spritePerImageUDN.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            spritePerImageUDN.Name = "spritePerImageUDN";
            spritePerImageUDN.Size = new System.Drawing.Size(213, 31);
            spritePerImageUDN.TabIndex = 8;
            spritePerImageUDN.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // spriteSelectNud
            // 
            spriteSelectNud.Enabled = false;
            spriteSelectNud.Location = new System.Drawing.Point(6, 626);
            spriteSelectNud.Name = "spriteSelectNud";
            spriteSelectNud.Size = new System.Drawing.Size(213, 31);
            spriteSelectNud.TabIndex = 4;
            spriteSelectNud.ValueChanged += spriteSelectNud_ValueChanged;
            // 
            // sprImageBox
            // 
            sprImageBox.AutoCenter = false;
            sprImageBox.AutoScaleImageBox = false;
            sprImageBox.HrizontalScrollBar = null;
            sprImageBox.Image = null;
            sprImageBox.Location = new System.Drawing.Point(6, 303);
            sprImageBox.MaxImageScale = 4;
            sprImageBox.MouseWheelZoom = false;
            sprImageBox.Name = "sprImageBox";
            sprImageBox.OriginalImage = null;
            sprImageBox.ScaleFactor = 1;
            sprImageBox.ScaleFactorFloat = 1F;
            sprImageBox.Size = new System.Drawing.Size(213, 317);
            sprImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            sprImageBox.TabIndex = 7;
            sprImageBox.TabStop = false;
            sprImageBox.VerticalScrollBar = null;
            // 
            // spriteWidthCb
            // 
            spriteWidthCb.FormattingEnabled = true;
            spriteWidthCb.Items.AddRange(new object[] { "OCS/ECS 16 Pixels", "AGA 32 Pixels", "AGA 64 Pixels" });
            spriteWidthCb.Location = new System.Drawing.Point(6, 97);
            spriteWidthCb.Name = "spriteWidthCb";
            spriteWidthCb.Size = new System.Drawing.Size(213, 33);
            spriteWidthCb.TabIndex = 5;
            spriteWidthCb.Text = "Select sprite width";
            // 
            // SliceBtn
            // 
            SliceBtn.Location = new System.Drawing.Point(6, 263);
            SliceBtn.Name = "SliceBtn";
            SliceBtn.Size = new System.Drawing.Size(213, 34);
            SliceBtn.TabIndex = 1;
            SliceBtn.Text = "Slice it!";
            SliceBtn.UseVisualStyleBackColor = true;
            SliceBtn.Click += SliceBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(133, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 25);
            label2.TabIndex = 3;
            label2.Text = "Raws";
            // 
            // numOfRawsNud
            // 
            numOfRawsNud.Location = new System.Drawing.Point(113, 60);
            numOfRawsNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numOfRawsNud.Name = "numOfRawsNud";
            numOfRawsNud.Size = new System.Drawing.Size(106, 31);
            numOfRawsNud.TabIndex = 2;
            numOfRawsNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            numOfRawsNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(110, 25);
            label1.TabIndex = 1;
            label1.Text = "Images/Raw";
            // 
            // ImagesPerRawNud
            // 
            ImagesPerRawNud.Location = new System.Drawing.Point(6, 60);
            ImagesPerRawNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ImagesPerRawNud.Name = "ImagesPerRawNud";
            ImagesPerRawNud.Size = new System.Drawing.Size(106, 31);
            ImagesPerRawNud.TabIndex = 0;
            ImagesPerRawNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ImagesPerRawNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SpriteSlicing
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(SlicingGb);
            Name = "SpriteSlicing";
            Size = new System.Drawing.Size(231, 733);
            Tag = "Side Panel";
            VisibleChanged += SpriteSlicing_VisibleChanged;
            SlicingGb.ResumeLayout(false);
            SlicingGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spritePerImageUDN).EndInit();
            ((System.ComponentModel.ISupportInitialize)spriteSelectNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)sprImageBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOfRawsNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImagesPerRawNud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox SlicingGb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox spriteNameTxtbox;
        public System.Windows.Forms.NumericUpDown spritePerImageUDN;
        public System.Windows.Forms.ComboBox spriteWidthCb;
        public System.Windows.Forms.NumericUpDown numOfRawsNud;
        public System.Windows.Forms.NumericUpDown ImagesPerRawNud;
        public Amiga.ImageBox sprImageBox;
        public System.Windows.Forms.NumericUpDown spriteSelectNud;
        public System.Windows.Forms.Button SpriteSaveBtn;
        public System.Windows.Forms.Button SliceBtn;
    }
}
