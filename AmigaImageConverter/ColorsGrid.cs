using Amiga;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigaImageConverter
{
    public partial class ColorsGrid : UserControl
    {
       
        public int _NumOfColors = 4;
        public Color[] Colors = new Color[256];
        // 0 1 2 3 4  5  6  7
        byte[] Yarray = { 1, 2, 2, 4, 4, 8, 8, 16, 16 };
        byte[] Xarray = { 1, 1, 2, 2, 4, 4, 8, 8, 16 };
        public Color _SelectedColor;
        public int SelectedColorARGB;
        public byte _SelectedColorIdx = 0;

        int[] ColorDialogCustomColors;
        private bool _SelectedColorBox = false;
        int NumOfCellsX;
        int NumOfCellsY;

        public enum PaletteFormat
        {
            TwelveBit,
            TwentyFour
        }

        [Description("Select 12 or 24 bit Paletter")]
        public PaletteFormat paletteFormat { get; set; }
 

        public event EventHandler<SelectedColorEventArgs> ColorSelected;

        public class SelectedColorEventArgs : EventArgs
        {
            public Color Color;
            public int colorIndex;
        }

        protected virtual void OnColorSelected(SelectedColorEventArgs e)
        {
            EventHandler<SelectedColorEventArgs> eventHandler = ColorSelected;

            if (eventHandler != null)
            {
                eventHandler(this, e);
            }
        }



        public int NumOfColors
        {
            get { return _NumOfColors; }
            set
            {
                _NumOfColors = value;
                colorPanel.Controls.Clear();
                colorPanel.Refresh();
            }
        }


        public ColorsGrid()
        {
            InitializeComponent();
            Random rnd = new Random();



            for (int i = 0; i < NumOfColors; i++)
            {
                Colors[i] = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            }

        }

        private void colorPanel_Resize(object sender, EventArgs e)
        {

            Panel panel = ((Panel)sender);
            panel.Controls.Clear();

            panel.Invalidate();
        }

    
        private void selectedColorPb_Resize(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            //  idxNum.Top = pb.Top + (int)(pb.Height - idxNum.Height)/2;
            //   idxNum.Left = pb.Left+ (int)(pb.Width - idxNum.Width) / 2;
        }


        private void colorPanel_Paint(object sender, PaintEventArgs e)
        {
            int margim = 0;
            //int RawAndClomn = (int)Math.Sqrt(NumOfColors);
            int index = (int)(Math.Log(NumOfColors) / Math.Log(2));
            NumOfCellsX = Xarray[index];
            NumOfCellsY = Yarray[index];

            for (int y = 0; y < NumOfCellsY; y++)
            {
                for (int x = 0; x < NumOfCellsX; x++)
                {
                    ColorBox pictureBox = new ColorBox();
                    pictureBox.Size = new Size(colorPanel.Width / NumOfCellsX - margim, colorPanel.Height / NumOfCellsY - margim);
                    pictureBox.color = Colors[y * (NumOfCellsX) + x];
                    pictureBox.MouseClick += ColorMouseClick;
                    pictureBox.BorderStyle = BorderStyle.FixedSingle;
                    pictureBox.Tag = y * NumOfCellsX + x;
                    pictureBox.Location = new Point(colorPanel.Width / NumOfCellsX * x + margim, colorPanel.Height / NumOfCellsY * y + margim);

                    ControlPaint.DrawBorder(e.Graphics, pictureBox.ClientRectangle, Color.Blue, ButtonBorderStyle.Solid);
                    ((Panel)sender).Controls.Add(pictureBox);
                }
            }
        }

        private void ColorMouseClick(object? sender, MouseEventArgs e)
        {

            ColorBox pickedColor = (ColorBox)sender;
            byte index = byte.Parse(pickedColor.Tag.ToString());

            if (e.Button == MouseButtons.Right && !(pickedColor.Tag.ToString() == "0"))
            {
                ColorDialog colorDialog = new ColorDialog();

                if (ColorDialogCustomColors != null)
                    colorDialog.CustomColors = ColorDialogCustomColors;

                colorDialog.Color = pickedColor.BackColor;
                colorDialog.FullOpen = true;
                colorDialog.AnyColor = true;
                colorDialog.SolidColorOnly = false;
                colorDialog.ShowDialog();
                ColorDialogCustomColors = colorDialog.CustomColors;
                // Color3P.BackColor = colorDialog.Color;
                pickedColor.BackColor = colorDialog.Color;

                Colors[int.Parse(pickedColor.Tag.ToString())] = pickedColor.BackColor;
                //Colors[int.Parse((pictureBox.Tag.ToString()))] = pictureBox.BackColor;

            }



            SelectedColorEventArgs args = new SelectedColorEventArgs();
            args.colorIndex = index;

            OnColorSelected(args);
        }

        public void SetPalette(Color[] palette)
        {
            NumOfColors = palette.Length;
            Colors = palette;
            _SelectedColorIdx = 0;
        }

        public byte FindColorInPallate(Color color)
        {
            byte i = 0;
            while (i < NumOfColors && Colors[i].ToArgb() != color.ToArgb())
            {
                i++;
            }
            return i;

        }


        private void Pallate_Enter(object sender, EventArgs e)
        {

            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.Play();
        }

        private void DrawBorder(ColorBox pb, Color color, int BorderWidth)
        {
            Graphics g = pb.CreateGraphics();
            Pen pen = new Pen(color, BorderWidth);
            g.DrawRectangle(pen, pb.ClientRectangle);
            g.Dispose();
        }

        private void RemoveBorder(ColorBox pictureBox)
        {
            Graphics g = pictureBox.CreateGraphics();
            g.Clear(System.Drawing.SystemColors.Control);
        }

        private void Pallate_Load(object sender, EventArgs e)
        {

        }
    }

}
