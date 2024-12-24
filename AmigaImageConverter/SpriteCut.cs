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
        
        public SpriteCut()
        {
            InitializeComponent();
        }

        public void SetWidth(int width)
        {
            widthNumUD.Value = width / vr.imageScalingFactoer;
        }
        public void SetHeight(int height)
        {
            heightNumUD.Value = height / vr.imageScalingFactoer;
        }
        private void cutSpriteBtn_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(vr.spriteRec.Width/vr.imageScalingFactoer, vr.spriteRec.Height/vr.imageScalingFactoer);
            Graphics gfx = Graphics.FromImage(bitmap);
            Sprite sprite = new Sprite();
            sprite.Name = spriteNameSCTB.Text;

            Rectangle OriginalSizeRect = new Rectangle(vr.spriteRec.X / vr.imageScalingFactoer,vr.spriteRec.Y / vr.imageScalingFactoer,vr.spriteRec.Width/vr.imageScalingFactoer,vr.spriteRec.Height/vr.imageScalingFactoer);
            gfx.DrawImage(vr.bitplane.bitmap, 0, 0, OriginalSizeRect, GraphicsUnit.Pixel);

            spriteCutPreviewIB.Image = bitmap;
            widthNumUD.Value = bitmap.Width;
            heightNumUD.Value = bitmap.Height;
            spriteCutPreviewIB.AutoScale();
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

        private void SpriteSaveBtn_Click(object sender, EventArgs e)
        {
            SaveSprite sp = new SaveSprite();
            sp.sprites = sprites;
            if (sp.ShowDialog(this) == DialogResult.Continue)
                MessageBox.Show("Sprite Files/s Created Successfully", "Succsess", MessageBoxButtons.OK);
        }
    }
}
