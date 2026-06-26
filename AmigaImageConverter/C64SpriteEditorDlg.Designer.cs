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
            spriteGrid = new C64.Controls.SpriteCtrl();
            helpProvider1 = new System.Windows.Forms.HelpProvider();
            spritePalette1 = new C64.Controls.SpritePalette();
            multiColorCheckBox = new System.Windows.Forms.CheckBox();
            clearButton = new System.Windows.Forms.Button();
            showGridButton = new System.Windows.Forms.CheckBox();
            saveButton = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new System.Windows.Forms.GroupBox();
            lblStatusMessage = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            bankNumber = new System.Windows.Forms.NumericUpDown();
            spriteAddressHb = new C64.Controls.HexBox();
            label1 = new System.Windows.Forms.Label();
            spriteNumber = new System.Windows.Forms.NumericUpDown();
            penCB = new System.Windows.Forms.RadioButton();
            drawingModeGB = new System.Windows.Forms.GroupBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lineCB = new System.Windows.Forms.RadioButton();
            fillCB = new System.Windows.Forms.RadioButton();
            btnShiftRight = new System.Windows.Forms.Button();
            btnShiftLeft = new System.Windows.Forms.Button();
            btnShiftUp = new System.Windows.Forms.Button();
            btnShiftDown = new System.Windows.Forms.Button();
            numericSpriteNumber = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            saveSpriteAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            spritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            addSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clearSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteSpriteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            btnAddSprite = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnDuplicate = new System.Windows.Forms.Button();
            btnDeleteSprite = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            messageTimer = new System.Windows.Forms.Timer(components);
            rectangleCB = new System.Windows.Forms.RadioButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bankNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spriteNumber).BeginInit();
            drawingModeGB.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericSpriteNumber).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // spriteGrid
            // 
            spriteGrid.CellWidthHeight = 20;
            spriteGrid.ColorProvider = null;
            spriteGrid.CurrentDrawingState = C64.Controls.DrawingState.Pen;
            spriteGrid.GridColor = System.Drawing.Color.LawnGreen;
            spriteGrid.IsMulticolor = false;
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
            spritePalette1.Location = new System.Drawing.Point(12, 506);
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
            saveButton.Location = new System.Drawing.Point(1012, 538);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(112, 34);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save As ...";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblStatusMessage);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(bankNumber);
            groupBox1.Controls.Add(spriteAddressHb);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(spriteNumber);
            groupBox1.Location = new System.Drawing.Point(523, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(239, 235);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sprite Address";
            // 
            // lblStatusMessage
            // 
            lblStatusMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            lblStatusMessage.ForeColor = System.Drawing.Color.Red;
            lblStatusMessage.Location = new System.Drawing.Point(3, 207);
            lblStatusMessage.Name = "lblStatusMessage";
            lblStatusMessage.Size = new System.Drawing.Size(233, 25);
            lblStatusMessage.TabIndex = 6;
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
            penCB.Size = new System.Drawing.Size(104, 39);
            penCB.TabIndex = 7;
            penCB.Text = "Pen";
            penCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            penCB.UseVisualStyleBackColor = true;
            penCB.CheckedChanged += penCB_CheckedChanged;
            // 
            // drawingModeGB
            // 
            drawingModeGB.Controls.Add(tableLayoutPanel1);
            drawingModeGB.Location = new System.Drawing.Point(523, 361);
            drawingModeGB.Name = "drawingModeGB";
            drawingModeGB.Size = new System.Drawing.Size(233, 126);
            drawingModeGB.TabIndex = 8;
            drawingModeGB.TabStop = false;
            drawingModeGB.Text = "Drawing Mode";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(rectangleCB, 1, 1);
            tableLayoutPanel1.Controls.Add(lineCB, 1, 0);
            tableLayoutPanel1.Controls.Add(fillCB, 0, 1);
            tableLayoutPanel1.Controls.Add(penCB, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(6, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(221, 90);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lineCB
            // 
            lineCB.Appearance = System.Windows.Forms.Appearance.Button;
            lineCB.AutoSize = true;
            lineCB.Dock = System.Windows.Forms.DockStyle.Fill;
            lineCB.Location = new System.Drawing.Point(113, 3);
            lineCB.Name = "lineCB";
            lineCB.Size = new System.Drawing.Size(105, 39);
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
            fillCB.Location = new System.Drawing.Point(3, 48);
            fillCB.Name = "fillCB";
            fillCB.Size = new System.Drawing.Size(104, 39);
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, spritesToolStripMenuItem, toolsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1136, 33);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem1, saveSpriteAsToolStripMenuItem, toolStripSeparator1, importToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(227, 34);
            toolStripMenuItem1.Text = "Load Sprite";
            // 
            // saveSpriteAsToolStripMenuItem
            // 
            saveSpriteAsToolStripMenuItem.Name = "saveSpriteAsToolStripMenuItem";
            saveSpriteAsToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            saveSpriteAsToolStripMenuItem.Text = "Save Sprite As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            importToolStripMenuItem.Text = "Import";
            // 
            // spritesToolStripMenuItem
            // 
            spritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { addSpriteToolStripMenuItem, deleteSpriteToolStripMenuItem });
            spritesToolStripMenuItem.Name = "spritesToolStripMenuItem";
            spritesToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            spritesToolStripMenuItem.Text = "Sprites";
            // 
            // addSpriteToolStripMenuItem
            // 
            addSpriteToolStripMenuItem.Name = "addSpriteToolStripMenuItem";
            addSpriteToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            addSpriteToolStripMenuItem.Text = "Add Sprite";
            // 
            // deleteSpriteToolStripMenuItem
            // 
            deleteSpriteToolStripMenuItem.Name = "deleteSpriteToolStripMenuItem";
            deleteSpriteToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            deleteSpriteToolStripMenuItem.Text = "Delete Sprite";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { clearSpriteToolStripMenuItem, deleteSpriteToolStripMenuItem1 });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // clearSpriteToolStripMenuItem
            // 
            clearSpriteToolStripMenuItem.Name = "clearSpriteToolStripMenuItem";
            clearSpriteToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            clearSpriteToolStripMenuItem.Text = "Clear Sprite";
            // 
            // deleteSpriteToolStripMenuItem1
            // 
            deleteSpriteToolStripMenuItem1.Name = "deleteSpriteToolStripMenuItem1";
            deleteSpriteToolStripMenuItem1.Size = new System.Drawing.Size(215, 34);
            deleteSpriteToolStripMenuItem1.Text = "Delete Sprite";
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
            groupBox3.Location = new System.Drawing.Point(774, 201);
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
            // rectangleCB
            // 
            rectangleCB.Appearance = System.Windows.Forms.Appearance.Button;
            rectangleCB.AutoSize = true;
            rectangleCB.Dock = System.Windows.Forms.DockStyle.Fill;
            rectangleCB.Location = new System.Drawing.Point(113, 48);
            rectangleCB.Name = "rectangleCB";
            rectangleCB.Size = new System.Drawing.Size(105, 39);
            rectangleCB.TabIndex = 10;
            rectangleCB.Text = "Rectangle";
            rectangleCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            rectangleCB.UseVisualStyleBackColor = true;
            rectangleCB.CheckedChanged += rectangleCB_CheckedChanged;
            // 
            // C64SpriteEditorDlg
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1136, 584);
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
            Controls.Add(menuStrip1);
            Name = "C64SpriteEditorDlg";
            Text = "C64Sprite";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bankNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)spriteNumber).EndInit();
            drawingModeGB.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericSpriteNumber).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSpriteAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem spritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSpriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSpriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearSpriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSpriteToolStripMenuItem1;
        private System.Windows.Forms.Button btnAddSprite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteSprite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatusMessage;
        private System.Windows.Forms.Button btnDuplicate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer messageTimer;
        private System.Windows.Forms.RadioButton lineCB;
        private System.Windows.Forms.RadioButton rectangleCB;
    }
}
