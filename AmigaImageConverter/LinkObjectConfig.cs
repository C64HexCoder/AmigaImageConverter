using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigaImageConverter
{
    public partial class LinkObjectConfig : Form
    {
        public LinkObjectConfig()
        {
            InitializeComponent();
        }

        public byte MemoryType
        {
            get
            {
                switch (memoryTypeComboBox.SelectedIndex)
                {
                    case 0:
                        return 0;
                        break;

                    case 1:
                        return 0x40;
                        break;
                    case 2:
                        return 0x80;
                        break;

                    default:
                        return 0;

                }
            }
        }

        public String ExternalDescriptor
        {
            get
            {
                return externalDescriptorTextBox.Text;
            }
        }
    }
}
