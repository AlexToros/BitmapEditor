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
        protected bool[,] BrushMap { get; set; }
        public bool IsErase { get; set; }
        
        public bool this[int x, int y] { get { return BrushMap[x, y]; } }

        public int Width { get { return BrushMap.GetLength(0); } }
        public int Height { get { return BrushMap.GetLength(1); } }

        public Brush(int squareSize) : this(squareSize, squareSize) { }
        public Brush(int width, int height)
        {
            BrushMap = new bool[width, height];
            InitializeBrush();
        }
        public Brush() : this(5, 5) { }

        public virtual void InitializeBrush()
        {
            for (int i = 0; i < BrushMap.GetLength(0); i++)
                BrushMap[i, BrushMap.GetLength(1) / 2] = true;
            for (int j = 0; j < BrushMap.GetLength(1); j++)
                BrushMap[BrushMap.GetLength(0) / 2, j] = true;
        }

        public void ChangeSize(int newSize)
        {
            BrushMap = new bool[newSize, newSize];
            InitializeBrush();
        }
    }
}
