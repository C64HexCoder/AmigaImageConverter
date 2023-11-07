using Amiga;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigaImageConverter
{
    public partial class AudioSamleEditorDialog : Form
    {
        Graphics gfx;
        public sbyte[] Sameples;

        bool IsDataSigned = true;

        MemoryStream WAVStream;
        WAV wav = new WAV();

        public AudioSamleEditorDialog()
        {
            InitializeComponent();
            gfx = GraphPicBox.CreateGraphics();
            ChanelComboBox.SelectedIndex = 0;

        }

        public AudioSamleEditorDialog(sbyte[] sameples)
        {
            InitializeComponent();
            gfx = GraphPicBox.CreateGraphics();
            ChanelComboBox.SelectedIndex = 0;
            Sameples = sameples;



            IsDataSigned = true;

        }

        public AudioSamleEditorDialog(byte[] sameples)
        {
            InitializeComponent();
            gfx = GraphPicBox.CreateGraphics();
            ChanelComboBox.SelectedIndex = 0;
            IsDataSigned = false;

            Sameples = new sbyte[sameples.Length];

            for (int i = 0; i < sameples.Length; i++)
            {
                Sameples[i] = (sbyte)sameples[i];
            }
        }

        private void AudioSamleEditorDialog_Paint(object sender, PaintEventArgs e)
        {

            int XaxisZero = 55, YaxisZero = GraphPicBox.Height / 2;
            int graphLength = GraphPicBox.Width - XaxisZero;
            int Amplituda = (GraphPicBox.Height / 2 - 20) / 127;


            System.Drawing.Font font = new System.Drawing.Font("Ariel", 12);
            SolidBrush fontBrush = new SolidBrush(Color.Red);
            int GraphWidth = comboBoxWaveform.Left - Left;
            //gfx = e.Graphics;
            int Hight = this.Bounds.Height;
            Pen linePen = new Pen(Color.Black, 4);
            Pen samplePen = new Pen(Color.Green, 4);
            // Horizontal center line
            gfx.DrawLine(linePen, 55, GraphPicBox.Height / 2, GraphPicBox.Width, GraphPicBox.Height / 2);
            //Vertical Lines
            gfx.DrawLine(linePen, 55, 20, 55, GraphPicBox.Height - 20);
            // Draw Shanatot
            gfx.DrawLine(linePen, 45, 20, 55, 20); //  127
            gfx.DrawString("127", font, fontBrush, new PointF(0, font.Height / 2));

            gfx.DrawLine(linePen, 45, GraphPicBox.Height / 2, 55, GraphPicBox.Height / 2); //  127
            gfx.DrawString("0", font, fontBrush, new PointF(10, GraphPicBox.Height / 2 - font.Height / 2));


            gfx.DrawLine(linePen, 45, GraphPicBox.Height - 20, 55, GraphPicBox.Height - 20); //  127
            gfx.DrawString("-127", font, fontBrush, new PointF(0, GraphPicBox.Height - 20 - font.Height / 2));

            //Console.Beep();

            if (Sameples != null)
            {
                int graphStep = graphLength / Sameples.Length;
                for (int i = 0; i < Sameples.Length; i++)
                {
                    gfx.DrawEllipse(samplePen, new Rectangle((XaxisZero + graphStep * i) - 5, (YaxisZero - ((Sameples[i] * Amplituda))) - 5, 10, 10));
                }

            }
            //gfx.Dispose();

        }

        private void numericNumOfSamples_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxWaveform_SelectedIndexChanged(object sender, EventArgs e)
        {
            Endian endian = new Endian();
            if (comboBoxWaveform.SelectedIndex == 0)
            {
                gfx.Clear(Color.Gray);
                Sameples = new sbyte[(int)numericNumOfSamples.Value];
                //Samples16bit = new short[(int)(numericNumOfSamples.Value)];

                float step = (float)((2 * Math.PI) / (float)numericNumOfSamples.Value);
                int idx = 0;
                for (float i = 0; i < 2 * Math.PI; i += step)
                {
                    double sinRes = Math.Sin(i) * 127;
                    Sameples[idx] = Convert.ToSByte(sinRes);
                    //Samples16bit[idx] = Convert.ToInt16(sinRes);
                    idx++;
                }
                Refresh();
                wav.WriteWAV(Sameples, 44100, 8);
            }
        }

        private void GraphPicBox_MouseHover(object sender, EventArgs e)
        {
            Point MousePos = MousePosition;
            Point ClientMousePos = PointToClient(MousePos);

            if (Sameples != null)
            {
                for (int i = 0; i <= Sameples.Length; i++)
                {
                    // go over the array of samples position on the graph and lit the cursor if on one of them
                }
            }

        }
    }
}
