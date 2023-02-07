namespace AmigaImageConverter
{
    partial class DisplayMask
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
            this.imageGrid = new Amiga.ImageGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageGrid
            // 
            this.imageGrid.CellBorder = true;
            this.imageGrid.CellsOnX = 20;
            this.imageGrid.CellsOnY = 10;
            this.imageGrid.DrawColor = System.Drawing.Color.Blue;
            this.imageGrid.GridImage = null;
            this.imageGrid.LineWidth = 2;
            this.imageGrid.Location = new System.Drawing.Point(5, 12);
            this.imageGrid.Name = "imageGrid";
            this.imageGrid.Size = new System.Drawing.Size(920, 435);
            this.imageGrid.TabIndex = 0;
            this.imageGrid.Load += new System.EventHandler(this.imageGrid_Load);
            this.imageGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.imageGrid_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(813, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DisplayMask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(948, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imageGrid);
            this.Name = "DisplayMask";
            this.Text = "Mask";
            this.Activated += new System.EventHandler(this.DisplayMask_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private Amiga.ImageGrid imageGrid;
        private System.Windows.Forms.Button button1;
    }
}