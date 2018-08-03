using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    class ContrastIncreaseFilter : Filter
    {
        public ContrastIncreaseFilter() : base()
        {
            for (int i = 0; i < KernelMaps[0].Length; i++)
                if (i == 4) KernelMaps[0][i] = 1.8f;
                else KernelMaps[0][i] = -0.1f;
        }
        public override void Apply(Layer layer)
        {
            layer.DrawPlace = PixelTransformation(layer.DrawPlace, KernelMaps[0], 0, 1, false,false);
        }
    }
}
