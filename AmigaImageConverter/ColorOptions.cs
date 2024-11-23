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
        }

        public enum BitsPerPixel
        {
            FourBpp,
            TwelveBpp
        }

        public BitsPerPixel bitsPerPixel
        {
            get
            {
                if (bitsPpCombo.SelectedIndex == 0)
                    return BitsPerPixel.FourBpp;
                else
                    return BitsPerPixel.TwelveBpp;
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
                return (ushort)(colorRegistersCombo.SelectedIndex == 0 ? 0x180 : 0x1A0);
            }
        }

    }
}
