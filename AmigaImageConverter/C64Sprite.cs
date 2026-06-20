using C64.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmigaImageConverter
{
    public partial class C64Sprite : Form
    {
        C64.Graphics.Sprite sprite = new C64.Graphics.Sprite();

        public C64Sprite()
        {
            InitializeComponent();

            showGridButton.Checked = spriteGrid.ShowGrid;
            multiColorCheckBox.Checked = spriteGrid.IsMulticolor;
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
            savePRG.Filter = "C64 PRG|*.prg"; savePRG.Title = "Saving Sprite as PRG";
            if (savePRG.ShowDialog() == DialogResult.OK)
            {
                PRG.SavePRGFile(savePRG.FileName, 0x3000, spriteGrid.SpriteData);
            }
        }

        private void spriteNumber_ValueChanged(object sender, EventArgs e)
        {
            spriteAddressHb.Value = (int)bankNumber.Value * 0x4000 + (byte)spriteNumber.Value * 64;
        }

        private void bankNumber_ValueChanged(object sender, EventArgs e)
        {
            spriteAddressHb.Value = (int)bankNumber.Value * 0x4000 + (byte)spriteNumber.Value * 64;
        }
    }
}
