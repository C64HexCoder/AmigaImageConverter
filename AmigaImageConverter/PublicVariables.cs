using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public int imageScalingFactoer = 0;

        public Bitplane.DataType outputSize = Bitplane.DataType.Word;
        public Bitplane.DataType Alignment = Bitplane.DataType.Word;

        public int NumInARow = 8;
        public ushort BaseColorRegister = 0x180;
        public byte bpp = 4;
        public Bitplane bitplane = new Bitplane();
        public CutRec spriteRec;
        public Sprite[] Sprites = new Sprite[100];

        public static PublicVariables instance
        {
            get { 
                if (_instance == null)
                    instance = new PublicVariables();

                return _instance; 
            }
            set { _instance = value; }
        }

        public struct CutRec
        {
            private int _X2, _Y2;
            public static int ScaleFactor = 1;
            public CutRec()
            {
                Bounds.X = 0;
                Bounds.Y = 0;
                _X2 = 0;
                Y2 = 0;

                Width = 0;
                Height = 0;
            }

            public CutRec(int x, int y, int width, int height)
            {
                X = x; Y = y; Width = width; Height = height;
            }

            public bool Enable { get; set; }
            public int LineWIdth { get; set; } = 4;

            public int X { get => Bounds.X; set => Bounds.X = value; }
            public int Y { get => Bounds.Y; set => Bounds.Y = value; }
            public int Width
            {
                get => Bounds.Width;
                set
                {
                    Bounds.Width = value;
                    X2 = Bounds.Width + Bounds.X;
                }
            }
            public int Height
            {
                get => Bounds.Height;

                set
                {
                    Bounds.Height = value;
                    _Y2 = Bounds.Height + Bounds.Y;
                }
            }

            public int X2
            {
                get => (Bounds.X + Bounds.Width);
                set { Bounds.Width = value - Bounds.X; }
            }

            public int Y2
            {
                get => (Bounds.Y + Bounds.Height);
                set
                {
                    Bounds.Height = value - Bounds.Y;
                }
            }

            public Rectangle PreviewRec
            {
                get
                {
                    return new Rectangle(X*ScaleFactor, Y*ScaleFactor, Width*ScaleFactor, Height * ScaleFactor);
                }
              
            }


            public void SetZoomedBounds (int x,int y,int width,int height)
            {
                X = x / ScaleFactor;
                Y = y / ScaleFactor;
                Width = Width / ScaleFactor;
                Height = Height / ScaleFactor;
            }

            public Bitmap CutImage ()
            {
                Bitmap cutBitmap = new Bitmap(Width/ScaleFactor,Height/ScaleFactor);

                return cutBitmap;
            }

            public bool IsSpriteCut = false;
            public Rectangle Bounds;
        };


        /* public PublicVariables()
         { 
             if (instance == null)
                 instance = new PublicVariables();
         }*/
    }
}
