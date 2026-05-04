using System.Reflection;
using System.Windows.Forms;

namespace AmigaImageConverter
{
    public partial class About : Form
    {

        public About()
        {
            InitializeComponent();
            versionLable.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }


    }
}
