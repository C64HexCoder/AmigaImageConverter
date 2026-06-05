using C64.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C64.Controls
{
    public partial class Sprite : UserControl
    {
        public Sprite()
        {
            InitializeComponent();
            DoubleBuffered = true; // להפחית ריצודים בעת הציור
        }

        public enum DrawingMode
        {
            Normal,
            Line,
            Rectangle,
            Circle,
            Fill
        }

        public byte[] SpriteData { get; set; } = new byte[64];

        private byte cellWidthHeight = 20;
        [Category("Grid"), Description("The width and height of each cell in pixels.")]
        public byte CellWidthHeight
        {
            get
            {
                return cellWidthHeight;
            }
            set
            {
                cellWidthHeight = value;
                Invalidate();
            }
        }

        private bool isMulticolor = false;
        [Category("Sprite"), Description("Determines whether the sprite is multicolor or not.")]
        public bool IsMulticolor
        {
            get
            {
                return isMulticolor;
            }
            set
            {
                isMulticolor = value;
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Pen borderPen = new Pen(Color.Black, 2);

            e.Graphics.FillRectangle(Brushes.White, 0, 0, 24 * CellWidthHeight, 21 * CellWidthHeight);
            //e.Graphics.DrawRectangle(borderPen, 0 , 0 , 24 * CellWidthHeight, 21 * CellWidthHeight);

            if (!IsMulticolor)
            {
                for (int x = 0; x < 24; x++)
                {
                    e.Graphics.DrawLine(Pens.Black, x * CellWidthHeight, 0, x * CellWidthHeight, 21 * CellWidthHeight);
                }
                e.Graphics.DrawLine(Pens.Black, 24 * CellWidthHeight, 0, 24 * CellWidthHeight, 21 * CellWidthHeight);

                for (int y = 0; y < 21; y++)
                {
                    e.Graphics.DrawLine(Pens.Black, 0, y * CellWidthHeight, 24 * CellWidthHeight, y * CellWidthHeight);
                }
                e.Graphics.DrawLine(Pens.Black, 0, 21 * CellWidthHeight, 24 * CellWidthHeight, 21 * CellWidthHeight);
            }
            else
            {
                for (int x = 0; x < 12; x++)
                {

                    e.Graphics.DrawLine(Pens.Black, x * CellWidthHeight * 2, 0, x * CellWidthHeight * 2, 21 * CellWidthHeight);
                }
                e.Graphics.DrawLine(Pens.Black, 12 * CellWidthHeight * 2, 0, 12 * CellWidthHeight * 2, 21 * CellWidthHeight);

                for (int y = 0; y < 21; y++)
                {
                    e.Graphics.DrawLine(Pens.Black, 0, y * CellWidthHeight, 24 * CellWidthHeight, y * CellWidthHeight);
                }
                e.Graphics.DrawLine(Pens.Black, 0, 21 * CellWidthHeight, 24 * CellWidthHeight, 21 * CellWidthHeight);
            }
            Width = 24 * CellWidthHeight + 1;
            Height = 21 * CellWidthHeight + 1;
            for (int i = 0; i < SpriteData.Length; i++)
            {
                byte dataByte = SpriteData[i];
                int cellX = (i % 3) * 8;
                int cellY = i / 3;
                for (int bit = 0; bit < 8; bit++)
                {
                    if ((dataByte & (1 << (7 - bit))) != 0)
                    {
                        int drawX = cellX + bit;
                        if (IsMulticolor)
                        {
                            drawX /= 2; // In multicolor mode, each cell is effectively 2 pixels wide
                        }
                        e.Graphics.FillRectangle(Brushes.Black, drawX * CellWidthHeight, cellY * CellWidthHeight, CellWidthHeight, CellWidthHeight);
                    }
                }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            int cellX = e.X / CellWidthHeight;
            int cellY = e.Y / CellWidthHeight;
            if (IsMulticolor)
            {
                cellX /= 2; // In multicolor mode, each cell is effectively 2 pixels wide
            }
            int byteIndex = cellY * 3 + (cellX / 8);
            int bitIndex = 7 - (cellX % 8);
            if (byteIndex < SpriteData.Length)
            {
                SpriteData[byteIndex] ^= (byte)(1 << bitIndex); // Toggle the bit
                Invalidate(); // Redraw the control to reflect changes
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                int cellX = e.X / CellWidthHeight;
                int cellY = e.Y / CellWidthHeight;
                if (IsMulticolor)
                {
                    cellX /= 2; // In multicolor mode, each cell is effectively 2 pixels wide
                }
                int byteIndex = cellY * 3 + (cellX / 8);
                int bitIndex = 7 - (cellX % 8);
                if (byteIndex < SpriteData.Length)
                {
                    SpriteData[byteIndex] |= (byte)(1 << bitIndex); // Set the bit
                    Invalidate(); // Redraw the control to reflect changes
                }
            }
        }

        public void ClearSprite()
        {
            for (int i = 0; i < SpriteData.Length; i++)
            {
                SpriteData[i] = 0;
            }
            Invalidate(); // Redraw the control to reflect changes
        }
    }
}
