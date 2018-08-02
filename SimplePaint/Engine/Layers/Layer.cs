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
        
        /// <summary>
        /// модель холста. Координаты пикселя и его цвет
        /// </summary>
        public short[,,] DrawPlace { get; private set; }
        public int Width { get; private set; }
        public int Heigth { get; private set; }
        public bool IsVisible { get; set; }
        public string Name { get; set; }
        public int DisplayListNumber { get; set; }

        public Layer(int list, string name, int width, int heigth)
        {
            DisplayListNumber = list;
            Name = name;
            Width = width;
            Heigth = heigth;
            DrawPlace = new short[Width, Heigth, 4];
            DrawArrayInit();
            IsVisible = true;
        }
        public Layer(int list, string name, int width, int heigth, bool visibility) :
            this(list, name, width, heigth)
        {
            IsVisible = visibility;
        }
        protected void DrawArrayInit()
        {
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
        public virtual void Draw(Color color, Brush br, int x, int y)
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
                            DrawPlace[i, j, 0] = color.R;
                            DrawPlace[i, j, 1] = color.G;
                            DrawPlace[i, j, 2] = color.B;
                            DrawPlace[i, j, 3] = br.IsErase ? (short)1 : (short)0;
                        }

                    }
            }
        }

        /// <summary>
        /// Отрисовка всего слоя
        /// </summary>
        public void Render(bool UseDisplayList)
        {
            if (IsVisible)
            {
                if (UseDisplayList)
                {
                    Gl.glCallList(DisplayListNumber);
                }
                else
                {
                    int count = 0;
                    List<int> arr_data_vertex = new List<int>(); 
                    List<float> arr_data_colors = new List<float>();
                    
                    for (int i = 0; i < Width; i++)
                        for (int j = 0; j < Heigth; j++)
                        {
                            if (DrawPlace[i, j, 3] == 0)
                            {
                                count++;
                                arr_data_vertex.Add(i);
                                arr_data_vertex.Add(j);

                                for (int c = 0; c < 3; c++)
                                    arr_data_colors.Add((float)DrawPlace[i, j, c] / 255.0f);
                            }
                        }

                    Gl.glEnableClientState(Gl.GL_VERTEX_ARRAY);
                    Gl.glEnableClientState(Gl.GL_COLOR_ARRAY);

                    Gl.glColorPointer(3, Gl.GL_FLOAT, 0, arr_data_colors.ToArray());
                    Gl.glVertexPointer(2, Gl.GL_INT, 0, arr_data_vertex.ToArray());

                    Gl.glDrawArrays(Gl.GL_POINTS, 0, count);

                    Gl.glDisableClientState(Gl.GL_VERTEX_ARRAY);
                    Gl.glDisableClientState(Gl.GL_COLOR_ARRAY);
                }
            }
        }

        public void CreateNewList()
        {
            if (Gl.glIsList(DisplayListNumber) == Gl.GL_TRUE)
            {
                Gl.glDeleteLists(DisplayListNumber, 1);
                Gl.glGenLists(1);
            }

            Gl.glNewList(DisplayListNumber, Gl.GL_COMPILE);

            Render(false);

            Gl.glEndList();
        }

        public void ClearList()
        {
            if (Gl.glIsList(DisplayListNumber) == Gl.GL_TRUE)
                Gl.glDeleteLists(DisplayListNumber, 1);
        }


        public override string ToString()
        {
            return Name;
        }
        
    }
}
