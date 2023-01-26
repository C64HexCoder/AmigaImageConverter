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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
        Panel ButtomPanel = new Panel();
        public MainForm()
        {
            InitializeComponent();
            SlicingPanel.Visible= false;
            
            ButtomPanel.Size = new Size(image.Width, statusStrip.Height);
            ButtomPanel.Top = image.Bottom + 2;
            Controls.Add(ButtomPanel);
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
            if (openImageFileDialog.ShowDialog() == DialogResult.OK)
            {
      
                toolStripFileName.Text = openImageFileDialog.FileName;
                bmp = new Bitmap(openImageFileDialog.FileName);
                image.Load(openImageFileDialog.FileName);
                image.ScaleImage((int)settings.previewScalingNud.Value);
                SlicingPanel.Left = image.Right + 2;
                SlicingPanel.Height= SlicingGb.Height;
                ButtomPanel.Top = image.Bottom + 2;
                ButtomPanel.Width= image.Width;
                vr.bitplane.LoadImage(openImageFileDialog.FileName);
                CheckImageAlignment();

                if (vr.bitplane.Width > Width || vr.bitplane.Height > Height)
                {
                    Width = vr.bitplane.Width + 20;
                    Height = vr.bitplane.Height + menuStrip1.Height + statusStrip.Height + 60;
                }
                toolStripFileName.Text = openImageFileDialog.FileName;
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
            if (saveSourceFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveSourceFileDialog.FilterIndex)
                {
                    case 1:
                        if (settings.sequentialRB.Checked == true)
                            vr.bitplane.SaveBitmapsAsAssemblerSourceCode(saveSourceFileDialog.FileName,vr.outputSize,vr.NumInARow);
                        else
                            vr.bitplane.SaveBitmapsAsInterleavedAssemblerSourceCode(saveSourceFileDialog.FileName,vr.outputSize,vr.NumInARow);
                        break;
                    case 2:
                        if (settings.sequentialRB.Checked == true)
                            vr.bitplane.SaveBitmapsAsBinaryFile(saveSourceFileDialog.FileName);
                        else
                            vr.bitplane.SaveBitmapsAsInterleavedBinaryFile(saveSourceFileDialog.FileName);
                        break;
                    case 3:
                        if (settings.sequentialRB.Checked == true)
                            vr.bitplane.SaveBitmapsAsCPPSourceCode(saveSourceFileDialog.FileName, vr.outputSize,vr.NumInARow);
                        else
                            vr.bitplane.SaveBitmapsAsInterleavedCPPSourceCode(saveSourceFileDialog.FileName, vr.outputSize,vr.NumInARow);
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
            if (vr.bitplane.bmp != null)
            {
                pallate.imagePallate.SetPalette(vr.bitplane.Pallate);
                selectBGColor.ShowDialog();
            }
            else
                MessageBox.Show("There is no pallate yet, try to load image first, or that the image you've loaded has no Pallate.", "Pallate Error", MessageBoxButtons.OK);

        }


        private void image_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Image OriginalImage = image.Image;
        }


        private void autoCorpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point StartPos = new Point(vr.bitplane.bmp.Width, vr.bitplane.Height), StopPos = new Point (0,0);
            Color backgroundColor = vr.bitplane.Pallate[0];

            for (int y = vr.bitplane.Height-1; y>=0;y--)
                for (int x = vr.bitplane.Width-1;x>=0;x--)
                {
                    Color pixel = vr.bitplane.bmp.GetPixel(x, y);
                    if ( pixel.R != backgroundColor.R || pixel.G != backgroundColor.G || pixel.B != backgroundColor.B)
                    //if (pixel != backgroundColor) // Dont have a clue why its not working
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
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            g.DrawImage(bmp,destRec, StartPos.X, StartPos.Y, NewWidth, NewHeight,GraphicsUnit.Pixel);
           
            
            g.Dispose();
            vr.bitplane.bmp= corpedImage;
            vr.bitplane.ConvertImageToBitmaps();
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

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSourceFileDialog.Filter = "PNG (*.PNG)|*.png";
            if (saveSourceFileDialog.ShowDialog () == DialogResult.OK)
            {
                vr.bitplane.bmp.Save(saveSourceFileDialog.FileName);
            }
        }

        private void saveImageAsSpriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vr.bitplane.bmp == null)
            {
                MessageBox.Show("Load Image First!","You Drunk Or Something?");
                return;
            }

            Sprite sprite = new Sprite();
            sprite.ImportImage(vr.bitplane.bmp);

            if (saveSourceFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveSourceFileDialog.FilterIndex) { 
                case 0:
                        sprite.SaveAsAssemblerSourceFile(saveSourceFileDialog.FileName);
                    break; 
                case 1:
                        sprite.SaveAsBinaryFile(saveSourceFileDialog.FileName);
                    break;
                case 2:
                        sprite.SaveAsCPPSourceFile(saveSourceFileDialog.FileName);
                    break;
                }
            }

        }

        private void sprireSheetCutterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SlicingPanel.Visible= true;
   
        }


  
        private void SliceBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
