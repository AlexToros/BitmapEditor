using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    class WatercolorFilter : Filter
    {
        public WatercolorFilter() : base()
        {
            KernelMaps.Add(new float[9]);

            for (int i = 0; i < KernelMaps[0].Length; i++)
                if (i == 4) KernelMaps[0][i] = 2.0f;
                else if (i % 2 == 0) KernelMaps[0][i] = 0.5f;
                else KernelMaps[0][i] = 1.0f;

            for (int i = 0; i < KernelMaps[1].Length; i++)
                if (i == 4) KernelMaps[1][i] = 6.0f;
                else KernelMaps[1][i] = -0.5f;
        }
        public override void Apply(Layer layer)
        {
            short[,,] temp = PixelTransformation(layer.DrawPlace, KernelMaps[0], 0, 2, true,false);
            layer.DrawPlace = PixelTransformation(temp, KernelMaps[1], 0, 1, false,false);
        }
    }
}
