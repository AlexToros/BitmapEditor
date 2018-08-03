using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    class EmbosingFilter : Filter
    {
        public EmbosingFilter()
        {
            for (int i = 0; i < KernelMaps[0].Length; i++)
                if (i == 4) KernelMaps[0][i] = 8.0f;
                else KernelMaps[0][i] = -1.0f;
        }
        public override void Apply(Layer layer)
        {
            PixelTransformation(layer.DrawPlace, KernelMaps[0], 0, 2, true,true);
        }
    }
}
