using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    class EraseBrush : Brush
    {
        public EraseBrush(int squareSize) : this(squareSize, squareSize) { }
        public EraseBrush(int width, int height) : base(width, height)
        {
            IsErase = true;
        }
        public EraseBrush() : this(5,5) { }
        public override void InitializeBrush()
        {
            for (int i = 1; i < BrushMap.GetLength(0) - 1; i++)
                for (int j = 1; j < BrushMap.GetLength(1) - 1; j++)
                    BrushMap[i, j] = true;
        }
    }
}
