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

            pictureBox.Image = vr.bitplane.Mask;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
        }
    }
}
