namespace AmigaImageConverter
{
    partial class C64SpriteEditorDlg
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
            components = new System.ComponentModel.Container();
            C64.Graphics.Sprite sprite1 = new C64.Graphics.Sprite();
            spriteGrid = new C64.Controls.SpriteCtrl();
            helpProvider1 = new System.Windows.Forms.HelpProvider();
            spritePalette1 = new C64.Controls.SpritePalette();
            multiColorCheckBox = new System.Windows.Forms.CheckBox();
            clearButton = new System.Windows.Forms.Button();
            showGridButton = new System.Windows.Forms.CheckBox();
            saveButton = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            bankNumber = new System.Windows.Forms.NumericUpDown();
            spriteAddressHb = new C64.Controls.HexBox();
            label1 = new System.Windows.Forms.Label();
            spriteNumber = new System.Windows.Forms.NumericUpDown();
            penCB = new System.Windows.Forms.RadioButton();
            drawingModeGB = new System.Windows.Forms.GroupBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            poygonCheckBox = new System.Windows.Forms.RadioButton();
            circleRadioBox = new System.Windows.Forms.RadioButton();
            rectangleCB = new System.Windows.Forms.RadioButton();
            lineCB = new System.Windows.Forms.RadioButton();
            fillCB = new System.Windows.Forms.RadioButton();
            btnShiftRight = new System.Windows.Forms.Button();
            btnShiftLeft = new System.Windows.Forms.Button();
            btnShiftUp = new System.Windows.Forms.Button();
            btnShiftDown = new System.Windows.Forms.Button();
            numericSpriteNumber = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            menuStrip = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            loadSpriteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveSpriteAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            spritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clearSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnAddSprite = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            insertSpriteBtn = new System.Windows.Forms.Button();
            btnDuplicate = new System.Windows.Forms.Button();
            btnDeleteSprite = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            messageTimer = new System.Windows.Forms.Timer(components);
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            messageStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            spritePreview1 = new C64.Controls.SpritePreview();
            spriteNameTextBox = new System.Windows.Forms.TextBox();
            spriteNameLabel = new System.Windows.Forms.Label();
            imageFileDialog = new System.Windows.Forms.OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bankNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spriteNumber).BeginInit();
            drawingModeGB.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSpriteNumber).BeginInit();
            menuStrip.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // spriteGrid
            // 
            sprite1.IsMulticolor = false;
            sprite1.RawData = new byte[]
    {
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0
    };
            spriteGrid.ActiveSprite = sprite1;
            spriteGrid.CellWidthHeight = 20;
            spriteGrid.ColorProvider = null;
            spriteGrid.CurrentDrawingState = C64.Controls.DrawingState.Pen;
            spriteGrid.GridColor = System.Drawing.Color.Red;
            spriteGrid.IsMulticolor = false;
            spriteGrid.IsMultiColor = false;
            spriteGrid.Location = new System.Drawing.Point(12, 51);
            spriteGrid.Name = "spriteGrid";
            spriteGrid.ShowGrid = true;
            spriteGrid.Size = new System.Drawing.Size(481, 421);
            spriteGrid.TabIndex = 0;
            // 
            // spritePalette1
            // 
            spritePalette1.AutoSize = true;
            spritePalette1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            spritePalette1.Location = new System.Drawing.Point(12, 491);
            spritePalette1.Name = "spritePalette1";
            spritePalette1.SelectedSlotIndex = 0;
            spritePalette1.Size = new System.Drawing.Size(476, 59);
            spritePalette1.TabIndex = 1;
            // 
            // multiColorCheckBox
            // 
            multiColorCheckBox.AutoSize = true;
            multiColorCheckBox.Location = new System.Drawing.Point(523, 51);
            multiColorCheckBox.Name = "multiColorCheckBox";
            multiColorCheckBox.Size = new System.Drawing.Size(126, 29);
            multiColorCheckBox.TabIndex = 2;
            multiColorCheckBox.Text = "Multi Color";
            multiColorCheckBox.UseVisualStyleBackColor = true;
            multiColorCheckBox.CheckedChanged += multiColorCheckBox_CheckedChanged;
            // 
            // clearButton
            // 
            clearButton.Location = new System.Drawing.Point(129, 31);
            clearButton.Name = "clearButton";
            clearButton.Size = new System.Drawing.Size(112, 34);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // showGridButton
            // 
            showGridButton.AutoSize = true;
            showGridButton.Location = new System.Drawing.Point(523, 86);
            showGridButton.Name = "showGridButton";
            showGridButton.Size = new System.Drawing.Size(120, 29);
            showGridButton.TabIndex = 4;
            showGridButton.Text = "Show Grid";
            showGridButton.UseVisualStyleBackColor = true;
            showGridButton.CheckedChanged += showGridButton_CheckedChanged;
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(1012, 591);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(112, 34);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save As ...";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(bankNumber);
            groupBox1.Controls.Add(spriteAddressHb);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(spriteNumber);
            groupBox1.Location = new System.Drawing.Point(523, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(239, 204);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sprite Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(9, 106);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 25);
            label4.TabIndex = 5;
            label4.Text = "Mem Ptr";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 69);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 25);
            label3.TabIndex = 4;
            label3.Text = "Bank";
            // 
            // bankNumber
            // 
            bankNumber.Location = new System.Drawing.Point(89, 67);
            bankNumber.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            bankNumber.Name = "bankNumber";
            bankNumber.Size = new System.Drawing.Size(144, 31);
            bankNumber.TabIndex = 3;
            bankNumber.ValueChanged += bankNumber_ValueChanged;
            // 
            // spriteAddressHb
            // 
            spriteAddressHb.AutoSize = true;
            spriteAddressHb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            spriteAddressHb.Location = new System.Drawing.Point(57, 141);
            spriteAddressHb.Name = "spriteAddressHb";
            spriteAddressHb.Size = new System.Drawing.Size(121, 57);
            spriteAddressHb.TabIndex = 2;
            spriteAddressHb.Value = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(196, 25);
            label1.TabIndex = 1;
            label1.Text = "C64 Address Calculator";
            // 
            // spriteNumber
            // 
            spriteNumber.Location = new System.Drawing.Point(89, 104);
            spriteNumber.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            spriteNumber.Name = "spriteNumber";
            spriteNumber.Size = new System.Drawing.Size(144, 31);
            spriteNumber.TabIndex = 0;
            spriteNumber.ValueChanged += spriteNumber_ValueChanged;
            // 
            // penCB
            // 
            penCB.Appearance = System.Windows.Forms.Appearance.Button;
            penCB.AutoSize = true;
            penCB.Dock = System.Windows.Forms.DockStyle.Fill;
            penCB.Location = new System.Drawing.Point(3, 3);
            penCB.Name = "penCB";
            penCB.Size = new System.Drawing.Size(104, 35);
            penCB.TabIndex = 7;
            penCB.Text = "Pen";
            penCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            penCB.UseVisualStyleBackColor = true;
            penCB.CheckedChanged += penCB_CheckedChanged;
            // 
            // drawingModeGB
            // 
            drawingModeGB.Controls.Add(tableLayoutPanel1);
            drawingModeGB.Location = new System.Drawing.Point(779, 207);
            drawingModeGB.Name = "drawingModeGB";
            drawingModeGB.Size = new System.Drawing.Size(233, 168);
            drawingModeGB.TabIndex = 8;
            drawingModeGB.TabStop = false;
            drawingModeGB.Text = "Drawing Mode";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(poygonCheckBox, 1, 2);
            tableLayoutPanel1.Controls.Add(circleRadioBox, 0, 2);
            tableLayoutPanel1.Controls.Add(rectangleCB, 1, 1);
            tableLayoutPanel1.Controls.Add(lineCB, 1, 0);
            tableLayoutPanel1.Controls.Add(fillCB, 0, 1);
            tableLayoutPanel1.Controls.Add(penCB, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(6, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(221, 123);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // poygonCheckBox
            // 
            poygonCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            poygonCheckBox.AutoSize = true;
            poygonCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            poygonCheckBox.Location = new System.Drawing.Point(113, 85);
            poygonCheckBox.Name = "poygonCheckBox";
            poygonCheckBox.Size = new System.Drawing.Size(105, 35);
            poygonCheckBox.TabIndex = 12;
            poygonCheckBox.Text = "Polygon";
            poygonCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            poygonCheckBox.UseVisualStyleBackColor = true;
            poygonCheckBox.CheckedChanged += poligonCheckBox_CheckedChanged;
            // 
            // circleRadioBox
            // 
            circleRadioBox.Appearance = System.Windows.Forms.Appearance.Button;
            circleRadioBox.AutoSize = true;
            circleRadioBox.Dock = System.Windows.Forms.DockStyle.Fill;
            circleRadioBox.Location = new System.Drawing.Point(3, 85);
            circleRadioBox.Name = "circleRadioBox";
            circleRadioBox.Size = new System.Drawing.Size(104, 35);
            circleRadioBox.TabIndex = 11;
            circleRadioBox.Text = "Circle";
            circleRadioBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            circleRadioBox.UseVisualStyleBackColor = true;
            circleRadioBox.CheckedChanged += circleRadioBox_CheckedChanged;
            // 
            // rectangleCB
            // 
            rectangleCB.Appearance = System.Windows.Forms.Appearance.Button;
            rectangleCB.AutoSize = true;
            rectangleCB.Dock = System.Windows.Forms.DockStyle.Fill;
            rectangleCB.Location = new System.Drawing.Point(113, 44);
            rectangleCB.Name = "rectangleCB";
            rectangleCB.Size = new System.Drawing.Size(105, 35);
            rectangleCB.TabIndex = 10;
            rectangleCB.Text = "Rectangle";
            rectangleCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            rectangleCB.UseVisualStyleBackColor = true;
            rectangleCB.CheckedChanged += rectangleCB_CheckedChanged;
            // 
            // lineCB
            // 
            lineCB.Appearance = System.Windows.Forms.Appearance.Button;
            lineCB.AutoSize = true;
            lineCB.Dock = System.Windows.Forms.DockStyle.Fill;
            lineCB.Location = new System.Drawing.Point(113, 3);
            lineCB.Name = "lineCB";
            lineCB.Size = new System.Drawing.Size(105, 35);
            lineCB.TabIndex = 9;
            lineCB.Text = "Line";
            lineCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lineCB.UseVisualStyleBackColor = true;
            lineCB.CheckedChanged += lineCB_CheckedChanged;
            // 
            // fillCB
            // 
            fillCB.Appearance = System.Windows.Forms.Appearance.Button;
            fillCB.AutoSize = true;
            fillCB.Dock = System.Windows.Forms.DockStyle.Fill;
            fillCB.Location = new System.Drawing.Point(3, 44);
            fillCB.Name = "fillCB";
            fillCB.Size = new System.Drawing.Size(104, 35);
            fillCB.TabIndex = 8;
            fillCB.Text = "Fill";
            fillCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            fillCB.UseVisualStyleBackColor = true;
            fillCB.CheckedChanged += fillCB_CheckedChanged;
            // 
            // btnShiftRight
            // 
            btnShiftRight.Location = new System.Drawing.Point(125, 75);
            btnShiftRight.Name = "btnShiftRight";
            btnShiftRight.Size = new System.Drawing.Size(112, 34);
            btnShiftRight.TabIndex = 9;
            btnShiftRight.Text = "Shift Right";
            btnShiftRight.UseVisualStyleBackColor = true;
            btnShiftRight.Click += btnShiftRight_Click;
            // 
            // btnShiftLeft
            // 
            btnShiftLeft.Location = new System.Drawing.Point(7, 75);
            btnShiftLeft.Name = "btnShiftLeft";
            btnShiftLeft.Size = new System.Drawing.Size(112, 34);
            btnShiftLeft.TabIndex = 10;
            btnShiftLeft.Text = "Shift Left";
            btnShiftLeft.UseVisualStyleBackColor = true;
            btnShiftLeft.Click += btnShiftLeft_Click;
            // 
            // btnShiftUp
            // 
            btnShiftUp.Location = new System.Drawing.Point(65, 35);
            btnShiftUp.Name = "btnShiftUp";
            btnShiftUp.Size = new System.Drawing.Size(112, 34);
            btnShiftUp.TabIndex = 11;
            btnShiftUp.Text = "Shift Up";
            btnShiftUp.UseVisualStyleBackColor = true;
            btnShiftUp.Click += btnShiftUp_Click;
            // 
            // btnShiftDown
            // 
            btnShiftDown.Location = new System.Drawing.Point(65, 115);
            btnShiftDown.Name = "btnShiftDown";
            btnShiftDown.Size = new System.Drawing.Size(112, 34);
            btnShiftDown.TabIndex = 12;
            btnShiftDown.Text = "Shift Down";
            btnShiftDown.UseVisualStyleBackColor = true;
            btnShiftDown.Click += btnShiftDown_Click;
            // 
            // numericSpriteNumber
            // 
            numericSpriteNumber.Location = new System.Drawing.Point(532, 530);
            numericSpriteNumber.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericSpriteNumber.Name = "numericSpriteNumber";
            numericSpriteNumber.Size = new System.Drawing.Size(230, 31);
            numericSpriteNumber.TabIndex = 13;
            numericSpriteNumber.ValueChanged += numericSpriteNumber_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(532, 502);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(128, 25);
            label2.TabIndex = 14;
            label2.Text = "Sprite Number";
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, spritesToolStripMenuItem });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new System.Drawing.Size(1136, 33);
            menuStrip.TabIndex = 16;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { loadSpriteMenuItem, saveSpriteAsToolStripMenuItem, toolStripSeparator1, importToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadSpriteMenuItem
            // 
            loadSpriteMenuItem.Name = "loadSpriteMenuItem";
            loadSpriteMenuItem.Size = new System.Drawing.Size(270, 34);
            loadSpriteMenuItem.Text = "Load Sprite";
            loadSpriteMenuItem.Click += loadSpriteMenuItem_Click;
            // 
            // saveSpriteAsToolStripMenuItem
            // 
            saveSpriteAsToolStripMenuItem.Name = "saveSpriteAsToolStripMenuItem";
            saveSpriteAsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            saveSpriteAsToolStripMenuItem.Text = "Save Sprite As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // spritesToolStripMenuItem
            // 
            spritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { addSpriteToolStripMenuItem, deleteSpriteToolStripMenuItem, clearSpriteToolStripMenuItem, duplicateToolStripMenuItem, insertToolStripMenuItem });
            spritesToolStripMenuItem.Name = "spritesToolStripMenuItem";
            spritesToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            spritesToolStripMenuItem.Text = "Sprites";
            // 
            // addSpriteToolStripMenuItem
            // 
            addSpriteToolStripMenuItem.Name = "addSpriteToolStripMenuItem";
            addSpriteToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            addSpriteToolStripMenuItem.Text = "Add Sprite";
            addSpriteToolStripMenuItem.Click += addSpriteToolStripMenuItem_Click;
            // 
            // deleteSpriteToolStripMenuItem
            // 
            deleteSpriteToolStripMenuItem.Name = "deleteSpriteToolStripMenuItem";
            deleteSpriteToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            deleteSpriteToolStripMenuItem.Text = "Delete Sprite";
            deleteSpriteToolStripMenuItem.Click += deleteSpriteToolStripMenuItem_Click;
            // 
            // clearSpriteToolStripMenuItem
            // 
            clearSpriteToolStripMenuItem.Name = "clearSpriteToolStripMenuItem";
            clearSpriteToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            clearSpriteToolStripMenuItem.Text = "Clear Sprite";
            clearSpriteToolStripMenuItem.Click += clearSpriteToolStripMenuItem_Click_1;
            // 
            // duplicateToolStripMenuItem
            // 
            duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            duplicateToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            duplicateToolStripMenuItem.Text = "Duplicate";
            duplicateToolStripMenuItem.Click += duplicateToolStripMenuItem_Click;
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            insertToolStripMenuItem.Text = "Insert";
            insertToolStripMenuItem.Click += insertToolStripMenuItem_Click;
            // 
            // btnAddSprite
            // 
            btnAddSprite.Location = new System.Drawing.Point(11, 30);
            btnAddSprite.Name = "btnAddSprite";
            btnAddSprite.Size = new System.Drawing.Size(112, 34);
            btnAddSprite.TabIndex = 17;
            btnAddSprite.Text = "Add Sprite";
            btnAddSprite.UseVisualStyleBackColor = true;
            btnAddSprite.Click += btnAddSprite_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(insertSpriteBtn);
            groupBox2.Controls.Add(btnDuplicate);
            groupBox2.Controls.Add(btnDeleteSprite);
            groupBox2.Controls.Add(btnAddSprite);
            groupBox2.Controls.Add(clearButton);
            groupBox2.Location = new System.Drawing.Point(768, 51);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(255, 150);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sprite Management";
            // 
            // insertSpriteBtn
            // 
            insertSpriteBtn.Location = new System.Drawing.Point(129, 71);
            insertSpriteBtn.Name = "insertSpriteBtn";
            insertSpriteBtn.Size = new System.Drawing.Size(112, 34);
            insertSpriteBtn.TabIndex = 20;
            insertSpriteBtn.Text = "Insert";
            insertSpriteBtn.UseVisualStyleBackColor = true;
            insertSpriteBtn.Click += insertSpriteBtn_Click;
            // 
            // btnDuplicate
            // 
            btnDuplicate.Location = new System.Drawing.Point(11, 110);
            btnDuplicate.Name = "btnDuplicate";
            btnDuplicate.Size = new System.Drawing.Size(112, 34);
            btnDuplicate.TabIndex = 19;
            btnDuplicate.Text = "Duplicate";
            btnDuplicate.UseVisualStyleBackColor = true;
            btnDuplicate.Click += btnDuplicate_Click;
            // 
            // btnDeleteSprite
            // 
            btnDeleteSprite.Location = new System.Drawing.Point(11, 70);
            btnDeleteSprite.Name = "btnDeleteSprite";
            btnDeleteSprite.Size = new System.Drawing.Size(112, 34);
            btnDeleteSprite.TabIndex = 18;
            btnDeleteSprite.Text = "Delete Sprite";
            btnDeleteSprite.UseVisualStyleBackColor = true;
            btnDeleteSprite.Click += btnDeleteSprite_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnShiftUp);
            groupBox3.Controls.Add(btnShiftRight);
            groupBox3.Controls.Add(btnShiftLeft);
            groupBox3.Controls.Add(btnShiftDown);
            groupBox3.Location = new System.Drawing.Point(532, 341);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(249, 162);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Shifting";
            // 
            // messageTimer
            // 
            messageTimer.Interval = 3000;
            messageTimer.Tick += timer_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { messageStatusBar });
            statusStrip1.Location = new System.Drawing.Point(0, 628);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(1136, 32);
            statusStrip1.TabIndex = 20;
            statusStrip1.Text = "statusStrip1";
            // 
            // messageStatusBar
            // 
            messageStatusBar.ForeColor = System.Drawing.Color.Red;
            messageStatusBar.Name = "messageStatusBar";
            messageStatusBar.Size = new System.Drawing.Size(155, 25);
            messageStatusBar.Text = "messageStatusBar";
            messageStatusBar.Click += toolStripStatusLabel1_Click;
            // 
            // spritePreview1
            // 
            spritePreview1.Location = new System.Drawing.Point(785, 366);
            spritePreview1.Name = "spritePreview1";
            spritePreview1.Size = new System.Drawing.Size(218, 218);
            spritePreview1.TabIndex = 21;
            // 
            // spriteNameTextBox
            // 
            spriteNameTextBox.Location = new System.Drawing.Point(532, 598);
            spriteNameTextBox.Name = "spriteNameTextBox";
            spriteNameTextBox.Size = new System.Drawing.Size(230, 31);
            spriteNameTextBox.TabIndex = 22;
            // 
            // spriteNameLabel
            // 
            spriteNameLabel.AutoSize = true;
            spriteNameLabel.Location = new System.Drawing.Point(532, 564);
            spriteNameLabel.Name = "spriteNameLabel";
            spriteNameLabel.Size = new System.Drawing.Size(110, 25);
            spriteNameLabel.TabIndex = 23;
            spriteNameLabel.Text = "Sprite Name";
            // 
            // C64SpriteEditorDlg
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1136, 660);
            Controls.Add(spriteNameLabel);
            Controls.Add(spriteNameTextBox);
            Controls.Add(spritePreview1);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(numericSpriteNumber);
            Controls.Add(drawingModeGB);
            Controls.Add(groupBox1);
            Controls.Add(saveButton);
            Controls.Add(showGridButton);
            Controls.Add(multiColorCheckBox);
            Controls.Add(spritePalette1);
            Controls.Add(spriteGrid);
            Controls.Add(menuStrip);
            Name = "C64SpriteEditorDlg";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "C64Sprite";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bankNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)spriteNumber).EndInit();
            drawingModeGB.ResumeLayout(false);
            drawingModeGB.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericSpriteNumber).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private C64.Controls.SpriteCtrl spriteGrid;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private C64.Controls.SpritePalette spritePalette1;
        private System.Windows.Forms.CheckBox multiColorCheckBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox showGridButton;
        private System.Windows.Forms.Button saveButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spriteNumber;
        private C64.Controls.HexBox spriteAddressHb;
        private System.Windows.Forms.NumericUpDown bankNumber;
        private System.Windows.Forms.RadioButton penCB;
        private System.Windows.Forms.GroupBox drawingModeGB;
        private System.Windows.Forms.RadioButton fillCB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnShiftRight;
        private System.Windows.Forms.Button btnShiftLeft;
        private System.Windows.Forms.Button btnShiftUp;
        private System.Windows.Forms.Button btnShiftDown;
        private System.Windows.Forms.NumericUpDown numericSpriteNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSpriteAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSpriteMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem spritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSpriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSpriteToolStripMenuItem;
        private System.Windows.Forms.Button btnAddSprite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteSprite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer messageTimer;
        private System.Windows.Forms.RadioButton lineCB;
        private System.Windows.Forms.RadioButton rectangleCB;
        private System.Windows.Forms.Button insertSpriteBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel messageStatusBar;
        private System.Windows.Forms.RadioButton poygonCheckBox;
        private System.Windows.Forms.RadioButton circleRadioBox;
        private C64.Controls.SpritePreview spritePreview1;
        private System.Windows.Forms.TextBox spriteNameTextBox;
        private System.Windows.Forms.Label spriteNameLabel;
        private System.Windows.Forms.ToolStripMenuItem clearSpriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog imageFileDialog;
    }
}
