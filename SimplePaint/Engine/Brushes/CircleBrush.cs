using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    class CircleBrush : Brush
    {
        public CircleBrush(int size) : base(size, size) { }

        public override void InitializeBrush()
        {
            Func<double, double, bool> predicate = (x, y) => x * x + y * y <= Math.Pow(Width / 2.0f,2);
            
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    if (predicate((double)i - Width / 2.0f, (double)j - Height / 2.0f))
                        BrushMap[i, j] = true;
        }
    }
}
