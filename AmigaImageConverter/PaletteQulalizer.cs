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
        ImageBox imageBox;
        Sprite sprite = new Sprite();

        public PaletteQulalizerBtn(ref ImageBox imageBox)
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
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "IFF Amiga File Format|*.iff";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sprite.EqualizePalette(sprite.palette);
                sprite.SaveACBM(saveFileDialog.FileName);
           
            }
        }
    }
}
