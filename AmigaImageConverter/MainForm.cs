using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amiga;


namespace AmigaImageConverter
{
    public partial class MainForm : Form
    {
        Bitmap bmp = null;
        Endian endian = new Endian();
       
        Settings settings = new Settings();
        About about = new About();
        Pallate pallate = new Pallate();
        PublicVariables vr = PublicVariables.instance;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                toolStripFileName.Text = openFileDialog.FileName;
                bmp = new Bitmap(openFileDialog.FileName);
                image.Load(openFileDialog.FileName);
                image.ScaleImage((int)settings.previewScalingNud.Value);
                
                
  
                vr.bitplane.LoadImage(openFileDialog.FileName);
                CheckImageAlignment();

                if (vr.bitplane.Width > Width || vr.bitplane.Height > Height)
                {
                    Width = vr.bitplane.Width + 20;
                    Height = vr.bitplane.Height + menuStrip1.Height + statusStrip.Height + 60;
                }
                toolStripFileName.Text = openFileDialog.FileName;
                toolStripResolutionLabel.Text = $"{vr.bitplane.Width}x{vr.bitplane.Height}";
                toolStripDepthLabel.Text = $"{vr.bitplane.NumOfBitmaps} Bitmaps, new Width: {vr.bitplane.actualWidth}";

                switch (image.Image.PixelFormat)
                {
                    case System.Drawing.Imaging.PixelFormat.Format64bppArgb:
                    case System.Drawing.Imaging.PixelFormat.Format32bppArgb:
                    case System.Drawing.Imaging.PixelFormat.Format24bppRgb:

                        break;

                    case System.Drawing.Imaging.PixelFormat.Format4bppIndexed:
                        break;

                    case System.Drawing.Imaging.PixelFormat.Format1bppIndexed:
                        break;

                }
            }
        }

        private void saveImageAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        if (settings.sequentialRB.Checked == true)
                            vr.bitplane.SaveBitmapsAsAssemblerSourceCode(saveFileDialog.FileName,vr.outputSize,vr.NumInARow);
                        else
                            vr.bitplane.SaveBitmapsAsInterleavedAssemblerSourceCode(saveFileDialog.FileName,vr.outputSize,vr.NumInARow);
                        break;
                    case 2:
                        if (settings.sequentialRB.Checked == true)
                            vr.bitplane.SaveBitmapsAsBinaryFile(saveFileDialog.FileName);
                        else
                            vr.bitplane.SaveBitmapsAsInterleavedBinaryFile(saveFileDialog.FileName);
                        break;
                    case 3:
                        if (settings.sequentialRB.Checked == true)
                            vr.bitplane.SaveBitmapsAsCPPSourceCode(saveFileDialog.FileName, vr.outputSize,vr.NumInARow);
                        else
                            vr.bitplane.SaveBitmapsAsInterleavedCPPSourceCode(saveFileDialog.FileName, vr.outputSize,vr.NumInARow);
                        break;
                }
            }
        }

      private void CheckImageAlignment ()
        {

            switch (vr.bitplane.CheckImageAlignment())
            {
                case Bitplane.Alignment.DoubleLong:
                    alignWidthComboBox.SelectedIndex = 3;
                    break;
                case Bitplane.Alignment.Long:
                    alignWidthComboBox.SelectedIndex = 2;
                    break;
                case Bitplane.Alignment.Word: 
                    alignWidthComboBox.SelectedIndex = 1;
                    break;

                default:
                    alignWidthComboBox.SelectedIndex = 0;
                    break;
            }
 
        }

        private void settingsMenuItem_Click(object sender, EventArgs e)
        {
            if (settings.ShowDialog() == DialogResult.OK)
            {
                if (settings.valueChanged == true) {
                    image.Image = vr.bitplane.bmp;
                    image.ScaleImage((int)settings.previewScalingNud.Value);
                }
            }
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            about.ShowDialog();
        }

        private void savePallateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog pallateFileDialog = new SaveFileDialog();
            pallateFileDialog.Filter = "Assembler Source|*.S";
            if (pallateFileDialog.ShowDialog() == DialogResult.OK)
            {
                vr.bitplane.SavePallate(pallateFileDialog.FileName, vr.BaseColor);
            }
        }

        private void cutSpriteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pallateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ColorPalette colorPalette = bitplane.Pallate;
            if (vr.bitplane.Pallate != null)
            {
                pallate.imagePallate.SetPalette(vr.bitplane.Pallate);
                pallate.ShowDialog();
            }
            else
                MessageBox.Show("There is no pallate yet, try to load image first, or that the image you've loaded has no Pallate.", "Pallate Error",MessageBoxButtons.OK);
        }

        private void selectBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectBackgroundColor selectBGColor = new SelectBackgroundColor();
            selectBGColor.pallete.NumOfColors = vr.bitplane.Pallate.Length;
            selectBGColor.pallete.Colors = vr.bitplane.Pallate;
            selectBGColor.ShowDialog();
        }


        private void image_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Image OriginalImage = image.Image;
        }


        private void autoCorpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point StartPos = new Point(vr.bitplane.bmp.Width, vr.bitplane.Height), StopPos = new Point (0,0);

            for (int y = vr.bitplane.Height-1; y>=0;y--)
                for (int x = vr.bitplane.Width-1;x>=0;x--)
                {
                    Color pixel = vr.bitplane.bmp.GetPixel(x, y),backgroundColor = vr.bitplane.Pallate[0];
                    if ( pixel.R != backgroundColor.R || pixel.G != backgroundColor.G || pixel.B != backgroundColor.B)
                    {
                        if (x < StartPos.X)
                            StartPos.X = x;

                        if (y < StartPos.Y)
                            StartPos.Y = y;

                        if (x > StopPos.X) StopPos.X = x;
                        if (y > StopPos.Y) StopPos.Y = y;
                    }
                }

            int NewWidth = StopPos.X - StartPos.X+1, NewHeight = StopPos.Y - StartPos.Y+1;
            Bitmap corpedImage = new Bitmap (NewWidth,NewHeight);
            
            Graphics g = Graphics.FromImage(corpedImage);
            Rectangle destRec = new Rectangle(0,0,NewWidth,NewHeight);
            g.DrawImage(bmp,destRec, StartPos.X, StartPos.Y, NewWidth, NewHeight,GraphicsUnit.Pixel);
           
            
            g.Dispose();
            vr.bitplane.bmp= corpedImage;

            image.Image = vr.bitplane.bmp;
            image.ScaleImage((int)settings.previewScalingNud.Value);

            CheckImageAlignment();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm ImageInfo = new InfoForm();
            ImageInfo.Show();
        }

        private void alignWidthComboBox_DropDownClosed(object sender, EventArgs e)
        {

            ToolStripComboBox alignmentCB = (ToolStripComboBox)sender;

            switch (alignmentCB.SelectedIndex)
            {
                //case 0:
                //    vr.bitplane.AlienWidth ()
                //  break; 
                case 1:
                    vr.bitplane.AlienWidth(Bitplane.Alignment.Word);
                    break;
                case 2:
                    vr.bitplane.AlienWidth(Bitplane.Alignment.Long);
                    break;
                case 3:
                    vr.bitplane.AlienWidth(Bitplane.Alignment.DoubleLong);
                    break;


            }
            image.Image = vr.bitplane.bmp;
            image.ScaleImage((int)settings.previewScalingNud.Value);
        }
    }
}
