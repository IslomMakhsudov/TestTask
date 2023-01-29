using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator.Tests.Figures
{
    public class CircleTests
    {
        [Fact]
        public void CalculateAreaIsCorrect()
        {
            // Given
            double radius = 7;
            var circle = new Circle(radius);

            // When
            var result = circle.CalculateArea();

            // Then
            var area = Math.PI * Math.Pow(radius, 2);
            Assert.Equal(area, result);
        }
    }
}
