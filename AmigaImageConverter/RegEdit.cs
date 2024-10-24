using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigaImageConverter
{
  
    internal class RegEdit
    {
        private static RegEdit instance = null;
        public RegistryKey regKey;
        public RegEdit() {
                      
            regKey = Registry.CurrentUser.OpenSubKey("Software\\AmigaToolsKit");

            if (regKey == null)
            {
                
                regKey = Registry.CurrentUser.CreateSubKey("Software\\AmigaImageConverter");
            }
               
        }
        public static RegEdit Instance
        {
            get
            {
                if (instance == null)
                    instance = new RegEdit();

                return instance;
            }
        }

    }

}
