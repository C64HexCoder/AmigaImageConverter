using Amiga;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigaImageConverter
{
    public partial class PaletteQulalizerBtn : UserControl
    {
        Amiga.PictureBox imageBox;
        Sprite sprite = new Sprite();
        PublicVariables pv = PublicVariables.instance;
        byte BackgroundColorIdx = 0;

        public PaletteQulalizerBtn(ref Amiga.PictureBox imageBox)
        {
            InitializeComponent();
            this.imageBox = imageBox;
        }

        private void paletteLoadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "IFF Amiga File|*.iff|Pal|*.pal";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                sprite.LoadIFF(ofd.FileName);
                paletteGrid.SetPalette(sprite.palette);
                fileNameTxt.Text = Path.GetFileName(ofd.FileName);
            }
        }

        private void convertPaletteBtn_Click(object sender, EventArgs e)
        {
            pv.bitplane.EqualizePalette(sprite.palette);
            imageBox.Image = pv.bitplane.CreateBitmap();
     
            MessageBox.Show("Palette Converted Succsesfully", "Palette Conversion Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgroundColorBox_Click(object sender, EventArgs e)
        {
            ColorBox colorBox = (ColorBox)sender;

            SelectBackgroundColor  selectBackgroundColor = new SelectBackgroundColor();
            if (selectBackgroundColor.ShowDialog() == DialogResult.OK)
            {
                colorBox.color = selectBackgroundColor.BackgroundColor;
                BackgroundColorIdx = selectBackgroundColor.BackgroundColorIdx;
            }
        }
    }
}
