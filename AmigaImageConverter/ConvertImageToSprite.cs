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
        Sprite sprite = new Sprite();

        PublicVariables.CutRec SpriteCutRec = new PublicVariables.CutRec();
        List<PublicVariables.CutRec> spriteCutRecs = new List<PublicVariables.CutRec>();
        List<Rectangle> spriteRects = new List<Rectangle>();
        private int ScaleFactor = 4;



        public ConvertImageToSprite()
        {
            InitializeComponent();


            if (pv.bitplane.Width > 64)
            {
                MessageBox.Show("Sprite Is To Wide For a Sprite. \n" +
                    "Please Resize the image to 16bit, 32bit or 64bit wide.", "Image Size Error", MessageBoxButtons.OK);
                return;
            }
            Sprite.SpriteWidth sprWidth;

            switch (pv.bitplane.Width)
            {
                case 64:
                    sprWidth = Sprite.SpriteWidth._64Pixels; 
                    break;
                case 32:
                    sprWidth = Sprite.SpriteWidth._32Pixels;
                    break;
                case 16:
                    sprWidth = Sprite.SpriteWidth._16Pixels;
                    break;

                 default:
                    sprWidth = Sprite.SpriteWidth._16Pixels;
                    break;

            }
            sprite = pv.bitplane.CreateSprite();
            //image.Image = sprite.bitmap;
            image.Image = sprite.bitmap;
            image.AutoScale();
            widthNumericUpDown.Value = pv.bitplane.Width;
            heightNumericUpDown.Value = pv.bitplane.Height;
        }

        private void image_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (spriteWIdth != 0)
            {

                //PublicVariables.SpriteCutRec.ScaleFactor = image.ScaleFactor;

                foreach (PublicVariables.CutRec spriteCutRec in spriteCutRecs)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Black, 2), spriteCutRec.PreviewRec);
                }
            }

            Rectangle rec = new Rectangle(0, 0, image.Width, image.Height);
            g.DrawRectangle(new Pen(Color.Black, 4), rec);
        }

        private void doItButton_Click(object sender, EventArgs e)
        {
            ControlWords controlWords = new ControlWords(sprites);
            controlWords.ShowDialog();


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Aseembler Source File|*.S;*.asm|Binary File|*.bin| C Source File |*.c";
            string newFileName = null;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                int spriteNum = 0;
           
                String fileName = Path.ChangeExtension(saveFileDialog.FileName, null);

                switch (saveFileDialog.FilterIndex) { 
                    case 1:
                        Path.ChangeExtension(saveFileDialog.FileName, "asm");
                        break;

                    case 3:
                        Path.ChangeExtension(saveFileDialog.FileName, "cpp");
                        break;
      
                }
                File.Delete(saveFileDialog.FileName);
                int i = 0;
                foreach (Sprite sprite in sprites)
                {
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            sprite.SaveAsAssemblerSourceFile(saveFileDialog.FileName, Sprite.MemoryType.CHIP, 10, 10, false,true);
                            break;
                        case 2:
                            newFileName = fileName + i + ".bin";
                            sprite.SaveAsBinaryFile(newFileName);
                            break;
                        case 3:
                            sprite.SaveAsCPPSourceFile(saveFileDialog.FileName, Sprite.MemoryType.CHIP, 0, 0, false,true);
                            break;

                    }
                }
            }

            MessageBox.Show($"Saved {sprites.Count} Sprites successfully");

        }

        private void spriteNum_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            if (sprites.Count > 0)
            {
                ScaleFactor = spritePreviewIB.ScaleFactor;
                spritePreviewIB.Image = sprites[(int)numericUpDown.Value].bitmap;
                spritePreviewIB.OriginalImage = null;

                spritePreviewIB.ScaleImage(ScaleFactor);
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



            //Sprite sprite = new Sprite();

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


            //sprite.Name = spriteNameTb.Text + spriteIndex++;
            sprite.Name = spriteNameTb.Text;
            sprites = sprite.SplitSprite(spritesPerImage);
            spriteNum.Value = 0;
            spritePreviewIB.Image = sprites[0].bitmap;
            spritePreviewIB.OriginalImage = null;
            spritePreviewIB.AutoScale();
            spritePreviewIB.Left = (sidePael.Width - spritePreviewIB.Width) / 2;




            if (sprites.Count > 0)
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

        private void resizeBtn_Click(object sender, EventArgs e)
        {

        }

        private void widthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void widthNumericUpDown_Leave(object sender, EventArgs e)
        {

        }

        private void calculateControlWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlWords controlWords = new ControlWords(sprites);
            if (controlWords.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
