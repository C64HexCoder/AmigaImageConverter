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
using NAudio;
using NAudio.Wave;

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
            SlicingPanel.Visible = false;

            ButtomPanel.Size = new Size(image.Width, statusStrip.Height);
            ButtomPanel.Top = image.Bottom + 2;
            Controls.Add(ButtomPanel);
            addBlitWordComboBox.SelectedIndex = 0;

        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {


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
                        if (loadImageDlg.ImageWidth != bmp.Width || loadImageDlg.ImageHeight != bmp.Height)
                        {
                            Bitmap NewBitmap = new Bitmap(loadImageDlg.ImageWidth, loadImageDlg.ImageHeight);
                            Graphics g = Graphics.FromImage(NewBitmap);
                            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                            g.DrawImage(bmp, 0, 0, loadImageDlg.ImageWidth, loadImageDlg.ImageHeight);
                            g.Dispose();
                            bmp = NewBitmap;
                        }
                    }
                    else return;


                    vr.bitplane.bitmap = KMeansQuant.DecreaseColors(bmp, loadImageDlg.ImageNumOfColors);

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

                SlicingPanel.Left = image.Right + 2;
                SlicingPanel.Height = SlicingGb.Height;
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
        }

        private void saveImageAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveSourceFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveSourceFileDialog.FilterIndex)
                {
                    case 1:
                        if (settings.sequentialRB.Checked == true)
                            vr.bitplane.SaveBitmapsAsAssemblerSourceCode(saveSourceFileDialog.FileName, vr.outputSize, vr.NumInARow);
                        else
                            vr.bitplane.SaveBitmapsAsInterleavedAssemblerSourceCode(saveSourceFileDialog.FileName, vr.outputSize, vr.NumInARow);
                        break;
                    case 2:
                        if (settings.sequentialRB.Checked == true)
                            vr.bitplane.SaveBitmapsAsBinaryFile(saveSourceFileDialog.FileName);
                        else
                            vr.bitplane.SaveBitmapsAsInterleavedBinaryFile(saveSourceFileDialog.FileName);
                        break;
                    case 3:
                        if (settings.sequentialRB.Checked == true)
                            vr.bitplane.SaveBitmapsAsCPPSourceCode(saveSourceFileDialog.FileName, vr.outputSize, vr.NumInARow);
                        else
                            vr.bitplane.SaveBitmapsAsInterleavedCPPSourceCode(saveSourceFileDialog.FileName, vr.outputSize, vr.NumInARow);
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

                        SlicingPanel.Left = image.Right + 2;
                        SlicingPanel.Height = SlicingGb.Height;

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

                        SlicingPanel.Left = image.Right + 2;
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
            SlicingPanel.Visible = true;

        }



        private void SliceBtn_Click(object sender, EventArgs e)
        {
            if (SpritesPerRawNud.Value == 0 || numOfRawsNud.Value == 0 || spriteWidthCb.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all the parametters first", "Missing info...", MessageBoxButtons.OK);
                return;
            }
            sprites.Clear();

            int SprireWidth = (int)(vr.bitplane.bitmap.Width / SpritesPerRawNud.Value);
            int SpriteHeight = (int)(vr.bitplane.bitmap.Height / numOfRawsNud.Value);

            int NumOfSprites = (int)(SpritesPerRawNud.Value * numOfRawsNud.Value);

            for (int y = 0; y < numOfRawsNud.Value; y++)
            {
                for (int x = 0; x < SpritesPerRawNud.Value; x++)
                {

                    Bitmap SprBmp = new Bitmap(SprireWidth, SpriteHeight);
                    SprBmp.SetResolution(vr.bitplane.bitmap.HorizontalResolution, vr.bitplane.bitmap.VerticalResolution);
                    Sprite sprite = new Sprite();

                    Graphics gr = Graphics.FromImage(SprBmp);
                    Rectangle sourceRec = new Rectangle(x * SprireWidth, y * SpriteHeight, SprireWidth, SpriteHeight);
                    gr.DrawImage(vr.bitplane.bitmap, 0, 0, sourceRec, GraphicsUnit.Pixel);

                    //pictureBox1.Update();
                    gr.Dispose();

                    Sprite.SpriteWidth SprWidth;
                    switch (spriteWidthCb.SelectedIndex)
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
            sprImageBox.Image = sprites[0].bitmap;
            //sprImageBox.AutoScale();
            //sprImageBox.ScaleImage(4);
            //sprImageBox.Location= new Point((int)((SlicingGb.Width - sprImageBox.Width)/2),sprImageBox.Top);

            Bitmap SelectedSpriteImage = new Bitmap(vr.bitplane.bitmap);
            Graphics SSI = Graphics.FromImage(SelectedSpriteImage);
            Pen p = new Pen(Color.Black, 2);
            SSI.DrawRectangle(p, 0, 0, SprireWidth, SpriteHeight);
            SSI.Dispose();
            image.Image = SelectedSpriteImage;
            image.ScaleImage((int)(settings.previewScalingNud.Value));
            spriteSelectNud.Maximum = sprites.Count - 1;
            SliceBtn.Enabled = false;
            SpriteSaveBtn.Enabled = true;
            spriteSelectNud.Value = 0;
            SlicedSpriteSheet = true;
        }


        private void spriteSelectNud_ValueChanged(object sender, EventArgs e)
        {
            int SprireWidth = (int)(vr.bitplane.bitmap.Width / SpritesPerRawNud.Value);
            int SpriteHeight = (int)(vr.bitplane.bitmap.Height / numOfRawsNud.Value);

            NumericUpDown Nud = (NumericUpDown)sender;
            int SpriteNumber = (int)Nud.Value;
            sprImageBox.Image = sprites[(int)(Nud.Value)].bitmap;
            int SpriteXPos = (int)Nud.Value % (int)SpritesPerRawNud.Value, SpriteYPos = (int)Nud.Value / (int)SpritesPerRawNud.Value;

            Bitmap SelectedSpriteImage = new Bitmap(vr.bitplane.bitmap);
            Graphics SSI = Graphics.FromImage(SelectedSpriteImage);
            Pen p = new Pen(Color.Black, 2);
            SSI.DrawRectangle(p, SpriteXPos * SprireWidth, SpriteYPos * SpriteHeight, SprireWidth, SpriteHeight);
            SSI.Dispose();
            image.Image = SelectedSpriteImage;
            image.ScaleImage((int)(settings.previewScalingNud.Value));
        }

        private void SpriteSaveBtn_Click(object sender, EventArgs e)
        {
            SaveSprite sp = new SaveSprite();
            sp.sprites = sprites;
            sp.ShowDialog(this);
        }

        private void spriteWidthCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SliceBtn.Enabled = true;
        }

        private void image_MouseClick(object sender, MouseEventArgs e)
        {
            if (SlicedSpriteSheet)
            {
                int MouseX = e.X, MouseY = e.Y;

                int SprireWidth = (int)(image.Width / SpritesPerRawNud.Value);
                int SpriteHeight = (int)(image.Height / numOfRawsNud.Value);


                int SpriteXPos = (int)MouseX / SprireWidth, SpriteYPos = (int)MouseY / SpriteHeight;
                image.Image = vr.bitplane.bitmap;
                image.ScaleImage((int)(settings.previewScalingNud.Value));
                Bitmap SelectedSpriteImage = new Bitmap(image.Image);
                Graphics SSI = Graphics.FromImage(SelectedSpriteImage);
                Pen p = new Pen(Color.Black, 2 * (int)(settings.previewScalingNud.Value));
                SSI.DrawRectangle(p, SpriteXPos * SprireWidth, SpriteYPos * SpriteHeight, SprireWidth, SpriteHeight);
                SSI.Dispose();
                image.Image = SelectedSpriteImage;
                spriteSelectNud.Value = SpriteXPos + SpriteYPos * SpritesPerRawNud.Value;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            int test = 1;
        }

        private void MainForm_Enter(object sender, EventArgs e)
        {
            int test = 1;

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
    }
}
