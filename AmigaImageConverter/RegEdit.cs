using Microsoft.Win32;

namespace AmigaImageConverter
{

    internal class RegEdit
    {
        private static RegEdit instance = null;
        public RegistryKey regKey;
        public RegEdit()
        {

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
