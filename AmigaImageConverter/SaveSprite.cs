using Amiga;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigaImageConverter
{
    public partial class SaveSprite : Form
    {
        public List<Sprite> sprites;
        public SaveSprite()
        {
            InitializeComponent();
            saveOptionsCb.SelectedIndex = 0;
        }

        public bool SaveAsMultiplyFiles
        {
            get
            {
                return multiFilesRadioButton.Checked;
            }
        }
      
        public enum SaveFormat
        {
            SourceCode,
            IFF
        }
        enum SaveType
        {
            Single,
            Range,
            All
        };
        SaveType saveType = SaveType.Single;
        struct Range
        {
            public int From;
            public int To;
        };

        Range SaveRange;
        private void SaveSprite_Load(object sender, EventArgs e)
        {
            imageBox.Image = sprites[0].bitmap;
            currentSpriteNud.Maximum = sprites.Count - 1;
            //imageBox.AutoScale();
            //imageBox.ScaleImage();
        }

        private void currentSpriteNud_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            imageBox.Image = sprites[(int)numericUpDown.Value].bitmap;
            // imageBox.AutoScale();
        }

        delegate void SaveSpriteFunc(string fileName);
        SaveSpriteFunc SaveSprites;
        private void saveOptionsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (saveOptionsCb.SelectedIndex)
            {
                // Single Sprite
                case 0:
                    RangeGb.Enabled = false;
                    saveType = SaveType.Single;
                    multiFilesRadioButton.Checked = true;
                    saveAsGB.Enabled = false;
                    break;
                // Range of Sprites
                case 1:
                    RangeGb.Enabled = true;
                    saveAsGB.Enabled = true;
                    fromNud.Value = 0;
                    toNud.Value = sprites.Count - 1;
                    fromNud.ReadOnly = false; toNud.ReadOnly = false;
                    saveType = SaveType.Range;
                    break;
                // All Sprites
                case 2:
                    RangeGb.Enabled = false;
                    saveAsGB.Enabled = true;
                    toNud.ReadOnly = true; fromNud.ReadOnly = true;
                    saveType = SaveType.All;
                    break;
            }
        }



        private void SpriteSaveBtn_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
       
            saveFileDialog.Filter = SaveAsMultiplyFiles
                ? "Assembler Source Code|*.asm;*.s;*.a|C/Cpp Source Code|*.c;*.cpp|Binary File|*.bin|IFF ILBM File|*.iff;*.ilbm"
                : "Assembler Source Code|*.asm;*.s;*.a|C/Cpp Source Code|*.c;*.cpp|IFF ILBM File|*.iff;*.ilbm";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (SaveAsMultiplyFiles)
                {
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            SaveAsAsm(saveFileDialog.FileName);
                            break;
                        case 2:
                            SaveAsC(saveFileDialog.FileName);
                            break;
                        case 3:
                            SaveAsBin(saveFileDialog.FileName);
                            break;
                        case 4:
                            SaveAsIFF(saveFileDialog.FileName);
                            break;
                    }

                }
                else // Single file
                {
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            SaveAsAsm(saveFileDialog.FileName);
                            break;
                        case 2:
                            SaveAsC(saveFileDialog.FileName);
                            break;
                        case 3:
                            // Save multiple sprites in a single IFF file with a common palette
                            IFF.SaveSpriteAnimation(saveFileDialog.FileName, sprites);
                            break;

                    }
                }
            }
            
            Close();

        }

        private void SaveAsC(string fileName)
        {
            int i;
            string NewFileName;

            switch (saveType)
            {
                case SaveType.Single:
                    sprites[(int)currentSpriteNud.Value].SaveAsCPPSourceFile(fileName);
                    break;
                case SaveType.Range:
                    fileName = Path.ChangeExtension(fileName, null);
                    for (i = SaveRange.From; i <= SaveRange.To; i++)
                    {
                        NewFileName = fileName + i + ".C";
                        sprites[i].SaveAsCPPSourceFile(NewFileName);
                    }
                    break;
                case SaveType.All:
                    i = 0;
                    fileName = Path.ChangeExtension(fileName, null);
                    foreach (Sprite sprite in sprites)
                    {
                        NewFileName = fileName + i++ + ".C";
                        sprite.SaveAsCPPSourceFile(NewFileName);
                    }
                    break;
            }
        }

        private void SaveAsAsm(string fileName)
        {
            int i;
            string NewFileName;

            switch (saveType)
            {
                case SaveType.Single:
                    sprites[(int)currentSpriteNud.Value].SaveAsAssemblerSourceFile(fileName);
                    break;
                case SaveType.Range:
                    fileName = Path.ChangeExtension(fileName, null);
                    for (i = SaveRange.From; i <= SaveRange.To; i++)
                    {
                        NewFileName = fileName + i + ".Asm";
                        sprites[i].SaveAsAssemblerSourceFile(NewFileName);
                    }
                    break;
                case SaveType.All:
                    i = 0;
                    fileName = Path.ChangeExtension(fileName, null);
                    foreach (Sprite sprite in sprites)
                    {
                        NewFileName = fileName + i++ + ".Asm";
                        sprite.SaveAsAssemblerSourceFile(NewFileName);
                    }
                    break;
            }
        }

        private void SaveAsBin(string fileName)
        {
            int i;
            string NewFileName;

            switch (saveType)
            {
                case SaveType.Single:
                    sprites[(int)currentSpriteNud.Value].SaveAsBinaryFile(fileName);
                    break;
                case SaveType.Range:
                    fileName = Path.ChangeExtension(fileName, null);
                    for (i = SaveRange.From; i <= SaveRange.To; i++)
                    {
                        NewFileName = fileName + i + ".Bin";
                        sprites[i].SaveAsBinaryFile(NewFileName);
                    }
                    break;
                case SaveType.All:
                    i = 0;
                    fileName = Path.ChangeExtension(fileName, null);
                    foreach (Sprite sprite in sprites)
                    {
                        NewFileName = fileName + i++ + ".Bin";
                        sprite.SaveAsBinaryFile(NewFileName);
                    }
                    break;
            }
        }

        private void SaveAsIFF(string fileName)
        {
            int i;
            string NewFileName;
            switch (saveType)
            {
                case SaveType.Single:
                    sprites[(int)currentSpriteNud.Value].SaveILBM(fileName);
                    break;
                case SaveType.Range:
                    fileName = Path.ChangeExtension(fileName, null);
                    for (i = SaveRange.From; i <= SaveRange.To; i++)
                    {
                        NewFileName = fileName + i + ".Iff";
                        sprites[i].SaveILBM(NewFileName);
                    }
                    break;
                case SaveType.All:
                    i = 0;
                    fileName = Path.ChangeExtension(fileName, null);
                    foreach (Sprite sprite in sprites)
                    {
                        NewFileName = fileName + i++ + ".Iff";
                        sprite.SaveILBM(NewFileName);
                    }
                    break;
            }
        }

        // Example method to save multiple images with a common palette as an IFF ILBM file
        public void SaveImagesWithCommonPaletteAsIFF(string filename, List<byte[,]> bitmaps, Color[] palette, int width, int height, int numPlanes)
        {
            using (var file = File.OpenWrite(filename))
            using (var writer = new BinaryWriter(file))
            {
                // Write FORM header
                writer.Write(Encoding.ASCII.GetBytes("FORM"));
                long formSizePos = writer.BaseStream.Position;
                writer.Write(0); // Placeholder for FORM size

                // Write ILBM type
                writer.Write(Encoding.ASCII.GetBytes("ILBM"));

                // Write shared CMAP chunk
                writer.Write(Encoding.ASCII.GetBytes("CMAP"));
                writer.Write(BitConverter.GetBytes((uint)(palette.Length * 3)).Reverse().ToArray());
                foreach (var color in palette)
                {
                    writer.Write(color.R);
                    writer.Write(color.G);
                    writer.Write(color.B);
                }

                // Write each image's BMHD and BODY
                foreach (var bitplanes in bitmaps)
                {
                    // BMHD
                    writer.Write(Encoding.ASCII.GetBytes("BMHD"));
                    writer.Write(BitConverter.GetBytes((uint)20).Reverse().ToArray());
                    writer.Write(BitConverter.GetBytes((ushort)width).Reverse().ToArray());
                    writer.Write(BitConverter.GetBytes((ushort)height).Reverse().ToArray());
                    writer.Write(BitConverter.GetBytes((ushort)0).Reverse().ToArray()); // xOrigin
                    writer.Write(BitConverter.GetBytes((ushort)0).Reverse().ToArray()); // yOrigin
                    writer.Write((byte)numPlanes);
                    writer.Write((byte)0); // mask
                    writer.Write((byte)0); // compression
                    writer.Write((byte)0); // pad1
                    writer.Write(BitConverter.GetBytes((ushort)0).Reverse().ToArray()); // transClr
                    writer.Write((byte)1); // xAspect
                    writer.Write((byte)1); // yAspect
                    writer.Write(BitConverter.GetBytes((ushort)width).Reverse().ToArray());
                    writer.Write(BitConverter.GetBytes((ushort)height).Reverse().ToArray());

                    // BODY
                    writer.Write(Encoding.ASCII.GetBytes("BODY"));
                    int widthInBytes = ((width + 15) / 16) * 2;
                    int bodySize = numPlanes * widthInBytes * height;
                    writer.Write(BitConverter.GetBytes((uint)bodySize).Reverse().ToArray());
                    for (int y = 0; y < height; y++)
                        for (int bp = 0; bp < numPlanes; bp++)
                            for (int x = 0; x < widthInBytes; x++)
                                writer.Write(bitplanes[bp, y * widthInBytes + x]);
                }

                // Update FORM size
                long endPos = writer.BaseStream.Position;
                long formSize = endPos - formSizePos - 4;
                writer.Seek((int)formSizePos, SeekOrigin.Begin);
                writer.Write(BitConverter.GetBytes((uint)formSize).Reverse().ToArray());
            }
        }

        public void SaveSpriteAnimationIFF(string filename, List<byte[,]> frames, Color[] palette, int width, int height, int numPlanes)
        {
            using var file = File.OpenWrite(filename);
            using var writer = new BinaryWriter(file);

            // Write FORM header
            writer.Write(Encoding.ASCII.GetBytes("FORM"));
            long formSizePos = writer.BaseStream.Position;
            writer.Write(0); // Placeholder for FORM size

            // Write custom type, e.g., "SPRT"
            writer.Write(Encoding.ASCII.GetBytes("SPRT"));

            // Write shared CMAP
            writer.Write(Encoding.ASCII.GetBytes("CMAP"));
            writer.Write(BitConverter.GetBytes((uint)(palette.Length * 3)).Reverse().ToArray());
            foreach (var color in palette)
            {
                writer.Write(color.R);
                writer.Write(color.G);
                writer.Write(color.B);
            }

            // Write ANIM chunk
            writer.Write(Encoding.ASCII.GetBytes("ANIM"));
            long animSizePos = writer.BaseStream.Position;
            writer.Write(0); // Placeholder for ANIM size

            // Write frame count
            writer.Write(BitConverter.GetBytes((ushort)frames.Count).Reverse().ToArray());

            int widthInBytes = ((width + 15) / 16) * 2;

            foreach (var bitplanes in frames)
            {
                // BMHD
                writer.Write(Encoding.ASCII.GetBytes("BMHD"));
                // BMHD size is always 20 bytes
                writer.Write(BitConverter.GetBytes((uint)20).Reverse().ToArray());
                // BMHD fields
                writer.Write(BitConverter.GetBytes((ushort)width).Reverse().ToArray());
                writer.Write(BitConverter.GetBytes((ushort)height).Reverse().ToArray());
                writer.Write(BitConverter.GetBytes((ushort)0).Reverse().ToArray()); // xOrigin
                writer.Write(BitConverter.GetBytes((ushort)0).Reverse().ToArray()); // yOrigin
                writer.Write((byte)numPlanes);
                writer.Write((byte)0); // mask
                writer.Write((byte)0); // compression
                writer.Write((byte)0); // pad1
                writer.Write(BitConverter.GetBytes((ushort)0).Reverse().ToArray()); // transClr
                writer.Write((byte)1); // xAspect
                writer.Write((byte)1); // yAspect
                writer.Write(BitConverter.GetBytes((ushort)width).Reverse().ToArray());
                writer.Write(BitConverter.GetBytes((ushort)height).Reverse().ToArray());

                // BODY
                writer.Write(Encoding.ASCII.GetBytes("BODY"));
                int bodySize = numPlanes * widthInBytes * height;
                writer.Write(BitConverter.GetBytes((uint)bodySize).Reverse().ToArray());
                for (int y = 0; y < height; y++)
                    for (int bp = 0; bp < numPlanes; bp++)
                        for (int x = 0; x < widthInBytes; x++)
                            writer.Write(bitplanes[bp, y * widthInBytes + x]);
            }

            // Update ANIM size
            long animEnd = writer.BaseStream.Position;
            long animSize = animEnd - animSizePos - 4;
            writer.Seek((int)animSizePos, SeekOrigin.Begin);
            writer.Write(BitConverter.GetBytes((uint)animSize).Reverse().ToArray());
            writer.Seek((int)animEnd, SeekOrigin.Begin);

            // Update FORM size
            long endPos = writer.BaseStream.Position;
            long formSize = endPos - formSizePos - 4;
            writer.Seek((int)formSizePos, SeekOrigin.Begin);
            writer.Write(BitConverter.GetBytes((uint)formSize).Reverse().ToArray());
        }

        private void fromNud_ValueChanged(object sender, EventArgs e)
        {
            SaveRange.From = (int)((NumericUpDown)sender).Value;
        }

        private void toNud_ValueChanged(object sender, EventArgs e)
        {
            SaveRange.To = (int)((NumericUpDown)sender).Value;
        }

        private void MultiFilesRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}


