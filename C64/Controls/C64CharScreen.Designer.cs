using System.Drawing;

namespace C64.Controls
{
    partial class C64CharScreen
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
            SuspendLayout();
            // 
            // C64CharScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            CellsOnX = 40;
            CellsOnY = 25;
            Name = "C64CharScreen";
            ResolutionX = 40;
            ResolutionY = 25;
            Size = new Size(626, 415);
            ResumeLayout(false);
        }

        #endregion
    }
}
