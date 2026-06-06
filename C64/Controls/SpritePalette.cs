using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C64.Graphics;

namespace C64.Controls
{
    public partial class SpritePalette : UserControl
    {
        byte spriteColorIndex;
        byte multiColor1Index;
        byte multiColor2Index;

        byte SpriteColorIndex
        {
            get => spriteColorIndex;

            set
            {
                spriteColorIndex = value;
                BackColor = C64Palette.GetColor(spriteColorIndex);
            }
        }

        byte MultiColor1Index 
        {
            get => multiColor1Index;
            set
            {
                multiColor1Index = value;
                
            }
        }
        byte MultiColor2Index 
        {
            get => multiColor2Index;
            set
            {
                multiColor2Index = value;
                BackColor = C64Palette.GetColor(multiColor2Index);
            }
        }
        public SpritePalette()
        {
            InitializeComponent();
            SpriteColorIndex = 1;
            MultiColor1Index = 2;
            MultiColor2Index = 3;
        }

        private void spriteColorColorSelector_ColorSelectorClicked(object sender, ColorSelectorEventArgs e)
        {
            SpriteColorIndex = e.C64ColorIndex;
        }

        private void multiColor1ColorSelector_ColorSelectorClicked(object sender, ColorSelectorEventArgs e)
        {
            MultiColor1Index = e.C64ColorIndex;
        }

        private void multiColor2ColorSelector_ColorSelectorClicked(object sender, ColorSelectorEventArgs e)
        {
            MultiColor2Index = e.C64ColorIndex;
        }
    }
}
