using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navruz.Shapes
{
    public abstract class Polygon : Shape
    {
        protected abstract double[] Sides { get; set; }

        protected Polygon(double area) : base(area) { }
    }
}
