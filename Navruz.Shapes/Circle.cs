using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navruz.Shapes
{
    public class Circle : Shape
    {
        public Circle(double radius) : base(CalculateArea(radius)) { }

        /// <summary>
        /// Calculates area of the circle
        /// </summary>
        /// <param name="radius">Radius of the circle</param>
        /// <returns>Calculated area of the the circle</returns>
        public static double CalculateArea(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Provided radius value is not positive.");

            return Math.PI * radius * radius;
        } 
    }
}
