namespace AmigaImageConverter
{
    partial class IFFSave
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
            compressBODYcheckBox = new System.Windows.Forms.CheckBox();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // compressBODYcheckBox
            // 
            compressBODYcheckBox.AutoSize = true;
            compressBODYcheckBox.Location = new System.Drawing.Point(12, 12);
            compressBODYcheckBox.Name = "compressBODYcheckBox";
            compressBODYcheckBox.Size = new System.Drawing.Size(170, 29);
            compressBODYcheckBox.TabIndex = 0;
            compressBODYcheckBox.Text = "Compress BODY";
            compressBODYcheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            button1.Location = new System.Drawing.Point(200, 94);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // IFFSave
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(324, 140);
            Controls.Add(button1);
            Controls.Add(compressBODYcheckBox);
            Name = "IFFSave";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "IFF Options";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox compressBODYcheckBox;
        private System.Windows.Forms.Button button1;
    }
}