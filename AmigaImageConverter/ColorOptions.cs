using Microsoft.VisualBasic;
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
    public partial class ColorOptions : Form
    {
        public ColorOptions()
        {
            InitializeComponent();
            bitsPpCombo.SelectedIndex = 0;
            colorRegistersCombo.SelectedIndex = 0;
            chipsetCB.SelectedIndex = 0;
        }

        public enum ChipSet
        {
            OCS_ECS,
            AGA
        }

        public ChipSet chipSet
        {
            get
            {
                switch (chipsetCB.SelectedIndex)
                {
                    case 0:
                        return ChipSet.OCS_ECS;
                        break;
                    case 1:
                        return ChipSet.AGA;
                        break;

                    default:
                        return ChipSet.OCS_ECS;
                        break;
                }
            }
        }
        public enum BitsPerPixel
        {
            FourBpp,
            EightBpp
        }

        public BitsPerPixel bitsPerPixel
        {
            get
            {
                if (bitsPpCombo.SelectedIndex == 0)
                    return BitsPerPixel.FourBpp;
                else
                    return BitsPerPixel.EightBpp;
            }

        }

        public enum ColorRegistersSet
        {
            Low16,
            High16
        }

        public ColorRegistersSet ColorRegisters
        {
            get
            {
                return colorRegistersCombo.SelectedIndex == 0 ? ColorRegistersSet.Low16 : ColorRegistersSet.High16;
            }
        }

        public ushort BaseColorRegister
        {
            get
            {
                if (chipSet == ChipSet.OCS_ECS)
                {                  
                    return (ushort)(colorRegistersCombo.SelectedIndex == 0 ? 0x180 : 0x190);
                }
                else
                {
                    return (ushort)(colorRegistersCombo.SelectedIndex == 0 ? 0x180 : 0x1A0);
                }
            }
        }

        private void chipsetCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            if (comboBox.SelectedIndex == 0)
            {
                bitsPpCombo.Enabled = false;
                bankNumUD.Enabled = false;
                bitsPpCombo.SelectedIndex = 0;

                colorRegistersCombo.Items.Clear();
                colorRegistersCombo.Items.Add("$180 - $18E (0-7)");
                colorRegistersCombo.Items.Add("$190 - $19E (8-F)");
                colorRegistersCombo.SelectedIndex = 0;
            }
            else
            {
                bitsPpCombo.Enabled = true;
                bankNumUD.Enabled = true;

                colorRegistersCombo.Items.Clear();
                colorRegistersCombo.Items.Add("$180 - $19E (0-15)");
                colorRegistersCombo.Items.Add("1A0 - $1Be (16-31)");
                colorRegistersCombo.SelectedIndex = 0;
            }
        }
    }
}
