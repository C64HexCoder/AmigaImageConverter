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

namespace AmigaImageConverter
{
    public partial class ControlWords : Form
    {
        private ushort _Xpos, _Ypos;

        Sprite sprite = null;
        List<Sprite> sprites = new List<Sprite>();

        public ControlWords(Sprite sprite)
        {
            InitializeComponent();
            this.sprite = sprite;

        }

        public ControlWords(List<Sprite> sprites)
        {
            InitializeComponent();
            this.sprites = sprites;
        }
        public ControlWords()
        {
            InitializeComponent();
        }
        bool RelativePositioning
        {
            get
            {
                return PositionAddressingCB.SelectedIndex == 0 ? true : false;
            }

        }

        public ushort Xpos
        {
            get
            {
                return _Xpos;
            }
        }
        public ushort Ypos
        {
            get
            {
                return _Ypos;
            }
        }

        public ulong SPRxPOS
        {
            get
            {
                return sprite.SPRxPOS;
            }
        }

        public ulong SPRxCTL
        {
            get
            {
                return sprite.SPRxCTL;
            }
        }
        private void CalculateComWordsBT_Click(object sender, EventArgs e)
        {
            if (sprites.Count == 0)
            {
                MessageBox.Show("No Sprite Found...");
                return;
            }

            /*if (sprite != null)
            {
                sprite.CalculateControlWords(_Xpos, _Ypos, RelativePositioning);
                SPRxPOSTB.Text = sprite.SPRxPOS.ToString();
                SPRxCTLTB.Text = sprite.SPRxCTL.ToString();
            }
            else*/

            ushort xpos = Xpos;
            foreach (Sprite sprite in sprites)
            {
                sprite.CalculateControlWords(xpos, Ypos, RelativePositioning);
                xpos += (ushort)sprite.bitmap.Width;
            }
            SPRxPOSTB.Text = "$" + sprites[0].SPRxPOS.ToString("X4");
            SPRxCTLTB.Text = "$" + sprites[0].SPRxCTL.ToString("X4");
        }

        private void NameTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sprite.Name = ((TextBox)sender).Text;
            }
        }

        private void xPosNum_ValueChanged(object sender, EventArgs e)
        {
            _Xpos = (ushort)xPosNum.Value;
        }

        private void yPosNum_ValueChanged(object sender, EventArgs e)
        {
            _Ypos = (ushort)yPosNum.Value;
        }

    }
}
