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
            this.RangeGb = new System.Windows.Forms.GroupBox();
            this.toNud = new System.Windows.Forms.NumericUpDown();
            this.fromNud = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveOptionsCb = new System.Windows.Forms.ComboBox();
            this.imageBox = new Amiga.ImageBox();
            this.SpriteSaveBtn = new System.Windows.Forms.Button();
            this.currentSpriteNud = new System.Windows.Forms.NumericUpDown();
            this.RangeGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentSpriteNud)).BeginInit();
            this.SuspendLayout();
            // 
            // RangeGb
            // 
            this.RangeGb.Controls.Add(this.toNud);
            this.RangeGb.Controls.Add(this.fromNud);
            this.RangeGb.Controls.Add(this.label2);
            this.RangeGb.Controls.Add(this.label1);
            this.RangeGb.Location = new System.Drawing.Point(12, 64);
            this.RangeGb.Name = "RangeGb";
            this.RangeGb.Size = new System.Drawing.Size(206, 112);
            this.RangeGb.TabIndex = 0;
            this.RangeGb.TabStop = false;
            this.RangeGb.Text = "Range";
            // 
            // toNud
            // 
            this.toNud.Location = new System.Drawing.Point(110, 62);
            this.toNud.Name = "toNud";
            this.toNud.Size = new System.Drawing.Size(90, 31);
            this.toNud.TabIndex = 3;
            this.toNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toNud.ValueChanged += new System.EventHandler(this.toNud_ValueChanged);
            // 
            // fromNud
            // 
            this.fromNud.Location = new System.Drawing.Point(6, 62);
            this.fromNud.Name = "fromNud";
            this.fromNud.Size = new System.Drawing.Size(90, 31);
            this.fromNud.TabIndex = 2;
            this.fromNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fromNud.ValueChanged += new System.EventHandler(this.fromNud_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // saveOptionsCb
            // 
            this.saveOptionsCb.FormattingEnabled = true;
            this.saveOptionsCb.Items.AddRange(new object[] {
            "Save Current Sprite",
            "Save Range",
            "Save All Sprite"});
            this.saveOptionsCb.Location = new System.Drawing.Point(12, 25);
            this.saveOptionsCb.Name = "saveOptionsCb";
            this.saveOptionsCb.Size = new System.Drawing.Size(200, 33);
            this.saveOptionsCb.TabIndex = 1;
            this.saveOptionsCb.SelectedIndexChanged += new System.EventHandler(this.saveOptionsCb_SelectedIndexChanged);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(238, 12);
            this.imageBox.Name = "imageBox";
            this.imageBox.ScaleFactor = 4;
            this.imageBox.Size = new System.Drawing.Size(301, 426);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            // 
            // SpriteSaveBtn
            // 
            this.SpriteSaveBtn.Location = new System.Drawing.Point(12, 404);
            this.SpriteSaveBtn.Name = "SpriteSaveBtn";
            this.SpriteSaveBtn.Size = new System.Drawing.Size(200, 34);
            this.SpriteSaveBtn.TabIndex = 3;
            this.SpriteSaveBtn.Text = "Save";
            this.SpriteSaveBtn.UseVisualStyleBackColor = true;
            this.SpriteSaveBtn.Click += new System.EventHandler(this.SpriteSaveBtn_Click);
            // 
            // currentSpriteNud
            // 
            this.currentSpriteNud.Location = new System.Drawing.Point(18, 204);
            this.currentSpriteNud.Name = "currentSpriteNud";
            this.currentSpriteNud.Size = new System.Drawing.Size(194, 31);
            this.currentSpriteNud.TabIndex = 4;
            this.currentSpriteNud.ValueChanged += new System.EventHandler(this.currentSpriteNud_ValueChanged);
            // 
            // SaveSprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.currentSpriteNud);
            this.Controls.Add(this.SpriteSaveBtn);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.saveOptionsCb);
            this.Controls.Add(this.RangeGb);
            this.Name = "SaveSprite";
            this.Text = "SaveSprite";
            this.Load += new System.EventHandler(this.SaveSprite_Load);
            this.RangeGb.ResumeLayout(false);
            this.RangeGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentSpriteNud)).EndInit();
            this.ResumeLayout(false);

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