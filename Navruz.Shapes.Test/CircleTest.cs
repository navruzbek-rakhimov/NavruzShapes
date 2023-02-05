using Xunit;

namespace Navruz.Shapes.Test
{
    public class CircleShould
    {
        /// <summary>
        /// Test for ArgumentException the radius of the circle is zero
        /// Should throw ArgumentException!
        /// </summary>
        [Fact]
        public void ThrowException_WhenCircleRadiusIsZero()
        {
            Exception actualException = Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Equal("Provided radius value is not positive.", actualException.Message);
        }


        /// <summary>
        /// Test for ArgumentException when the radius of the circle is less than zero
        /// </summary>
        [Fact]
        public void ThrowException_WhenRadiusIsLessThanZero()
        {
            Exception actualException = Assert.Throws<ArgumentException>(() => new Circle(-0.5));
            Assert.Equal("Provided radius value is not positive.", actualException.Message);
        }


        /// <summary>
        /// Test the circle area calculation
        /// </summary>
        [Fact]
        public void CalculateArea_WhenRadiusIsValid()
        {
            var circle = new Circle(5.675);

            var area = circle.GetArea();

            Assert.Equal(101.177, area, 3);
        }
    }
}