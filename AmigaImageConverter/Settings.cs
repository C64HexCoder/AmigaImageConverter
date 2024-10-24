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
using Microsoft.Win32;

namespace AmigaImageConverter
{
    public partial class Settings : Form
    {
        PublicVariables vr = PublicVariables.instance;
        public Bitplane.OutputSize _Aligment;
        public bool valueChanged = false;
        RegEdit regEdit = null;
        public Settings()
        {
            regEdit = RegEdit.Instance;

            InitializeComponent();

            outPutSize = vr.outputSize;
            numInARowNud.Value = vr.NumInARow;
            bitsPpCombo.SelectedIndex = 0;
            colorRegistersCombo.SelectedIndex = 0;

            Alignment = vr.Alignment;

            bool result = Convert.ToBoolean(regEdit.regKey.GetValue("AutoScaling"));
            if (result != null)
            {
                scaleToMaxCheckBox.Checked = result;
            }

            var ScalingFactor = regEdit.regKey.GetValue("ScaleFactor", RegistryValueKind.DWord);
            if (ScalingFactor != null)
            {
                previewScalingNud.Value = Convert.ToDecimal(ScalingFactor);
            }


            var Sequencial = regEdit.regKey.GetValue("Sequencial");
            if (Sequencial != null)
            {
                sequentialRB.Checked = Convert.ToBoolean(Sequencial);
            }

            var Interleaved = regEdit.regKey.GetValue("Interleaved");
            if (Interleaved != null)
            {
                interleavedRB.Checked = Convert.ToBoolean(Interleaved);
            }

            var align = regEdit.regKey.GetValue("AlignByte");
            if (Interleaved != null)
            {
                alignByteRb.Checked = Convert.ToBoolean(align);
            }

            align = regEdit.regKey.GetValue("AlignWord");
            if (Interleaved != null)
            {
                alignWordRb.Checked = Convert.ToBoolean(align);
            }

            align = regEdit.regKey.GetValue("AlignLong");
            if (Interleaved != null)
            {
                alignLongRb.Checked = Convert.ToBoolean(align);
            }
        }

        public enum ScaleType
        {
            ScaleToMax,
            Predefined
        }

        public bool ScaleToMax
        {
            get
            {
                return scaleToMaxCheckBox.Checked;
            }
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
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            regEdit.regKey.SetValue("ScaleFactor", numericUpDown.Value);
            valueChanged = true;
        }

        private void autoCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            previewScalingNud.Enabled = !((CheckBox)sender).Checked;
        }


        private void scaleToMaxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox scaleToMax = (CheckBox)sender;
            valueChanged = true;
            regEdit.regKey.SetValue("AutoScaling", scaleToMax.Checked);

        }

        private void sequentialRB_CheckedChanged(object sender, EventArgs e)
        {
            regEdit.regKey.SetValue("Sequencial", sequentialRB.Checked);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            regEdit.regKey.SetValue("Interleaved", interleavedRB.Checked);

        }

        private void alignByteRb_CheckedChanged_1(object sender, EventArgs e)
        {
            regEdit.regKey.SetValue("AlignByte", alignByteRb.Checked);

        }

        private void alignWordRb_CheckedChanged_1(object sender, EventArgs e)
        {
            regEdit.regKey.SetValue("AlignWord", alignWordRb.Checked);
        }

        private void alignLongRb_CheckedChanged_1(object sender, EventArgs e)
        {
            regEdit.regKey.SetValue("AlignLong", alignLongRb.Checked);

        }
    }
}
