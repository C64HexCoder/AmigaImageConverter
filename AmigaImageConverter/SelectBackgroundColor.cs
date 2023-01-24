using System;
using System.CodeDom.Compiler;
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
    public partial class SelectBackgroundColor : Form
    {
        PublicVariables vr = PublicVariables.instance;
        public SelectBackgroundColor()
        {
            InitializeComponent();
            pallete.Colors = vr.bitplane.Pallate;
        }

        private void pallete_ColorSelected(object sender, Amiga.Pallate.SelectedColorEventArgs e)
        {
           // selectedColorPB.BackColor = e.Color;
        }

        private void swapBt_Click(object sender, EventArgs e)
        {
            // for (int i = 0; i<vr.bitplane.Pallate.Length;i++)
            //{
            //  if (vr.bitplane.Pallate[i] == pallete.SelectedColor)

            //            }
            Color oldColorZero = vr.bitplane.Pallate[0];
            vr.bitplane.Pallate[0] = pallete.SelectedColor;
            vr.bitplane.Pallate[pallete.SelectedColorIdx] = oldColorZero;
            vr.bitplane.ConvertImageToBitmaps();

        }
    }
}
