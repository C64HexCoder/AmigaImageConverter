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
