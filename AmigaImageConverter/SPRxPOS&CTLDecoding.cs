using Amiga;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AmigaImageConverter
{
    public partial class SPRxPOS_CTLDecoding : Form
    {
        int _SprXPos, _SprYPos, _SprHieght;
        public SPRxPOS_CTLDecoding()
        {
            InitializeComponent();
        }

        public int SprXPos
        {
            get
            {
                return _SprXPos;
            }

            set
            {
                _SprXPos = value;
                sprXPosNumUD.Value = value;
            }
        }

        public int SprYPos
        {
            get { return _SprYPos; }
            set
            {
                _SprYPos = value;
                sprYPosNumUD.Value = value;
            }
        }
        private void sprPosHexBox_HexBoxChanged(object sender, EventArgs e)
        {
           ExtractSpriteProperties();
        }

        private void sprCtlHexBox_HexBoxChanged(object sender, EventArgs e)
        {
            ExtractSpriteProperties();
        }

        private void ExtractSpriteProperties()
        {
            try
            {
                int VSTOP = (sprCtlHexBox.HexByte & 0xff00) >> 8 | (sprCtlHexBox.HexByte & 0x0002) >> 2;

                SprXPos = (sprPosHexBox.HexByte & 0x00ff) << 1 | sprCtlHexBox.HexByte & 0x0001;
                SprYPos = (sprPosHexBox.HexByte & 0xff00) >> 8 | (sprCtlHexBox.HexByte & 0x0004) << 6;

                if (sprCtlHexBox.HexByte != 0)
                {
                    sprHeightNumUD.Value = VSTOP - SprYPos;
                }
            } catch { }
        }
    }
}
