namespace AmigaImageConverter
{
    partial class ColorsGrid
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
            colorPanel = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // colorPanel
            // 
            colorPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            colorPanel.Location = new System.Drawing.Point(3, 3);
            colorPanel.Name = "colorPanel";
            colorPanel.Size = new System.Drawing.Size(440, 450);
            colorPanel.TabIndex = 0;
            colorPanel.Paint += colorPanel_Paint;
            // 
            // ColorsGrid
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(colorPanel);
            Name = "ColorsGrid";
            Size = new System.Drawing.Size(446, 453);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel colorPanel;
    }
}
