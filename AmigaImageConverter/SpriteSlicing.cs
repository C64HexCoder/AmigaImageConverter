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
    public partial class SpriteSlicing : UserControl
    {
        List<Sprite> sprites = new List<Sprite>();
        PublicVariables vr = PublicVariables.instance;
        
        public bool isSliced {  get; set; } = false;

        public event EventHandler ImageUpdated;

        public SpriteSlicing()
        {
            InitializeComponent();

        }
        public int ImagesPerRaw
        {
            get
            {
                return (int)ImagesPerRawNud.Value;
            }

        }

        public int SpritesPerImage
        {
            get
            {
                return (int)spritePerImageUDN.Value;
            }
        }

        public int NumOfRaws
        {
            get
            {
                return (int)numOfRawsNud.Value;
            }
        }

        public Bitmap ImageBox
        {
            set
            {
                sprImageBox.Image = value;
            }
        }
        private void RectangleSprite(int SpriteNum)
        {
            int SprireWidth = (int)(vr.bitplane.Width / ImagesPerRawNud.Value / spritePerImageUDN.Value);
            int SpriteHeight = (int)(vr.bitplane.Height / numOfRawsNud.Value);
            int SpritePerRaw = (int)(ImagesPerRawNud.Value * spritePerImageUDN.Value);

            sprImageBox.Image = sprites[SpriteNum].bitmap;
            int SpriteXPos = SpriteNum % SpritePerRaw, SpriteYPos = SpriteNum / SpritePerRaw;

            vr.spriteRec.LineWIdth = 4;
            vr.spriteRec.X = SpriteXPos * SprireWidth  * vr.imageScalingFactoer;
            vr.spriteRec.Y = SpriteYPos * SpriteHeight * vr.imageScalingFactoer;
            vr.spriteRec.Width = SprireWidth * vr.imageScalingFactoer;
            vr.spriteRec.Height = SpriteHeight * vr.imageScalingFactoer;

            ImageUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void SliceBtn_Click(object sender, EventArgs e)
        {
            int SpritesPerRaw = (int)(ImagesPerRawNud.Value * spritePerImageUDN.Value);
            if (ImagesPerRawNud.Value == 0 || numOfRawsNud.Value == 0 || spriteWidthCb.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all the parametters first", "Missing info...", MessageBoxButtons.OK);
                return;
            }
            sprites.Clear();

            int SprireWidth = (int)(vr.bitplane.bitmap.Width / ImagesPerRawNud.Value / spritePerImageUDN.Value);
            int SpriteHeight = (int)(vr.bitplane.bitmap.Height / numOfRawsNud.Value);

            int NumOfSprites = (int)(ImagesPerRawNud.Value * numOfRawsNud.Value * spritePerImageUDN.Value);

            int SpriteNum = 0;
            for (int y = 0; y < numOfRawsNud.Value; y++)
            {
                for (int x = 0; x < SpritesPerRaw; x++)
                {

                    Bitmap SprBmp = new Bitmap(SprireWidth, SpriteHeight);
                    SprBmp.SetResolution(vr.bitplane.bitmap.HorizontalResolution, vr.bitplane.bitmap.VerticalResolution);
                    Sprite sprite = new Sprite();

                    sprite.Name = spriteNameTxtbox.Text != "" ? spriteNameTxtbox.Text + SpriteNum++.ToString() : "SpriteName";


                    Graphics gr = Graphics.FromImage(SprBmp);
                    Rectangle sourceRec = new Rectangle(x * SprireWidth, y * SpriteHeight, SprireWidth, SpriteHeight);
                    gr.DrawImage(vr.bitplane.bitmap, 0, 0, sourceRec, GraphicsUnit.Pixel);

                    //pictureBox1.Update();
                    gr.Dispose();

                    Sprite.SpriteWidth SprWidth;
                    switch (spriteWidthCb.SelectedIndex)
                    {
                        case 0:
                            SprWidth = Sprite.SpriteWidth._16Pixels;
                            break;
                        case 1:
                            SprWidth = Sprite.SpriteWidth._32Pixels;
                            break;
                        case 2:
                            SprWidth = Sprite.SpriteWidth._64Pixels;
                            break;
                        default:
                            SprWidth = Sprite.SpriteWidth._16Pixels;
                            break;
                    }
                    //bitmaps.Add(SprBmp);
                    sprite.ImportImage(SprBmp, SprWidth);
                    sprites.Add(sprite);
                }
            }
            sprImageBox.Image = sprites[0].bitmap;


            spriteSelectNud.Maximum = sprites.Count - 1;
            SliceBtn.Enabled = false;
            SpriteSaveBtn.Enabled = true;
            spriteSelectNud.Value = 0;
            //SlicedSpriteSheet = true;
            spriteSelectNud.Enabled = true;
            vr.spriteRec.Enable = true;

            RectangleSprite(0);
            isSliced = true;
            //CreateRecCallback?.Invoke(0);
        }

        private void spriteSelectNud_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown Nud = (NumericUpDown)sender;

            if (Nud.Enabled == false)
                return;

            sprImageBox.Image = sprites[(int)Nud.Value].bitmap;
            RectangleSprite((int)Nud.Value);
            //CreateRecCallback?.Invoke((int)Nud.Value);

            ImageUpdated?.Invoke(this, EventArgs.Empty);
            //image.Invalidate();

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
