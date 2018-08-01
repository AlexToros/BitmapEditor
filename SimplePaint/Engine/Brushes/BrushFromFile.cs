using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace SimplePaint
{
    class BrushFromFile : Brush
    {
        private Bitmap File;
        public BrushFromFile(string file, int width, int height) : base(width, height)
        {
            File = (Bitmap)Bitmap.FromFile(file);
        }
        public override void InitializeBrush()
        {
            for (int i = 0; i < BrushMap.GetLength(0); i++)
                for (int j = 0; j < BrushMap.GetLength(1); j++)
                {
                    Color c = File.GetPixel(i, j);
                    if (c.R != 255 || c.G != 0 || c.B != 0)
                        BrushMap[i, j] = true;
                    else
                        BrushMap[i, j] = false;
                }
        }
    }
}
