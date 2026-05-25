using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace C64.Controls
{
    public partial class C64CharScreen : Amiga.ImageGrid
    {
        public C64CharScreen()
        {
            InitializeComponent();
        }

        public C64CharScreen(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
