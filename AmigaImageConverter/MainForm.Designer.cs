namespace AmigaImageConverter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePallateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageAsSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.alignWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignWidthComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.addWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.autoCorpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pallateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripResolutionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDepthLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.image = new Amiga.ImageBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(871, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.toolStripMenuItem3,
            this.saveImageAsToolStripMenuItem,
            this.savePallateToolStripMenuItem,
            this.saveImageAsSpriteToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(282, 34);
            this.toolStripMenuItem3.Text = "Save Image";
            // 
            // saveImageAsToolStripMenuItem
            // 
            this.saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            this.saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.saveImageAsToolStripMenuItem.Text = "Save Image As";
            this.saveImageAsToolStripMenuItem.Click += new System.EventHandler(this.saveImageAsToolStripMenuItem_Click);
            // 
            // savePallateToolStripMenuItem
            // 
            this.savePallateToolStripMenuItem.Name = "savePallateToolStripMenuItem";
            this.savePallateToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.savePallateToolStripMenuItem.Text = "Save Pallate";
            this.savePallateToolStripMenuItem.Click += new System.EventHandler(this.savePallateToolStripMenuItem_Click);
            // 
            // saveImageAsSpriteToolStripMenuItem
            // 
            this.saveImageAsSpriteToolStripMenuItem.Name = "saveImageAsSpriteToolStripMenuItem";
            this.saveImageAsSpriteToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.saveImageAsSpriteToolStripMenuItem.Text = "Save Image As Sprite";
            this.saveImageAsSpriteToolStripMenuItem.Click += new System.EventHandler(this.saveImageAsSpriteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alignWidthToolStripMenuItem,
            this.addWordToolStripMenuItem,
            this.autoCorpToolStripMenuItem,
            this.informationToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(78, 29);
            this.toolStripMenuItem2.Text = "Image";
            // 
            // alignWidthToolStripMenuItem
            // 
            this.alignWidthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alignWidthComboBox});
            this.alignWidthToolStripMenuItem.Name = "alignWidthToolStripMenuItem";
            this.alignWidthToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.alignWidthToolStripMenuItem.Text = "Align Width";
            // 
            // alignWidthComboBox
            // 
            this.alignWidthComboBox.Items.AddRange(new object[] {
            "Byte",
            "Word",
            "Long",
            "Double Long"});
            this.alignWidthComboBox.Name = "alignWidthComboBox";
            this.alignWidthComboBox.Size = new System.Drawing.Size(140, 33);
            this.alignWidthComboBox.ToolTipText = "The width alignment Of the Image";
            this.alignWidthComboBox.DropDownClosed += new System.EventHandler(this.alignWidthComboBox_DropDownClosed);
            // 
            // addWordToolStripMenuItem
            // 
            this.addWordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.addWordToolStripMenuItem.Name = "addWordToolStripMenuItem";
            this.addWordToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addWordToolStripMenuItem.Text = "Add Blitter Word";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "None",
            "Left",
            "Right"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 33);
            // 
            // autoCorpToolStripMenuItem
            // 
            this.autoCorpToolStripMenuItem.Name = "autoCorpToolStripMenuItem";
            this.autoCorpToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.autoCorpToolStripMenuItem.Text = "Auto Corp";
            this.autoCorpToolStripMenuItem.Click += new System.EventHandler(this.autoCorpToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutSpriteToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 29);
            this.toolStripMenuItem1.Text = "Sprite";
            // 
            // cutSpriteToolStripMenuItem
            // 
            this.cutSpriteToolStripMenuItem.Name = "cutSpriteToolStripMenuItem";
            this.cutSpriteToolStripMenuItem.Size = new System.Drawing.Size(192, 34);
            this.cutSpriteToolStripMenuItem.Text = "Cut Sprite";
            this.cutSpriteToolStripMenuItem.Click += new System.EventHandler(this.cutSpriteToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenuItem,
            this.pallateToolStripMenuItem,
            this.selectBackgroundToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(260, 34);
            this.settingsMenuItem.Text = "Settings";
            this.settingsMenuItem.Click += new System.EventHandler(this.settingsMenuItem_Click);
            // 
            // pallateToolStripMenuItem
            // 
            this.pallateToolStripMenuItem.Name = "pallateToolStripMenuItem";
            this.pallateToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.pallateToolStripMenuItem.Text = "Pallate";
            this.pallateToolStripMenuItem.Click += new System.EventHandler(this.pallateToolStripMenuItem_Click);
            // 
            // selectBackgroundToolStripMenuItem
            // 
            this.selectBackgroundToolStripMenuItem.Name = "selectBackgroundToolStripMenuItem";
            this.selectBackgroundToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            this.selectBackgroundToolStripMenuItem.Text = "Select Background";
            this.selectBackgroundToolStripMenuItem.Click += new System.EventHandler(this.selectBackgroundToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All image files|*.png;*.bmp|PNG Files|*.PNG|JPEG Files|*.JPG|BMP Files|*.bmp|All " +
    "Files|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Aseembler Source File|*.S;*.asm|Binary File|*.bin| C Source File |*.c";
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFileName,
            this.toolStripResolutionLabel,
            this.toolStripDepthLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 611);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(871, 32);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripFileName
            // 
            this.toolStripFileName.Name = "toolStripFileName";
            this.toolStripFileName.Size = new System.Drawing.Size(90, 25);
            this.toolStripFileName.Text = "File Name";
            // 
            // toolStripResolutionLabel
            // 
            this.toolStripResolutionLabel.Name = "toolStripResolutionLabel";
            this.toolStripResolutionLabel.Size = new System.Drawing.Size(95, 25);
            this.toolStripResolutionLabel.Text = "Resolution";
            // 
            // toolStripDepthLabel
            // 
            this.toolStripDepthLabel.Name = "toolStripDepthLabel";
            this.toolStripDepthLabel.Size = new System.Drawing.Size(61, 25);
            this.toolStripDepthLabel.Text = "Depth";
            // 
            // image
            // 
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Location = new System.Drawing.Point(0, 34);
            this.image.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.image.Name = "image";
            this.image.ScaleFactor = 4;
            this.image.Size = new System.Drawing.Size(862, 575);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.image.TabIndex = 3;
            this.image.TabStop = false;
            this.image.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.image_LoadCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(871, 643);
            this.Controls.Add(this.image);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "MainForm";
            this.Text = "Amiga Image Converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageAsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePallateToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripFileName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripResolutionLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDepthLabel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutSpriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pallateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageAsSpriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectBackgroundToolStripMenuItem;
        private Amiga.ImageBox image;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem alignWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox alignWidthComboBox;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem autoCorpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

