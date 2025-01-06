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
    public partial class SaveAFolderAs : Form
    {
        const byte Xoffset = 64, Yoffset = 44;

        string[] asmFileExt = { ".asm", ".s", ".i" };
        string[] cppFileExt = { ".cpp", ".c", ".h" };

        string[] fileNames;
        Sprite sprite = new Sprite();

        public SaveAFolderAs()
        {
            InitializeComponent();
            fileFormatComboBox.SelectedIndex = 0;
            spriteWidthComboBox.SelectedIndex = 0;
        }

        private ushort Xpos { get; set; }
        private ushort Ypos { get; set; }

        public int SpriteWidth
        {
            get
            {
                switch (fileFormatComboBox.SelectedIndex)
                {
                    default:
                    case 0: return 16;
                    case 1: return 32;
                    case 2: return 64;
                }
            }
        }

        public enum FileFormats
        {
            Assembly,
            CPP,
            Binary
        }

        public FileFormats FileFormat
        {
            get
            {
                switch (fileFormatComboBox.SelectedIndex)
                {
                    case 0:
                        return FileFormats.Assembly;
                    case 1:
                        return FileFormats.CPP;
                    case 2:
                        return FileFormats.Binary;
                    default:
                        return FileFormats.Assembly;

                }
            }
            private set
            {
                switch (FileFormat)
                {
                    default:
                    case FileFormats.Assembly:
                        fileFormatComboBox.SelectedIndex = 0;

                        fileExtensionComboBox.Items.Clear();

                        foreach (string ext in asmFileExt)
                            fileExtensionComboBox.Items.Add(ext);

                        fileExtensionComboBox.SelectedIndex = 0;
                        break;

                    case FileFormats.CPP:
                        fileFormatComboBox.SelectedIndex = 1;

                        fileExtensionComboBox.Items.Clear();

                        foreach (string ext in cppFileExt)
                            fileExtensionComboBox.Items.Add(ext);

                        fileExtensionComboBox.SelectedIndex = 0;
                        break;

                    case FileFormats.Binary:
                        fileFormatComboBox.SelectedIndex = 2;

                        fileExtensionComboBox.Items.Clear();

                        fileExtensionComboBox.Items.Add("bin");
                        fileExtensionComboBox.SelectedIndex = 0;
                        break;


                }
            }
        }

        private void fileFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox fileFormatComboBox = sender as ComboBox;

            switch (fileFormatComboBox.SelectedIndex)
            {

                case 0:
                    FileFormat = FileFormats.Assembly;
                    break;

                case 1:
                    FileFormat = FileFormats.CPP;
                    break;

                case 2:
                    FileFormat = FileFormats.Binary;
                    break;
            }
        }

        private void folderSelectBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                folderNameTextBox.Text = dialog.SelectedPath;

                fileNames = Directory.GetFiles(dialog.SelectedPath);

                if (fileNames.Length == 0)
                    MessageBox.Show ("No files found in the Folder","No Files Found",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void executeBtn_Click(object sender, EventArgs e)
        {
            Point SprPos = new Point(Xpos, Ypos);
            progressBar.Maximum = fileNames.Length - 1;

            if (fileNames.Length == 0)
            {
                MessageBox.Show ("No files found!!!\n" +
                    "Please select a Folder with IFF files to load as sprites","Files not found",MessageBoxButtons.OK,MessageBoxIcon.Error);

                return;
            }

            if (relativeCheckBox.Checked)
                SprPos = Sprite.ConvertAbsoluteToPhysicalPosition(Xpos, Ypos);

            for (int i = 0; i < fileNames.Length; i++)
            {
                List<Sprite> sprites;
                sprite.LoadIFF(fileNames[i]);
                Directory.SetCurrentDirectory(Path.GetDirectoryName(fileNames[i]));
                string newFileName = Path.GetFileNameWithoutExtension(fileNames[i]) + fileExtensionComboBox.SelectedItem;
                string spriteName = Path.GetFileNameWithoutExtension(fileNames[i]);

                if (sprite.Width > SpriteWidth)
                {
                    sprites = sprite.SplitSpriteToWidth(SpriteWidth);
                    int pNum = 0;
                    foreach (Sprite spr in sprites)
                    {
                        spr.Name = spriteName + "_P"+pNum++;
                        switch (FileFormat)
                        {
                            case FileFormats.Assembly:
                                spr.SaveAsAssemblerSourceFile(newFileName, Sprite.MemoryType.CHIP, SprPos.X+pNum*SpriteWidth, SprPos.Y, false, true);
                                break;
                            case FileFormats.CPP:
                                spr.SaveAsCPPSourceFile(newFileName, Sprite.MemoryType.CHIP, SprPos.X+pNum*SpriteWidth, SprPos.Y, false, true);
                                break;
                            case FileFormats.Binary:
                                string tmpFilename = Path.GetFileNameWithoutExtension(fileNames[i]) + pNum + fileExtensionComboBox.SelectedItem;
                                spr.SaveAsBinaryFile(tmpFilename);
                                break;
                        }
                    }
                }
                else
                {
                    sprite.Name = spriteName;
                    switch (FileFormat)
                    {
                        case FileFormats.Assembly:
                            sprite.SaveAsAssemblerSourceFile(newFileName, Sprite.MemoryType.CHIP, SprPos.X, SprPos.Y, false, false);
                            break;
                        case FileFormats.CPP:
                            sprite.SaveAsCPPSourceFile(newFileName, Sprite.MemoryType.CHIP, SprPos.X, SprPos.Y, false, false);
                            break;
                        case FileFormats.Binary:
                            sprite.SaveAsBinaryFile(newFileName);
                            break;
                    }
                }


                progressBar.Value = i;
            }
        }

        private void xPosNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Xpos = (ushort)numericUpDown.Value;
        }

        private void yPosNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Ypos = (ushort)numericUpDown.Value;
        }
    }
}
