using Amiga;
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
    public partial class Resize : Form
    {
        PublicVariables vr = PublicVariables.instance;

        public Resize()
        {
            InitializeComponent();

            widthNumericUpDown.Value = vr.bitplane.Width;
            heightNumericUpDown.Value = vr.bitplane.Height;
        }

        private void ResizeBtn_Click(object sender, EventArgs e)
        {
            int NewWidth = (int)widthNumericUpDown.Value;
            int NewHeight = (int)heightNumericUpDown.Value;

            if (NewWidth != vr.bitplane.Width || NewHeight != vr.bitplane.Height)
            {
                Bitmap resizedBitmap = new Bitmap(NewWidth, NewHeight);
                Graphics g = Graphics.FromImage(resizedBitmap);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage (vr.bitplane.bitmap, 0, 0,NewWidth,NewHeight);
                g.Dispose();
                vr.bitplane.bitmap= resizedBitmap;
                
                Close();
            }
        }

        private void widthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (ratioCheckBox.Checked)
            {
                float HeghtWidthRatio = (float)vr.bitplane.Height / (float)vr.bitplane.Width;
                heightNumericUpDown.Value = Math.Round((decimal)(widthNumericUpDown.Value * (decimal)HeghtWidthRatio));
            }
        }

        private void heightNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (ratioCheckBox.Checked)
            {
                float WidthHightRatio = (float)vr.bitplane.Width / (float)vr.bitplane.Height;
                widthNumericUpDown.Value = Math.Round((decimal)(heightNumericUpDown.Value * (decimal)WidthHightRatio));
            }
        }
    }
}
