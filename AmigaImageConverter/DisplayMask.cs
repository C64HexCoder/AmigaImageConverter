using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigaImageConverter
{
    public partial class DisplayMask : Form
    { PublicVariables vr = PublicVariables.instance;

        public DisplayMask()
        {
            InitializeComponent();
            imageGrid.SetResolution(vr.bitplane.Width, vr.bitplane.Height, 5,5);
            Width= imageGrid.Width;
            Height= imageGrid.Height;
        }

        private void DisplayMask_Activated(object sender, EventArgs e)
        {
            imageGrid.DrawImage(vr.bitplane.Mask);

        }

        private void imageGrid_Load(object sender, EventArgs e)
        {
   
        }

        private void imageGrid_Paint(object sender, PaintEventArgs e)
        {
   /*         for (int y = 0; y < vr.bitplane.Height; y++)
            {
                for (int x = 0; x < vr.bitplane.Width; x++)
                {
                    byte imageBit = vr.bitplane.GetMaskBit(x, y);
                    if (imageBit != 0)
                        imageGrid.SetPixel(x, y, Color.Blue);
                }
            } */
        }
    }
}
