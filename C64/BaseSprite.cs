using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public abstract class BaseSprite
    {
        public abstract int Width { get; }
        public abstract int Height { get; }

        // ה-Grid קורא וכותב פה, ולא מעניין אותו מה קורה בפנים
        public abstract int this[int x, int y] { get; set; }
    }
}