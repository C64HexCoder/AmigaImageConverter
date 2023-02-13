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
    public partial class DisplayMask : Form
    { PublicVariables vr = PublicVariables.instance;

        public DisplayMask()
        {
            InitializeComponent();
      
        }

        private void DisplayMask_Activated(object sender, EventArgs e)
        {
            float ScaleFactor = ((float)pictureBox.Height / (float)vr.bitplane.Mask.Height);
            pictureBox.Image = vr.bitplane.Mask;
            pictureBox.ScaleImage(ScaleFactor);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            saveBtn.Left = pictureBox.Right - saveBtn.Width;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {   Settings setings = new Settings();
            vr.bitplane.SaveMaskAs(setings.outPutSize);
        }
    }
}
