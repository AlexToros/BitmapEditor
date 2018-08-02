using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    class HiddenLayer : Layer
    {
        public HiddenLayer(int width, int heigth) : base(0,"", width, heigth) { }

        public override void Draw(Color color,Brush br, int x, int y)
        {
            DrawArrayInit();
            if (IsVisible)
            {
                int real_x = x < br.Width / 2 ? 0 : x - br.Width / 2;
                int real_y = y < br.Height / 2 ? 0 : y - br.Height / 2;

                int boundary_x = real_x + br.Width > Width ? Width : real_x + br.Width;
                int boundary_y = real_y + br.Height > Heigth ? Heigth : real_y + br.Height;

                for (int i = real_x, br_x = 0; i < boundary_x; i++, br_x++)
                    for (int j = real_y, br_y = 0; j < boundary_y; j++, br_y++)
                    {
                        if (br.IsErase)
                        {
                            if (br[br_x, br_y])
                            {
                                DrawPlace[i, j, 0] = 255;
                                DrawPlace[i, j, 1] = 255;
                                DrawPlace[i, j, 2] = 255;
                            }
                            else
                            {
                                DrawPlace[i, j, 0] = 0;
                                DrawPlace[i, j, 1] = 0;
                                DrawPlace[i, j, 2] = 0;
                            }
                            DrawPlace[i, j, 3] = 0;
                        }
                        else if (br[br_x, br_y])
                        {
                            DrawPlace[i, j, 0] = color.R;
                            DrawPlace[i, j, 1] = color.G;
                            DrawPlace[i, j, 2] = color.B;
                            DrawPlace[i, j, 3] = 0;
                        }
                    }
            }
        }
    }
}
