using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AmigaImageConverter
{
    internal class ReadOnlyRichTextBox : RichTextBox
    {
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);
            HideCaret(this.Handle);
        }
    }
}
