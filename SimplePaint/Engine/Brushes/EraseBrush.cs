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
        public EraseBrush(int size) : base(size)
        {
            IsErase = true;
        }
        public EraseBrush() : this(5) { }
        public override void InitializeBrush()
        {
            for (int i = 1; i < BrushMap.GetLength(0) - 1; i++)
                for (int j = 1; j < BrushMap.GetLength(1) - 1; j++)
                    BrushMap[i, j] = true;
        }
    }
}
