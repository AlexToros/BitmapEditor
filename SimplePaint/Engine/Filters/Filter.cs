using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint.Engine.Filters
{
    abstract class Filter
    {
        abstract public float[] Kernel { get; set; }
        abstract public void Apply(Layer layer);
    }
}
