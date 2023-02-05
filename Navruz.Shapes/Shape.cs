using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navruz.Shapes
{
    public abstract class Shape : IShape
    {
        private readonly double area;

        protected Shape(double area)
        {
            this.area = area;
        }

        public double GetArea() => area;

        // protected abstract double CalculateArea();
    }
}
