using System.ComponentModel;

namespace Retro
{
    public partial class ColorBox : UserControl
    {
        public ColorBox()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color color
        {
            get
            {
                return BackColor;
            }
            set
            {
                BackColor = value;
                ushort colr4bitRgb = (ushort)((int)(BackColor.R >> 4) << 8 | (int)(BackColor.G >> 4) << 4 | (int)(BackColor.B >> 4));
                RGBDispLbl.Text = colr4bitRgb.ToString("X3");
                // RGBDispLbl.ForeColor = Color.FromArgb(0xff^BackColor.R,0xFF^BackColor.G,0xFF ^ BackColor.B);
                RGBDispLbl.ForeColor = Color.White;
            }
        }

        private void RGBDispLbl_MouseClick(object sender, MouseEventArgs e)
        {
            Label textBox = (Label)sender;
            Parent.Invoke(OnMouseClick, e);
        }

      

        [Category("Color Box"), Description("Set to true to draw a border around the color box.")]
        private bool setBorder;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool SetBorder
        {
            get
            {
                return setBorder;
            }
            set
            {
                setBorder = value;
                if (!DesignMode)
                        Invalidate();
            }
        }

        [Category("Color Box"), Description("Set the width of the border around the color box.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BorderWidth
        {
            get
            {
                return Padding.All;
            }
            set
            {
                Padding = new Padding(value);
                Invalidate();
            }
        }

        private Color borderColor = Color.Green;

        [Category("Color Box"), Description("Set the color of the border around the color box.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor
        {
            get {
                return borderColor;
            }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (DesignMode)
            {
                e.Graphics.DrawRectangle(Pens.Gray, 0, 0, Width - 1, Height - 1);
                return;
            }

            if (SetBorder)
            {
                using (var pen = new Pen(BorderColor, BorderWidth))
                    e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            }
        }

    }
}
