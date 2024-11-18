using Amiga;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AmigaImageConverter
{
    public partial class ImageSaveDialog : Form
    {
        public Bitplane.DataType dataType;
        PublicVariables vr = PublicVariables.instance;
        public ImageSaveDialog()
        {
            InitializeComponent();
            bitsPpCombo.SelectedIndex = 0;
            colorRegistersCombo.SelectedIndex = 0;

            DataType = Bitplane.DataType.Word;
            arrayNameTextBox.Text = vr.bitplane.ArrayName;
        }

        public enum ImageFormats
        {
            Sequential,
            Interleaved
        }

        public enum AligmentTypes
        {
            Byte,
            Word,
            Long
        }

        public enum ColorRegistersSet
        {
            Low16,
            High16
        }
        public ImageFormats ImageFormat
        {
            get
            {
                return sequentialRB.Checked ? ImageFormats.Sequential : ImageFormats.Interleaved;
            }

        }

        public Bitplane.DataType DataType
        {
            get
            {
                return dataType;
            }
            set
            {
                dataType = value;
            }
        }

        public AligmentTypes Aligment
        {
            get
            {
                switch (Aligment)
                {
                    case AligmentTypes.Byte:
                        return AligmentTypes.Byte;
                    case AligmentTypes.Word:
                        return AligmentTypes.Word;
                    case AligmentTypes.Long:
                        return AligmentTypes.Long;

                    default:
                        return AligmentTypes.Byte;
                }
            }
        }

        public int DataPerRaw
        {
            get
            {
                return (int)dataPerRowNud.Value;
            }
            set
            {
                dataPerRowNud.Value = value;
            }
        }

        public int BitPerPixel
        {
            get
            {
                return (int)bitsPpCombo.SelectedIndex == 0 ? 4 : 8;
            }
        }

        public ColorRegistersSet ColorRegisters
        {
            get
            {
                return colorRegistersCombo.SelectedIndex == 0 ? ColorRegistersSet.Low16 : ColorRegistersSet.High16;
            }
        }

        private void byteRbox_CheckedChanged(object sender, EventArgs e)
        {

            System.Windows.Forms.RadioButton radioButton = (System.Windows.Forms.RadioButton)sender;

            if (radioButton.Checked)
                DataType = Bitplane.DataType.Byte;
        }

        private void wordRbox_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton radioButton = (System.Windows.Forms.RadioButton)sender;

            if (radioButton.Checked)
                DataType = Bitplane.DataType.Word;
        }

        private void longRbox_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton radioButton = (System.Windows.Forms.RadioButton)sender;

            if (radioButton.Checked)
                DataType = Bitplane.DataType.Long;
        }

        private void arrayNameTextBox_TextChanged(object sender, EventArgs e)
        {
            vr.bitplane.ArrayName = ((TextBox)sender).Text;
        }
    }
}
