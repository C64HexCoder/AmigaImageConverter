using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmigaBitplane;

namespace AmigaImageConverter
{
    public partial class Settings : Form
    {
        PublicVariables vr = PublicVariables.instance;
        public Settings()
        {
            InitializeComponent();
            outPutSize = vr.outputSize;
            numInARowNud.Value = vr.NumInARow;
            bitsPpCombo.SelectedIndex = 0;
            colorRegistersCombo.SelectedIndex = 0;
        }

        public Bitplane.OutputSize outPutSize
        {
            get
            {
                if (byteRbox.Checked)
                    return Bitplane.OutputSize.Byte;
                else if (wordRbox.Checked)
                    return Bitplane.OutputSize.Word;
                else
                    return Bitplane.OutputSize.Long;
            }
            set
            {
                switch (value)
                {
                    case Bitplane.OutputSize.Byte:
                        byteRbox.Checked = true;
                        break;
                    case Bitplane.OutputSize.Word:
                        wordRbox.Checked = true;
                        break;
                    case Bitplane.OutputSize.Long:
                        longRbox.Checked = true;
                        break;

                }
            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void byteRbox_CheckedChanged(object sender, EventArgs e)
        {
           vr.outputSize = Bitplane.OutputSize.Byte;
        }

        private void wordRbox_CheckedChanged(object sender, EventArgs e)
        {
            vr.outputSize = Bitplane.OutputSize.Word;
        }

        private void longRbox_CheckedChanged(object sender, EventArgs e)
        {
            vr.outputSize = Bitplane.OutputSize.Long;
        }

        private void numInARowNud_ValueChanged(object sender, EventArgs e)
        {
            vr.NumInARow = (int)((NumericUpDown)sender).Value;
        }

        private void bitsPpCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.Tag == "bpp")
            {
                if (comboBox.SelectedIndex == 0)
                    vr.BaseColor = 4;
                else
                    vr.BaseColor = 8;
            }
            else
            {
                if ((comboBox.SelectedIndex == 0))
                    vr.BaseColor = 0x180;
                else
                    vr.BaseColor = 0x1A0;
            }
        }
    }
}
