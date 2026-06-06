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
            spriteColorColorSelector = new ColorSelector();
            multiColor1ColorSelector = new ColorSelector();
            multiColor2colorSelector = new ColorSelector();
            SuspendLayout();
            // 
            // spriteColorColorSelector
            // 
            spriteColorColorSelector.C64ColorIndex = 0;
            spriteColorColorSelector.Location = new System.Drawing.Point(3, 3);
            spriteColorColorSelector.Name = "spriteColorColorSelector";
            spriteColorColorSelector.Size = new System.Drawing.Size(113, 53);
            spriteColorColorSelector.TabIndex = 0;
            spriteColorColorSelector.ColorSelectorClicked += spriteColorColorSelector_ColorSelectorClicked;
            // 
            // multiColor1ColorSelector
            // 
            multiColor1ColorSelector.C64ColorIndex = 0;
            multiColor1ColorSelector.Location = new System.Drawing.Point(122, 3);
            multiColor1ColorSelector.Name = "multiColor1ColorSelector";
            multiColor1ColorSelector.Size = new System.Drawing.Size(113, 53);
            multiColor1ColorSelector.TabIndex = 1;
            multiColor1ColorSelector.ColorSelectorClicked += multiColor1ColorSelector_ColorSelectorClicked;
            // 
            // multiColor2colorSelector
            // 
            multiColor2colorSelector.C64ColorIndex = 0;
            multiColor2colorSelector.Location = new System.Drawing.Point(241, 3);
            multiColor2colorSelector.Name = "multiColor2colorSelector";
            multiColor2colorSelector.Size = new System.Drawing.Size(113, 53);
            multiColor2colorSelector.TabIndex = 2;
            multiColor2colorSelector.ColorSelectorClicked += multiColor2ColorSelector_ColorSelectorClicked;
            // 
            // SpritePalette
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(multiColor2colorSelector);
            Controls.Add(multiColor1ColorSelector);
            Controls.Add(spriteColorColorSelector);
            Name = "SpritePalette";
            Size = new System.Drawing.Size(357, 59);
            ResumeLayout(false);
        }

        #endregion

        private ColorSelector spriteColorColorSelector;
        private ColorSelector multiColor1ColorSelector;
        private ColorSelector multiColor2colorSelector;
    }
}
