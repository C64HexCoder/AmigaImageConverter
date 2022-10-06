namespace AmigaImageConverter
{
    partial class SelectBackgroundColor
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
            this.pallete = new Pallate_Control.Pallate();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pallete
            // 
            this.pallete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pallete.Location = new System.Drawing.Point(12, 24);
            this.pallete.Name = "pallete";
            this.pallete.NumOfColors = 4;
            this.pallete.RGBVisible = false;
            this.pallete.SelectedColor = System.Drawing.Color.Empty;
            this.pallete.SelectedColorBox = true;
            this.pallete.Size = new System.Drawing.Size(397, 414);
            this.pallete.TabIndex = 0;
            this.pallete.ColorSelected += new System.EventHandler<Pallate_Control.Pallate.SelectedColorEventArgs>(this.pallete_ColorSelected);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(281, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "I\'ve Selected";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(12, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "No Thanks";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SelectBackgroundColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 537);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pallete);
            this.Name = "SelectBackgroundColor";
            this.Text = "SelectBackgroundColor";
            this.ResumeLayout(false);

        }

        #endregion

        private Pallate_Control.Pallate pallete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}