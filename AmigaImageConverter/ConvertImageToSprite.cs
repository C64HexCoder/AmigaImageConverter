using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amiga;

namespace AmigaImageConverter
{
    public partial class ConvertImageToSprite : Form
    {
        PublicVariables pv = PublicVariables.instance;
        int spriteWIdth = 0;
        List<Sprite> sprites = new List<Sprite>();
        PublicVariables.SpriteCutRec SpriteCutRec = new PublicVariables.SpriteCutRec();
        List<PublicVariables.SpriteCutRec> spriteCutRecs = new List<PublicVariables.SpriteCutRec>();
        List<Rectangle> spriteRects = new List<Rectangle>();
        private int ScaleFactor = 4;



        public ConvertImageToSprite()
        {
            InitializeComponent();

            image.Image = pv.bitplane.bitmap;
            image.AutoScale();
            PublicVariables.SpriteCutRec.ScaleFactor = image.ScaleFactor;
            widthNumericUpDown.Value = image.Width;
            heightNumericUpDown.Value = image.Height;
        }

        private void image_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (spriteWIdth != 0)
            {

                PublicVariables.SpriteCutRec.ScaleFactor = image.ScaleFactor;

                foreach (PublicVariables.SpriteCutRec spriteCutRec in spriteCutRecs)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 2), spriteCutRec.PreviewRec);
                }
            }

            Rectangle rec = new Rectangle(0, 0, image.Width, image.Height);
            g.DrawRectangle(new Pen(Color.Black, 4), rec);
        }

        private void doItButton_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Aseembler Source File|*.S;*.asm|Binary File|*.bin| C Source File |*.c";
            string newFileName = null;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                int spriteNum = 0;

                String fileName = Path.ChangeExtension(saveFileDialog.FileName, null);
                Path.ChangeExtension(saveFileDialog.FileName, null);
                foreach (Sprite sprite in sprites)
                {
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            newFileName = fileName + spriteNum++ + ".asm";
                            sprite.SaveAsAssemblerSourceFile(newFileName);
                            break;
                        case 2:
                            newFileName = fileName + spriteNum++ + ".bin";
                            sprite.SaveAsBinaryFile(newFileName);
                            break;
                        case 3:
                            newFileName = fileName + spriteNum++ + "cpp";
                            sprite.SaveAsCPPSourceFile(newFileName);
                            break;

                    }
                }
            }

        }

        private void spriteNum_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            //if (sprites.Count > 0)
            {
                spritePreviewIB.Image = sprites[(int)numericUpDown.Value].bitmap;
                spritePreviewIB.Left = (sidePael.Width - spritePreviewIB.Width) / 2;
            }
        }

        private void spriteWIdthCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sprites.Clear();
            spriteCutRecs.Clear();
            ComboBox comboBox = sender as ComboBox;

            switch (comboBox.SelectedIndex)
            {

                case 0:
                    spriteWIdth = 16;
                    break;
                case 1:
                    spriteWIdth = 32;
                    break;
                case 2:
                    spriteWIdth = 64;
                    break;
            }

            int spritesPerImage = pv.bitplane.bitmap.Width / spriteWIdth;

            for (int i = 0; i < spritesPerImage; i++)
            {
                int x = i * spriteWIdth;
                int x2 = i * spriteWIdth + spriteWIdth;
                int y = 0;
                int y2 = pv.bitplane.bitmap.Height;
                PublicVariables.SpriteCutRec rectangle = new PublicVariables.SpriteCutRec(x, y, x2 - x, y2 - y);
                spriteCutRecs.Add(rectangle);
            }
            int spriteIndex = 0;
            foreach (PublicVariables.SpriteCutRec rectangle in spriteCutRecs)
            {
                Bitmap cutSprite = new Bitmap(rectangle.Width, rectangle.Height);
                Graphics gfx = Graphics.FromImage(cutSprite);
                Rectangle destRec = new Rectangle(0, 0, cutSprite.Width, cutSprite.Height);

                gfx.DrawImage(pv.bitplane.bitmap, destRec, rectangle.SpriteRec, GraphicsUnit.Pixel);
                spritePreviewIB.Image = cutSprite;

                spritePreviewIB.AutoScale();
                Sprite sprite = new Sprite();

                Sprite.SpriteWidth spriteWidth;
                switch (spriteWIdth)
                {
                    case 16:
                        spriteWidth = Sprite.SpriteWidth._16Pixels;
                        break;
                    case 32:
                        spriteWidth = Sprite.SpriteWidth._32Pixels;
                        break;
                    case 64:
                        spriteWidth = Sprite.SpriteWidth._64Pixels;
                        break;
                    default:
                        spriteWidth = Sprite.SpriteWidth._16Pixels;
                        break;

                }

                sprite.bitmap = cutSprite;
                sprite.Name = spriteNameTb.Text + spriteIndex++;
                sprite.ImportImage(cutSprite, spriteWidth);
                sprites.Add(sprite);
                spritePreviewIB.Left = (sidePael.Width - spritePreviewIB.Width) / 2;
            }

            spriteNum.Maximum = sprites.Count - 1;
            image.Refresh();
        }

        private void spriteNameTb_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            int i = 0;
            foreach (var sprite in sprites)
                sprite.Name = textBox.Text + i++;
        }
    }
}
