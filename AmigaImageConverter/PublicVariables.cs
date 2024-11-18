using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amiga;

namespace AmigaImageConverter
{
    internal class PublicVariables
    {
        public static PublicVariables _instance;

        public Bitplane.DataType outputSize = Bitplane.DataType.Word;
        public Bitplane.DataType Alignment = Bitplane.DataType.Word;

        public int NumInARow = 8;
        public ushort BaseColor = 0x180;
        public byte bpp = 4;
        public Bitplane bitplane = new Bitplane();

        public static PublicVariables instance
        {
            get { 
                if (_instance == null)
                    instance = new PublicVariables();

                return _instance; 
            }
            set { _instance = value; }
        }

        public struct SpriteCutRec
        {
            private int _X2, _Y2;
            public static int ScaleFactor = 1;
            public SpriteCutRec()
            {
                SpriteRec.X = 0;
                SpriteRec.Y = 0;
                _X2 = 0;
                Y2 = 0;

                Width = 0;
                Height = 0;
            }

            public SpriteCutRec(int x, int y, int width, int height)
            {
                X = x; Y = y; Width = width; Height = height;
            }

            public bool Enable { get; set; }
            public int LineWIdth { get; set; } = 4;

            public int X { get => SpriteRec.X; set => SpriteRec.X = value; }
            public int Y { get => SpriteRec.Y; set => SpriteRec.Y = value; }
            public int Width
            {
                get => SpriteRec.Width;
                set
                {
                    SpriteRec.Width = value;
                    X2 = SpriteRec.Width + SpriteRec.X;
                }
            }
            public int Height
            {
                get => SpriteRec.Height;

                set
                {
                    SpriteRec.Height = value;
                    _Y2 = SpriteRec.Height + SpriteRec.Y;
                }
            }

            public int X2
            {
                get => (SpriteRec.X + SpriteRec.Width);
                set { SpriteRec.Width = value - SpriteRec.X; }
            }

            public int Y2
            {
                get => (SpriteRec.Y + SpriteRec.Height);
                set
                {
                    SpriteRec.Height = value - SpriteRec.Y;
                }
            }

            public Rectangle PreviewRec
            {
                get
                {
                    return new Rectangle(X*ScaleFactor, Y*ScaleFactor, Width*ScaleFactor, Height * ScaleFactor);
                }
              
            }

            public bool IsSpriteCut = false;
            public Rectangle SpriteRec;
        };


        /* public PublicVariables()
         { 
             if (instance == null)
                 instance = new PublicVariables();
         }*/
    }
}
