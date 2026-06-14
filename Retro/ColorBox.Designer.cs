namespace Retro
{
    partial class ColorBox
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
            RGBDispLbl = new Label();
            SuspendLayout();
            // 
            // RGBDispLbl
            // 
            RGBDispLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RGBDispLbl.AutoSize = true;
            RGBDispLbl.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            RGBDispLbl.Location = new Point(91, 97);
            RGBDispLbl.Name = "RGBDispLbl";
            RGBDispLbl.Size = new Size(42, 25);
            RGBDispLbl.TabIndex = 0;
            RGBDispLbl.Text = "000";
            RGBDispLbl.MouseClick += RGBDispLbl_MouseClick;
            // 
            // ColorBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RGBDispLbl);
            Name = "ColorBox";
            Size = new Size(136, 131);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RGBDispLbl;
    }
}
