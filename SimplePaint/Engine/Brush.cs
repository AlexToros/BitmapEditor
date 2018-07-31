using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    class Brush
    {
        /// <summary>
        /// Маска кисти
        /// </summary>
        private bool[,] BrushMap { get; set; }

        public bool this[int x, int y] { get { return BrushMap[x, y]; } }

        public int Width { get { return BrushMap.GetLength(0); } }
        public int Height { get { return BrushMap.GetLength(1); } }

        public Brush()
        {
            BrushMap = new bool[5,5];

            for (int i = 0; i < 5; i++)
            {
                BrushMap[i, 2] = true;
                BrushMap[2, i] = true;
            }

        }
    }
}
