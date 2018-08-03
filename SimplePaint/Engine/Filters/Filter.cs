using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    abstract class Filter
    {
        public Filter() => KernelMaps = new List<float[]>() { new float[9] };
        public List<float[]> KernelMaps { get; set; }
        abstract public void Apply(Layer layer);
        protected void PixelTransformation(Layer layer, float[] kernel, int corr, int coeff, bool need_count_correction)
        {
            float[] result_RGB = new float[3];
            int ProcessingCounter = 0;

            for (int X = 0; X < layer.Width; X++)
                for (int Y = 0; Y < layer.Heigth; Y++)
                {
                    for (int chanel = 0; chanel < 3; chanel++)
                    {
                        result_RGB[chanel] = 0;
                        ProcessingCounter = 0;
                        for (int kernel_y = -1; kernel_y < 2; kernel_y++)
                            for (int kernel_x = -1; kernel_x < 2; kernel_x++)
                            {
                                if (X + kernel_x < 0 || X + kernel_x >= layer.Width ||
                                    Y + kernel_y < 0 || Y + kernel_y > layer.Heigth)
                                    result_RGB[chanel] += ((float)layer.DrawPlace[X, Y, chanel]) * kernel[ProcessingCounter++] * coeff + corr;
                                else
                                    result_RGB[chanel] += ((float)layer.DrawPlace[X + kernel_x, Y + kernel_y, chanel]) * kernel[ProcessingCounter++] * coeff + corr;
                            }

                        if (ProcessingCounter != 0 && need_count_correction)
                            result_RGB[chanel] /= ProcessingCounter;
                        result_RGB[chanel] = result_RGB[chanel] < 0 ? 0 : result_RGB[chanel] > 255 ? 255 : result_RGB[chanel];

                        layer.DrawPlace[X, Y, chanel] = (short)result_RGB[chanel];
                    }
                }
        }
    }
}
