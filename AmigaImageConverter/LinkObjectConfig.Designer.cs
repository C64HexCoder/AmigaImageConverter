namespace AmigaImageConverter
{
    partial class LinkObjectConfig
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
            externalDescriptorTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            memoryTypeComboBox = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // externalDescriptorTextBox
            // 
            externalDescriptorTextBox.Location = new System.Drawing.Point(12, 37);
            externalDescriptorTextBox.Name = "externalDescriptorTextBox";
            externalDescriptorTextBox.Size = new System.Drawing.Size(447, 31);
            externalDescriptorTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(155, 25);
            label1.TabIndex = 1;
            label1.Text = "External Definition";
            // 
            // memoryTypeComboBox
            // 
            memoryTypeComboBox.FormattingEnabled = true;
            memoryTypeComboBox.Items.AddRange(new object[] { "Any", "Chip", "Fast" });
            memoryTypeComboBox.Location = new System.Drawing.Point(12, 74);
            memoryTypeComboBox.Name = "memoryTypeComboBox";
            memoryTypeComboBox.Size = new System.Drawing.Size(447, 33);
            memoryTypeComboBox.TabIndex = 2;
            memoryTypeComboBox.Text = "Choose Memory Type";
            // 
            // button1
            // 
            button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            button1.Location = new System.Drawing.Point(347, 116);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // LinkObjectConfig
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(467, 162);
            Controls.Add(button1);
            Controls.Add(memoryTypeComboBox);
            Controls.Add(label1);
            Controls.Add(externalDescriptorTextBox);
            Name = "LinkObjectConfig";
            Text = "Link Object Configuration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox externalDescriptorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox memoryTypeComboBox;
        private System.Windows.Forms.Button button1;
    }
}