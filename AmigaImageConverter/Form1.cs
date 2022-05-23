using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hexadecimal;  

namespace AmigaImageConverter
{
    public partial class MainForm : Form
    {
        Bitmap bmp = null;
        Endian endian = new Endian();

        public MainForm()
        {
            InitializeComponent();
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(openFileDialog.FileName);
                pictureBox.Load(openFileDialog.FileName);
                uint x = endian.ConvertToBigEndian(0x01020304);

                switch (pictureBox.Image.PixelFormat)
                {
                    case System.Drawing.Imaging.PixelFormat.Format64bppArgb:
                    case System.Drawing.Imaging.PixelFormat.Format32bppArgb:
                    case System.Drawing.Imaging.PixelFormat.Format24bppRgb:

                        break;

                    case System.Drawing.Imaging.PixelFormat.Format4bppIndexed:
                        break;

                    case System.Drawing.Imaging.PixelFormat.Format1bppIndexed:
                        break;

                }
            }
        }

        private void saveImageAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
            
                switch (pictureBox.Image.PixelFormat)
                {
                    case System.Drawing.Imaging.PixelFormat.Format64bppArgb:
                    case System.Drawing.Imaging.PixelFormat.Format32bppArgb:
                    case System.Drawing.Imaging.PixelFormat.Format24bppRgb:
                     
                        break;

                    case System.Drawing.Imaging.PixelFormat.Format4bppIndexed:
                        break;

                    case System.Drawing.Imaging.PixelFormat.Format1bppIndexed:
                        break;
                    
                }
            }
        }
    }
}
