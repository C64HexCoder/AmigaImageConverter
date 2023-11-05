namespace AmigaImageConverter
{
    partial class AudioSamleEditorDialog
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
            comboBoxWaveform = new System.Windows.Forms.ComboBox();
            numericNumOfSamples = new System.Windows.Forms.NumericUpDown();
            button1 = new System.Windows.Forms.Button();
            GraphPicBox = new System.Windows.Forms.PictureBox();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            sampleRateLbl = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            playButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numericNumOfSamples).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GraphPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxWaveform
            // 
            comboBoxWaveform.FormattingEnabled = true;
            comboBoxWaveform.Items.AddRange(new object[] { "Sine Wave", "Squere Wave", "Triangle Wave" });
            comboBoxWaveform.Location = new System.Drawing.Point(1180, 12);
            comboBoxWaveform.Name = "comboBoxWaveform";
            comboBoxWaveform.Size = new System.Drawing.Size(265, 33);
            comboBoxWaveform.TabIndex = 0;
            comboBoxWaveform.Text = "Select Waveform";
            comboBoxWaveform.SelectedIndexChanged += comboBoxWaveform_SelectedIndexChanged;
            // 
            // numericNumOfSamples
            // 
            numericNumOfSamples.Location = new System.Drawing.Point(1180, 95);
            numericNumOfSamples.Maximum = new decimal(new int[] { 256, 0, 0, 0 });
            numericNumOfSamples.Name = "numericNumOfSamples";
            numericNumOfSamples.Size = new System.Drawing.Size(265, 31);
            numericNumOfSamples.TabIndex = 1;
            numericNumOfSamples.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numericNumOfSamples.ValueChanged += numericNumOfSamples_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(1333, 526);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Finished";
            button1.UseVisualStyleBackColor = true;
            // 
            // GraphPicBox
            // 
            GraphPicBox.Location = new System.Drawing.Point(12, 12);
            GraphPicBox.Name = "GraphPicBox";
            GraphPicBox.Size = new System.Drawing.Size(1153, 548);
            GraphPicBox.TabIndex = 3;
            GraphPicBox.TabStop = false;
            GraphPicBox.MouseHover += GraphPicBox_MouseHover;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(1180, 175);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(265, 31);
            numericUpDown1.TabIndex = 4;
            // 
            // sampleRateLbl
            // 
            sampleRateLbl.AutoSize = true;
            sampleRateLbl.Location = new System.Drawing.Point(1180, 147);
            sampleRateLbl.Name = "sampleRateLbl";
            sampleRateLbl.Size = new System.Drawing.Size(111, 25);
            sampleRateLbl.TabIndex = 5;
            sampleRateLbl.Text = "Sample Rate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(1180, 67);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(174, 25);
            label1.TabIndex = 6;
            label1.Text = "Number Of Samples";
            // 
            // playButton
            // 
            playButton.Location = new System.Drawing.Point(1180, 243);
            playButton.Name = "playButton";
            playButton.Size = new System.Drawing.Size(265, 34);
            playButton.TabIndex = 7;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            // 
            // AudioSamleEditorDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1457, 576);
            Controls.Add(playButton);
            Controls.Add(label1);
            Controls.Add(sampleRateLbl);
            Controls.Add(numericUpDown1);
            Controls.Add(GraphPicBox);
            Controls.Add(button1);
            Controls.Add(numericNumOfSamples);
            Controls.Add(comboBoxWaveform);
            Name = "AudioSamleEditorDialog";
            Text = "Audio_Samle_Editor";
            Paint += AudioSamleEditorDialog_Paint;
            ((System.ComponentModel.ISupportInitialize)numericNumOfSamples).EndInit();
            ((System.ComponentModel.ISupportInitialize)GraphPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxWaveform;
        private System.Windows.Forms.NumericUpDown numericNumOfSamples;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox GraphPicBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label sampleRateLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playButton;
    }
}