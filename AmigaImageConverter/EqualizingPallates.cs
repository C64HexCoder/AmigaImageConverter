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
    public partial class EqualizingPallates : Form
    {
        PublicVariables vr = PublicVariables.instance;
        int NumOfColors;
        int NumOfSprites;
        const int LowWord = 0, HiWord = 1;
        int[] PallateToCopyFrom;

        //public Panel PallatePanel;

        public delegate byte GetPixelDelg (int x, int y);
        public delegate void SetPixelDelg (int x, int y, ulong colorIndex);
        int[] verify = new int[16];

        // public SetPixelDelg SetPixel;
        // public GetPixelDelg GetPixel;
        struct SimilarColor
        {
            public byte colorIdx;
            public Color color;
        }

        // List<SimilarColors> similarColors = new List<SimilarColors>();
        // List<List<SimilarColors>> similarColors2 = new List<List<SimilarColors>>();

        // similarColors[Sprite,It's pallate]
        // an array with an array of pallate for each sprite represents the similar color to the sprite 0 color in that position
        int[,] similarColors;// = new SimilarColor[ 16];
        int[] NewPallate;
        

        public EqualizingPallates()
        {
            InitializeComponent();
            colorsToUseCbox.SelectedIndex = 0;

        }

        // ------------------------------------------------- CONVERT BUTTON -------------------------------------------------------
        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            NumOfColors = vr.Sprites[(int)fromSpriteNud.Value].Attached ? 16 : 4;
            NumOfSprites = (int)(toSpriteNud.Value - fromSpriteNud.Value)+1;
            similarColors = new int[NumOfSprites, 16];
            NewPallate = new int[NumOfColors];
            PallateToCopyFrom = vr.Sprites[(int)pallateNud.Value].Colors;

            int fromSprite = (int)fromSpriteNud.Value;
            int toSprite = (int)toSpriteNud.Value;
            List<int> CommonColors = new List<int>();
            List<int> UnCommonColors = new List<int>();

            if (!IsAllPallateTheSameSize(fromSprite,toSprite))
                MessageBox.Show("Eror, Pallates are not of the same size! You can noly do equalization on sprite with the same number of colors!)", "ERROR",MessageBoxButtons.OK);

            
            // go over the sprites pallate and searching for each of sprite 0 colors a similar one in all the pallates of the other sprites
            for (int sprite = fromSprite; sprite <= toSprite; sprite++)
            {
                for (int i = 1; i < NumOfColors; i++) {
                   
                    similarColors[sprite-fromSprite,i] = FindSimilarColorInPallate(PallateToCopyFrom, vr.Sprites[sprite].Colors[i]);
                }
            }

           if (colorsToUseCbox.SelectedIndex == 1)
                  AvaragingColors();

           for (int sprite = fromSprite; sprite <= toSprite; sprite++)
            {
                int[] PallateToCopyFrom = colorsToUseCbox.SelectedIndex == 1 ? NewPallate : this.PallateToCopyFrom;

                for (int i = 0; i < NumOfColors; i++)
                    vr.Sprites[sprite].Colors[i] = PallateToCopyFrom[i];
                   
                    ReplaceCollorsInSprite(sprite);
            }



            Close();
        }
    // --------------------------------------------- END OF CONVERT BUTTON ------------------------------------------------------ 
        private void ReplaceCollorsInSprite(int spriteNum)
        {
            for (int y=0; y < vr.Sprites[spriteNum].Height; y++)
                for (int x=0; x < vr.Sprites[spriteNum].Width; x++)
                {
                    byte color = GetPixel(x, y, spriteNum);
                    SetPixel(x, y,(byte) similarColors[spriteNum, color],spriteNum);
                }
        }
        private float ColorDifference(Color color1, Color color2)
        {
            //float RedDiff = Math.Abs(color1.R - color2.R) / 255f;
            return (Math.Abs(color1.R - color2.R) / 255f + Math.Abs(color1.G - color2.G) / 255f + Math.Abs(color1.B - color2.B) / 255f) / 3f;
        }

        private void AvaragingColors ()
        {
            int AvarageRed = 0, AvarageGreen = 0, AvarageBlue = 0; 
            for (int i = 1; i < NumOfColors; i++)
            {
                AvarageRed = 0; AvarageGreen = 0; AvarageBlue = 0;

                for (int sprite = 0; sprite < NumOfSprites; sprite++)
                {
                    int index = getEquivilentColorFromPallate(sprite,i);
                    if (index != -1)
                    {
                        AvarageRed += Color.FromArgb(vr.Sprites[sprite].Colors[index]).R;
                        AvarageGreen += Color.FromArgb(vr.Sprites[sprite].Colors[index]).G;
                        AvarageBlue += Color.FromArgb(vr.Sprites[sprite].Colors[index]).B;
                    }
                }
                AvarageRed = AvarageRed / NumOfSprites;
                AvarageGreen = AvarageGreen / NumOfSprites;
                AvarageBlue = AvarageBlue / NumOfSprites;

                //Color NewColor = Color();
                //NewColor = Color.FromArgb(255, AvarageRed, AvarageGreed, AvarageBlue);
                NewPallate[i] = (Color.FromArgb(255, AvarageRed, AvarageGreen, AvarageBlue)).ToArgb();
                NewPallate[0] = SystemColors.Control.ToArgb();
            }
        }

        private int getEquivilentColorFromPallate (int Sprite, int RequiredIndexPos)
        {
           
            for (int i = 1; i < NumOfColors; i++)
            if (similarColors[Sprite,i] == RequiredIndexPos)
                return i;

            return -1;
        }
        private int FindSimilarColorInPallate(int[] Pallate,int color)
        {
            byte PosInPal = 0;
            float difference = 1f;
            
            for (int i = 1; i < NumOfColors; i++)
            {
      //          if (Pallate[i] != 1)
         //       {
                    float tempDiff = ColorDifference(Color.FromArgb(color), Color.FromArgb(Pallate[i]));
                    if (tempDiff < difference)
                    {
                        PosInPal = (byte)i;
                        difference = tempDiff;

                    }
       //         }
            }
       //     Pallate[simColor.colorIdx] = 1;
            return PosInPal;
        }

        private bool IsExistInList (List<int> list, int color)
        {
            List<int> resultList = new List<int>();
            list.Find (x => x == color);
            return resultList.Count > 0;
        }
        private bool IsColorInPallate(int[] Pallaet, int color)
        {
            bool isColorExits = false;

            int i = 0;
            while (!isColorExits && i < NumOfColors)
                {
                    if (Pallaet[i] == color)
                        isColorExits = true;
                    
                    i++;
                }
            return isColorExits;
        }

        private bool IsColorInPallates(int fromSprite, int toSprite, int color)
        {
            bool IsExistInPlates = true;

            int i = fromSprite;
            while (IsExistInPlates && i<toSprite)
            {
                IsExistInPlates = IsColorInPallate(vr.Sprites[i].Colors, color);
                i++;
            }
            return IsExistInPlates;
        }

        private bool IsAllPallateTheSameSize(int fromSprite, int toSprite)

        {
            bool firstSpriteAttached = vr.Sprites[fromSprite].Attached;
            for (int sprite = fromSprite + 1; sprite <= toSprite; sprite++)
            {
                if (vr.Sprites[sprite].Attached != firstSpriteAttached)
                    return false;
            }
            return true;
        }

        private byte GetPixel(int x, int y, int spriteNum)
        {
            try
            {
                byte MSB = (byte)(vr.Sprites[spriteNum].Width - 1);
                ulong BitMasking = (ulong)1 << (MSB - x);
                byte ColorIdx = 0;

                if (vr.Sprites[spriteNum].Attached)
                {
                    ColorIdx |= (byte)(((vr.Sprites[spriteNum].SpriteData[1, HiWord, y] & BitMasking) >> (MSB - x)) << 3);
                    ColorIdx |= (byte)(((vr.Sprites[spriteNum].SpriteData[1, LowWord, y] & BitMasking) >> (MSB - x) << 2));

                }

                ColorIdx |= (byte)(((vr.Sprites[spriteNum].SpriteData[0, HiWord, y] & BitMasking) >> (MSB - x) << 1));
                return ColorIdx |= (byte)((vr.Sprites[spriteNum].SpriteData[0, LowWord, y] & BitMasking) >> (MSB - x));
            }
            catch (StackOverflowException e)
            {
                return 0;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pallateNud_ValueChanged(object sender, EventArgs e)
        {
            PallateToCopyFrom = vr.Sprites[(int)pallateNud.Value].Colors;
        }

        private void colorsToUseCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex == 1)
                pallateNud.Enabled = false;
            else
                pallateNud.Enabled = true;
        }

        private void SetPixel(int x, int y, ulong ColorIdx, int spritrNum)
        {
            ulong bit = 1;
            byte MSB = (byte)(vr.Sprites[spritrNum].Width - 1);
            byte BitToMask = (byte)(MSB - x);
            ulong MaskingBit = (ulong)(bit << BitToMask);
            vr.Sprites[spritrNum].SpriteData[0, LowWord, y] &= (ulong)~(bit << BitToMask);
            vr.Sprites[spritrNum].SpriteData[0, HiWord, y] &= (ulong)~(bit << BitToMask);
            ulong OrBit = (ulong)((ColorIdx & 0x01) << BitToMask);
            vr.Sprites[spritrNum].SpriteData[0, LowWord, y] |= OrBit;
            OrBit = (ulong)(((ColorIdx & 0x02) >> 1) << (MSB - x));
            vr.Sprites[spritrNum].SpriteData[0, HiWord, y] |= OrBit;

            if (vr.Sprites[spritrNum].Attached)
            {
                vr.Sprites[spritrNum].SpriteData[1, LowWord, y] &= (ulong)~(bit << (MSB - x));
                vr.Sprites[spritrNum].SpriteData[1, HiWord, y] &= (ulong)~(bit << (MSB - x));
                OrBit = (ulong)((ColorIdx & 0x04) >> 2) << (MSB - x);
                vr.Sprites[spritrNum].SpriteData[1, LowWord, y] |= OrBit;
                OrBit = (ulong)(((ColorIdx & 0x08) >> 3) << (MSB - x));
                vr.Sprites[spritrNum].SpriteData[1, HiWord, y] |= OrBit;
            }
        }

    }
}
