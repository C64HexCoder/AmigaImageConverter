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
  
    public partial class ColorSelector : UserControl
    {
        private byte _c64ColorIndex = 0;
        ColorSelectorEventArgs colorSelectorEventArgs;
        public ColorSelector()
        {
            InitializeComponent();
            Cursor = Cursors.Hand;
        }



        [Category ("C64 Properties"), Description("The index of the color in the C64 palette (0-15)")]
        public byte C64ColorIndex
        {
            get => _c64ColorIndex;

            set 
            {
                if (_c64ColorIndex != value && value >= 0 && value < 16)
                {
                    _c64ColorIndex = value;

                    BackColor = C64Palette.GetColor(_c64ColorIndex);
                    Invalidate();
                }
            }

        }

        [Category ("C64 Events"), Description("Fires when the color selector is clicked")]
        public event EventHandler<ColorSelectorEventArgs> ColorSelectorClicked;

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, Width - 1, Height - 1);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            if (e.Button == MouseButtons.Right)
            {
                ColorDialog colorDialog = new ColorDialog
                {
                    AllowFullOpen = true,
                    FullOpen = true,
                    Color = BackColor
                };
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    C64ColorIndex = C64Palette.MapRGBToC64Index(colorDialog.Color);
                }
                // Handle right-click event if needed
            }
            else
            {
                colorSelectorEventArgs = new ColorSelectorEventArgs(_c64ColorIndex);
                ColorSelectorClicked?.Invoke(this, colorSelectorEventArgs);
            }
        }

    }

    public class ColorSelectorEventArgs : EventArgs
    {
        public byte C64ColorIndex { get; }
        public ColorSelectorEventArgs(byte c64ColorIndex)
        {
            C64ColorIndex = c64ColorIndex;
        }
    }
}
