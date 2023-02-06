using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculator.Figures
{

    /// <exception cref="ArgumentException">Throws when constructor parameter is equal or less than 0</exception>
    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            if(radius <= 0)
                throw new ArgumentException("Value can not be equal or less than 0", nameof(radius));

            this.radius = radius;
        }

        public override double CalculateArea()
        {
            var result = Math.PI * Math.Pow(radius, 2);

            return double.Round(result, 2);
        }
    }
}
