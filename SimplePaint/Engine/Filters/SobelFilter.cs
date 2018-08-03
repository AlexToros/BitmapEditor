using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    class SobelFilter : Filter
    {
        public SobelFilter() : base()
        {
            KernelMaps[0][0] = KernelMaps[0][6] = 1;
            KernelMaps[0][2] = KernelMaps[0][8] = -1;
            KernelMaps[0][3] = 2;
            KernelMaps[0][5] = -2;

            KernelMaps.Add(new float[9]);

            KernelMaps[1][0] = KernelMaps[1][2] = -1;
            KernelMaps[1][6] = KernelMaps[1][8] = 1;
            KernelMaps[1][7] = 2;
            KernelMaps[1][1] = -2;
        }
        public override void Apply(Layer layer)
        {
            short[,,] temp1 = PixelTransformation(layer.DrawPlace, KernelMaps[0], 0, 1, false,false);
            short[,,] temp2 = PixelTransformation(layer.DrawPlace, KernelMaps[0], 0, 1, false,false);

            for (int X = 0; X < layer.Width; X++)
                for (int Y = 0; Y < layer.Heigth; Y++)
                    for (int ch = 0; ch < 3; ch++)
                        layer.DrawPlace[X, Y, ch] = (short)Math.Sqrt(Math.Pow(temp1[X, Y, ch], 2) + Math.Pow(temp2[X, Y, ch], 2));
        }
    }
}
