using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace SimplePaint
{
    class Layer
    {

        public static Color ActiveColor { get; set; }
        /// <summary>
        /// модель холста. Координаты пикселя и его цвет
        /// </summary>
        public int[,,] DrawPlace { get; private set; }
        public int Width { get; private set; }
        public int Heigth { get; private set; }
        public bool IsVisible { get; set; }
        public string Name { get; set; }
        
        public Layer(string name, int width, int heigth)
        {
            Name = name;
            Width = width;
            Heigth = heigth;
            DrawArrayInit();
            IsVisible = true;
            ActiveColor = Color.Black;
            
        }
        public Layer(string name, int width, int heigth, bool visibility) :
            this(name, width, heigth)
        {
            IsVisible = visibility;
        }
        public void DrawArrayInit()
        {
            DrawPlace = new int[Width, Heigth, 4];//4 - RGBA
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Heigth; j++)
                    DrawPlace[i, j, 3] = 1;//прозрачность
        }
        /// <summary>
        /// Рисование на слое
        /// </summary>
        /// <param name="br">кисть</param>
        /// <param name="x">координата по оси x</param>
        /// <param name="y">координата по оси y</param>
        public void Draw(Brush br, int x, int y)
        {
            if (IsVisible)
            {
                int real_x = x < br.Width / 2 ? 0 : x - br.Width / 2;
                int real_y = y < br.Height / 2 ? 0 : y - br.Height / 2;

                int boundary_x = real_x + br.Width > Width ? Width : real_x + br.Width;
                int boundary_y = real_y + br.Height > Heigth ? Heigth : real_y + br.Height;

                for (int i = real_x, br_x = 0; i < boundary_x; i++, br_x++)
                    for (int j = real_y, br_y = 0; j < boundary_y; j++, br_y++)
                    {
                        if (br[br_x, br_y])
                        {
                            DrawPlace[i, j, 0] = ActiveColor.R;
                            DrawPlace[i, j, 1] = ActiveColor.G;
                            DrawPlace[i, j, 2] = ActiveColor.B;
                            DrawPlace[i, j, 3] = 0;
                        }
                    }
            }
        }

        /// <summary>
        /// Отрисовка всего слоя
        /// </summary>
        public void Render()
        {
            if (IsVisible)
            {
                Gl.glBegin(Gl.GL_POINTS);

                for (int i = 0; i < Width; i++)
                    for (int j = 0; j < Heigth; j++)
                    {
                        if (DrawPlace[i, j, 3] != 1)
                        {
                            Gl.glColor3f(DrawPlace[i, j, 0], DrawPlace[i, j, 1], DrawPlace[i, j, 2]);
                            Gl.glVertex2i(i, j);
                        }
                    }
                Gl.glEnd();
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
