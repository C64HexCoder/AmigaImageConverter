﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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
