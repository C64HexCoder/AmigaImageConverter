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
        public Bitplane.DataType _Aligment;
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
                scaleToMaxRadioBox.Checked = result;
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

            previewScalingNud.Enabled = predefinedScalingRadioBox.Checked;
        }

        public enum ScaleType
        {
            ScaleToMax,
            AutoScale,
            Predefined
        }

        public bool ScaleToMax
        {
            get
            {
                return scaleToMaxRadioBox.Checked;
            }
        }

        public ScaleType ScalingType
        {
            get 
            { 
                if (scaleToMaxRadioBox.Checked)
                    return ScaleType.ScaleToMax;
                else if (autoScalingRadioBox.Checked)
                    return ScaleType.AutoScale;
                else
                    return ScaleType.Predefined;
            }

            set
            {
                if (value == ScaleType.ScaleToMax)
                {
                    scaleToMaxRadioBox.Checked = true;
                }
                else if (value == ScaleType.AutoScale)
                {
                    autoScalingRadioBox.Checked = true;
                }
                else
                {
                    predefinedScalingRadioBox.Checked= true;
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

        public Bitplane.DataType outPutSize
        {
            get
            {
                if (byteRbox.Checked)
                    return Bitplane.DataType.Byte;
                else if (wordRbox.Checked)
                    return Bitplane.DataType.Word;
                else
                    return Bitplane.DataType.Long;
            }
            set
            {
                switch (value)
                {
                    case Bitplane.DataType.Byte:
                        byteRbox.Checked = true;
                        break;
                    case Bitplane.DataType.Word:
                        wordRbox.Checked = true;
                        break;
                    case Bitplane.DataType.Long:
                        longRbox.Checked = true;
                        break;

                }
            }
        }

        public Bitplane.DataType Alignment
        {
            get { return vr.Alignment; }
            set
            {
                switch (value)
                {
                    case Bitplane.DataType.Byte:
                        alignByteRb.Checked = true;
                        break;
                    case Bitplane.DataType.Word:
                        alignWordRb.Checked = true;
                        break;
                    case Bitplane.DataType.Long:
                        alignLongRb.Checked = true;
                        break;
                }
            }
        }

        private void byteRbox_CheckedChanged(object sender, EventArgs e)
        {
            vr.outputSize = Bitplane.DataType.Byte;
        }

        private void wordRbox_CheckedChanged(object sender, EventArgs e)
        {
            vr.outputSize = Bitplane.DataType.Word;
        }

        private void longRbox_CheckedChanged(object sender, EventArgs e)
        {
            vr.outputSize = Bitplane.DataType.Long;
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
                    vr.BaseColorRegister = 4;
                else
                    vr.BaseColorRegister = 8;
            }
            else
            {
                if ((comboBox.SelectedIndex == 0))
                    vr.BaseColorRegister = 0x180;
                else
                    vr.BaseColorRegister = 0x1A0;
            }
        }

        private void alignByteRb_CheckedChanged(object sender, EventArgs e)
        {
            vr.Alignment = Bitplane.DataType.Byte;
        }

        private void alignWordRb_CheckedChanged(object sender, EventArgs e)
        {
            vr.Alignment = Bitplane.DataType.Word;
        }

        private void alignLongRb_CheckedChanged(object sender, EventArgs e)
        {
            vr.Alignment = Bitplane.DataType.Long;
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

        private void predefinedScalingRadioBox_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            previewScalingNud.Enabled = radioButton.Checked;
            
        }
    }
}
