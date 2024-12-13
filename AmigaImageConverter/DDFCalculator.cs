using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigaImageConverter
{
    public partial class DDFCalculator : Form
    {
        ushort displayWindowWidth = 320, displayWindowHeight = 256;
        ushort diwstrt, diwstop, ddfstrt, ddfstop;
        byte dmaCycles = 16;
        int Hstart = 0, Vstart = 0;

        public DDFCalculator()
        {
            InitializeComponent();

            DIWSTRT = 0x2c81;
            diwWidthNum.Value = displayWindowWidth;
            diwheightNum.Value = displayWindowHeight;
            resolutionCB.SelectedIndex = 0;
            dmaWidthCB.SelectedIndex = 0;

        }

        public ushort DisplayWindowWidth
        {
            get
            {
                return displayWindowWidth;
            }
            set
            {
                displayWindowWidth = value;
                diwWidthNum.Value = (ushort)displayWindowWidth;
            }
        }

        public ushort DisplayWindowsHeight
        {
            get
            {
                return displayWindowHeight;
            }
            set
            {
                displayWindowHeight = value;
                diwheightNum.Value = (ushort)displayWindowHeight;
            }
        }
        public ushort DIWSTRT
        {
            get
            {
                return diwstrt;
            }
            set
            {
                diwstrt = value;
                diwstrtHexBox.Value = diwstrt;
                diwstop = (ushort)(diwstopHexBox.Value = ((((diwstrt & 0xff00) >> 8) + displayWindowHeight) << 8 | ((diwstrt & 0x00ff) + displayWindowWidth) & 0x00ff) & 0xffff);

                switch (resolutionCB.SelectedIndex)
                {
                    case 0:
                    default:
                        ddfstrt = (ushort)(ddfstartHexBox.Value = (ushort)((diwstrt & 0x00ff) / 2f - 8.5f));
                        break;
                    case 1:
                        ddfstrt = (ushort)(ddfstartHexBox.Value = (ushort)((diwstrt & 0x00ff) / 2f - 4.5f));
                        break;


                }
                ddfstop = (ushort)(ddfstopHexBox.Value = (int)(ddfstrt + (displayWindowWidth / 2f) - dmaCycles) & 0x00ff);
                if (hardScrollCheckBox.Checked)
                {
                    ddfstartHexBox.Value = ddfstrt -= dmaCycles;
                }
            }
        }

        public ushort DIWSTOP
        {
            get
            {
                return diwstop;
            }
            set
            {
                diwstop = value;
            }
        }
        private ushort CreateDIWSTRT(byte x, byte y)
        {
            return (ushort)(y << 8 | x);
        }

        private void DDFCalculator_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;

        }

        private void tvPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen pen = new Pen(Color.Black, 4);
            Rectangle maxDisplayWindows = new Rectangle(100, 100, 640, 400);
            //Width = maxDisplayWindows.Width;
            //Height = maxDisplayWindows.Height;
            float PixelWidth, PixelHeight;
            if (resolutionCB.SelectedIndex == 0)
            {
                PixelWidth = 640 / 320;
                PixelHeight = 400f / 256f;
            }
            else
            {
                PixelWidth = 1;
                PixelHeight = 400 / 256;
            }

            byte Vstart = (byte)(ushort)(diwstrt >> 8);
            byte Hstart = (byte)(ushort)(diwstrt & 0x00ff);
            int tmpWidth = (int)((float)diwWidthNum.Value * PixelWidth);
            int tmpHeight = (int)((float)diwheightNum.Value * PixelHeight);


            gfx.DrawRectangle(pen, 100 + (Hstart - 0x81)*PixelWidth, 100 + (Vstart - 0x2c) * PixelHeight, tmpWidth, tmpHeight);
        }

        private void dmaWidthCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            switch (cmb.SelectedIndex)
            {
                case 0:
                    dmaCycles = 8;
                    break;
                case 1:
                    dmaCycles = 16;
                    break;
                case 2:
                    dmaCycles = 32;
                    break;

                default:
                    dmaCycles = 8;
                    break;
            }

            CalculateDDF();

        }

        public void CalculateDDF()
        {

            switch (resolutionCB.SelectedIndex)
            {
                case 0:
                default:
                    ddfstrt = (ushort)(ddfstartHexBox.Value = (ushort)((diwstrt & 0x00ff) / 2f - 8.5f));
                    break;
                case 1:
                    ddfstrt = (ushort)(ddfstartHexBox.Value = (short)((diwstrt & 0x00ff) / 2f - 4.5f));
                    break;


            }
            ddfstop = (ushort)(ddfstopHexBox.Value = (int)(ddfstrt + (displayWindowWidth / 2f) - dmaCycles) & 0x00ff);

            if (hardScrollCheckBox.Checked)
            {
                ddfstartHexBox.Value = ddfstrt -= dmaCycles;
            }

        }

        private void hardScrollCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;

            if (chk.Checked)
            {
                ddfstartHexBox.Value = ddfstrt -= dmaCycles;
            }
            else
                ddfstartHexBox.Value = ddfstrt += dmaCycles;

        }

        private void resolutionCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            if (cmb.SelectedIndex == 0)
            {
                DisplayWindowsHeight = 256;
                DisplayWindowWidth = 320;
            }
            else
            {
                DisplayWindowsHeight = 256;
                DisplayWindowWidth = 640;
            }

            CalculateDDF();
        }

        private void diwWidthNum_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            displayWindowWidth = (ushort)numericUpDown.Value;

            if (resolutionCB.SelectedIndex == 0)
            {
                byte Margin = (byte)((320 - displayWindowWidth) / 2);
                if (Margin >160)
                {
                    MessageBox.Show("The Width can not be less then 160", "Width is too short");
                    return;

                }
                diwstrt &= 0xff00;
                DIWSTRT = diwstrt |= (byte)(0x81 + Margin);
                diwstop = (ushort)(diwstopHexBox.Value = ((((diwstrt & 0xff00) >> 8) + displayWindowHeight) << 8 | ((diwstrt & 0x00ff) + displayWindowWidth) & 0x00ff) & 0xffff);
                Refresh();
            }
        }

        private void diwheightNum_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            displayWindowHeight = (ushort)numericUpDown.Value;

            if (resolutionCB.SelectedIndex == 0)
            {
                diwstop &= 0x00ff;
                diwstop = (ushort)(diwstopHexBox.Value = ((((diwstrt & 0xff00) >> 8) + displayWindowHeight) << 8 | ((diwstrt & 0x00ff) + displayWindowWidth) & 0x00ff) & 0xffff);
            }
            Refresh();
        }
    }
}
