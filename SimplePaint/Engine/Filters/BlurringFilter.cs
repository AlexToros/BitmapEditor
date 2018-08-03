using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    class BlurringFilter : Filter
    {
        public BlurringFilter() : base()
        {
            for (int i = 0; i < KernelMaps[0].Length; i++)
                if (i == 4) KernelMaps[0][i] = 0.6f;
                else KernelMaps[0][i] = 0.05f;
        }
        public override void Apply(Layer layer)
        {
            PixelTransformation(layer, KernelMaps[0], 0, 1, false);
        }
    }
}
