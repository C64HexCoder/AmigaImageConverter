using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmigaBitplane;

namespace AmigaImageConverter
{
    internal class PublicVariables
    {
        public static PublicVariables _instance;

        public Bitplane.OutputSize outputSize = Bitplane.OutputSize.Word;
        public int NumInARow = 8;
        public ushort BaseColor = 0x180;
        public byte bpp = 4;

        public static PublicVariables instance
        {
            get { 
                if (_instance == null)
                    instance = new PublicVariables();

                return _instance; 
            }
            set { _instance = value; }
        }

       /* public PublicVariables()
        { 
            if (instance == null)
                instance = new PublicVariables();
        }*/
    }
}
