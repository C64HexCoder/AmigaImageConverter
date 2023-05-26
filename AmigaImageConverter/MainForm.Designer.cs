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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            LoadIFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveIFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            iLBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aCBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            saveMaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            savePallateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveImageAsSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            alignWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            alignWidthComboBox = new System.Windows.Forms.ToolStripComboBox();
            addWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addBlitWordComboBox = new System.Windows.Forms.ToolStripComboBox();
            removeBlitterWorldToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            removeBlitterWordToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            addedWordNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            setImageWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripChangeWidthTextBox = new System.Windows.Forms.ToolStripTextBox();
            autoCorpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            displayMaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            cutSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            spriteSheetCutterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pallateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            selectBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            saveSourceFileDialog = new System.Windows.Forms.SaveFileDialog();
            statusStrip = new System.Windows.Forms.StatusStrip();
            toolStripFileName = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripResolutionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripDepthLabel = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripScalingFactorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            image = new Amiga.ImageBox();
            SlicingPanel = new System.Windows.Forms.Panel();
            SlicingGb = new System.Windows.Forms.GroupBox();
            sprImageBox = new Amiga.ImageBox();
            SpriteSaveBtn = new System.Windows.Forms.Button();
            spriteWidthCb = new System.Windows.Forms.ComboBox();
            spriteSelectNud = new System.Windows.Forms.NumericUpDown();
            SliceBtn = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            numOfRawsNud = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            SpritesPerRawNud = new System.Windows.Forms.NumericUpDown();
            hScrollBar = new System.Windows.Forms.HScrollBar();
            vScrollBar = new System.Windows.Forms.VScrollBar();
            menuStrip1.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            SlicingPanel.SuspendLayout();
            SlicingGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sprImageBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spriteSelectNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOfRawsNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpritesPerRawNud).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, imageToolStripMenuItem, toolStripMenuItem1, colorsToolStripMenuItem, settingsToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1100, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { loadImageToolStripMenuItem, saveImageToolStripMenuItem, saveImageAsToolStripMenuItem, toolStripSeparator1, LoadIFFToolStripMenuItem, saveIFFToolStripMenuItem, toolStripSeparator2, saveMaskToolStripMenuItem, savePallateToolStripMenuItem, saveImageAsSpriteToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadImageToolStripMenuItem
            // 
            loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            loadImageToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            loadImageToolStripMenuItem.Text = "Load Image";
            loadImageToolStripMenuItem.Click += loadImageToolStripMenuItem_Click;
            // 
            // saveImageToolStripMenuItem
            // 
            saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            saveImageToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            saveImageToolStripMenuItem.Text = "Save Image";
            saveImageToolStripMenuItem.Click += saveImageToolStripMenuItem_Click;
            // 
            // saveImageAsToolStripMenuItem
            // 
            saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            saveImageAsToolStripMenuItem.Text = "Save Image As";
            saveImageAsToolStripMenuItem.Click += saveImageAsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(279, 6);
            // 
            // LoadIFFToolStripMenuItem
            // 
            LoadIFFToolStripMenuItem.Name = "LoadIFFToolStripMenuItem";
            LoadIFFToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            LoadIFFToolStripMenuItem.Text = "Load IFF";
            LoadIFFToolStripMenuItem.Click += LoadIFFToolStripMenuItem_Click;
            // 
            // saveIFFToolStripMenuItem
            // 
            saveIFFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { iLBMToolStripMenuItem, aCBMToolStripMenuItem });
            saveIFFToolStripMenuItem.Name = "saveIFFToolStripMenuItem";
            saveIFFToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            saveIFFToolStripMenuItem.Text = "Save IFF";
            // 
            // iLBMToolStripMenuItem
            // 
            iLBMToolStripMenuItem.Name = "iLBMToolStripMenuItem";
            iLBMToolStripMenuItem.Size = new System.Drawing.Size(163, 34);
            iLBMToolStripMenuItem.Text = "ILBM";
            iLBMToolStripMenuItem.ToolTipText = "Widly Supported";
            iLBMToolStripMenuItem.Click += iLBMToolStripMenuItem_Click;
            // 
            // aCBMToolStripMenuItem
            // 
            aCBMToolStripMenuItem.Name = "aCBMToolStripMenuItem";
            aCBMToolStripMenuItem.Size = new System.Drawing.Size(163, 34);
            aCBMToolStripMenuItem.Text = "ACBM";
            aCBMToolStripMenuItem.ToolTipText = "Faster, Less popular";
            aCBMToolStripMenuItem.Click += aCBMToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(279, 6);
            // 
            // saveMaskToolStripMenuItem
            // 
            saveMaskToolStripMenuItem.Name = "saveMaskToolStripMenuItem";
            saveMaskToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            saveMaskToolStripMenuItem.Text = "Save Mask";
            // 
            // savePallateToolStripMenuItem
            // 
            savePallateToolStripMenuItem.Name = "savePallateToolStripMenuItem";
            savePallateToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            savePallateToolStripMenuItem.Text = "Save Pallate";
            savePallateToolStripMenuItem.Click += savePallateToolStripMenuItem_Click;
            // 
            // saveImageAsSpriteToolStripMenuItem
            // 
            saveImageAsSpriteToolStripMenuItem.Name = "saveImageAsSpriteToolStripMenuItem";
            saveImageAsSpriteToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            saveImageAsSpriteToolStripMenuItem.Text = "Save Image As Sprite";
            saveImageAsSpriteToolStripMenuItem.Click += saveImageAsSpriteToolStripMenuItem_Click;
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { resizeToolStripMenuItem, alignWidthToolStripMenuItem, addWordToolStripMenuItem, removeBlitterWorldToolStripMenuItem3, setImageWidthToolStripMenuItem, autoCorpToolStripMenuItem, displayMaskToolStripMenuItem, informationToolStripMenuItem });
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            imageToolStripMenuItem.Text = "Image";
            // 
            // resizeToolStripMenuItem
            // 
            resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            resizeToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            resizeToolStripMenuItem.Text = "Resize";
            resizeToolStripMenuItem.Click += resizeToolStripMenuItem_Click;
            // 
            // alignWidthToolStripMenuItem
            // 
            alignWidthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { alignWidthComboBox });
            alignWidthToolStripMenuItem.Name = "alignWidthToolStripMenuItem";
            alignWidthToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            alignWidthToolStripMenuItem.Tag = "Image";
            alignWidthToolStripMenuItem.Text = "Align Width To";
            alignWidthToolStripMenuItem.ToolTipText = " Round image width to Byte/Word/Long/Double long and align it";
            alignWidthToolStripMenuItem.MouseHover += alignWidthToolStripMenuItem_MouseHover;
            // 
            // alignWidthComboBox
            // 
            alignWidthComboBox.Items.AddRange(new object[] { "Byte", "Word", "Long", "Double Long" });
            alignWidthComboBox.Name = "alignWidthComboBox";
            alignWidthComboBox.Size = new System.Drawing.Size(140, 33);
            alignWidthComboBox.ToolTipText = "The width alignment Of the Image";
            alignWidthComboBox.DropDownClosed += alignWidthComboBox_DropDownClosed;
            // 
            // addWordToolStripMenuItem
            // 
            addWordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { addBlitWordComboBox });
            addWordToolStripMenuItem.Name = "addWordToolStripMenuItem";
            addWordToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            addWordToolStripMenuItem.Tag = "Image";
            addWordToolStripMenuItem.Text = "Add Blitter Word";
            // 
            // addBlitWordComboBox
            // 
            addBlitWordComboBox.Items.AddRange(new object[] { "None", "Left", "Right", "Both" });
            addBlitWordComboBox.Name = "addBlitWordComboBox";
            addBlitWordComboBox.Size = new System.Drawing.Size(121, 33);
            addBlitWordComboBox.SelectedIndexChanged += addBlitWordComboBox_SelectedIndexChanged;
            // 
            // removeBlitterWorldToolStripMenuItem3
            // 
            removeBlitterWorldToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { removeBlitterWordToolStripComboBox, addedWordNoneToolStripMenuItem });
            removeBlitterWorldToolStripMenuItem3.Name = "removeBlitterWorldToolStripMenuItem3";
            removeBlitterWorldToolStripMenuItem3.Size = new System.Drawing.Size(277, 34);
            removeBlitterWorldToolStripMenuItem3.Text = "Remove Blitter Word";
            removeBlitterWorldToolStripMenuItem3.MouseHover += removeBlitterWorldToolStripMenuItem3_MouseHover;
            // 
            // removeBlitterWordToolStripComboBox
            // 
            removeBlitterWordToolStripComboBox.Items.AddRange(new object[] { "None", "Left", "Right", "Both" });
            removeBlitterWordToolStripComboBox.Name = "removeBlitterWordToolStripComboBox";
            removeBlitterWordToolStripComboBox.Size = new System.Drawing.Size(121, 33);
            removeBlitterWordToolStripComboBox.SelectedIndexChanged += removeBlitterWordToolStripComboBox_SelectedIndexChanged;
            // 
            // addedWordNoneToolStripMenuItem
            // 
            addedWordNoneToolStripMenuItem.Name = "addedWordNoneToolStripMenuItem";
            addedWordNoneToolStripMenuItem.Size = new System.Drawing.Size(269, 34);
            addedWordNoneToolStripMenuItem.Text = "Added Word: None";
            // 
            // setImageWidthToolStripMenuItem
            // 
            setImageWidthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripChangeWidthTextBox });
            setImageWidthToolStripMenuItem.Name = "setImageWidthToolStripMenuItem";
            setImageWidthToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            setImageWidthToolStripMenuItem.Text = "Change Width";
            setImageWidthToolStripMenuItem.MouseHover += setImageWidthToolStripMenuItem_MouseHover;
            // 
            // toolStripChangeWidthTextBox
            // 
            toolStripChangeWidthTextBox.Name = "toolStripChangeWidthTextBox";
            toolStripChangeWidthTextBox.Size = new System.Drawing.Size(100, 31);
            toolStripChangeWidthTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            toolStripChangeWidthTextBox.KeyDown += toolStripChangeWidthTextBox_KeyDown;
            // 
            // autoCorpToolStripMenuItem
            // 
            autoCorpToolStripMenuItem.Name = "autoCorpToolStripMenuItem";
            autoCorpToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            autoCorpToolStripMenuItem.Text = "Auto Corp";
            autoCorpToolStripMenuItem.Click += autoCorpToolStripMenuItem_Click;
            // 
            // displayMaskToolStripMenuItem
            // 
            displayMaskToolStripMenuItem.Name = "displayMaskToolStripMenuItem";
            displayMaskToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            displayMaskToolStripMenuItem.Text = "Create Mask";
            displayMaskToolStripMenuItem.Click += displayMaskToolStripMenuItem_Click;
            // 
            // informationToolStripMenuItem
            // 
            informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            informationToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            informationToolStripMenuItem.Text = "Information";
            informationToolStripMenuItem.Click += informationToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cutSpriteToolStripMenuItem, spriteSheetCutterToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(74, 29);
            toolStripMenuItem1.Text = "Sprite";
            // 
            // cutSpriteToolStripMenuItem
            // 
            cutSpriteToolStripMenuItem.Name = "cutSpriteToolStripMenuItem";
            cutSpriteToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            cutSpriteToolStripMenuItem.Text = "Cut Sprite";
            // 
            // spriteSheetCutterToolStripMenuItem
            // 
            spriteSheetCutterToolStripMenuItem.Name = "spriteSheetCutterToolStripMenuItem";
            spriteSheetCutterToolStripMenuItem.Size = new System.Drawing.Size(262, 34);
            spriteSheetCutterToolStripMenuItem.Text = "Sprite Sheet Cutter";
            spriteSheetCutterToolStripMenuItem.Click += sprireSheetCutterToolStripMenuItem_Click;
            // 
            // colorsToolStripMenuItem
            // 
            colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { pallateToolStripMenuItem, selectBackgroundToolStripMenuItem });
            colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            colorsToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            colorsToolStripMenuItem.Text = "Colors";
            // 
            // pallateToolStripMenuItem
            // 
            pallateToolStripMenuItem.Name = "pallateToolStripMenuItem";
            pallateToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            pallateToolStripMenuItem.Text = "Pallate";
            pallateToolStripMenuItem.Click += pallateToolStripMenuItem_Click;
            // 
            // selectBackgroundToolStripMenuItem
            // 
            selectBackgroundToolStripMenuItem.Name = "selectBackgroundToolStripMenuItem";
            selectBackgroundToolStripMenuItem.Size = new System.Drawing.Size(260, 34);
            selectBackgroundToolStripMenuItem.Text = "Select Background";
            selectBackgroundToolStripMenuItem.Click += selectBackgroundToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { settingsMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // settingsMenuItem
            // 
            settingsMenuItem.Name = "settingsMenuItem";
            settingsMenuItem.Size = new System.Drawing.Size(178, 34);
            settingsMenuItem.Text = "Settings";
            settingsMenuItem.Click += settingsMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            aboutToolStripMenuItem.Text = "About";
            // 
            // aboutMenuItem
            // 
            aboutMenuItem.Name = "aboutMenuItem";
            aboutMenuItem.Size = new System.Drawing.Size(164, 34);
            aboutMenuItem.Text = "About";
            aboutMenuItem.Click += aboutMenuItem_Click;
            // 
            // openImageFileDialog
            // 
            openImageFileDialog.Filter = "All image files|*.png;*.bmp|PNG Files|*.PNG|JPEG Files|*.JPG;*.JFIF|BMP Files|*.bmp|All Files|*.*";
            // 
            // saveSourceFileDialog
            // 
            saveSourceFileDialog.Filter = "Aseembler Source File|*.S;*.asm|Binary File|*.bin| C Source File |*.c";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripFileName, toolStripResolutionLabel, toolStripDepthLabel, toolStripScalingFactorLabel, toolStripProgressBar });
            statusStrip.Location = new System.Drawing.Point(0, 611);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip.Size = new System.Drawing.Size(1100, 32);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripFileName
            // 
            toolStripFileName.Name = "toolStripFileName";
            toolStripFileName.Size = new System.Drawing.Size(90, 25);
            toolStripFileName.Text = "File Name";
            // 
            // toolStripResolutionLabel
            // 
            toolStripResolutionLabel.Name = "toolStripResolutionLabel";
            toolStripResolutionLabel.Size = new System.Drawing.Size(95, 25);
            toolStripResolutionLabel.Text = "Resolution";
            // 
            // toolStripDepthLabel
            // 
            toolStripDepthLabel.Name = "toolStripDepthLabel";
            toolStripDepthLabel.Size = new System.Drawing.Size(61, 25);
            toolStripDepthLabel.Text = "Depth";
            // 
            // toolStripScalingFactorLabel
            // 
            toolStripScalingFactorLabel.Name = "toolStripScalingFactorLabel";
            toolStripScalingFactorLabel.Size = new System.Drawing.Size(121, 25);
            toolStripScalingFactorLabel.Text = "Scaling Factor";
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Size = new System.Drawing.Size(100, 24);
            // 
            // image
            // 
            image.AutoScaleImageBox = false;
            image.Image = null;
            image.Location = new System.Drawing.Point(0, 34);
            image.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            image.Name = "image";
            image.ScaleFactor = 4;
            image.ScaleFactorFloat = 1F;
            image.Size = new System.Drawing.Size(831, 534);
            image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            image.TabIndex = 3;
            image.TabStop = false;
            image.LoadCompleted += image_LoadCompleted;
            image.MouseClick += image_MouseClick;
            // 
            // SlicingPanel
            // 
            SlicingPanel.Controls.Add(SlicingGb);
            SlicingPanel.Location = new System.Drawing.Point(866, 34);
            SlicingPanel.Name = "SlicingPanel";
            SlicingPanel.Size = new System.Drawing.Size(234, 575);
            SlicingPanel.TabIndex = 4;
            // 
            // SlicingGb
            // 
            SlicingGb.Controls.Add(sprImageBox);
            SlicingGb.Controls.Add(SpriteSaveBtn);
            SlicingGb.Controls.Add(spriteWidthCb);
            SlicingGb.Controls.Add(spriteSelectNud);
            SlicingGb.Controls.Add(SliceBtn);
            SlicingGb.Controls.Add(label2);
            SlicingGb.Controls.Add(numOfRawsNud);
            SlicingGb.Controls.Add(label1);
            SlicingGb.Controls.Add(SpritesPerRawNud);
            SlicingGb.Location = new System.Drawing.Point(3, 3);
            SlicingGb.Name = "SlicingGb";
            SlicingGb.Size = new System.Drawing.Size(231, 569);
            SlicingGb.TabIndex = 0;
            SlicingGb.TabStop = false;
            SlicingGb.Text = "Slicing";
            // 
            // sprImageBox
            // 
            sprImageBox.AutoScaleImageBox = false;
            sprImageBox.Image = null;
            sprImageBox.Location = new System.Drawing.Point(6, 176);
            sprImageBox.Name = "sprImageBox";
            sprImageBox.ScaleFactor = 1;
            sprImageBox.ScaleFactorFloat = 1F;
            sprImageBox.Size = new System.Drawing.Size(213, 234);
            sprImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            sprImageBox.TabIndex = 7;
            sprImageBox.TabStop = false;
            // 
            // SpriteSaveBtn
            // 
            SpriteSaveBtn.Enabled = false;
            SpriteSaveBtn.Location = new System.Drawing.Point(6, 453);
            SpriteSaveBtn.Name = "SpriteSaveBtn";
            SpriteSaveBtn.Size = new System.Drawing.Size(213, 34);
            SpriteSaveBtn.TabIndex = 6;
            SpriteSaveBtn.Text = "Save";
            SpriteSaveBtn.UseVisualStyleBackColor = true;
            SpriteSaveBtn.Click += SpriteSaveBtn_Click;
            // 
            // spriteWidthCb
            // 
            spriteWidthCb.FormattingEnabled = true;
            spriteWidthCb.Items.AddRange(new object[] { "OCS/ECS 16 Pixels", "AGA 32 Pixels", "AGA 64 Pixels" });
            spriteWidthCb.Location = new System.Drawing.Point(6, 97);
            spriteWidthCb.Name = "spriteWidthCb";
            spriteWidthCb.Size = new System.Drawing.Size(213, 33);
            spriteWidthCb.TabIndex = 5;
            spriteWidthCb.Text = "Select sprite width";
            spriteWidthCb.SelectedIndexChanged += spriteWidthCb_SelectedIndexChanged;
            // 
            // spriteSelectNud
            // 
            spriteSelectNud.Location = new System.Drawing.Point(6, 416);
            spriteSelectNud.Name = "spriteSelectNud";
            spriteSelectNud.Size = new System.Drawing.Size(213, 31);
            spriteSelectNud.TabIndex = 4;
            spriteSelectNud.ValueChanged += spriteSelectNud_ValueChanged;
            // 
            // SliceBtn
            // 
            SliceBtn.Location = new System.Drawing.Point(6, 136);
            SliceBtn.Name = "SliceBtn";
            SliceBtn.Size = new System.Drawing.Size(213, 34);
            SliceBtn.TabIndex = 1;
            SliceBtn.Text = "Slice it!";
            SliceBtn.UseVisualStyleBackColor = true;
            SliceBtn.Click += SliceBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(133, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 25);
            label2.TabIndex = 3;
            label2.Text = "Raws";
            // 
            // numOfRawsNud
            // 
            numOfRawsNud.Location = new System.Drawing.Point(113, 60);
            numOfRawsNud.Name = "numOfRawsNud";
            numOfRawsNud.Size = new System.Drawing.Size(106, 31);
            numOfRawsNud.TabIndex = 2;
            numOfRawsNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(106, 25);
            label1.TabIndex = 1;
            label1.Text = "Sprites/Raw";
            // 
            // SpritesPerRawNud
            // 
            SpritesPerRawNud.Location = new System.Drawing.Point(6, 60);
            SpritesPerRawNud.Name = "SpritesPerRawNud";
            SpritesPerRawNud.Size = new System.Drawing.Size(106, 31);
            SpritesPerRawNud.TabIndex = 0;
            SpritesPerRawNud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hScrollBar
            // 
            hScrollBar.Location = new System.Drawing.Point(0, 572);
            hScrollBar.Name = "hScrollBar";
            hScrollBar.Size = new System.Drawing.Size(862, 30);
            hScrollBar.TabIndex = 5;
            hScrollBar.Visible = false;
            hScrollBar.ValueChanged += hScrollBar_ValueChanged;
            // 
            // vScrollBar
            // 
            vScrollBar.Location = new System.Drawing.Point(832, 37);
            vScrollBar.Name = "vScrollBar";
            vScrollBar.Size = new System.Drawing.Size(30, 531);
            vScrollBar.TabIndex = 6;
            vScrollBar.Visible = false;
            vScrollBar.ValueChanged += vScrollBar_ValueChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(1100, 643);
            Controls.Add(vScrollBar);
            Controls.Add(hScrollBar);
            Controls.Add(SlicingPanel);
            Controls.Add(image);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Amiga Image Converter";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            SlicingPanel.ResumeLayout(false);
            SlicingGb.ResumeLayout(false);
            SlicingGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sprImageBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)spriteSelectNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOfRawsNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpritesPerRawNud).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripScalingFactorLabel;
        public System.Windows.Forms.StatusStrip statusStrip;
    }
}

