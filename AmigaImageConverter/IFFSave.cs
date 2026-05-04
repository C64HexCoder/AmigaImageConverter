using System.Windows.Forms;

namespace AmigaImageConverter
{
    public partial class IFFSave : Form
    {
        public IFFSave()
        {
            InitializeComponent();
        }

        public bool CompressbODY
        {
            get { return compressBODYcheckBox.Checked; }
        }
    }
}
