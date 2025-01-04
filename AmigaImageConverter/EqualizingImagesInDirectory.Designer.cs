namespace AmigaImageConverter
{
    partial class EqualizingImagesInDirectory
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
            destPaletteGB = new System.Windows.Forms.GroupBox();
            loadPaletteBtn = new System.Windows.Forms.Button();
            paletteFileTb = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            selectDirBtn = new System.Windows.Forms.Button();
            folderTBox = new System.Windows.Forms.TextBox();
            equalizeAllBtn = new System.Windows.Forms.Button();
            colorsGrid = new Amiga.ColorsGrid();
            progressBar = new System.Windows.Forms.ProgressBar();
            groupBox2 = new System.Windows.Forms.GroupBox();
            stringToAddTb = new System.Windows.Forms.TextBox();
            saveOptionCbox = new System.Windows.Forms.ComboBox();
            destPaletteGB.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // destPaletteGB
            // 
            destPaletteGB.Controls.Add(loadPaletteBtn);
            destPaletteGB.Controls.Add(paletteFileTb);
            destPaletteGB.Location = new System.Drawing.Point(12, 12);
            destPaletteGB.Name = "destPaletteGB";
            destPaletteGB.Size = new System.Drawing.Size(300, 111);
            destPaletteGB.TabIndex = 0;
            destPaletteGB.TabStop = false;
            destPaletteGB.Text = "Dest. Palette";
            // 
            // loadPaletteBtn
            // 
            loadPaletteBtn.Location = new System.Drawing.Point(182, 67);
            loadPaletteBtn.Name = "loadPaletteBtn";
            loadPaletteBtn.Size = new System.Drawing.Size(112, 34);
            loadPaletteBtn.TabIndex = 1;
            loadPaletteBtn.Text = "Load";
            loadPaletteBtn.UseVisualStyleBackColor = true;
            loadPaletteBtn.Click += loadPaletteBtn_Click;
            // 
            // paletteFileTb
            // 
            paletteFileTb.Location = new System.Drawing.Point(6, 30);
            paletteFileTb.Name = "paletteFileTb";
            paletteFileTb.Size = new System.Drawing.Size(288, 31);
            paletteFileTb.TabIndex = 0;
            paletteFileTb.Text = "Select IFF File Containg The Palette";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(selectDirBtn);
            groupBox1.Controls.Add(folderTBox);
            groupBox1.Location = new System.Drawing.Point(18, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(300, 112);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Directory";
            // 
            // selectDirBtn
            // 
            selectDirBtn.Location = new System.Drawing.Point(176, 67);
            selectDirBtn.Name = "selectDirBtn";
            selectDirBtn.Size = new System.Drawing.Size(112, 34);
            selectDirBtn.TabIndex = 2;
            selectDirBtn.Text = "Select";
            selectDirBtn.UseVisualStyleBackColor = true;
            selectDirBtn.Click += selectDirBtn_Click;
            // 
            // folderTBox
            // 
            folderTBox.Location = new System.Drawing.Point(0, 30);
            folderTBox.Name = "folderTBox";
            folderTBox.Size = new System.Drawing.Size(288, 31);
            folderTBox.TabIndex = 1;
            folderTBox.Text = "Select Folder ";
            // 
            // equalizeAllBtn
            // 
            equalizeAllBtn.Location = new System.Drawing.Point(565, 386);
            equalizeAllBtn.Name = "equalizeAllBtn";
            equalizeAllBtn.Size = new System.Drawing.Size(112, 34);
            equalizeAllBtn.TabIndex = 2;
            equalizeAllBtn.Text = "Equalize All";
            equalizeAllBtn.UseVisualStyleBackColor = true;
            equalizeAllBtn.Click += equalizeAllBtn_Click;
            // 
            // colorsGrid
            // 
            colorsGrid.Location = new System.Drawing.Point(324, 12);
            colorsGrid.Name = "colorsGrid";
            colorsGrid.NumOfColors = 4;
            colorsGrid.paletteFormat = Amiga.ColorsGrid.PaletteFormat.TwelveBit;
            colorsGrid.Size = new System.Drawing.Size(355, 355);
            colorsGrid.TabIndex = 3;
            // 
            // progressBar
            // 
            progressBar.Location = new System.Drawing.Point(14, 432);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(665, 34);
            progressBar.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(stringToAddTb);
            groupBox2.Controls.Add(saveOptionCbox);
            groupBox2.Location = new System.Drawing.Point(18, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(300, 128);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Save Options";
            // 
            // stringToAddTb
            // 
            stringToAddTb.Location = new System.Drawing.Point(6, 80);
            stringToAddTb.Name = "stringToAddTb";
            stringToAddTb.Size = new System.Drawing.Size(282, 31);
            stringToAddTb.TabIndex = 1;
            stringToAddTb.Text = "_PalFixed";
            // 
            // saveOptionCbox
            // 
            saveOptionCbox.FormattingEnabled = true;
            saveOptionCbox.Items.AddRange(new object[] { "Overwrite", "Add To File Name" });
            saveOptionCbox.Location = new System.Drawing.Point(6, 30);
            saveOptionCbox.Name = "saveOptionCbox";
            saveOptionCbox.Size = new System.Drawing.Size(282, 33);
            saveOptionCbox.TabIndex = 0;
            // 
            // EqualizingImagesInDirectory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(689, 478);
            Controls.Add(groupBox2);
            Controls.Add(progressBar);
            Controls.Add(colorsGrid);
            Controls.Add(equalizeAllBtn);
            Controls.Add(groupBox1);
            Controls.Add(destPaletteGB);
            Name = "EqualizingImagesInDirectory";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Equalizing All Images In Directory";
            destPaletteGB.ResumeLayout(false);
            destPaletteGB.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox destPaletteGB;
        private System.Windows.Forms.Button loadPaletteBtn;
        private System.Windows.Forms.TextBox paletteFileTb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectDirBtn;
        private System.Windows.Forms.TextBox folderTBox;
        private System.Windows.Forms.Button equalizeAllBtn;
        private Amiga.ColorsGrid colorsGrid;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox saveOptionCbox;
        private System.Windows.Forms.TextBox stringToAddTb;
    }
}