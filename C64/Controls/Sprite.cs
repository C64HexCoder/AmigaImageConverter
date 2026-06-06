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
            SelectedColor = MainColor; // ברירת מחדל לצבע הראשי
        }

        public enum DrawingMode
        {
            Normal,
            Line,
            Rectangle,
            Circle,
            Fill
        }
        private DrawingMode currentDrawingMode = DrawingMode.Normal;

        public struct SpriteColor
        {
            public SpriteColor() { }
            public Color Color
            {
                get { return C64Palette.GetColor(Value); }
                set 
                {
                    Value = C64Palette.MapRGBToC64Index(value);
                }
            }
            private byte value;
            public byte Value
            {
                get { return (byte)Value; }
                set
                {
                    if (Value < 0 || Value > 15)
                        throw new ArgumentOutOfRangeException("Value must be between 0 and 15.");

                    Value = value;
                    Color = C64Palette.GetColor(value);
                }
            }
        }
         
        public SpriteColor MainColor = new SpriteColor();
        public SpriteColor MultiColor1 = new SpriteColor();
        public SpriteColor MainColor2 = new SpriteColor();

        private SpriteColor SelectedColor = new SpriteColor();

        public void SetDrawingMode(DrawingMode mode)
        {
            currentDrawingMode = mode;
        }

        public void SetSelectedColor(SpriteColor color)
        {
            SelectedColor = color;
        }

        public void SetSelectedColor(byte colorValue)
        {
            SelectedColor.Value = colorValue;
        }

        public void SetSelectedColor(Color color)
        {
            SelectedColor.Color = color;
        }

        public void SetMainColor(byte colorValue)
        {
            MainColor.Value = colorValue;
        }

        public void SetMultiColor1(byte colorValue)
        {
            MultiColor1.Value = colorValue;
        }
        public void SetMainColor2(byte colorValue)
        {
            MainColor2.Value = colorValue;
        }

        public void SetMainColor(Color color)
        {
            MainColor.Color = color;
        }

        public void SetMultiColor1(Color color)
        {
            MultiColor1.Color = color;
        }

        public void SetMainColor2(Color color)
        {
            MainColor2.Color = color;
        }

        public void SetMainColor(SpriteColor color)
        {
            MainColor = color;
        }

        public void SetMultiColor1(SpriteColor color)
        {
            MultiColor1 = color;
        }

        public void SetMainColor2(SpriteColor color)
        {
            MainColor2 = color;
        }

        public void SetSpriteData(byte[] data)
        {
            if (data.Length != 64)
                throw new ArgumentException("Sprite data must be exactly 64 bytes long.");
            SpriteData = data;
            Invalidate(); // Redraw the control to reflect changes
        }

        public byte[] GetSpriteData()
        {
            return SpriteData;
        }

        public void SetSpriteColors(byte mainColorValue, byte multiColor1Value, byte mainColor2Value)
        {
            SetMainColor(mainColorValue);
            SetMultiColor1(multiColor1Value);
            SetMainColor2(mainColor2Value);
            Invalidate(); // Redraw the control to reflect changes
        }

        public void SetSpriteColors(Color mainColor, Color multiColor1, Color mainColor2)
        {
            SetMainColor(mainColor);
            SetMultiColor1(multiColor1);
            SetMainColor2(mainColor2);
            Invalidate(); // Redraw the control to reflect changes
        }

        public void SetSpriteColors(SpriteColor mainColor, SpriteColor multiColor1, SpriteColor mainColor2)
        {
            SetMainColor(mainColor);
            SetMultiColor1(multiColor1);
            SetMainColor2(mainColor2);
            Invalidate(); // Redraw the control to reflect changes
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

        private Point? lineStartPoint = null;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            int cellX = e.X / CellWidthHeight;
            int cellY = e.Y / CellWidthHeight;

            if (currentDrawingMode != DrawingMode.Normal)
            {
                // Handle other drawing modes (Line, Rectangle, Circle, Fill) here
                // This is a placeholder for future implementation
                switch(currentDrawingMode)
                {
                    case DrawingMode.Line:
                        // Implement line drawing logic
                        lineStartPoint = new Point(cellX, cellY);
                        break;
                    case DrawingMode.Rectangle:
                        // Implement rectangle drawing logic
                        break;
                    case DrawingMode.Circle:
                        // Implement circle drawing logic
                        break;
                    case DrawingMode.Fill:
                        // Implement fill drawing logic
                        break;
                    }
                    return;
            }
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

            System.Drawing.Graphics g = CreateGraphics();

            if (e.Button == MouseButtons.Left)
            {
                int cellX = e.X / CellWidthHeight;
                int cellY = e.Y / CellWidthHeight;
                if ((currentDrawingMode != DrawingMode.Normal))
                    {
                    switch (currentDrawingMode)
                    {
                        case DrawingMode.Line:
                            if (lineStartPoint.HasValue)
                            {
                                // Implement line drawing logic based on lineStartPoint and current mouse position
                                //g.DrawLine(Pens.Red, lineStartPoint.Value.X * CellWidthHeight, lineStartPoint.Value.Y * CellWidthHeight, cellX * CellWidthHeight, cellY * CellWidthHeight);
                            }
                            break;
                    }
                }
                else {
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
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (currentDrawingMode == DrawingMode.Line)
            {
                // Draw the final line based on the starting point and the current mouse position into the SpriteData
                int X = e.X / CellWidthHeight;
                int Y = e.Y / CellWidthHeight;
                if (IsMulticolor)
                {
                    X /= 2; // In multicolor mode, each cell is effectively 2 pixels wide
                }
                

                lineStartPoint = null; // Reset line start point after drawing
            }
        }

        private void UpdateSpriteDataFromGrid()
        {
            // This method can be used to update the SpriteData array based on the current state of the grid
            // It can be called after drawing operations to ensure SpriteData is in sync with the visual representation

            
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
