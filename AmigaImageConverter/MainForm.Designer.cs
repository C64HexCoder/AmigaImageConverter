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
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LoadIFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveIFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iLBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveMaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePallateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageAsSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignWidthComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.addWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBlitWordComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.removeBlitterWorldToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBlitterWordToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.addedWordNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setImageWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripChangeWidthTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.autoCorpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayMaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spriteSheetCutterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pallateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveSourceFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripResolutionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDepthLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.image = new Amiga.ImageBox();
            this.SlicingPanel = new System.Windows.Forms.Panel();
            this.SlicingGb = new System.Windows.Forms.GroupBox();
            this.sprImageBox = new Amiga.ImageBox();
            this.SpriteSaveBtn = new System.Windows.Forms.Button();
            this.spriteWidthCb = new System.Windows.Forms.ComboBox();
            this.spriteSelectNud = new System.Windows.Forms.NumericUpDown();
            this.SliceBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numOfRawsNud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.SpritesPerRawNud = new System.Windows.Forms.NumericUpDown();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SlicingPanel.SuspendLayout();
            this.SlicingGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteSelectNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfRawsNud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpritesPerRawNud)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.colorsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1100, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.saveImageToolStripMenuItem,
            this.saveImageAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.LoadIFFToolStripMenuItem,
            this.saveIFFToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveMaskToolStripMenuItem,
            this.savePallateToolStripMenuItem,
            this.saveImageAsSpriteToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // saveImageAsToolStripMenuItem
            // 
            this.saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            this.saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.saveImageAsToolStripMenuItem.Text = "Save Image As";
            this.saveImageAsToolStripMenuItem.Click += new System.EventHandler(this.saveImageAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(279, 6);
            // 
            // LoadIFFToolStripMenuItem
            // 
            this.LoadIFFToolStripMenuItem.Name = "LoadIFFToolStripMenuItem";
            this.LoadIFFToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.LoadIFFToolStripMenuItem.Text = "Load IFF";
            this.LoadIFFToolStripMenuItem.Click += new System.EventHandler(this.LoadIFFToolStripMenuItem_Click);
            // 
            // saveIFFToolStripMenuItem
            // 
            this.saveIFFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iLBMToolStripMenuItem,
            this.aCBMToolStripMenuItem});
            this.saveIFFToolStripMenuItem.Name = "saveIFFToolStripMenuItem";
            this.saveIFFToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.saveIFFToolStripMenuItem.Text = "Save IFF";
            // 
            // iLBMToolStripMenuItem
            // 
            this.iLBMToolStripMenuItem.Name = "iLBMToolStripMenuItem";
            this.iLBMToolStripMenuItem.Size = new System.Drawing.Size(163, 34);
            this.iLBMToolStripMenuItem.Text = "ILBM";
            this.iLBMToolStripMenuItem.ToolTipText = "Widly Supported";
            this.iLBMToolStripMenuItem.Click += new System.EventHandler(this.iLBMToolStripMenuItem_Click);
            // 
            // aCBMToolStripMenuItem
            // 
            this.aCBMToolStripMenuItem.Name = "aCBMToolStripMenuItem";
            this.aCBMToolStripMenuItem.Size = new System.Drawing.Size(163, 34);
            this.aCBMToolStripMenuItem.Text = "ACBM";
            this.aCBMToolStripMenuItem.ToolTipText = "Faster, Less popular";
            this.aCBMToolStripMenuItem.Click += new System.EventHandler(this.aCBMToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(279, 6);
            // 
            // saveMaskToolStripMenuItem
            // 
            this.saveMaskToolStripMenuItem.Name = "saveMaskToolStripMenuItem";
            this.saveMaskToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.saveMaskToolStripMenuItem.Text = "Save Mask";
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
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeToolStripMenuItem,
            this.alignWidthToolStripMenuItem,
            this.addWordToolStripMenuItem,
            this.removeBlitterWorldToolStripMenuItem3,
            this.setImageWidthToolStripMenuItem,
            this.autoCorpToolStripMenuItem,
            this.displayMaskToolStripMenuItem,
            this.informationToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // alignWidthToolStripMenuItem
            // 
            this.alignWidthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alignWidthComboBox});
            this.alignWidthToolStripMenuItem.Name = "alignWidthToolStripMenuItem";
            this.alignWidthToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.alignWidthToolStripMenuItem.Tag = "Image";
            this.alignWidthToolStripMenuItem.Text = "Align Width";
            this.alignWidthToolStripMenuItem.MouseHover += new System.EventHandler(this.alignWidthToolStripMenuItem_MouseHover);
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
            this.addBlitWordComboBox});
            this.addWordToolStripMenuItem.Name = "addWordToolStripMenuItem";
            this.addWordToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.addWordToolStripMenuItem.Tag = "Image";
            this.addWordToolStripMenuItem.Text = "Add Blitter Word";
            // 
            // addBlitWordComboBox
            // 
            this.addBlitWordComboBox.Items.AddRange(new object[] {
            "None",
            "Left",
            "Right",
            "Both"});
            this.addBlitWordComboBox.Name = "addBlitWordComboBox";
            this.addBlitWordComboBox.Size = new System.Drawing.Size(121, 33);
            this.addBlitWordComboBox.SelectedIndexChanged += new System.EventHandler(this.addBlitWordComboBox_SelectedIndexChanged);
            // 
            // removeBlitterWorldToolStripMenuItem3
            // 
            this.removeBlitterWorldToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeBlitterWordToolStripComboBox,
            this.addedWordNoneToolStripMenuItem});
            this.removeBlitterWorldToolStripMenuItem3.Name = "removeBlitterWorldToolStripMenuItem3";
            this.removeBlitterWorldToolStripMenuItem3.Size = new System.Drawing.Size(277, 34);
            this.removeBlitterWorldToolStripMenuItem3.Text = "Remove Blitter Word";
            this.removeBlitterWorldToolStripMenuItem3.MouseHover += new System.EventHandler(this.removeBlitterWorldToolStripMenuItem3_MouseHover);
            // 
            // removeBlitterWordToolStripComboBox
            // 
            this.removeBlitterWordToolStripComboBox.Items.AddRange(new object[] {
            "None",
            "Left",
            "Right",
            "Both"});
            this.removeBlitterWordToolStripComboBox.Name = "removeBlitterWordToolStripComboBox";
            this.removeBlitterWordToolStripComboBox.Size = new System.Drawing.Size(121, 33);
            this.removeBlitterWordToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.removeBlitterWordToolStripComboBox_SelectedIndexChanged);
            // 
            // addedWordNoneToolStripMenuItem
            // 
            this.addedWordNoneToolStripMenuItem.Name = "addedWordNoneToolStripMenuItem";
            this.addedWordNoneToolStripMenuItem.Size = new System.Drawing.Size(269, 34);
            this.addedWordNoneToolStripMenuItem.Text = "Added Word: None";
            // 
            // setImageWidthToolStripMenuItem
            // 
            this.setImageWidthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripChangeWidthTextBox});
            this.setImageWidthToolStripMenuItem.Name = "setImageWidthToolStripMenuItem";
            this.setImageWidthToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.setImageWidthToolStripMenuItem.Text = "Change Width";
            this.setImageWidthToolStripMenuItem.MouseHover += new System.EventHandler(this.setImageWidthToolStripMenuItem_MouseHover);
            // 
            // toolStripChangeWidthTextBox
            // 
            this.toolStripChangeWidthTextBox.Name = "toolStripChangeWidthTextBox";
            this.toolStripChangeWidthTextBox.Size = new System.Drawing.Size(100, 31);
            this.toolStripChangeWidthTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripChangeWidthTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripChangeWidthTextBox_KeyDown);
            // 
            // autoCorpToolStripMenuItem
            // 
            this.autoCorpToolStripMenuItem.Name = "autoCorpToolStripMenuItem";
            this.autoCorpToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.autoCorpToolStripMenuItem.Text = "Auto Corp";
            this.autoCorpToolStripMenuItem.Click += new System.EventHandler(this.autoCorpToolStripMenuItem_Click);
            // 
            // displayMaskToolStripMenuItem
            // 
            this.displayMaskToolStripMenuItem.Name = "displayMaskToolStripMenuItem";
            this.displayMaskToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.displayMaskToolStripMenuItem.Text = "Create Mask";
            this.displayMaskToolStripMenuItem.Click += new System.EventHandler(this.displayMaskToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutSpriteToolStripMenuItem,
            this.spriteSheetCutterToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 29);
            this.toolStripMenuItem1.Text = "Sprite";
            // 
            // cutSpriteToolStripMenuItem
            // 
            this.cutSpriteToolStripMenuItem.Name = "cutSpriteToolStripMenuItem";
            this.cutSpriteToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.cutSpriteToolStripMenuItem.Text = "Cut Sprite";
            // 
            // spriteSheetCutterToolStripMenuItem
            // 
            this.spriteSheetCutterToolStripMenuItem.Name = "spriteSheetCutterToolStripMenuItem";
            this.spriteSheetCutterToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            this.spriteSheetCutterToolStripMenuItem.Text = "Sprite Sheet Cutter";
            this.spriteSheetCutterToolStripMenuItem.Click += new System.EventHandler(this.sprireSheetCutterToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pallateToolStripMenuItem,
            this.selectBackgroundToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.colorsToolStripMenuItem.Text = "Colors";
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
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(178, 34);
            this.settingsMenuItem.Text = "Settings";
            this.settingsMenuItem.Click += new System.EventHandler(this.settingsMenuItem_Click);
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
            // openImageFileDialog
            // 
            this.openImageFileDialog.Filter = "All image files|*.png;*.bmp|PNG Files|*.PNG|JPEG Files|*.JPG;*.JFIF|BMP Files|*.b" +
    "mp|All Files|*.*";
            // 
            // saveSourceFileDialog
            // 
            this.saveSourceFileDialog.Filter = "Aseembler Source File|*.S;*.asm|Binary File|*.bin| C Source File |*.c";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFileName,
            this.toolStripResolutionLabel,
            this.toolStripDepthLabel,
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 611);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1100, 32);
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
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 24);
            // 
            // image
            // 
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Location = new System.Drawing.Point(0, 34);
            this.image.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.image.Name = "image";
            this.image.ScaleFactor = 4;
            this.image.ScaleFactorFloat = 1F;
            this.image.Size = new System.Drawing.Size(862, 575);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.image.TabIndex = 3;
            this.image.TabStop = false;
            this.image.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.image_LoadCompleted);
            this.image.MouseClick += new System.Windows.Forms.MouseEventHandler(this.image_MouseClick);
            // 
            // SlicingPanel
            // 
            this.SlicingPanel.Controls.Add(this.SlicingGb);
            this.SlicingPanel.Location = new System.Drawing.Point(866, 34);
            this.SlicingPanel.Name = "SlicingPanel";
            this.SlicingPanel.Size = new System.Drawing.Size(234, 575);
            this.SlicingPanel.TabIndex = 4;
            // 
            // SlicingGb
            // 
            this.SlicingGb.Controls.Add(this.sprImageBox);
            this.SlicingGb.Controls.Add(this.SpriteSaveBtn);
            this.SlicingGb.Controls.Add(this.spriteWidthCb);
            this.SlicingGb.Controls.Add(this.spriteSelectNud);
            this.SlicingGb.Controls.Add(this.SliceBtn);
            this.SlicingGb.Controls.Add(this.label2);
            this.SlicingGb.Controls.Add(this.numOfRawsNud);
            this.SlicingGb.Controls.Add(this.label1);
            this.SlicingGb.Controls.Add(this.SpritesPerRawNud);
            this.SlicingGb.Location = new System.Drawing.Point(3, 3);
            this.SlicingGb.Name = "SlicingGb";
            this.SlicingGb.Size = new System.Drawing.Size(231, 569);
            this.SlicingGb.TabIndex = 0;
            this.SlicingGb.TabStop = false;
            this.SlicingGb.Text = "Slicing";
            // 
            // sprImageBox
            // 
            this.sprImageBox.Location = new System.Drawing.Point(6, 176);
            this.sprImageBox.Name = "sprImageBox";
            this.sprImageBox.ScaleFactor = 1;
            this.sprImageBox.ScaleFactorFloat = 1F;
            this.sprImageBox.Size = new System.Drawing.Size(213, 234);
            this.sprImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sprImageBox.TabIndex = 7;
            this.sprImageBox.TabStop = false;
            // 
            // SpriteSaveBtn
            // 
            this.SpriteSaveBtn.Enabled = false;
            this.SpriteSaveBtn.Location = new System.Drawing.Point(6, 453);
            this.SpriteSaveBtn.Name = "SpriteSaveBtn";
            this.SpriteSaveBtn.Size = new System.Drawing.Size(213, 34);
            this.SpriteSaveBtn.TabIndex = 6;
            this.SpriteSaveBtn.Text = "Save";
            this.SpriteSaveBtn.UseVisualStyleBackColor = true;
            this.SpriteSaveBtn.Click += new System.EventHandler(this.SpriteSaveBtn_Click);
            // 
            // spriteWidthCb
            // 
            this.spriteWidthCb.FormattingEnabled = true;
            this.spriteWidthCb.Items.AddRange(new object[] {
            "OCS/ECS 16 Pixels",
            "AGA 32 Pixels",
            "AGA 64 Pixels"});
            this.spriteWidthCb.Location = new System.Drawing.Point(6, 97);
            this.spriteWidthCb.Name = "spriteWidthCb";
            this.spriteWidthCb.Size = new System.Drawing.Size(213, 33);
            this.spriteWidthCb.TabIndex = 5;
            this.spriteWidthCb.Text = "Select sprite width";
            this.spriteWidthCb.SelectedIndexChanged += new System.EventHandler(this.spriteWidthCb_SelectedIndexChanged);
            // 
            // spriteSelectNud
            // 
            this.spriteSelectNud.Location = new System.Drawing.Point(6, 416);
            this.spriteSelectNud.Name = "spriteSelectNud";
            this.spriteSelectNud.Size = new System.Drawing.Size(213, 31);
            this.spriteSelectNud.TabIndex = 4;
            this.spriteSelectNud.ValueChanged += new System.EventHandler(this.spriteSelectNud_ValueChanged);
            // 
            // SliceBtn
            // 
            this.SliceBtn.Location = new System.Drawing.Point(6, 136);
            this.SliceBtn.Name = "SliceBtn";
            this.SliceBtn.Size = new System.Drawing.Size(213, 34);
            this.SliceBtn.TabIndex = 1;
            this.SliceBtn.Text = "Slice it!";
            this.SliceBtn.UseVisualStyleBackColor = true;
            this.SliceBtn.Click += new System.EventHandler(this.SliceBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Raws";
            // 
            // numOfRawsNud
            // 
            this.numOfRawsNud.Location = new System.Drawing.Point(113, 60);
            this.numOfRawsNud.Name = "numOfRawsNud";
            this.numOfRawsNud.Size = new System.Drawing.Size(106, 31);
            this.numOfRawsNud.TabIndex = 2;
            this.numOfRawsNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sprites/Raw";
            // 
            // SpritesPerRawNud
            // 
            this.SpritesPerRawNud.Location = new System.Drawing.Point(6, 60);
            this.SpritesPerRawNud.Name = "SpritesPerRawNud";
            this.SpritesPerRawNud.Size = new System.Drawing.Size(106, 31);
            this.SpritesPerRawNud.TabIndex = 0;
            this.SpritesPerRawNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.resizeToolStripMenuItem.Text = "Resize";
            this.resizeToolStripMenuItem.Click += new System.EventHandler(this.resizeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1100, 643);
            this.Controls.Add(this.SlicingPanel);
            this.Controls.Add(this.image);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amiga Image Converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.SlicingPanel.ResumeLayout(false);
            this.SlicingGb.ResumeLayout(false);
            this.SlicingGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sprImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spriteSelectNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfRawsNud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpritesPerRawNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageAsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.SaveFileDialog saveSourceFileDialog;
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
        private System.Windows.Forms.ToolStripMenuItem saveImageAsSpriteToolStripMenuItem;
        private Amiga.ImageBox image;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alignWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox alignWidthComboBox;
        private System.Windows.Forms.ToolStripComboBox addBlitWordComboBox;
        private System.Windows.Forms.ToolStripMenuItem autoCorpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spriteSheetCutterToolStripMenuItem;
        private System.Windows.Forms.Panel SlicingPanel;
        private System.Windows.Forms.Button SliceBtn;
        private System.Windows.Forms.GroupBox SlicingGb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numOfRawsNud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SpritesPerRawNud;
        private System.Windows.Forms.NumericUpDown spriteSelectNud;
        private System.Windows.Forms.ComboBox spriteWidthCb;
        private System.Windows.Forms.Button SpriteSaveBtn;
        private Amiga.ImageBox sprImageBox;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripMenuItem removeBlitterWorldToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pallateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox removeBlitterWordToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem addedWordNoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setImageWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripChangeWidthTextBox;
        private System.Windows.Forms.ToolStripMenuItem saveMaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayMaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem LoadIFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveIFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iLBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
    }
}

