namespace AmigaImageConverter
{
    partial class ImageToSprite
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
            imageBox1 = new Amiga.ImageBox();
            SpriteCutterGB = new System.Windows.Forms.GroupBox();
            CutBtn = new System.Windows.Forms.Button();
            spritePreviewIB = new Amiga.ImageBox();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            spriteNameLbl = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            trimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            loadImageMI = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)imageBox1).BeginInit();
            SpriteCutterGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)spritePreviewIB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // imageBox1
            // 
            imageBox1.AutoScaleImageBox = false;
            imageBox1.HrizontalScrollBar = null;
            imageBox1.Image = null;
            imageBox1.Location = new System.Drawing.Point(12, 36);
            imageBox1.Name = "imageBox1";
            imageBox1.ScaleFactor = 1;
            imageBox1.ScaleFactorFloat = 1F;
            imageBox1.Size = new System.Drawing.Size(776, 631);
            imageBox1.TabIndex = 0;
            imageBox1.TabStop = false;
            imageBox1.VerticalScrollBar = null;
            // 
            // SpriteCutterGB
            // 
            SpriteCutterGB.Controls.Add(textBox1);
            SpriteCutterGB.Controls.Add(spriteNameLbl);
            SpriteCutterGB.Controls.Add(numericUpDown1);
            SpriteCutterGB.Controls.Add(spritePreviewIB);
            SpriteCutterGB.Controls.Add(CutBtn);
            SpriteCutterGB.Location = new System.Drawing.Point(794, 36);
            SpriteCutterGB.Name = "SpriteCutterGB";
            SpriteCutterGB.Size = new System.Drawing.Size(229, 631);
            SpriteCutterGB.TabIndex = 1;
            SpriteCutterGB.TabStop = false;
            SpriteCutterGB.Text = "Sprite Cutter";
            // 
            // CutBtn
            // 
            CutBtn.Location = new System.Drawing.Point(6, 591);
            CutBtn.Name = "CutBtn";
            CutBtn.Size = new System.Drawing.Size(217, 34);
            CutBtn.TabIndex = 0;
            CutBtn.Text = "button1";
            CutBtn.UseVisualStyleBackColor = true;
            // 
            // spritePreviewIB
            // 
            spritePreviewIB.AutoScaleImageBox = false;
            spritePreviewIB.HrizontalScrollBar = null;
            spritePreviewIB.Image = null;
            spritePreviewIB.Location = new System.Drawing.Point(6, 101);
            spritePreviewIB.Name = "spritePreviewIB";
            spritePreviewIB.ScaleFactor = 1;
            spritePreviewIB.ScaleFactorFloat = 1F;
            spritePreviewIB.Size = new System.Drawing.Size(217, 447);
            spritePreviewIB.TabIndex = 1;
            spritePreviewIB.TabStop = false;
            spritePreviewIB.VerticalScrollBar = null;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(6, 554);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(217, 31);
            numericUpDown1.TabIndex = 2;
            // 
            // spriteNameLbl
            // 
            spriteNameLbl.AutoSize = true;
            spriteNameLbl.Location = new System.Drawing.Point(6, 36);
            spriteNameLbl.Name = "spriteNameLbl";
            spriteNameLbl.Size = new System.Drawing.Size(114, 25);
            spriteNameLbl.TabIndex = 3;
            spriteNameLbl.Text = "Sprite Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(6, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(217, 31);
            textBox1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { loadImageMI, toolStripMenuItem1 });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1035, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cutToolStripMenuItem, trimToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(69, 29);
            toolStripMenuItem1.Text = "Tools";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // trimToolStripMenuItem
            // 
            trimToolStripMenuItem.Name = "trimToolStripMenuItem";
            trimToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            trimToolStripMenuItem.Text = "Trim";
            // 
            // loadImageMI
            // 
            loadImageMI.Name = "loadImageMI";
            loadImageMI.Size = new System.Drawing.Size(118, 29);
            loadImageMI.Text = "load Image";
            // 
            // ImageToSprite
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1035, 679);
            Controls.Add(SpriteCutterGB);
            Controls.Add(imageBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ImageToSprite";
            Text = "ImageToSprite";
            ((System.ComponentModel.ISupportInitialize)imageBox1).EndInit();
            SpriteCutterGB.ResumeLayout(false);
            SpriteCutterGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spritePreviewIB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Amiga.ImageBox imageBox1;
        private System.Windows.Forms.GroupBox SpriteCutterGB;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Amiga.ImageBox spritePreviewIB;
        private System.Windows.Forms.Button CutBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label spriteNameLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageMI;
    }
}