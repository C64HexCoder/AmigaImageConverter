using System.Windows.Forms;

namespace AmigaImageConverter
{
    internal static class NoImageMsgBox
    {
        static public void Show()
        {
            MessageBox.Show("Image Missing... Please upload an image first", "Image Missing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
