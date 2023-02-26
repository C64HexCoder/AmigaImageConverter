using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        enum BlitWord
        {
            None,
            Left,
            Right,
            Both
        }

        BlitWord AddedBlitWord = BlitWord.None;
        //List<Bitmap> bitmaps = new List<Bitmap>();

        public MainForm()
        {
            InitializeComponent();
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
       
                SlicingPanel.Left = image.Right + 2;
                SlicingPanel.Height = SlicingGb.Height;
                ButtomPanel.Top = image.Bottom + 2;
                ButtomPanel.Width = image.Width;
                bmp = new Bitmap(openImageFileDialog.FileName);

                vr.bitplane.bitmap = KMeansQuant.DecreaseColors(bmp);
    
                //vr.bitplane.LoadImage(openImageFileDialog.FileName);
                CheckImageAlignment();
                image.Image = vr.bitplane.bitmap;
                image.ScaleImage((int)settings.previewScalingNud.Value);


                if (vr.bitplane.Width > Width || vr.bitplane.Height > Height)
                {
                    Width = vr.bitplane.Width + 20;
                    Height = vr.bitplane.Height + menuStrip1.Height + statusStrip.Height + 60;
                }
                String name = Path.GetFileName(openImageFileDialog.FileName);
                toolStripFileName.Text = name;
                toolStripResolutionLabel.Text = $"{vr.bitplane.Width}x{vr.bitplane.Height}";
                toolStripDepthLabel.Text = $"{vr.bitplane.NumOfBitmaps} Bitmaps, new Width: {vr.bitplane.actualWidth}";

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
                    image.Image = vr.bitplane.bitmap;
                    image.ScaleImage((int)settings.previewScalingNud.Value);
                    SlicingPanel.Left = image.Right + 2;
                    ButtomPanel.Width = image.Width;
                    ButtomPanel.Top = image.Bottom + 2;
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
                if (iffImage.bmp != null)
                    pallate.imagePallate.SetPalette(iffImage.palette);
                else
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
            ButtomPanel.Top = image.Bottom+1;
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
            if (vr.bitplane.bitmap == null)
            {
                MessageBox.Show("Load Image First!", "You Drunk Or Something?");
                return;
            }

            Sprite sprite = new Sprite();
            sprite.ImportImage(vr.bitplane.bitmap);

            if (saveSourceFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (saveSourceFileDialog.FilterIndex)
                {
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
                    SprBmp.SetResolution(vr.bitplane.bitmap.HorizontalResolution, vr.bitplane.  bitmap.VerticalResolution);
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
                        MessageBox.Show("Left Word already added to the image.","Silly you...",MessageBoxButtons.OK);
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
            if (iffFile.ShowDialog() == DialogResult.OK )
            {
                vr.bitplane.LoadIFF (iffFile.FileName);
                image.Image = vr.bitplane.bitmap;
                image.ScaleImage ((int)settings.previewScalingNud.Value);
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

     
    }
}
