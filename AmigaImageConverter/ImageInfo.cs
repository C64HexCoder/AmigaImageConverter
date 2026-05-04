using System;
using System.Windows.Forms;

namespace AmigaImageConverter
{
    public partial class InfoForm : Form
    {
        PublicVariables vr = PublicVariables.instance;
        public InfoForm()
        {
            InitializeComponent();
            if (vr.bitplane.bitmap != null)
            {
                WidthLbl.Text = "Width: " + vr.bitplane.Width.ToString();
                HeightLbl.Text = "Height: " + vr.bitplane.Height.ToString();
                BitplanesLbl.Text = "Bitplanes: " + vr.bitplane.NumOfBitmaps.ToString();
                PaletteSizeLbl.Text = "Palette Size: " + vr.bitplane.PaletteSize.ToString();
                //ColorUsedLbl.Text = "Color Used: "+vr.bitplane.palette.Length.ToString();
            }
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
