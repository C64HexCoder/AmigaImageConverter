namespace AmigaImageConverter
{
    partial class LoadBox
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
            textBox1 = new System.Windows.Forms.TextBox();
            loadBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox1.Location = new System.Drawing.Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // loadBtn
            // 
            loadBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            loadBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            loadBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            loadBtn.Location = new System.Drawing.Point(156, 3);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new System.Drawing.Size(71, 33);
            loadBtn.TabIndex = 1;
            loadBtn.Text = "...";
            loadBtn.UseVisualStyleBackColor = true;
            // 
            // LoadBox
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(loadBtn);
            Controls.Add(textBox1);
            Name = "LoadBox";
            Size = new System.Drawing.Size(229, 44);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button loadBtn;
    }
}
