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
        protected void PixelTransformation(Layer layer, int corr, int coeff, bool need_count_correction)
        {
            float[] result_RGB = new float[3];
            int ProcessingCounter = 0;

            for (int X = 0; X < layer.Width; X++)
                for (int Y = 0; Y < layer.Heigth; Y++)
                    for (int chanel = 0; chanel < 3; chanel++)
                    {
                        result_RGB[chanel] = 0;
                        ProcessingCounter = 0;
                    }
        }
    }
}
