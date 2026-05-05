using System.Windows.Forms;
using System.Drawing;

namespace AmigaImageConverter
{
    public partial class PaletteDlg : Form
    {
        public PaletteDlg()
        {
            InitializeComponent();
        }


        public Color SelectedColor
        {
            get
            {
                return imagePallate.SelectedColor;
            }
        }
    }
}
