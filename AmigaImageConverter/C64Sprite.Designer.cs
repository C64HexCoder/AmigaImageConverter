namespace AmigaImageConverter
{
    partial class C64Sprite
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
            sprite1 = new C64.Controls.Sprite();
            helpProvider1 = new System.Windows.Forms.HelpProvider();
            SuspendLayout();
            // 
            // sprite1
            // 
            sprite1.CellWidthHeight = 20;
            sprite1.IsMulticolor = false;
            sprite1.Location = new System.Drawing.Point(12, 12);
            sprite1.Name = "sprite1";
            sprite1.Size = new System.Drawing.Size(481, 421);
            sprite1.SpriteData = new byte[]
    {
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0
    };
            sprite1.TabIndex = 0;
            // 
            // C64Sprite
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(sprite1);
            Name = "C64Sprite";
            Text = "C64Sprite";
            ResumeLayout(false);
        }

        #endregion

        private C64.Controls.Sprite sprite1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}