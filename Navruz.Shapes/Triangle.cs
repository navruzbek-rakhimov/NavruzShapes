using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navruz.Shapes
{
    public class Triangle : Polygon
    {
        protected override double[] Sides { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class.
        /// </summary>
        /// <param name="a">First side of triangle</param>
        /// <param name="b">Second side of triangle</param>
        /// <param name="c">Third side of triangle</param>
        public Triangle(double a, double b, double c) : base(GalculateArea(a, b, c))
        {
            Sides = new double[] { a, b, c };
        }

        /// <summary>
        /// Returns boolean which tells if triangle is right angled
        /// </summary>
        public bool IsRightAngled => CheckIsRightAngled(Sides[0], Sides[1], Sides[2]);

        /// <summary>
        /// Checks if a triangle is right angled
        /// </summary>
        /// <param name="a">First side of triangle</param>
        /// <param name="b">Second side of triangle</param>
        /// <param name="c">Third side of triangle</param>
        public static bool CheckIsRightAngled(double a, double b, double c, double eps = 1E-6)
        {
            var sides = new[] { a, b, c };
            Array.Sort(sides);
            return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) <= eps;
        }

        /// <summary>
        /// Calculates the area of the triangle
        /// </summary>
        /// <param name="a">First side of triangle</param>
        /// <param name="b">Second side of triangle</param>
        /// <param name="c">Third side of triangle</param>
        /// <returns>Calculated area of the the triangle</returns>
        public static double GalculateArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Provided side length is not a positive");

            if (a + b < c || b + c < a || a + c < b)
                throw new ArgumentException("Provided sides do not form a triangle");

            var semiParameter = (a + b + c) / 2;

            var area = Math.Sqrt(semiParameter *
                (semiParameter - a) *
                (semiParameter - b) *
                (semiParameter - c));

            return area;
        }
    }
}
