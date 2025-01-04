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
            saveOptionCbox.SelectedIndex = 1;
        }

        public enum SaveOptions
        {
            Overrite,
            ChangeName,
        }

        public SaveOptions SaveOption
        {
            get
            {
                if (saveOptionCbox.SelectedIndex == 0)
                    return SaveOptions.Overrite;
                else
                    return SaveOptions.ChangeName;
            }
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
            if (folderTBox.Text  == "Select Folder ")
            {
                
                MessageBox.Show("No Folder Selected\n" +
                    "Please Select a Folder you wich to work on\n" +
                    "and try again.", "No Folder Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                
            }
            fileNames = Directory.GetFiles(folderTBox.Text);
            Sprite sprite = new Sprite();

            if (destPalette ==  null)
            {
                MessageBox.Show("No Destination Palette Chosen\n" +
                    "Please Load A Palette you whish to change for\n" +
                    "and try again.", "No Destination Palette", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            progressBar.Maximum = fileNames.Length-1;

            for (int i = 0; i < fileNames.Length; i++)
            {
                
                sprite.LoadIFF(fileNames[i]);

                if (!sprite.ComparePalettes(destPalette))
                {
                    string saveFileName = Path.GetFileNameWithoutExtension(fileNames[i]);

                    sprite.EqualizePalette(destPalette);
                    if (SaveOption == SaveOptions.ChangeName)
                    {
                         saveFileName = saveFileName + stringToAddTb.Text + ".iff";
                    }
                        sprite.SaveILBM(saveFileName);

                        
                }
                progressBar.Value = i;

            }
            MessageBox.Show ("Finished Qualizing all the images in the folder","Equalizing succeeded",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
