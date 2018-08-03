using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    sealed class InverseFilter : Filter
    {
        public override void Apply(Layer layer)
        {
            for (int i = 0; i < layer.Width; i++)
                for (int j = 0; j < layer.Heigth; j++)
                    for (int k = 0; k < 3; k++)
                        layer.DrawPlace[i, j, k] = (short)(255 - layer.DrawPlace[i, j, k]);
        }
    }
}
