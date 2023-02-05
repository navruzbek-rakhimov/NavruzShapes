using Xunit;

namespace Navruz.Shapes.Test
{
    public class RectangleShould
    {
        /// <summary>
        /// Test for ArgumentException when one or more sides of triangle is zero
        /// </summary>
        [Fact]
        public void ThrowException_WhenSideIsZero()
        {
            Exception actualException = Assert.Throws<ArgumentException>(() => new Triangle(6.0, 0.0, 4.0));
            Assert.Equal("Provided side length is not a positive", actualException.Message);
        }


        /// <summary>
        /// Test for ArgumentException one or more sides of triangle is less than zero
        /// </summary>
        [Fact]
        public void ThrowException_WhenSideIsLessThanZero()
        {
            Exception actualException = Assert.Throws<ArgumentException>(() => new Triangle(6.0, 10.0, -4.0));
            Assert.Equal("Provided side length is not a positive", actualException.Message);
        }


        /// <summary>
        /// Test for ArgumentException when triangles cannot be formed from the given side parameters
        /// </summary>
        [Fact]
        public void ThrowException_WhenTriangleCannotBeCreated()
        {
            Exception actualException = Assert.Throws<ArgumentException>(() => new Triangle(25, 10, 5));
            Assert.Equal("Provided sides do not form a triangle", actualException.Message);
        }


        /// <summary>
        /// Test the triangle area calculation
        /// </summary>
        [Fact]
        public void CalculateArea()
        {
            var triangle = new Triangle(30, 45, 50);

            var area = triangle.GetArea();

            Assert.Equal(666.58528, area, 5);
        }


        /// <summary>
        /// Test when triangle is right angled
        /// </summary>
        [Fact]
        public void IsRightAngled()
        {
            var triangle = new Triangle(3, 4, 5);

            var isRightAngled = triangle.IsRightAngled;

            Assert.True(isRightAngled);
        }


        /// <summary>
        /// Test when triangle is not right angled
        /// </summary>
        [Fact]
        public void TriangleIsNotRight()
        {
            var triangle = new Triangle(7, 7, 7);

            var isRightAngled = triangle.IsRightAngled;

            Assert.False(isRightAngled);
        }
    }
}