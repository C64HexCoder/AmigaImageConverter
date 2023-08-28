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
    public partial class Settings : Form
    {
        PublicVariables vr = PublicVariables.instance;
        public Bitplane.OutputSize _Aligment;
        public bool valueChanged = false;
        public Settings()
        {
            InitializeComponent();

            outPutSize = vr.outputSize;
            numInARowNud.Value = vr.NumInARow;
            bitsPpCombo.SelectedIndex = 0;
            colorRegistersCombo.SelectedIndex = 0;

            Alignment = vr.Alignment;

        }

        public enum ScaleType
        {
            ScaleToMax,
            Predefined
        }

        public ScaleType ScalingType
        {
            get { return scaleToMaxCheckBox.Checked == true ? ScaleType.ScaleToMax : ScaleType.Predefined; }

            set
            {
                if (value == ScaleType.ScaleToMax)
                {
                    scaleToMaxCheckBox.Checked = true;
                    previewScalingNud.Enabled = false;
                }
                else
                {
                    scaleToMaxCheckBox.Checked = false;
                    previewScalingNud.Enabled = true;
                }
            }
        }

        public decimal PrevScaleFactor
        {
            get
            {
                return previewScalingNud.Value;
            }
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

        public Bitplane.OutputSize Alignment
        {
            get { return vr.Alignment; }
            set
            {
                switch (value)
                {
                    case Bitplane.OutputSize.Byte:
                        alignByteRb.Checked = true;
                        break;
                    case Bitplane.OutputSize.Word:
                        alignWordRb.Checked = true;
                        break;
                    case Bitplane.OutputSize.Long:
                        alignLongRb.Checked = true;
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

        private void alignByteRb_CheckedChanged(object sender, EventArgs e)
        {
            vr.Alignment = Bitplane.OutputSize.Byte;
        }

        private void alignWordRb_CheckedChanged(object sender, EventArgs e)
        {
            vr.Alignment = Bitplane.OutputSize.Word;
        }

        private void alignLongRb_CheckedChanged(object sender, EventArgs e)
        {
            vr.Alignment = Bitplane.OutputSize.Long;
        }

        private void previewScalingNud_ValueChanged(object sender, EventArgs e)
        {
            valueChanged = true;
        }

        private void autoCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            previewScalingNud.Enabled = !((CheckBox)sender).Checked;
        }
    }
}
