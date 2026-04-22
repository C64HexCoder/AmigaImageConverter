using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Amiga
{
    // Simple color quantizer using a median-cut style algorithm.
    // Provides palette extraction and nearest-color remapping.
    public static class ColorQuantizer
    {
        public static List<Color> Quantize(Bitmap source, int maxColors)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (maxColors < 1) throw new ArgumentOutOfRangeException(nameof(maxColors));

            // Collect colors (unique) from the image
            var colorSet = new HashSet<int>();
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    Color c = source.GetPixel(x, y);
                    colorSet.Add((c.R << 16) | (c.G << 8) | c.B);
                }
            }

            var colors = colorSet.Select(rgb => new ColorTriplet(rgb)).ToList();

            if (colors.Count <= maxColors)
            {
                return colors.Select(t => Color.FromArgb(t.R, t.G, t.B)).ToList();
            }

            // Start with one box containing all colors
            var boxes = new List<ColorBox> { new ColorBox(colors) };

            // Split boxes until we have enough
            while (boxes.Count < maxColors)
            {
                // Pick the box with the largest color range to split
                var boxToSplit = boxes.OrderByDescending(b => b.Range).FirstOrDefault();
                if (boxToSplit == null || boxToSplit.Colors.Count <= 1)
                    break;

                boxes.Remove(boxToSplit);
                var pair = boxToSplit.Split();
                boxes.Add(pair.Item1);
                if (boxes.Count < maxColors && pair.Item2 != null)
                    boxes.Add(pair.Item2);
                else if (pair.Item2 != null && boxes.Count > maxColors)
                {
                    // If we overshot, stop splitting
                    break;
                }
            }

            // Average each box to create the palette
            var palette = boxes.Select(b => b.AverageColor()).ToList();
            return palette;
        }

        public static Bitmap ApplyPalette(Bitmap source, IList<Color> palette)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (palette == null) throw new ArgumentNullException(nameof(palette));
            if (palette.Count == 0) throw new ArgumentException("Palette must contain at least one color.", nameof(palette));

            var dst = new Bitmap(source.Width, source.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    var srcC = source.GetPixel(x, y);
                    Color best = palette[0];
                    int bestDist = ColorDistanceSquared(srcC, best);
                    for (int i = 1; i < palette.Count; i++)
                    {
                        int d = ColorDistanceSquared(srcC, palette[i]);
                        if (d < bestDist)
                        {
                            bestDist = d;
                            best = palette[i];
                        }
                    }
                    dst.SetPixel(x, y, best);
                }
            }
            return dst;
        }

        private static int ColorDistanceSquared(Color a, Color b)
        {
            int dr = a.R - b.R;
            int dg = a.G - b.G;
            int db = a.B - b.B;
            return dr * dr + dg * dg + db * db;
        }

        private class ColorTriplet
        {
            public int R { get; }
            public int G { get; }
            public int B { get; }

            public ColorTriplet(int rgb)
            {
                R = (rgb >> 16) & 0xFF;
                G = (rgb >> 8) & 0xFF;
                B = rgb & 0xFF;
            }
        }

        private class ColorBox
        {
            public List<ColorTriplet> Colors { get; }
            public int Rmin, Rmax, Gmin, Gmax, Bmin, Bmax;

            public ColorBox(List<ColorTriplet> colors)
            {
                Colors = colors ?? throw new ArgumentNullException(nameof(colors));
                RecalcBounds();
            }

            public int Range
            {
                get
                {
                    int rRange = Rmax - Rmin;
                    int gRange = Gmax - Gmin;
                    int bRange = Bmax - Bmin;
                    return Math.Max(rRange, Math.Max(gRange, bRange));
                }
            }

            public void RecalcBounds()
            {
                Rmin = Gmin = Bmin = 255;
                Rmax = Gmax = Bmax = 0;
                foreach (var c in Colors)
                {
                    if (c.R < Rmin) Rmin = c.R;
                    if (c.R > Rmax) Rmax = c.R;
                    if (c.G < Gmin) Gmin = c.G;
                    if (c.G > Gmax) Gmax = c.G;
                    if (c.B < Bmin) Bmin = c.B;
                    if (c.B > Bmax) Bmax = c.B;
                }
            }

            public Tuple<ColorBox, ColorBox> Split()
            {
                // Choose longest axis
                int rRange = Rmax - Rmin;
                int gRange = Gmax - Gmin;
                int bRange = Bmax - Bmin;

                if (Colors.Count <= 1)
                    return new Tuple<ColorBox, ColorBox>(this, null);

                if (rRange >= gRange && rRange >= bRange)
                    Colors.Sort((a, b) => a.R.CompareTo(b.R));
                else if (gRange >= rRange && gRange >= bRange)
                    Colors.Sort((a, b) => a.G.CompareTo(b.G));
                else
                    Colors.Sort((a, b) => a.B.CompareTo(b.B));

                int median = Colors.Count / 2;
                var left = Colors.Take(median).ToList();
                var right = Colors.Skip(median).ToList();

                var box1 = new ColorBox(left);
                var box2 = right.Count > 0 ? new ColorBox(right) : null;
                return new Tuple<ColorBox, ColorBox>(box1, box2);
            }

            public Color AverageColor()
            {
                if (Colors.Count == 0) return Color.Black;
                long r = 0, g = 0, b = 0;
                foreach (var c in Colors)
                {
                    r += c.R;
                    g += c.G;
                    b += c.B;
                }
                int cnt = Colors.Count;
                return Color.FromArgb((int)(r / cnt), (int)(g / cnt), (int)(b / cnt));
            }
        }
    }
}
