using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hexadecimal;
using AmigaBitplane;


namespace AmigaImageConverter
{
    public partial class MainForm : Form
    {
        Bitmap bmp = null;
        Endian endian = new Endian();
        Bitplane bitplane = new Bitplane();
        Settings settings = new Settings();
        About about = new About();

        public MainForm()
        {
            InitializeComponent();
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //bmp = new Bitmap(openFileDialog.FileName);
                pictureBox.Load(openFileDialog.FileName);
               
                bitplane.LoadImage(openFileDialog.FileName);
                pictureBox.Width = bitplane.Width;
                pictureBox.Height = bitplane.Height;
                Width = bitplane.Width+20;
                Height = bitplane.Height + menuStrip1.Height + statusStrip1.Height+40;
                toolStripFileName.Text = openFileDialog.FileName;
                toolStripResolutionLabel.Text = $"{bitplane.Width}x{bitplane.Height}";
                toolStripDepthLabel.Text = $"{bitplane.NumOfBitmaps} Bitmaps";

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
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        bitplane.SaveBitmapsAsAssemblerSourceCode(saveFileDialog.FileName);
                        break;
                    case 2:
                    if (settings.sequentialRB.Checked == true)
                        bitplane.SaveBitmapsAsBinaryFile(saveFileDialog.FileName);
                    else
                        bitplane.SaveBitmapsAsInterleavedBinaryFile(saveFileDialog.FileName);
                        break;
                }
            }
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void settingsMenuItem_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            about.ShowDialog();
        }

        private void savePallateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog pallateFileDialog = new SaveFileDialog();
            pallateFileDialog.Filter = "Assembler Source|*.S";
            if (pallateFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitplane.SavePallate(pallateFileDialog.FileName);
            }
        }
    }
}
