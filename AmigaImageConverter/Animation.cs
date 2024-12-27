using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amiga;

namespace AmigaImageConverter
{
    public partial class Animation : UserControl
    {
        List<Sprite> sprites = new List<Sprite>();
        PublicVariables pv = PublicVariables.instance;

        public Animation()
        {
            InitializeComponent();

            if (pv.bitplane.bitmap != null)
            {
                Sprite sprite = pv.bitplane.CreateSprite();
                colorsGrid.SetPalette(sprite.palette);               
            }
        }
    }
}
