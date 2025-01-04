using Amiga;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigaImageConverter
{
    public partial class EqualizingImagesInDirectory : Form
    {
        Sprite sprite = new Sprite();
        Color[] destPalette = null;

        public EqualizingImagesInDirectory()
        {
            InitializeComponent();
        }

        private void selectDirBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                folderTBox.Text = dialog.SelectedPath;
                Directory.SetCurrentDirectory(folderTBox.Text);


            }
        }

        private void loadPaletteBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "IFF Amiga File Format|*.iff";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sprite.LoadIFF(openFileDialog.FileName);
                destPalette = sprite.palette;
                colorsGrid.SetPalette(sprite.palette);
                paletteFileTb.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
            }
        }

        private void equalizeAllBtn_Click(object sender, EventArgs e)
        {
            string[] fileNames;// = new string[];
            fileNames = Directory.GetFiles(folderTBox.Text);
            Sprite sprite = new Sprite();

            progressBar.Maximum = fileNames.Length-1;

            for (int i = 0; i < fileNames.Length; i++)
            {
                
                sprite.LoadIFF(fileNames[i]);

                if (!sprite.ComparePalettes(destPalette))
                {
                    sprite.EqualizePalette(destPalette);
                    string saveFileName = Path.GetFileNameWithoutExtension(fileNames[i]) + stringToAddTb.Text + ".iff";
                    sprite.SaveILBM(saveFileName);

                        
                }
                progressBar.Value = i;

            }
            MessageBox.Show ("Finished Qualizing all the images in the folder","Equalizing succeeded",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
