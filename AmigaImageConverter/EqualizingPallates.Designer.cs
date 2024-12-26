namespace AmigaImageConverter
{
    partial class EqualizingPallates
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
            this.label1 = new System.Windows.Forms.Label();
            this.fromSpriteNud = new System.Windows.Forms.NumericUpDown();
            this.toSpriteNud = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.pallateNud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.colorsToUseCbox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fromSpriteNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toSpriteNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pallateNud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Sprite:";
            // 
            // fromSpriteNud
            // 
            this.fromSpriteNud.Location = new System.Drawing.Point(14, 42);
            this.fromSpriteNud.Name = "fromSpriteNud";
            this.fromSpriteNud.Size = new System.Drawing.Size(180, 31);
            this.fromSpriteNud.TabIndex = 1;
            // 
            // toSpriteNud
            // 
            this.toSpriteNud.Location = new System.Drawing.Point(14, 123);
            this.toSpriteNud.Name = "toSpriteNud";
            this.toSpriteNud.Size = new System.Drawing.Size(180, 31);
            this.toSpriteNud.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "To Sprite:";
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ConvertBtn.Location = new System.Drawing.Point(295, 196);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(112, 34);
            this.ConvertBtn.TabIndex = 4;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(14, 196);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(112, 34);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // pallateNud
            // 
            this.pallateNud.Location = new System.Drawing.Point(225, 123);
            this.pallateNud.Name = "pallateNud";
            this.pallateNud.Size = new System.Drawing.Size(180, 31);
            this.pallateNud.TabIndex = 7;
            this.pallateNud.ValueChanged += new System.EventHandler(this.pallateNud_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pallate to copy:";
            // 
            // colorsToUseCbox
            // 
            this.colorsToUseCbox.FormattingEnabled = true;
            this.colorsToUseCbox.Items.AddRange(new object[] {
            "Choose Pallate",
            "Avaragong Colors"});
            this.colorsToUseCbox.Location = new System.Drawing.Point(225, 40);
            this.colorsToUseCbox.Name = "colorsToUseCbox";
            this.colorsToUseCbox.Size = new System.Drawing.Size(182, 33);
            this.colorsToUseCbox.TabIndex = 8;
            this.colorsToUseCbox.SelectedIndexChanged += new System.EventHandler(this.colorsToUseCbox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Colors to use:";
            // 
            // EqualizingPallates
            // 
            this.AcceptButton = this.ConvertBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(423, 242);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.colorsToUseCbox);
            this.Controls.Add(this.pallateNud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.toSpriteNud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fromSpriteNud);
            this.Controls.Add(this.label1);
            this.Name = "EqualizingPallates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AvaragePallates";
            ((System.ComponentModel.ISupportInitialize)(this.fromSpriteNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toSpriteNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pallateNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown fromSpriteNud;
        private System.Windows.Forms.NumericUpDown toSpriteNud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.NumericUpDown pallateNud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox colorsToUseCbox;
        private System.Windows.Forms.Label label4;
    }
}