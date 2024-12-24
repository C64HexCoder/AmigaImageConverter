using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Formats.Asn1;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amiga;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Amiga.Sprite;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using System.Runtime.CompilerServices;
using System.Diagnostics.Eventing.Reader;

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
        List<Sprite> sprites = new List<Sprite>();
        bool SlicedSpriteSheet = false;
        IFF iffImage = new IFF();
        int defaultimageWidth, defaultimageHeight;

        RegEdit RegEdit = RegEdit.Instance;
        SpriteCut spriteCut = new SpriteCut();
        SpriteSlicing spriteSlicing; //= new SpriteSlicing();
        enum FormState
        {
            Image,
            SpriteSplit,
            SpriteCut
        }

        FormState formState = FormState.Image;

        enum SpriteCutState
        {
            Cut,
            PanSE,
            PanNW,
            PanNE,
            PanSW,
            Pan
        }

        SpriteCutState spriteCutState = SpriteCutState.Cut;
        PublicVariables.SpriteCutRec spriteRec;



        enum BlitWord
        {
            None,
            Left,
            Right,
            Both
        }

        BlitWord AddedBlitWord = BlitWord.None;
        //List<Bitmap> bitmaps = new List<Bitmap>();

        int ScreenWidth
        {
            get { return SystemInformation.VirtualScreen.Width; }
        }

        int ScreenHeight
        {
            get { return SystemInformation.VirtualScreen.Height; }
        }
        public MainForm()
        {
            InitializeComponent();
            defaultimageWidth = image.Width;
            defaultimageHeight = image.Height;
        

            ButtomPanel.Size = new Size(image.Width, statusStrip.Height);
            ButtomPanel.Top = image.Bottom + 2;
            Controls.Add(ButtomPanel);
            addBlitWordComboBox.SelectedIndex = 0;

        }

        private void ImageUpdate(object sender, EventArgs e)
        {
            image.Invalidate();
        }
        private async void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Remove(spriteSlicing);
            spriteSlicing = null;

            image.MouseWheelZoom = true;
            formState = FormState.Image;
            spriteRec.IsSpriteCut = false;



            if (openImageFileDialog.ShowDialog() == DialogResult.OK)
            {

                toolStripFileName.Text = openImageFileDialog.FileName;


                bmp = new Bitmap(openImageFileDialog.FileName);

                // If image is not Pallate base (True Color)
                if (bmp.PixelFormat != PixelFormat.Format8bppIndexed && bmp.PixelFormat != PixelFormat.Format4bppIndexed && bmp.PixelFormat != PixelFormat.Format1bppIndexed)
                {
                    LoadImageDialog loadImageDlg = new LoadImageDialog(bmp);
                    if (loadImageDlg.ShowDialog() == DialogResult.OK)
                    {
                        // Change image size if user requested to do so in LoadImageDlg
                        if (loadImageDlg.RequestedImageWidth != bmp.Width || loadImageDlg.RequestedImageHeight != bmp.Height)
                        {
                            Bitmap NewBitmap = new Bitmap(loadImageDlg.RequestedImageWidth, loadImageDlg.RequestedImageHeight);
                            Graphics g = Graphics.FromImage(NewBitmap);
                            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                            g.DrawImage(bmp, 0, 0, loadImageDlg.RequestedImageWidth, loadImageDlg.RequestedImageHeight);
                            g.Dispose();
                            bmp = NewBitmap;
                        }
                    }
                    else return;


                    menuStrip1.Enabled = false;
                    switch (loadImageDlg.algorithemCB.SelectedIndex)
                    {
                        case 0:
                            vr.bitplane.bitmap = await Task.Run(() => KMeansQuant.ReduceColors(bmp, loadImageDlg.ImageNumOfColors));
                            break;

                        case 1:
                            MedianCut mc = new MedianCut();
                            vr.bitplane.bitmap = await Task.Run(() => vr.bitplane.bitmap = mc.ReduceColors(bmp));
                            break;

                        case 2:
                            DeepCycle dp = new DeepCycle();
                            vr.bitplane.bitmap = await Task.Run(() => dp.ReduceColors(bmp, DeepCycle.ColorAvaragingMethod.RelaativeToNumberOfInstances));
                            break;
                    }
                    menuStrip1.Enabled = true;

                }
                else  // The image is not true color (24 or 32 bit)
                    vr.bitplane.LoadImage(openImageFileDialog.FileName);

                // check if the image is 8bit/16bit/32bit alignment
                CheckImageAlignment();

                // copy the image that we have losded in bitplane class into the imageBox to display it
                image.Image = vr.bitplane.bitmap;

                float ScalingFactor = (int)settings.PrevScaleFactor;

                // if image after scaling using ScalingFactor is to bit to fit on screen then....

                // Auto scaling
                if (settings.ScalingType == Settings.ScaleType.ScaleToMax)
                {       // Auto scaling modde
                    ScaleToMax();
                }
                // Manual scalling
                else
                {
                    PredefinedScale();
                }

                toolStripScalingFactorLabel.Text += ScalingFactor.ToString();



                String name = Path.GetFileName(openImageFileDialog.FileName);

                toolStripFileName.Text = name;
                toolStripResolutionLabel.Text = $"{vr.bitplane.Width}x{vr.bitplane.Height}";
                toolStripDepthLabel.Text = $"{vr.bitplane.NumOfBitmaps} Bitmaps, new Width: {vr.bitplane.actualWidth}";


                hScrollBar.Top = image.Bottom;
                hScrollBar.Left = image.Left;
                hScrollBar.Width = image.Width;
                vScrollBar.Left = image.Right;
                vScrollBar.Height = image.Height;
                statusStrip.Top = hScrollBar.Bottom;
                statusStrip.Left = hScrollBar.Left;
                statusStrip.Width = hScrollBar.Width;

                //ButtomPanel.Top = hScrollBar.Bottom + 2;
                //ButtomPanel.Width = image.Width;
                //ButtomPanel.Height = statusStrip.Height;



                if (image.Image.Width > image.Width)
                {
                    //     hScrollBar.Maximum = image.Image.Width - image.Width;
                    //     hScrollBar.Visible = true;
                }
                else
                {
                    hScrollBar.Visible = false;
                }

                if (image.Image.Height > image.Height)
                {
                    //vScrollBar.Maximum = image.Image.Height - image.Height;
                    //vScrollBar.Visible = true;
                }
                else { hScrollBar.Visible = false; }


                switch (vr.bitplane.bitmap.PixelFormat)
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

            spriteCut.widthNumUD.Maximum = image.Width;
            spriteCut.heightNumUD.Maximum = image.Height;
        }

        private void ProgressBarEvent(object sender, KMeansQuant.ProgressBarEventArgs e)
        {
            toolStripProgressBar.Minimum = e.Min;
            toolStripProgressBar.Maximum = e.Max;
            toolStripProgressBar.Value = e.Position;
        }
        private void saveImageAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageSaveDialog imageSaveDialog = new ImageSaveDialog();

            imageSaveDialog.ShowDialog();

            if (saveSourceFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveSourceFileDialog.FilterIndex)
                {
                    case 1:
                        if (imageSaveDialog.ImageFormat == ImageSaveDialog.ImageFormats.Sequential)
                            vr.bitplane.SaveBitmapsAsAssemblerSourceCode(saveSourceFileDialog.FileName, imageSaveDialog.DataType, imageSaveDialog.DataPerRaw);
                        else
                            vr.bitplane.SaveBitmapsAsInterleavedAssemblerSourceCode(saveSourceFileDialog.FileName, imageSaveDialog.DataType, imageSaveDialog.DataPerRaw);
                        break;
                    case 2:
                        if (imageSaveDialog.ImageFormat == ImageSaveDialog.ImageFormats.Sequential)
                            vr.bitplane.SaveBitmapsAsBinaryFile(saveSourceFileDialog.FileName);
                        else
                            vr.bitplane.SaveBitmapsAsInterleavedBinaryFile(saveSourceFileDialog.FileName);
                        break;
                    case 3:
                        if (imageSaveDialog.ImageFormat == ImageSaveDialog.ImageFormats.Sequential)
                            vr.bitplane.SaveBitmapsAsCPPSourceCode(saveSourceFileDialog.FileName, imageSaveDialog.DataType, imageSaveDialog.DataPerRaw);
                        else
                            vr.bitplane.SaveBitmapsAsInterleavedCPPSourceCode(saveSourceFileDialog.FileName, imageSaveDialog.DataType, imageSaveDialog.DataPerRaw);
                        break;
                }
            }
        }

        private void CheckImageAlignment()
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
                if (settings.valueChanged == true)
                {
                    if (settings.ScaleToMax)
                    {
                        image.SizeMode = PictureBoxSizeMode.AutoSize;

                        image.ScaleToMax(0.8f);
                    }
                    else
                    {
                        image.Width = defaultimageWidth;
                        image.Height = defaultimageHeight;
                        // setting to autosize just for now.
                        //image.SizeMode = PictureBoxSizeMode.AutoSize;
                        image.Image = vr.bitplane.bitmap;
                        image.ScaleImage((int)settings.previewScalingNud.Value);

                        hScrollBar.Top = image.Bottom;
                        hScrollBar.Left = image.Left;
                        hScrollBar.Width = image.Width;
                        vScrollBar.Left = image.Right;
                        vScrollBar.Height = image.Height;
                        statusStrip.Top = hScrollBar.Bottom;
                        statusStrip.Left = hScrollBar.Left;
                        statusStrip.Width = hScrollBar.Width;
                        //ButtomPanel.Top = hScrollBar.Bottom + 2;
                        //ButtomPanel.Width = image.Width;
                        //ButtomPanel.Height = statusStrip.Height;

                        ButtomPanel.Width = image.Width;
                        ButtomPanel.Top = image.Bottom + 2;

                        // if (image.Image != null)
                        //   hScrollBar.Maximum = image.Image.Width - image.Width;
                    }

                }
            }
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            about.ShowDialog();
        }

        private void savePallateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vr.bitplane.bitmap == null)
            {
                MessageBox.Show("Pease load image first", "Missing Image", MessageBoxButtons.OK);
                return;
            }
            ColorOptions colorOptions = new ColorOptions();
            colorOptions.ShowDialog();

            SaveFileDialog pallateFileDialog = new SaveFileDialog();
            pallateFileDialog.Filter = "Assembler Source|*.S";
            if (pallateFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (colorOptions.bitsPerPixel == ColorOptions.BitsPerPixel.FourBpp)
                    vr.bitplane.SavePallate(pallateFileDialog.FileName, colorOptions.BaseColorRegister);
                else
                    vr.bitplane.Save24bitPalette(pallateFileDialog.FileName, colorOptions.BaseColorRegister, (int)colorOptions.bankNumUD.Value);
            }
        }


        private void pallateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ColorPalette colorPalette = bitplane.Pallate;
            if (vr.bitplane.Pallate != null || iffImage.bmp != null)
            {
                pallate.imagePallate.SetPalette(vr.bitplane.Pallate);
                pallate.ShowDialog();
            }
            else
                MessageBox.Show("There is no pallate yet, try to load image first, or that the image you've loaded has no Pallate.", "Pallate Error", MessageBoxButtons.OK);
        }

        private void selectBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectBackgroundColor selectBGColor = new SelectBackgroundColor();
            if (vr.bitplane.bitmap != null)
            {
                selectBGColor.pallete.SetPalette(vr.bitplane.Pallate);
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
            Point StartPos = new Point(vr.bitplane.bitmap.Width, vr.bitplane.Height), StopPos = new Point(0, 0);
            Color backgroundColor = vr.bitplane.Pallate[0];

            for (int y = vr.bitplane.Height - 1; y >= 0; y--)
                for (int x = vr.bitplane.Width - 1; x >= 0; x--)
                {
                    Color pixel = vr.bitplane.bitmap.GetPixel(x, y);
                    if (pixel.R != backgroundColor.R || pixel.G != backgroundColor.G || pixel.B != backgroundColor.B)
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

            int NewWidth = StopPos.X - StartPos.X + 1, NewHeight = StopPos.Y - StartPos.Y + 1;
            Bitmap corpedImage = new Bitmap(NewWidth, NewHeight);
            Graphics g = Graphics.FromImage(corpedImage);
            Rectangle destRec = new Rectangle(0, 0, NewWidth, NewHeight);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            g.DrawImage(vr.bitplane.bmp, destRec, StartPos.X, StartPos.Y, NewWidth, NewHeight, GraphicsUnit.Pixel);
            g.Dispose();
            vr.bitplane.bitmap = corpedImage;
            image.Image = vr.bitplane.bitmap;
            image.ScaleImage((int)settings.previewScalingNud.Value);
            ButtomPanel.Top = image.Bottom + 1;
            ButtomPanel.Width = image.Width < 500 ? 500 : image.Width;
            CheckImageAlignment();
            toolStripResolutionLabel.Text = vr.bitplane.Width.ToString() + "x" + vr.bitplane.Height.ToString();
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
            image.Image = vr.bitplane.bitmap;
            image.ScaleImage((int)settings.previewScalingNud.Value);

            toolStripResolutionLabel.Text = vr.bitplane.bitmap.Width + "x" + vr.bitplane.bitmap.Height;
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSourceFileDialog.Filter = "PNG (*.PNG)|*.png";
            if (saveSourceFileDialog.ShowDialog() == DialogResult.OK)
            {
                vr.bitplane.bitmap.Save(saveSourceFileDialog.FileName);
            }
        }

        private void saveImageAsSpriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpriteDialog spriteDialog = new SpriteDialog();

            if (vr.bitplane.bitmap == null)
            {
                MessageBox.Show("Load Image First!", "You Drunk Or Something?");
                return;
            }

            if (vr.bitplane.bitmap.Width > 64)
            {
                if (spriteDialog.ShowDialog() == DialogResult.OK)
                {
                    image.Image = vr.bitplane.bitmap;
                    image.ScaleImage((int)settings.PrevScaleFactor);
                }
            }

            Sprite sprite = new Sprite();
            sprite.ImportImage(vr.bitplane.bitmap);
            if (saveSourceFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveSourceFileDialog.FilterIndex)
                {
                    case 1:
                        sprite.SaveAsAssemblerSourceFile(saveSourceFileDialog.FileName);
                        break;
                    case 2:
                        sprite.SaveAsBinaryFile(saveSourceFileDialog.FileName);
                        break;
                    case 3:
                        sprite.SaveAsCPPSourceFile(saveSourceFileDialog.FileName);
                        break;
                }
            }

        }

        private void sprireSheetCutterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateSpriteSlicing();
            image.MouseWheelZoom = false;

            this.Controls.Add(spriteSlicing);
            
            formState = FormState.SpriteSplit;
            sprites.Clear();
  

        }



        /*  private void SliceBtn_Click(object sender, EventArgs e)
          {
              int SpritesPerRaw = (int)(ImagesPerRawNud.Value * spritePerImageUDN.Value);
              if (ImagesPerRawNud.Value == 0 || numOfRawsNud.Value == 0 || spriteWidthCb.SelectedIndex == -1)
              {
                  MessageBox.Show("Please fill in all the parametters first", "Missing info...", MessageBoxButtons.OK);
                  return;
              }
              sprites.Clear();

              int SprireWidth = (int)(vr.bitplane.bitmap.Width / ImagesPerRawNud.Value / spritePerImageUDN.Value);
              int SpriteHeight = (int)(vr.bitplane.bitmap.Height / numOfRawsNud.Value);

              int NumOfSprites = (int)(ImagesPerRawNud.Value * numOfRawsNud.Value * spritePerImageUDN.Value);

              int SpriteNum = 0;
              for (int y = 0; y < numOfRawsNud.Value; y++)
              {
                  for (int x = 0; x < SpritesPerRaw; x++)
                  {

                      Bitmap SprBmp = new Bitmap(SprireWidth, SpriteHeight);
                      SprBmp.SetResolution(vr.bitplane.bitmap.HorizontalResolution, vr.bitplane.bitmap.VerticalResolution);
                      Sprite sprite = new Sprite();

                      sprite.Name = spriteNameTxtbox.Text != "" ? spriteNameTxtbox.Text + SpriteNum++.ToString() : "SpriteName";


                      Graphics gr = Graphics.FromImage(SprBmp);
                      Rectangle sourceRec = new Rectangle(x * SprireWidth, y * SpriteHeight, SprireWidth, SpriteHeight);
                      gr.DrawImage(vr.bitplane.bitmap, 0, 0, sourceRec, GraphicsUnit.Pixel);

                      //pictureBox1.Update();
                      gr.Dispose();

                      Sprite.SpriteWidth SprWidth;
                      switch (spriteSlicing.spriteWidthCb.SelectedIndex)
                      {
                          case 0:
                              SprWidth = Sprite.SpriteWidth._16Pixels;
                              break;
                          case 1:
                              SprWidth = Sprite.SpriteWidth._32Pixels;
                              break;
                          case 2:
                              SprWidth = Sprite.SpriteWidth._64Pixels;
                              break;
                          default:
                              SprWidth = Sprite.SpriteWidth._16Pixels;
                              break;
                      }
                      //bitmaps.Add(SprBmp);
                      sprite.ImportImage(SprBmp, SprWidth);
                      sprites.Add(sprite);
                  }
              }
              spriteSlicing.sprImageBox.Image = sprites[0].bitmap;


              spriteSlicing.spriteSelectNud.Maximum = sprites.Count - 1;
              spriteSlicing.SliceBtn.Enabled = false;
              spriteSlicing.SpriteSaveBtn.Enabled = true;
              spriteSelectNud.Value = 0;
              SlicedSpriteSheet = true;
              spriteSelectNud.Enabled = true;
              spriteRec.Enable = true;

              RectangleSprite(0);

          }*/




        private void RectangleSprite(int SpriteNum)
        {
            int SprireWidth = (int)(image.Width / spriteSlicing.ImagesPerRaw / spriteSlicing.SpritesPerImage);
            int SpriteHeight = (int)(image.Height / spriteSlicing.NumOfRaws);
            int SpritePerRaw = (int)(spriteSlicing.ImagesPerRaw * spriteSlicing.SpritesPerImage);

            int SpriteXPos = SpriteNum % SpritePerRaw, SpriteYPos = SpriteNum / SpritePerRaw;

            spriteRec.LineWIdth = 4;
            spriteRec.X = SpriteXPos * SprireWidth;
            spriteRec.Y = SpriteYPos * SpriteHeight;
            spriteRec.Width = SprireWidth;
            spriteRec.Height = SpriteHeight;

            image.Invalidate();
        }
      

        private void spriteWidthCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            spriteSlicing.SliceBtn.Enabled = true;
        }

        private void image_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (spriteSlicing != null)
            {
                if (!spriteSlicing.isSliced)
                    return;

                int SpritesPerRaw = (int)(spriteSlicing.ImagesPerRawNud.Value * spriteSlicing.spritePerImageUDN.Value);

                int MouseX = e.X, MouseY = e.Y;

                int SprireWidth = (int)(image.Width / SpritesPerRaw);
                int SpriteHeight = (int)(image.Height / spriteSlicing.numOfRawsNud.Value);


                int SpriteXPos = (int)MouseX / SprireWidth, SpriteYPos = (int)MouseY / SpriteHeight;

                spriteSlicing.spriteSelectNud.Value = SpriteXPos + SpriteYPos * SpritesPerRaw;

                //image.Invalidate();
            }
        }

        private void addBlitWordComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox tscb = (ToolStripComboBox)sender;
            Bitmap NewBitmap;
            Graphics g;

            switch (tscb.SelectedIndex)
            {
                case 1:
                    if (AddedBlitWord != BlitWord.Left && AddedBlitWord != BlitWord.Both)
                    {
                        vr.bitplane.AddBlitterWord(Bitplane.BlitWord.Left);
                        image.Image = vr.bitplane.bitmap;
                        image.ScaleImage((int)settings.previewScalingNud.Value);
                        toolStripResolutionLabel.Text = vr.bitplane.Width + "x" + vr.bitplane.bitmap.Height;
                        if (AddedBlitWord == BlitWord.None)
                            AddedBlitWord = BlitWord.Left;
                        else // if no left then its right
                            AddedBlitWord = BlitWord.Both;
                    }
                    else
                        MessageBox.Show("Left Word already added to the image.", "Silly you...", MessageBoxButtons.OK);
                    break;
                case 2:
                    if (AddedBlitWord != BlitWord.Right && AddedBlitWord != BlitWord.Both)
                    {
                        vr.bitplane.AddBlitterWord(Bitplane.BlitWord.Right);
                        image.Image = vr.bitplane.bitmap;
                        image.ScaleImage((int)settings.previewScalingNud.Value);
                        toolStripResolutionLabel.Text = vr.bitplane.Width + "x" + vr.bitplane.bitmap.Height;
                        if (AddedBlitWord == BlitWord.None)
                            AddedBlitWord = BlitWord.Right;
                        else // if no left then its right
                            AddedBlitWord = BlitWord.Both;
                    }
                    else
                        MessageBox.Show("Right Word already added to the image.", "Silly you...", MessageBoxButtons.OK);
                    break;
                case 3:
                    if (AddedBlitWord != BlitWord.Both)
                    {
                        vr.bitplane.AddBlitterWord(Bitplane.BlitWord.Both);
                        image.Image = vr.bitplane.bitmap;
                        image.ScaleImage((int)settings.previewScalingNud.Value);
                        toolStripResolutionLabel.Text = vr.bitplane.Width + "x" + vr.bitplane.bitmap.Height;

                        AddedBlitWord = BlitWord.Both;
                    }
                    else
                        MessageBox.Show("Right Word already added to the image.", "Silly you...", MessageBoxButtons.OK);
                    break;
            }
        }

        private void removeBlitterWorldToolStripMenuItem3_MouseHover(object sender, EventArgs e)
        {
            removeBlitterWordToolStripComboBox.SelectedIndex = 0;
        }

        private void removeBlitterWordToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (removeBlitterWordToolStripComboBox.SelectedIndex)
            {
                case 0:         // None
                    break;
                case 1:         // Left
                    if (AddedBlitWord == BlitWord.Left || AddedBlitWord == BlitWord.Both)
                    {

                    }
                    break;
                case 2:         // Right
                    break;
                case 3:         // Both
                    break;
            }
        }

        private void setImageWidthToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            if (vr.bitplane.bitmap != null)
            {
                toolStripChangeWidthTextBox.Enabled = true;
                toolStripChangeWidthTextBox.Text = vr.bitplane.Width.ToString();

            }
            else
            {
                toolStripChangeWidthTextBox.Enabled = false;
            }
        }

        private void toolStripChangeWidthTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            ToolStripTextBox tstb = (ToolStripTextBox)sender;

            if (e.KeyCode == Keys.Enter)
            {
                vr.bitplane.ChangeWidth(int.Parse(tstb.Text));
                image.Image = vr.bitplane.bitmap;
                image.ScaleImage((int)settings.previewScalingNud.Value);
            }
        }

        private void alignWidthToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;

            if (vr.bitplane.bitmap != null)
            {
                alignWidthComboBox.Enabled = true;
                CheckImageAlignment();
            }
            else
                alignWidthComboBox.Enabled = false;
        }

        private void displayMaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayMask dm = new DisplayMask();
            vr.bitplane.CreateMask();
            //vr.bitplane.CreateMaskBitmap();
            dm.ShowDialog(); ;
        }

        private void LoadIFFToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog iffFile = new OpenFileDialog();
            iffFile.Filter = "Amiga IFF|*.iff;*.ilbm;*.pbm;*.acbm";
            if (iffFile.ShowDialog() == DialogResult.OK)
            {
                vr.bitplane.LoadIFF(iffFile.FileName);
                image.Image = vr.bitplane.bitmap;
                image.ScaleImage((int)settings.previewScalingNud.Value);

                if (vr.bitplane.bitmap == null)
                    if (MessageBox.Show("Whould you like to load palette?\nWith the absence of palette no image will be displayed!", "Missing Palette", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        OpenFileDialog paletteDlg = new OpenFileDialog();
                        if (paletteDlg.ShowDialog() == DialogResult.OK)
                        {
                            iffImage.Load(paletteDlg.FileName);
                            vr.bitplane.palette = iffImage.palette;
                            image.Image = vr.bitplane.CreateBitmap();
                            //image.Refresh();
                            //image.ScaleImage();
                        }
                    }
            }
        }


        private void iLBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog iffFile = new SaveFileDialog();
            iffFile.Filter = "Amiga IFF|*.iff;*.ilbm;*.pbm;*.acbm";

            if (iffFile.ShowDialog() == DialogResult.OK)
            {
                vr.bitplane.SaveILBM(iffFile.FileName);
            }
        }

        private void aCBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog iffFile = new SaveFileDialog();
            iffFile.Filter = "Amiga IFF|*.iff;*.ilbm;*.pbm;*.acbm";

            if (iffFile.ShowDialog() == DialogResult.OK)
            {
                vr.bitplane.SaveACBM(iffFile.FileName);
            }
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resize resize = new Resize();
            if (resize.ShowDialog() == DialogResult.OK)
            {
                if (vr.bitplane.Width != image.Image.Width || vr.bitplane.Height != image.Image.Height)
                {
                    image.Image = vr.bitplane.bitmap;
                    image.SizeMode = PictureBoxSizeMode.AutoSize;
                    image.ScaleImage((float)settings.previewScalingNud.Value);

                }
            }
        }

        private void hScrollBar_ValueChanged(object sender, EventArgs e)
        {
            HScrollBar hScrollBar = (HScrollBar)sender;

            image.DrawImagePart(hScrollBar.Value, vScrollBar.Value);
        }

        private void vScrollBar_ValueChanged(object sender, EventArgs e)
        {
            VScrollBar vScrollBar = (VScrollBar)sender;
            image.DrawImagePart(hScrollBar.Value, vScrollBar.Value);
        }

        private void ScaleToMax()
        {
            float ScalingFactor = (int)settings.PrevScaleFactor;

            image.SizeMode = PictureBoxSizeMode.AutoSize;
            //       if (vr.bitplane.Width * ScalingFactor > 0.8 * SystemInformation.VirtualScreen.Width || vr.bitplane.Height * ScalingFactor > 0.8 * SystemInformation.VirtualScreen.Height)
            //     {   // Scaled image bigger then the screen

            float XscaleFactor = (float)ScreenWidth * 0.8f / (float)vr.bitplane.Width;
            float YscaleFactor = (float)ScreenHeight * 0.8f / (float)vr.bitplane.Height;

            ScalingFactor = XscaleFactor > YscaleFactor ? YscaleFactor : XscaleFactor;

            image.ScaleImage(ScalingFactor);

        }

        private void PredefinedScale()
        {
            float scaleFactor = (int)settings.PrevScaleFactor;

            int XSize = (int)settings.PrevScaleFactor * image.Image.Width > ScreenWidth ? (int)(ScreenWidth * 0.8f) : (int)settings.PrevScaleFactor * image.Image.Width;
            int YSize = (int)settings.PrevScaleFactor * image.Image.Height > ScreenHeight ? (int)(ScreenHeight * 0.8f) : (int)settings.PrevScaleFactor * image.Image.Height;


            image.Size = new Size(XSize, YSize);
            image.SizeMode = PictureBoxSizeMode.Normal;




            image.ScaleImage((int)settings.PrevScaleFactor);
        }

        private void NoScaleing()
        {
            image.Width = defaultimageWidth;
            image.Height = defaultimageHeight;
            image.SizeMode = PictureBoxSizeMode.Normal;
            image.ScaleImage((int)settings.PrevScaleFactor);
        }

        private void SaveLinkFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkObjectConfig linkObjectConfig = new LinkObjectConfig();

            uint MemoryType;
            int NumOfLongs = vr.bitplane.Bitplanes.Length % 4 == 0 ? vr.bitplane.Bitplanes.Length / 4 : vr.bitplane.Bitplanes.Length / 4 + 1;

            SaveFileDialog ObjSaveFileDialog = new SaveFileDialog();
            ObjSaveFileDialog.Filter = "Linkable File (Obj)|*.obj";

            if (linkObjectConfig.ShowDialog() == DialogResult.OK)
            {

            }
            int NumOfLongsInExtarnalDescriptor = linkObjectConfig.ExternalDescriptor.Length % 4 == 0 ? linkObjectConfig.ExternalDescriptor.Length / 4 : linkObjectConfig.ExternalDescriptor.Length / 4 + 1;
            int BytesToPad = 4 - linkObjectConfig.ExternalDescriptor.Length % 4;

            MemoryType = (uint)linkObjectConfig.MemoryType;

            if (ObjSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream sw = new FileStream(ObjSaveFileDialog.FileName, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(sw);

                bw.Write(endian.Convert(0x000003e7));
                bw.Write(0x00000000);

                bw.Write(endian.Convert(0x000003E8));
                bw.Write(endian.Convert(0x00000002));
                bw.Write(endian.Convert(0x64617461));
                bw.Write(endian.Convert(0x73656300));
                uint OutLong = MemoryType << 24 | 0x03EA;
                bw.Write(endian.Convert(OutLong));
                bw.Write((uint)endian.Convert(NumOfLongs));

                vr.bitplane.SaveBitmapsAsLongBinaryFile(bw);

                bw.Write(endian.Convert(0x000003ef));
                int LongOut = 0x01000000 | NumOfLongsInExtarnalDescriptor;
                bw.Write(endian.Convert(LongOut));

                foreach (char c in linkObjectConfig.ExternalDescriptor)
                {
                    bw.Write((Char)c);
                }

                for (int i = 0; i < BytesToPad; i++)
                {
                    bw.Write((byte)0x00);
                }

                bw.Write(0x00000000);
                bw.Write(0x00000000);
                bw.Write(endian.Convert(0x000003f2));

                sw.Flush();
                sw.Close();
            }
        }

        private void c64ImageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void image_HorizontalScrollBarChanged(object sender, ImageBox.ScrollBarEventArgs args)
        {
            hScrollBar.Maximum = args.Maximum;
            hScrollBar.Visible = args.Enabled;
        }

        private void image_VerticalScrollBarChanged(object sender, ImageBox.ScrollBarEventArgs args)
        {
            vScrollBar.Maximum = args.Maximum;
            vScrollBar.Visible = args.Enabled;
        }

        private void loadAmigaFonttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Amiga.Font obj = new Amiga.Font();

            Graphics gfx = image.CreateGraphics();
            obj.gfx = gfx;
            gfx.Clear(Color.White);

            obj.OpenObjectFile();
            //obj.DrawFont('G', 0, 0,5);
            image.Image = obj.CreatePreview(); ;
            //image.Image = obj.fonts[(int)('G' - 0x20)];
            image.ScaleImage(4);
            //Refresh();

        }

        private void sineWaveGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AudioSamleEditorDialog dlg = new AudioSamleEditorDialog();
            dlg.ShowDialog();

        }

        private void loadWAVAudiotoolStripMenuItem_Click(object sender, EventArgs e)
        {
            WAV wAV = new WAV();
            wAV.OpenWaveFile();

            AudioSamleEditorDialog dialog = new AudioSamleEditorDialog(wAV.LeftChannelSamples);
            dialog.ShowDialog();

        }

        private void cutSpriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image.MouseWheelZoom = false;

            formState = FormState.SpriteCut;
            sprites.Clear();


        }

        private void saveSpriteAsMenuItem_Click(object sender, EventArgs e)
        {

            ConvertImageToSprite convertImageToSprite = new ConvertImageToSprite();
            if (convertImageToSprite.ShowDialog() == DialogResult.OK)
            {

            }

        }

        int CutStartX, CutStartY;
        private void image_MouseDown(object sender, MouseEventArgs e)
        {
            if (formState == FormState.SpriteCut)
            {
                spriteRec.Enable = true;

                if (spriteCutState == SpriteCutState.Cut)
                {
                    spriteRec.X = e.X;
                    spriteRec.Y = e.Y;
                    spriteRec.Width = 0;
                    spriteRec.Height = 0;
                }
            }
        }

        int OldXPos = 0, OldYPos = 0;
        Bitmap BackUp;
        Point PanPos;
        private void image_MouseMove(object sender, MouseEventArgs e)
        {
            if (formState != FormState.SpriteCut)
                return;

            Graphics gfx = image.CreateGraphics();
            spriteRec.LineWIdth = 4;
            Pen p = new Pen(Color.Black, spriteRec.LineWIdth);

            image.Refresh();

            if (e.Button == MouseButtons.Left)
            {
                switch (spriteCutState)
                {
                    case SpriteCutState.Cut:
                        if (e.X > spriteRec.X && e.Y > spriteRec.Y)
                        {
                            Rectangle temp = new Rectangle(spriteRec.X, spriteRec.Y, e.X - spriteRec.X, e.Y - spriteRec.Y);
                            gfx.DrawRectangle(p, temp);
                        }
                        break;
                    case SpriteCutState.PanNW:

                        int NewWidth = spriteRec.Width - (e.X - spriteRec.X);
                        int NewHeight = spriteRec.Height - (e.Y - spriteRec.Y);
                        spriteRec.X = e.X;
                        spriteRec.Y = e.Y;
                        spriteRec.Width = NewWidth;
                        spriteRec.Height = NewHeight;
                        break;

                    case SpriteCutState.PanSW:
                        spriteRec.Width = spriteRec.Width - (e.X - spriteRec.X);

                        spriteRec.X = e.X;
                        spriteRec.Y2 = e.Y;
                        break;

                    case SpriteCutState.PanSE:

                        spriteRec.Width = e.X - spriteRec.X;
                        spriteRec.Height = e.Y - spriteRec.Y;
                        break;

                    case SpriteCutState.PanNE:
                        spriteRec.Height = spriteRec.Height - (e.Y - spriteRec.Y);
                        spriteRec.X2 = e.X;
                        spriteRec.Y = e.Y;
                        break;

                    case SpriteCutState.Pan:
                        int DeltaX = e.X - PanPos.X;
                        int DeltaY = e.Y - PanPos.Y;
                        if (spriteRec.X + DeltaX >= 0 && spriteRec.X2 + DeltaX <= image.Width - 1)
                        {
                            spriteRec.X += DeltaX;
                            PanPos.X = e.X;
                        }
                        if (spriteRec.Y + DeltaY >= 0 && spriteRec.Y2 + DeltaY <= image.Height - 1)
                        {
                            spriteRec.Y += DeltaY;
                            PanPos.Y = e.Y;
                        }
                        break;

                }
            }
            else
            {
                if (Math.Abs(e.X - spriteRec.X) < 5 && Math.Abs(e.Y - spriteRec.Y) < 5)
                {
                    image.Cursor = Cursors.PanNW;
                    spriteCutState = SpriteCutState.PanNW;
                }
                else if (Math.Abs(e.X - (spriteRec.X2)) < 5 && Math.Abs(e.Y - spriteRec.Y2) < 5)
                {
                    image.Cursor = Cursors.PanSE;
                    spriteCutState = SpriteCutState.PanSE;
                }
                else if (Math.Abs(e.X - spriteRec.X) < 5 && Math.Abs(e.Y - spriteRec.Y2) < 5)
                {
                    image.Cursor = Cursors.PanSW;
                    spriteCutState = SpriteCutState.PanSW;
                }
                else if (Math.Abs(e.X - spriteRec.X2) < 5 && Math.Abs(e.Y - spriteRec.Y) < 5)
                {
                    image.Cursor = Cursors.PanNE;
                    spriteCutState = SpriteCutState.PanNE;
                }

                else if (e.X > spriteRec.X + 5 && e.X < spriteRec.X2 - 5 && e.Y > spriteRec.Y + 5 && e.Y < spriteRec.Y2 - 5)
                {
                    image.Cursor = Cursors.Hand;
                    spriteCutState = SpriteCutState.Pan;
                    PanPos.X = e.X; PanPos.Y = e.Y;
                }
                else
                {
                    image.Cursor = Cursors.Default;
                    spriteCutState = SpriteCutState.Cut;
                }
            }
            spriteCut.widthNumUD.Maximum = image.Width;
            spriteCut.heightNumUD.Maximum = image.Height;
            spriteCut.widthNumUD.Value = spriteRec.Width / image.ScaleFactor;
            spriteCut.heightNumUD.Value = spriteRec.Height / image.ScaleFactor;

        }

        private void image_MouseUp(object sender, MouseEventArgs e)
        {

            if (formState == FormState.SpriteCut && spriteCutState == SpriteCutState.Cut)
            {
                vr.spriteRec.Width = e.X - vr.spriteRec.X;
                vr.spriteRec.Height = e.Y - vr.spriteRec.Y;
                vr.spriteRec.IsSpriteCut = true;
            }

            image.Invalidate();
        }

        private void image_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new(Color.Black, spriteRec.LineWIdth);

            if (formState == FormState.SpriteSplit || formState == FormState.SpriteCut)
            {
                if (vr.spriteRec.Enable)
                    g.DrawRectangle(p, vr.spriteRec.SpriteRec);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cutSpriteBtn_Click(object sender, EventArgs e)
        {
            /*        Bitmap bitmap = new Bitmap(spriteRec.Width, spriteRec.Height);
                    Graphics gfx = Graphics.FromImage(bitmap);
                    Sprite sprite = new Sprite();
                    sprite.Name = spriteNameSCTB.Text;

                    //            gfx.DrawImage (image.Image,spriteRec.X,spriteRec.Y,spriteRec.Width,spriteRec.Height);
                    gfx.DrawImage(image.Image, 0, 0, spriteRec.SpriteRec, GraphicsUnit.Pixel);

                    spriteCutPreviewIB.Image = bitmap;
                    sprite.bitmap = bitmap;
                    sprites.Add(sprite);
                    spriteCutSaveButton.Enabled = true;

                    if (sprites.Count > 1 && spriteSelectorNud.Enabled == false)
                    {
                        spriteSelectorNud.Enabled = true;

                    }

                    spriteSelectorNud.Value = sprites.Count - 1;*/


        }




        private void widthNumUD_Leave(object sender, EventArgs e)
        {

            NumericUpDown newWidth = (NumericUpDown)sender;
            spriteRec.Width = (int)newWidth.Value * image.ScaleFactor;
            image.Invalidate();
        }

        private void imageCutGB_VisibleChanged(object sender, EventArgs e)
        {
            GroupBox groupBox = sender as GroupBox;

            if (groupBox.Visible == false)
            {
                spriteRec.Enable = false;
                image.Refresh();

                sprites.Clear();
            }
        }


        private void heightNumUD_Leave(object sender, EventArgs e)
        {
            NumericUpDown newHeight = (NumericUpDown)sender;

            spriteRec.Height = (int)newHeight.Value * image.ScaleFactor;
        }

        private void loadAmigaPaletterMI_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Paletter Files|*.col;*.pal|PPaint|*.col|Dpaint|*.pal";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // loading only the palette not the image... since there is no image in the file
                iffImage.Load(openFileDialog.FileName);
                // what to do with the palette? i did not know what should i do with it so i just uploaded it so i put it in a temporary array
                vr.bitplane.palette = iffImage.palette;
            }
        }

        private void loadIFFAsSpriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sprite sprite = new Sprite();        // temporery sprite.... just for testing porposes......
            OpenFileDialog iffFileDialog = new OpenFileDialog();
            iffFileDialog.Filter = "IFF File (*.IFF)|*.IFF";

            if (iffFileDialog.ShowDialog() == DialogResult.OK)
            {
                sprite.LoadIFF(iffFileDialog.FileName, SpriteWidth._16Pixels);
            }
        }

        private void calculateBlitterLFByteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlitterLFCalculator blitterLFCalculator = new BlitterLFCalculator();
            blitterLFCalculator.ShowDialog();

        }


        private void dDFCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DDFCalculator dDFCalculator = new DDFCalculator();
            dDFCalculator.ShowDialog();
        }

        private void sPRxPOSSPRxCTLConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SPRxPOS_CTLDecoding sPRxPOS_CTLDecoding = new SPRxPOS_CTLDecoding();
            sPRxPOS_CTLDecoding.ShowDialog();
        }

        private void image_SizeChanged(object sender, EventArgs e)
        {
            if (formState == FormState.SpriteSplit)
            {
                spriteSlicing.Left = image.Right + 2;
                this.Width = Width + spriteSlicing.Width;

            }
            else if (formState == FormState.SpriteCut)
            {
                spriteCut.Left = image.Right + 2;
                Width = Width + spriteCut.Width;
            }

        }

        private void image_ScaleEvent(object sender, Amiga.ImageBox.ScalingEventArgs e)
        {
            vr.imageScalingFactoer = e.ScaleFactoer;
        }

        private void CreateSpriteSlicing ()
        {
            spriteSlicing = new SpriteSlicing(); 
            //Controls.Add(spriteSlicing);

            spriteSlicing.ImageUpdated += ImageUpdate;
            //spriteSlicing.Left = this.Right - spriteSlicing.Width;
            if (Width - image.Right  > spriteSlicing.Width)
            {
                spriteSlicing.Dock = DockStyle.Right;
            }
            else
            {
                spriteSlicing.Left = image.Right + 2;
            }
            //this.Width += image.Width - spriteSlicing.Width;
        }

    }
}
