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
    public partial class InfoForm : Form
    {
        PublicVariables vr = PublicVariables.instance;
        public InfoForm()
        {
            InitializeComponent();
            if (vr.bitplane.bmp != null)
            {
                WidthLbl.Text = "Width: " + vr.bitplane.Width.ToString();
                HeightLbl.Text = "Height: " + vr.bitplane.Height.ToString();
                BitplanesLbl.Text = "Bitplanes: " + vr.bitplane.NumOfBitmaps.ToString();
                PaletteSizeLbl.Text = "Palette Size: " + vr.bitplane.PaletteSize.ToString();
                //ColorUsedLbl.Text = "Color Used"+vr.bitplane.
            }
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
