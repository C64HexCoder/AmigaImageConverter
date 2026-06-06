namespace C64.Controls
{
    partial class SpritePalette
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
            colorSelector1 = new ColorSelector();
            colorSelector2 = new ColorSelector();
            colorSelector3 = new ColorSelector();
            SuspendLayout();
            // 
            // spriteColorColorSelector
            // 
            colorSelector1.C64ColorIndex = 0;
            colorSelector1.Location = new System.Drawing.Point(3, 3);
            colorSelector1.Name = "colorSelector1";
            colorSelector1.Size = new System.Drawing.Size(113, 53);
            colorSelector1.TabIndex = 0;
            // 
            // multiColor1ColorSelector
            // 
            colorSelector2.C64ColorIndex = 0;
            colorSelector2.Location = new System.Drawing.Point(122, 3);
            colorSelector2.Name = "colorSelector2";
            colorSelector2.Size = new System.Drawing.Size(113, 53);
            colorSelector2.TabIndex = 1;
            colorSelector2.Load += colorSelector2_Load;
            // 
            // multiColor2colorSelector
            // 
            colorSelector3.C64ColorIndex = 0;
            colorSelector3.Location = new System.Drawing.Point(241, 3);
            colorSelector3.Name = "colorSelector3";
            colorSelector3.Size = new System.Drawing.Size(113, 53);
            colorSelector3.TabIndex = 2;
            // 
            // SpritePalette
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(colorSelector3);
            Controls.Add(colorSelector2);
            Controls.Add(colorSelector1);
            Name = "SpritePalette";
            Size = new System.Drawing.Size(357, 59);
            ResumeLayout(false);
        }

        #endregion

        private ColorSelector colorSelector1;
        private ColorSelector colorSelector2;
        private ColorSelector colorSelector3;
    }
}
