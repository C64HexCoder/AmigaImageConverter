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
        int _SpriteXPos, _SpriteYPos, _SprHieght;
        ushort _SPRxPOS, _SPRxCTL;
        public SPRxPOS_CTLDecoding()
        {
            InitializeComponent();
        }

        public ushort SPRxPOS
        {
            set
            {
                sprPosHexBox.Value = value;
            }
        }

        public ushort SPRxCTL
        {
            set
            {
                sprCtlHexBox.Value = value;
            }
        }
        public int SpriteXPos
        {
            get
            {
                return _SpriteXPos;
            }

            set
            {
                _SpriteXPos = value;
                sprXPosNumUD.Value = value;
            }
        }

        public int SpriteYPos
        {
            get { return _SpriteYPos; }
            set
            {
                _SpriteYPos = value;
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

                SpriteXPos = (sprPosHexBox.HexByte & 0x00ff) << 1 | sprCtlHexBox.HexByte & 0x0001;
                SpriteYPos = (sprPosHexBox.HexByte & 0xff00) >> 8 | (sprCtlHexBox.HexByte & 0x0004) << 6;

                if (sprCtlHexBox.HexByte != 0)
                {
                    sprHeightNumUD.Value = VSTOP - SpriteYPos;
                }
            }
            catch { }
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            int vstop = (int)(sprYPosNumUD.Value + sprHeightNumUD.Value);
            SPRxPOS = (ushort)(((int)sprYPosNumUD.Value & 0xff) << 8 | ((int)sprXPosNumUD.Value >> 1) & 0x0ff);
            SPRxCTL = (ushort)((vstop & 0xff) << 8 | (vstop & 0x100) >> 7 | ((int)sprYPosNumUD.Value & 0x100) >> 6 | (int)sprXPosNumUD.Value & 0x01);
        }
    }
}
