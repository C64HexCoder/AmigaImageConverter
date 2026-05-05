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
            groupBox1 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            alignCombobox = new System.Windows.Forms.ComboBox();
            ratioCheckBox = new System.Windows.Forms.CheckBox();
            heightNUD = new System.Windows.Forms.NumericUpDown();
            widthNUD = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            ResizeButton = new System.Windows.Forms.Button();
            colorBox = new Amiga.ColorBox();
            scaledImage = new Amiga.PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heightNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)widthNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scaledImage).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(alignCombobox);
            groupBox1.Controls.Add(ratioCheckBox);
            groupBox1.Controls.Add(heightNUD);
            groupBox1.Controls.Add(widthNUD);
            groupBox1.Location = new System.Drawing.Point(615, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(385, 192);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 101);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 25);
            label2.TabIndex = 4;
            label2.Text = "Alignment";
            // 
            // alignCombobox
            // 
            alignCombobox.FormattingEnabled = true;
            alignCombobox.Items.AddRange(new object[] { "None", "16 bit Alignment", "32 bit Alignment", "64 bit Alignment" });
            alignCombobox.Location = new System.Drawing.Point(6, 129);
            alignCombobox.Name = "alignCombobox";
            alignCombobox.Size = new System.Drawing.Size(182, 33);
            alignCombobox.TabIndex = 3;
            alignCombobox.SelectedIndexChanged += alignCombobox_SelectedIndexChanged;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(615, 238);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(239, 25);
            label1.TabIndex = 4;
            label1.Text = "Background Color (Fill Color)";
            label1.Click += label1_Click;
            // 
            // ResizeButton
            // 
            ResizeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            ResizeButton.Location = new System.Drawing.Point(878, 444);
            ResizeButton.Name = "ResizeButton";
            ResizeButton.Size = new System.Drawing.Size(122, 34);
            ResizeButton.TabIndex = 2;
            ResizeButton.Text = "Resize";
            ResizeButton.UseVisualStyleBackColor = true;
            ResizeButton.Click += ResizeButton_Click;
            // 
            // colorBox
            // 
            colorBox.BackColor = System.Drawing.SystemColors.Control;
            colorBox.BorderColor = System.Drawing.Color.Green;
            colorBox.BorderWidth = 0;
            colorBox.color = System.Drawing.SystemColors.Control;
            colorBox.Location = new System.Drawing.Point(615, 266);
            colorBox.Name = "colorBox";
            colorBox.SetBorder = true;
            colorBox.Size = new System.Drawing.Size(385, 46);
            colorBox.TabIndex = 3;
            colorBox.Click += colorBox_Click;
            // 
            // scaledImage
            // 
            scaledImage.Dock = System.Windows.Forms.DockStyle.Left;
            scaledImage.HorizontalScrollBar = null;
            scaledImage.HScrollBarAlignment = Amiga.PictureBox.HorizontalScrollBarAlignment.Bottom;
            scaledImage.Image = null;
            scaledImage.InterpolationAlgorithm = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            scaledImage.Location = new System.Drawing.Point(0, 0);
            scaledImage.MouseWheelZoom = true;
            scaledImage.Name = "scaledImage";
            scaledImage.OverlayLineWidth = 4;
            scaledImage.ScaleFactor = 1F;
            scaledImage.ScaleStep = 0.1F;
            scaledImage.ScrollBarsWidth = 20;
            scaledImage.ShowScrollBars = true;
            scaledImage.Size = new System.Drawing.Size(609, 490);
            scaledImage.SizeMode = Amiga.PictureBox.PictureBoxSizeMode.Zoom;
            scaledImage.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            scaledImage.TabIndex = 4;
            scaledImage.TabStop = false;
            scaledImage.VerticalScrollBar = null;
            scaledImage.VScrollBarAlignment = Amiga.PictureBox.VerticalScrollBarAlignment.Right;
            scaledImage.Click += scaledImage_Click;
            scaledImage.MouseClick += scaledImage_MouseClick;
            // 
            // ResizeCanvas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1012, 490);
            Controls.Add(label1);
            Controls.Add(scaledImage);
            Controls.Add(colorBox);
            Controls.Add(ResizeButton);
            Controls.Add(groupBox1);
            Name = "ResizeCanvas";
            Text = "ResizeCanvas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)heightNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)widthNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)scaledImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Amiga.ExPictureBox exPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ResizeButton;
        private System.Windows.Forms.CheckBox ratioCheckBox;
        public System.Windows.Forms.NumericUpDown widthNUD;
        public System.Windows.Forms.NumericUpDown heightNUD;
        private Amiga.ColorBox colorBox;
        private System.Windows.Forms.Label label1;
        private Amiga.PictureBox scaledImage;
        private System.Windows.Forms.ComboBox alignCombobox;
        private System.Windows.Forms.Label label2;
    }
}
