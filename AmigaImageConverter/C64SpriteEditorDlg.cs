using C64.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C64.Controls;
using C64.Graphics;
using System.Runtime.InteropServices.Marshalling;
using System.Media;


namespace AmigaImageConverter
{
    public partial class C64SpriteEditorDlg : Form
    {

        List<Sprite> sprites = new List<Sprite>();

        public UInt16 spriteAddress = 0;

        public UInt16 SpriteAddress
        {
            get => spriteAddress;

            set
            {
                spriteAddress = value;
                spriteAddressHb.Value = spriteAddress;
                bankNumber.Value = spriteAddress / 0x4000;
                spriteNumber.Value = (spriteAddress % 0x4000) / 64;
            }
        }

        public C64SpriteEditorDlg()
        {
            InitializeComponent();

            showGridButton.Checked = spriteGrid.ShowGrid;
            multiColorCheckBox.Checked = spriteGrid.IsMulticolor;
            penCB.Checked = true;
            sprites.Add(new C64.Graphics.Sprite());
        }

        private int SelectedSprite
        {
            get
            {
                return (int)numericSpriteNumber.Value;
            }

        }
        private void multiColorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            spriteGrid.IsMulticolor = ((CheckBox)sender).Checked;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            spriteGrid.ClearSprite();
        }

        private void showGridButton_CheckedChanged(object sender, EventArgs e)
        {
            spriteGrid.ShowGrid = ((CheckBox)sender).Checked;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog savePRG = new SaveFileDialog();
            savePRG.Filter = "C64 PRG|*.prg|Binary BIN|*.bin"; savePRG.Title = "Saving Sprite as PRG";
            if (savePRG.ShowDialog() == DialogResult.OK)
            {
                switch (savePRG.FilterIndex)
                {
                    case 0:
                        Files.SaveSpritesAsPRG(savePRG.FileName, sprites, SpriteAddress);
                        break;
                    case 1:
                        int i = 0; // Place holder
                        break;

                }
            }
        }

        private void spriteNumber_ValueChanged(object sender, EventArgs e)
        {
            SpriteAddress = (UInt16)(spriteAddressHb.Value = (int)bankNumber.Value * 0x4000 + (byte)spriteNumber.Value * 64);
        }

        private void bankNumber_ValueChanged(object sender, EventArgs e)
        {
            SpriteAddress = (UInt16)(spriteAddressHb.Value = (int)bankNumber.Value * 0x4000 + (byte)spriteNumber.Value * 64);
        }

        private int CalculateSpriteAddress(byte bank, byte spriteNumber)
        {
            return bank * 0x400 + spriteNumber * 64;
        }

        private void penCB_CheckedChanged(object sender, EventArgs e)
        {
            spriteGrid.CurrentDrawingState = DrawingState.Pen;
        }

        private void fillCB_CheckedChanged(object sender, EventArgs e)
        {
            spriteGrid.CurrentDrawingState = DrawingState.Fill;
        }

        private void btnShiftLeft_Click(object sender, EventArgs e)
        {
            spriteGrid.Shift(ShiftDirection.Left);
        }

        private void btnShiftRight_Click(object sender, EventArgs e)
        {
            spriteGrid.Shift(ShiftDirection.Right);
        }

        private void btnShiftUp_Click(object sender, EventArgs e)
        {
            spriteGrid.Shift(ShiftDirection.Up);
        }

        private void btnShiftDown_Click(object sender, EventArgs e)
        {
            spriteGrid.Shift(ShiftDirection.Down);
        }

        private void btnAddSprite_Click(object sender, EventArgs e)
        {
            Sprite sprite = new Sprite();
            spriteGrid.SpriteData = sprite.RawData;
            sprites.Add(sprite);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblStatusMessage.Visible = false;
            messageTimer.Stop();
        }

        private void btnDeleteSprite_Click(object sender, EventArgs e)
        {
            sprites.RemoveAt((int)spriteNumber.Value);
            spriteNumber.Value--;
        }

        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            Sprite tmpSpr = sprites[(int)spriteNumber.Value];
            sprites.Add((Sprite)tmpSpr);
            spriteNumber.Value++;
        }

        private void lineCB_CheckedChanged(object sender, EventArgs e)
        {
            spriteGrid.CurrentDrawingState = DrawingState.Line;
        }

        private void rectangleCB_CheckedChanged(object sender, EventArgs e)
        {
            spriteGrid.CurrentDrawingState = DrawingState.Rectangle;
        }

        private void loadSpriteMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "C64 PRG Files | *.prg";
            UInt16 Address = 0;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sprites = Files.LoadSpritesFromPRG(openFileDialog.FileName, out Address);
                spriteGrid.SpriteData = sprites[SelectedSprite].RawData;
                SpriteAddress = Address;
            }
            spriteGrid.Invalidate();
        }

        private void numericSpriteNumber_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;

            if (numericUpDown.Value >=sprites.Count)
            {
                numericUpDown.Value = sprites.Count - 1;
                SystemSounds.Beep.Play();
                return;
            }
            spriteGrid.SpriteData = sprites[SelectedSprite].RawData;
            spriteGrid.Invalidate();

        }

        private void insertSpriteBtn_Click(object sender, EventArgs e)
        {
            Sprite newSprite = new Sprite();
            sprites.Insert(SelectedSprite + 1, newSprite);
        }
    }

}

