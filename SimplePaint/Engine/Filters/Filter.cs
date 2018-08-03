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
        protected short[,,] PixelTransformation(short[,,] layer, float[] kernel, int corr, int coeff, bool need_count_correction, bool isCacheChanging)
        {
            float[] result_RGB = new float[3];
            int ProcessingCounter = 0;
            short[,,] temp = new short[layer.GetLength(0), layer.GetLength(1), 4];
            for (int X = 0; X < layer.GetLength(0); X++)
                for (int Y = 0; Y < layer.GetLength(1); Y++)
                {
                    temp[X, Y, 3] = layer[X, Y, 3];
                    for (int chanel = 0; chanel < 3; chanel++)
                    {
                        result_RGB[chanel] = 0;
                        ProcessingCounter = 0;
                        for (int kernel_y = -1; kernel_y < 2; kernel_y++)
                            for (int kernel_x = -1; kernel_x < 2; kernel_x++)
                            {
                                if (X + kernel_x < 0 || X + kernel_x >= layer.GetLength(0) ||
                                    Y + kernel_y < 0 || Y + kernel_y >= layer.GetLength(1))
                                    result_RGB[chanel] += ((float)layer[X, Y, chanel]) * kernel[ProcessingCounter++] * coeff + corr;
                                else
                                    result_RGB[chanel] += ((float)layer[X + kernel_x, Y + kernel_y, chanel]) * kernel[ProcessingCounter++] * coeff + corr;
                            }

                        if (ProcessingCounter != 0 && need_count_correction)
                            result_RGB[chanel] /= ProcessingCounter;
                        result_RGB[chanel] = result_RGB[chanel] < 0 ? 0 : result_RGB[chanel] > 255 ? 255 : result_RGB[chanel];

                        temp[X, Y, chanel] = (short)result_RGB[chanel];
                        if (isCacheChanging)
                            layer[X, Y, chanel] = (short)result_RGB[chanel];
                    }
                }
            return temp;
        }
    }
}
