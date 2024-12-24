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
using static System.Net.Mime.MediaTypeNames;

namespace AmigaImageConverter
{
    public partial class SpriteCut : UserControl
    {
        List<Sprite> sprites = new List<Sprite>();
        PublicVariables vr = PublicVariables.instance;
        PublicVariables.SpriteCutRec spriteRec;
        public SpriteCut()
        {
            InitializeComponent();
        }

        private void cutSpriteBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(spriteRec.Width, spriteRec.Height);
            Graphics gfx = Graphics.FromImage(bitmap);
            Sprite sprite = new Sprite();
            sprite.Name = spriteNameSCTB.Text;

            //            gfx.DrawImage (image.Image,spriteRec.X,spriteRec.Y,spriteRec.Width,spriteRec.Height);
            gfx.DrawImage(vr.bitplane.bitmap, 0, 0, spriteRec.SpriteRec, GraphicsUnit.Pixel);

            spriteCutPreviewIB.Image = bitmap;
            sprite.bitmap = bitmap;
            sprites.Add(sprite);
            spriteCutSaveButton.Enabled = true;

            if (sprites.Count > 1 && spriteSelectorNud.Enabled == false)
            {
                spriteSelectorNud.Enabled = true;
            }

            spriteSelectorNud.Value = sprites.Count - 1;
        }

        private void spriteSelectorNud_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;

            if (num.Value < sprites.Count)
            {


                spriteCutPreviewIB.Image = sprites[(int)num.Value].bitmap;
            }
            else
                num.Value--;
        }
    }
}
