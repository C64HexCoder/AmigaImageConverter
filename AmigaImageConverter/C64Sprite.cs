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
    }
}
