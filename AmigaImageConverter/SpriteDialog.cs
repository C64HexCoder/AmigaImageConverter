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
    public partial class SpriteDialog : Form
    {
        PublicVariables PublicVariables = PublicVariables.instance;
        public SpriteDialog()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            switch (spriteSizeComboBox.SelectedIndex)
            {
                case 0:
                    PublicVariables.bitplane.Resize(16); break;
                case 1:
                    PublicVariables.bitplane.Resize(32); break;
                case 2:
                    PublicVariables.bitplane.Resize(64); break;

            }
        }
    }
}
