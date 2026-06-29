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
            AddressValidationResult avr = ValidateSpriteAddress((int)bankNumber.Value, (byte)spriteNumber.Value);
            if (avr.IsValid)
                SpriteAddress = (UInt16)(spriteAddressHb.Value = (int)bankNumber.Value * 0x4000 + (byte)spriteNumber.Value * 64);
            else
            {
                messageStatusBar.Text = avr.WarningMessage;
                messageStatusBar.Visible = true;
                messageTimer.Start();
                if (avr.JumpTo != 0)
                    spriteNumber.Value = avr.JumpTo;
            }
        }

        private void bankNumber_ValueChanged(object sender, EventArgs e)
        {
            AddressValidationResult avr = ValidateSpriteAddress((int)bankNumber.Value, (byte)spriteNumber.Value);
            if (avr.IsValid)
                SpriteAddress = (UInt16)(spriteAddressHb.Value = (int)bankNumber.Value * 0x4000 + (byte)spriteNumber.Value * 64);
            else
            {
                messageStatusBar.Text = avr.WarningMessage;
                messageTimer.Start();
            }
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
            messageStatusBar.Visible = false;
            messageTimer.Stop();
        }

        private void btnDeleteSprite_Click(object sender, EventArgs e)
        {
            sprites.RemoveAt((int)spriteNumber.Value);
            //spriteNumber.Value--;
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

            if (numericUpDown.Value >= sprites.Count)
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

        public struct AddressValidationResult
        {
            public bool IsValid { get; set; }
            public string WarningMessage { get; set; }
            public byte JumpTo { get; set; }
        }

        /// <summary>
        /// Validates the absolute memory address of a sprite based on the VIC bank and its pointer value.
        /// Checks for critical C64 hardware memory collisions and OS system area overwrites.
        /// </summary>
        public static AddressValidationResult ValidateSpriteAddress(int bank, byte pointerValue)
        {
            // 1. Calculate absolute memory address
            // Each VIC-II Bank is 16KB ($4000) and each sprite data block is 64 bytes.
            int bankBaseAddress = bank * 16384;
            int spriteOffset = pointerValue * 64;
            int absoluteAddress = bankBaseAddress + spriteOffset;

            // 2. Hardware and OS Collision Checks

            // Collision A: Zero Page & CPU Stack ($0000 - $03FF)
            if (absoluteAddress < 1024)
            {
                return new AddressValidationResult
                {
                    IsValid = false,
                    WarningMessage = "CRITICAL: Memory collision! Sprite address overwrites CPU Zero Page or Stack area.",
                    JumpTo = 16
                };
            }

            // Collision B: Default Screen RAM ($0400 - $07E7)
            // Valid for hardware reading, but dangerous since character data will overwrite the sprite pixels
            if (absoluteAddress >= 1024 && absoluteAddress < 2048)
            {
                return new AddressValidationResult
                {
                    IsValid = true,
                    WarningMessage = "WARNING: Sprite shares memory with the default Screen RAM. Typing text will corrupt sprite graphics."
                };
            }

            // Collision C: Hardware I/O Registers & Color RAM ($D000 - $DFFF -> 53248 to 57343)
            // Crucial: The VIC-II chip CANNOT fetch graphic data from $D000-$DFFF in Bank 0 and Bank 2!
            if (absoluteAddress >= 53248 && absoluteAddress <= 57343)
            {
                return new AddressValidationResult
                {
                    IsValid = false,
                    WarningMessage = "HARDWARE ERROR: The VIC-II chip cannot read sprite graphics from the I/O and Color RAM area ($D000-$DFFF)."
                };
            }

            // Collision D: Kernel ROM Area ($E000 - $FFFF -> 57344 and above)
            if (absoluteAddress >= 57344)
            {
                return new AddressValidationResult
                {
                    IsValid = false,
                    WarningMessage = "CRITICAL: Address conflict! Sprite memory points to the system Kernel ROM area."
                };
            }

            // Address is clean and safely points to open, generic RAM
            return new AddressValidationResult
            {
                IsValid = true,
                WarningMessage = $"Address ${absoluteAddress:X4} is valid and safe to use."
            };
        }

        private void lblStatusMessage_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }

}

