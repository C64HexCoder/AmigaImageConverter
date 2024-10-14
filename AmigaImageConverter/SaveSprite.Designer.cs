namespace AmigaImageConverter
{
    partial class SaveSprite
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
            RangeGb = new System.Windows.Forms.GroupBox();
            toNud = new System.Windows.Forms.NumericUpDown();
            fromNud = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            saveOptionsCb = new System.Windows.Forms.ComboBox();
            imageBox = new Amiga.ImageBox();
            SpriteSaveBtn = new System.Windows.Forms.Button();
            currentSpriteNud = new System.Windows.Forms.NumericUpDown();
            RangeGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fromNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currentSpriteNud).BeginInit();
            SuspendLayout();
            // 
            // RangeGb
            // 
            RangeGb.Controls.Add(toNud);
            RangeGb.Controls.Add(fromNud);
            RangeGb.Controls.Add(label2);
            RangeGb.Controls.Add(label1);
            RangeGb.Location = new System.Drawing.Point(12, 64);
            RangeGb.Name = "RangeGb";
            RangeGb.Size = new System.Drawing.Size(206, 112);
            RangeGb.TabIndex = 0;
            RangeGb.TabStop = false;
            RangeGb.Text = "Range";
            // 
            // toNud
            // 
            toNud.Location = new System.Drawing.Point(110, 62);
            toNud.Name = "toNud";
            toNud.Size = new System.Drawing.Size(90, 31);
            toNud.TabIndex = 3;
            toNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            toNud.ValueChanged += toNud_ValueChanged;
            // 
            // fromNud
            // 
            fromNud.Location = new System.Drawing.Point(6, 62);
            fromNud.Name = "fromNud";
            fromNud.Size = new System.Drawing.Size(90, 31);
            fromNud.TabIndex = 2;
            fromNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            fromNud.ValueChanged += fromNud_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(128, 34);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(30, 25);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(17, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 25);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // saveOptionsCb
            // 
            saveOptionsCb.FormattingEnabled = true;
            saveOptionsCb.Items.AddRange(new object[] { "Save Current Sprite", "Save Range", "Save All Sprite" });
            saveOptionsCb.Location = new System.Drawing.Point(12, 25);
            saveOptionsCb.Name = "saveOptionsCb";
            saveOptionsCb.Size = new System.Drawing.Size(200, 33);
            saveOptionsCb.TabIndex = 1;
            saveOptionsCb.SelectedIndexChanged += saveOptionsCb_SelectedIndexChanged;
            // 
            // imageBox
            // 
            imageBox.AutoScaleImageBox = false;
            imageBox.HrizontalScrollBar = null;
            imageBox.Image = null;
            imageBox.Location = new System.Drawing.Point(238, 12);
            imageBox.Name = "imageBox";
            imageBox.ScaleFactor = 4;
            imageBox.ScaleFactorFloat = 1F;
            imageBox.Size = new System.Drawing.Size(301, 426);
            imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            imageBox.TabIndex = 2;
            imageBox.TabStop = false;
            imageBox.VerticalScrollBar = null;
            // 
            // SpriteSaveBtn
            // 
            SpriteSaveBtn.DialogResult = System.Windows.Forms.DialogResult.Continue;
            SpriteSaveBtn.Location = new System.Drawing.Point(12, 404);
            SpriteSaveBtn.Name = "SpriteSaveBtn";
            SpriteSaveBtn.Size = new System.Drawing.Size(200, 34);
            SpriteSaveBtn.TabIndex = 3;
            SpriteSaveBtn.Text = "Save";
            SpriteSaveBtn.UseVisualStyleBackColor = true;
            SpriteSaveBtn.Click += SpriteSaveBtn_Click;
            // 
            // currentSpriteNud
            // 
            currentSpriteNud.Location = new System.Drawing.Point(18, 204);
            currentSpriteNud.Name = "currentSpriteNud";
            currentSpriteNud.Size = new System.Drawing.Size(194, 31);
            currentSpriteNud.TabIndex = 4;
            currentSpriteNud.ValueChanged += currentSpriteNud_ValueChanged;
            // 
            // SaveSprite
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(545, 450);
            Controls.Add(currentSpriteNud);
            Controls.Add(SpriteSaveBtn);
            Controls.Add(imageBox);
            Controls.Add(saveOptionsCb);
            Controls.Add(RangeGb);
            Name = "SaveSprite";
            Text = "SaveSprite";
            Load += SaveSprite_Load;
            RangeGb.ResumeLayout(false);
            RangeGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)toNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)fromNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)currentSpriteNud).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox RangeGb;
        private System.Windows.Forms.NumericUpDown toNud;
        private System.Windows.Forms.NumericUpDown fromNud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox saveOptionsCb;
        private Amiga.ImageBox imageBox;
        private System.Windows.Forms.Button SpriteSaveBtn;
        private System.Windows.Forms.NumericUpDown currentSpriteNud;
    }
}