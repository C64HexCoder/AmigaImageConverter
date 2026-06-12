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
        public ISpriteColorProvider colorProvider;

        public ISpriteColorProvider ColorProvider
        {
            get { return colorProvider; }
            set
            {
                colorProvider = value;
                //colorProvider.ColorChanged += (s, e) => Invalidate(); // Redraw the control to reflect changes in color provider
                colorProvider.ColorChanged += HandleOnColorChanged; // Subscribe to the ColorChanged event of the color provider
                Invalidate();
            }
        }

        public void HandleOnColorChanged(object sender, EventArgs e)
        {
            Invalidate(); // Redraw the control to reflect changes in color provider
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

       
         
        public byte MainColor = 4;
        public byte MultiColor1 = 2;
        public byte MainColor2 = 3;

        private byte SelectedColor
        {
            get
            {
                if (ColorProvider != null)
                {
                    return (byte)ColorProvider.SelectedSlotIndex;
                }
                else
                {
                    return MainColor; // ברירת מחדל לצבע הראשי אם אין ספק צבעים
                }
            }
        }

        internal Color GetColorFromIndex(byte colorIndex)
        {
            if (colorProvider != null)
            {
                return colorProvider.GetColorForSlot(colorIndex);
            }
            else
            {
                switch (colorIndex)
                {
                    case 0:
                        return Color.Transparent;
                        break;
                    case 1:
                        return Color.Green;
                        break;
                    case 2:
                        return Color.Blue;
                        break;
                    default:
                        return Color.Magenta; // צבע ברירת מחדל עבור אינדקסים לא מוכרים
           
                }
            }
        }
        // 2. החיבור האוטומטי: קורה מעצמו בזמן שהתוכנה עולה
        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            // אם ה-ColorProvider עדיין לא קושר ידנית ב-Properties, והתוכנה רצה כרגע (לא ב-Designer)
            if (colorProvider == null && !DesignMode && FindForm() != null)
            {
                // סורקים את כל הפקדים בטופס ומחפשים מישהו שמממש את ה-Interface שלנו
                foreach (Control ctrl in FindForm().Controls)
                {
                    if (ctrl is ISpriteColorProvider palette)
                    {
                        // מצאנו! משדכים אוטומטית
                        ColorProvider = palette;
                        break; // מצאנו אחד, מספיק טוב
                    }
                }
            }
        }
        public void SetDrawingMode(DrawingMode mode)
        {
            currentDrawingMode = mode;
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


        public byte[] SpriteData { get; set; } = new byte[64];

        private byte cellWidthHeight = 20;
        private byte MultiColorCellWidth;

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
                MultiColorCellWidth = (byte)(CellWidthHeight * 2);

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


            if (IsMulticolor)
            {
                for (int y = 0; y < 21; y++)
                    for (int x = 0; x < 12; x++)
                    {
                        byte mColor = (byte)(SpriteData[y * 3 + x / 4] & (3 << (6 - ((x % 4)*2 ))));
                        mColor >>= (6 - ((x % 4) * 2)); // Shift the color bits to the rightmost position
                        Brush brush = new SolidBrush(GetColorFromIndex(mColor));
                        e.Graphics.FillRectangle(brush, x * MultiColorCellWidth, y * CellWidthHeight, MultiColorCellWidth, CellWidthHeight);


                    }
            }
            else
            {
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
                            Brush brush = new SolidBrush(GetColorFromIndex(2));
                            e.Graphics.FillRectangle(brush, drawX * CellWidthHeight, cellY * CellWidthHeight, CellWidthHeight, CellWidthHeight);
                        }
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

                byte mColor = (byte)(SelectedColor << (6 - ((cellX % 4)*2 ))); // Shift the selected color to the correct position
                //byte mColor = (byte)(SelectedColor << (6 - ((cellX % 4) * 2))); // Shift the selected color to the correct position
                //mColor = (byte)(3 << (6 - ((cellX % 4) * 2))); // Mask to ensure only the relevant bits are affected
                byte earaseMask = (byte)~(3 << (6 - ((cellX % 4) * 2))); // Mask to clear the existing color bits for this cell
                SpriteData[cellY * 3 + (cellX / 4)] &= earaseMask; // Clear the existing color bits for this cell
                SpriteData[cellY * 3 + (cellX / 4)] |= (byte)mColor; // Toggle the color bits]
                Invalidate(); // Redraw the control to reflect changes

            }
            else
            {
                int byteIndex = cellY * 3 + (cellX / 8);
                int bitIndex = 7 - (cellX % 8);
                if (byteIndex < SpriteData.Length)
                {
                    SpriteData[byteIndex] ^= (byte)(1 << bitIndex); // Toggle the bit
                    Invalidate(); // Redraw the control to reflect changes
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.X >= this.Width || e.Y >= this.Height || e.X < 0 || e.Y < 0)
                return; // Prevent drawing outside the control bounds


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

                        if (cellX  < 0 || cellX >= 12 || cellY < 0 || cellY >= 21)
                            return; // Prevent drawing outside the control bounds

                        byte mColor = (byte)(SelectedColor << (6 - ((cellX % 4) * 2))); // Shift the selected color to the correct position
                        byte earaseMask = (byte)~(3 << (6 - ((cellX % 4) * 2))); // Mask to clear the existing color bits for this cell
                        SpriteData[cellY * 3 + (cellX / 4)] &= earaseMask; // Clear the existing color bits for this cell
                        SpriteData[cellY * 3 + (cellX / 4)] |= (byte)mColor; // Toggle the color bits]
                        Invalidate(); // Redraw the control to reflect changes

  
                    }
                    else
                    {
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

    class SpriteSelectorEventArgs : EventArgs
    {
        public byte ColorIndex { get; }
        public SpriteSelectorEventArgs(byte colorIndex)
        {
            ColorIndex = colorIndex;
        }
    }
}
