using System;
using System.Collections.Generic;
using System.Text;

namespace C64
{
    public abstract class BaseSprite
    {
        // משתנים משותפים לכל הספרייטים בעולם
        public int Width { get; protected set; }
        public int Height { get; protected set; }
        public int BitsPerPixel { get; protected set; }

        // מטריצת הפיקסלים הגנרית לתצוגה (מאחסנת אינדקס צבע 0, 1, 2...)
        protected int[,] pixelMatrix;

        protected BaseSprite(int width, int height, int bpp)
        {
            Width = width;
            Height = height;
            BitsPerPixel = bpp;
            pixelMatrix = new int[width, height];
        }

        // 🌟 אינדקסר וירטואלי משותף - כולם משתמשים בו כברירת מחדל!
        public virtual int this[int x, int y]
        {
            get
            {
                if (x >= 0 && x < Width && y >= 0 && y < Height)
                    return pixelMatrix[x, y];
                return 0;
            }
            set
            {
                if (x >= 0 && x < Width && y >= 0 && y < Height)
                    pixelMatrix[x, y] = value;
            }
        }

        // פעולה משותפת שכל ספרייט צריך
        public virtual void Clear()
        {
            Array.Clear(pixelMatrix, 0, pixelMatrix.Length);
        }

        // 🌟 הפונקציות שחייבות מימוש שונה לחלוטין לפי הברזל של המכשיר
        public abstract byte[] GetRawBytes();
        public abstract void LoadRawBytes(byte[] data);
    }
}
