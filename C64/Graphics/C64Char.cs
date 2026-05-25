using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace C64.Graphics
{
    internal class C64Char
    {
        bool Multicolor = false;

        Bitmap charBitmap = new Bitmap(8, 8);

        byte [] data = new byte[8];
        //byte[,] multicolorData = new byte[8, 2];

        
        public Color GetPixel (int x, int y)
        {
            if (Multicolor)
            {
                if (x > 3)
                    return Color.Transparent;
                else
                {
                    byte Mask = (byte)(0b11000000 >> (x * 2));
                    byte Index = (byte)((data[y] & Mask) >> (6 - x * 2));
                    return C64Palette.GetColor(Index);
                }
            }
            else
            {
                return C64Palette.GetColor((data[y] >> (7 - x)) & 1);
            }
        }
        public void SetPixel (int x, int y, Color color)
        {
            if (Multicolor)
            {
                if (x > 3)
                    return;
                else
                {
                    byte Mask = (byte)(0b11000000 >> (x * 2));
                    byte Index = 0;
                    for (int i = 0; i < 16; i++)
                    {
                        if (C64Palette.GetColor(i) == color)
                        {
                            Index = (byte)i;
                            break;
                        }
                    }
                    data[y] = (byte)((data[y] & ~Mask) | ((Index << (6 - x * 2)) & Mask));
                }
            }
            else
            {
                byte Mask = (byte)(1 << (7 - x));
                byte BitValue = (byte)(color == C64Palette.GetColor(1) ? 1 : 0);
                data[y] = (byte)((data[y] & ~Mask) | ((BitValue << (7 - x)) & Mask));
            }
        }
    }
}
