namespace AmigaImageConverter
{
    partial class ResizeCanvas
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
            scaledImage = new Amiga.ExPictureBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            ratioCheckBox = new System.Windows.Forms.CheckBox();
            heightNUD = new System.Windows.Forms.NumericUpDown();
            widthNUD = new System.Windows.Forms.NumericUpDown();
            ResizeButton = new System.Windows.Forms.Button();
            colorBox1 = new Amiga.ColorBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heightNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)widthNUD).BeginInit();
            SuspendLayout();
            // 
            // scaledImage
            // 
            scaledImage.Dock = System.Windows.Forms.DockStyle.Left;
            scaledImage.HScrollAlignment = Amiga.PictureBox.HorizontalScrollBarAlignment.Bottom;
            scaledImage.Image = null;
            scaledImage.InterpulationAlgorithem = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            scaledImage.Location = new System.Drawing.Point(0, 0);
            scaledImage.MouseWheelZoom = true;
            scaledImage.Name = "scaledImage";
            scaledImage.OverlayLineWidth = 4;
            scaledImage.OverlayRectangleColor = System.Drawing.Color.Red;
            scaledImage.OverlayRectangleEnabled = false;
            scaledImage.ScaldeFactor = 1F;
            scaledImage.ScaleStep = 0.1F;
            scaledImage.ScrollbarVisible = false;
            scaledImage.Size = new System.Drawing.Size(370, 450);
            scaledImage.SizeMode = Amiga.PictureBox.PictureBoxSizeMode.Scale;
            scaledImage.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            scaledImage.TabIndex = 0;
            scaledImage.VScrollAlignment = Amiga.PictureBox.VerticalScrollBarAlignment.Right;
            scaledImage.Paint += scaledImage_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ratioCheckBox);
            groupBox1.Controls.Add(heightNUD);
            groupBox1.Controls.Add(widthNUD);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(370, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(391, 127);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Size";
            // 
            // ratioCheckBox
            // 
            ratioCheckBox.AutoSize = true;
            ratioCheckBox.Checked = true;
            ratioCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            ratioCheckBox.Location = new System.Drawing.Point(6, 67);
            ratioCheckBox.Name = "ratioCheckBox";
            ratioCheckBox.Size = new System.Drawing.Size(182, 29);
            ratioCheckBox.TabIndex = 2;
            ratioCheckBox.Text = "Keep Aspect Ratio";
            ratioCheckBox.UseVisualStyleBackColor = true;
            ratioCheckBox.Click += ratioCheckBox_Click;
            // 
            // heightNUD
            // 
            heightNUD.Location = new System.Drawing.Point(199, 30);
            heightNUD.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            heightNUD.Name = "heightNUD";
            heightNUD.Size = new System.Drawing.Size(180, 31);
            heightNUD.TabIndex = 1;
            heightNUD.ValueChanged += heightNUD_ValueChanged;
            // 
            // widthNUD
            // 
            widthNUD.Location = new System.Drawing.Point(6, 30);
            widthNUD.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            widthNUD.Name = "widthNUD";
            widthNUD.Size = new System.Drawing.Size(180, 31);
            widthNUD.TabIndex = 0;
            widthNUD.ValueChanged += widthNUD_ValueChanged;
            // 
            // ResizeButton
            // 
            ResizeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            ResizeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            ResizeButton.Location = new System.Drawing.Point(370, 416);
            ResizeButton.Name = "ResizeButton";
            ResizeButton.Size = new System.Drawing.Size(391, 34);
            ResizeButton.TabIndex = 2;
            ResizeButton.Text = "Resize";
            ResizeButton.UseVisualStyleBackColor = true;
            ResizeButton.Click += ResizeButton_Click;
            // 
            // colorBox1
            // 
            colorBox1.color = System.Drawing.SystemColors.Control;
            colorBox1.Dock = System.Windows.Forms.DockStyle.Top;
            colorBox1.Location = new System.Drawing.Point(370, 127);
            colorBox1.Name = "colorBox1";
            colorBox1.Size = new System.Drawing.Size(391, 46);
            colorBox1.TabIndex = 3;
            // 
            // ResizeCanvas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(761, 450);
            Controls.Add(colorBox1);
            Controls.Add(ResizeButton);
            Controls.Add(groupBox1);
            Controls.Add(scaledImage);
            Name = "ResizeCanvas";
            Text = "ResizeCanvas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)heightNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)widthNUD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Amiga.ExPictureBox exPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ResizeButton;
        private System.Windows.Forms.CheckBox ratioCheckBox;
        public Amiga.ExPictureBox scaledImage;
        public System.Windows.Forms.NumericUpDown widthNUD;
        public System.Windows.Forms.NumericUpDown heightNUD;
        private Amiga.ColorBox colorBox1;
    }
}
