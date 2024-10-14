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
            NumericUpDown numericUpDown= (NumericUpDown)sender;
            imageBox.Image = sprites[(int)numericUpDown.Value].bitmap;
           // imageBox.AutoScale();
        }

        delegate void SaveSpriteFunc(string fileName);
        SaveSpriteFunc SaveSprites;
        private void saveOptionsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (saveOptionsCb.SelectedIndex)
            {
                case 0:
                    RangeGb.Enabled= false;
                    saveType = SaveType.Single;
                    break;
                case 1:
                    RangeGb.Enabled= true;
                    fromNud.Value= 0;
                    toNud.Value = sprites.Count - 1;
                    fromNud.ReadOnly=false; toNud.ReadOnly=false;
                    saveType = SaveType.Range;
                    break;
                case 2:
                    RangeGb.Enabled = false;
                    toNud.ReadOnly = true; fromNud.ReadOnly=true;
                    saveType = SaveType.All;
                    break;
            }
        }

        

        private void SpriteSaveBtn_Click(object sender, EventArgs e)
        {
       
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Assembler Source Code|*.asm;*.s;*.a|C/Cpp Source Code|*.c;*.cpp|Binary File|*.bin";

          

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
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
                }
            }

            Close();
     
        }

        private void SaveAsC (string fileName)
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
                    fileName = Path.ChangeExtension (fileName,null);
                    foreach (Sprite sprite in sprites)
                    {
                        NewFileName = fileName + i++ + ".C";
                        sprite.SaveAsCPPSourceFile(NewFileName);
                    }
                    break;
            }
        }

        private void SaveAsAsm (string fileName)
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

        private void SaveAsBin (string fileName)
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

    

        private void fromNud_ValueChanged(object sender, EventArgs e)
        {
            SaveRange.From = (int)((NumericUpDown)sender).Value;
        }

        private void toNud_ValueChanged(object sender, EventArgs e)
        {
            SaveRange.To = (int)((NumericUpDown)sender).Value;
        }
    }
}
