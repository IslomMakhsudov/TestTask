namespace FigureAreaCalculator.Tests.Figures
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateAreaIsCorrect()
        {
            // Given
            double a = 4;
            double b = 6;
            double c = 23;

            var triangle = new Triangle(a, b, c);

            // When
            var result = triangle.CalculateArea();
            
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            // Then
            Assert.Equal(s, result);
        }

        [Fact]
        public void IsRightAngledIsCorrect()
        {
            // Given
            double a = 4;
            double b = 6;
            double c = 23;

            var triangle = new Triangle(a, b, c);

            // When
            var result = triangle.IsRightAngled();

            double[] areas = new double[] { a, b, c };
            
            double max = areas.Max();

            double d = areas.First(x => x != max);
            double e = areas.First(x => x != d && x != max);

            bool rightAgled = false;

             if(Math.Pow(max, 2) == (Math.Pow(d, 2) + Math.Pow(e, 2)))
                rightAgled = true;

            // Then
            Assert.Equal(rightAgled, result);
        }
    }
}