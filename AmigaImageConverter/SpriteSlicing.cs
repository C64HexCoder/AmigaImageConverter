using Amiga;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AmigaImageConverter
{
    public partial class SpriteSlicing : UserControl
    {
        List<Sprite> sprites = new List<Sprite>();
        PublicVariables vr;
        ExPictureBox pictureBox;

        public event Action SlicePanelClosed;
        [DefaultValue(false)]
        public bool isSliced { get; set; } = false;

        public event EventHandler ImageUpdated;

        public SpriteSlicing()
        {
            InitializeComponent();
            if (!IsInDesignMode())
                InitRuntime();

        }
        public SpriteSlicing(ref Amiga.ExPictureBox picBox)
        {
            InitializeComponent();
            pictureBox = picBox;
            if (!IsInDesignMode())
                InitRuntime();
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

        [DefaultValue(false)]
        public Bitmap ImageBox
        {
            set
            {
                sprImageBox.Image = value;
            }
        }
        private void RectangleSprite(int SpriteNum)
        {
            // השורה הזו אומרת: אם אנחנו בתוך ה-Designer של Visual Studio, תעצור הכל ותצא.
            // אל תנסה לגשת ל-vr, אל תנסה לגשת ל-pictureBox, פשוט אל תעשה כלום.
            if (this.DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            // רק מכאן והלאה הקוד האמיתי שלך רץ (שרץ רק כשהאפליקציה פועלת)
            if (vr == null || pictureBox == null || pictureBox.Image == null)
                return;

            int SprireWidth = (int)(pictureBox.Image.Width / ImagesPerRawNud.Value / spritePerImageUDN.Value);
            int SpriteHeight = (int)(pictureBox.Image.Height / numOfRawsNud.Value);
            int SpritePerRaw = (int)(ImagesPerRawNud.Value * spritePerImageUDN.Value);

            sprImageBox.Image = sprites[SpriteNum].bitmap;
            int SpriteXPos = SpriteNum % SpritePerRaw, SpriteYPos = SpriteNum / SpritePerRaw;

            //pictureBox.ClearOverlayRectangles();
            vr.spriteRec.LineWIdth = 4;
            vr.spriteRec.X = (int)(SpriteXPos * SprireWidth * pictureBox.ScaldeFactor);
            vr.spriteRec.Y = (int)(SpriteYPos * SpriteHeight * pictureBox.ScaldeFactor);
            vr.spriteRec.Width = (int)(SprireWidth * pictureBox.ScaldeFactor);
            vr.spriteRec.Height = (int)(SpriteHeight * pictureBox.ScaldeFactor);

            //pictureBox.DrawOverlayRectangle(vr.spriteRec.X,vr.spriteRec.Y,vr.spriteRec.Width,vr.spriteRec.Height);
            pictureBox.DrawOverlayRectangle(vr.spriteRec.PreviewRec);
            //pictureBox.pictureBox.Invalidate();
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

            int SpriteWidth = (int)(vr.bitplane.bitmap.Width / ImagesPerRawNud.Value / spritePerImageUDN.Value);
            int SpriteHeight = (int)(vr.bitplane.bitmap.Height / numOfRawsNud.Value);

            int NumOfSprites = (int)(ImagesPerRawNud.Value * numOfRawsNud.Value * spritePerImageUDN.Value);

            if (vr.bitplane.bitmap.Width % SpriteWidth != 0 ||
               vr.bitplane.bitmap.Height % SpriteHeight != 0)
            {
                if (MessageBox.Show("Sprite sheet is not evenly divisible by the selected parameters.\n" +
                    "Do you want to Resize the Image canvas?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    ResizeCanvas resizeCanvas = new ResizeCanvas(vr.bitplane.bitmap);

                    if (resizeCanvas.ShowDialog(this) == DialogResult.OK)
                    {
                        MessageBox.Show("Image resized successfully. Please click the Slice button again.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        return;
                }
            }
            // i need to decide the best way to slice the sprite when the sheet is divided evenly by the number of sprites.
            int SpriteNum = 0;
            for (int y = 0; y < numOfRawsNud.Value; y++)
            {
                for (int x = 0; x < SpritesPerRaw; x++)
                {

                    Rectangle sourceRec = new Rectangle(x * SpriteWidth, y * SpriteHeight, SpriteWidth, SpriteHeight);

                    Bitplane slicedBitplane = vr.bitplane.Slice(sourceRec.X, sourceRec.Y, sourceRec.Width, sourceRec.Height);

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


                    Sprite sprite = slicedBitplane.CreateSprite();
                    sprite.Name = spriteNameTxtbox.Text != "" ? spriteNameTxtbox.Text + SpriteNum++.ToString() : "SpriteName";

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

        public void Update()
        {
            spriteSelectNud_ValueChanged(spriteSelectNud, new EventArgs());
        }

        private void SpriteSlicing_VisibleChanged(object sender, EventArgs e)
        {
            vr.spriteRec.Enable = false;
            ImageUpdated?.Invoke(this, EventArgs.Empty);

        }

        private void sprImageBox_Click(object sender, EventArgs e)
        {
            PaletteDlg palette = new PaletteDlg();
            palette.imagePallate.SetPalette(sprites[(int)spriteSelectNud.Value].Palette);
            palette.ShowDialog();
        }

        private void InitRuntime()
        {
            vr = PublicVariables.instance;
            // כל שאר האתחולים שלך
        }

        private bool IsInDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime ||
                   DesignMode ||
                   Site?.DesignMode == true;
        }

        private void spritePerImageUDN_ValueChanged(object sender, EventArgs e)
        {

        }

        private void spritePerImageUDN_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                if (e.NewValue != 0)
                    ImagesPerRawNud.Maximum = 100 / e.NewValue;
                else
                    ImagesPerRawNud.Maximum = 100;
            }
        }
    }


}
