using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculator.Figures
{
    /// <exception cref="ArgumentException">Throws when constructor parameter is equal or less than 0</exception>
    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0)
                throw new ArgumentException("Value can not be equal or less than 0", nameof(a));

            if (b <= 0)
                throw new ArgumentException("Value can not be equal or less than 0", nameof(b));

            if (c <= 0)
                throw new ArgumentException("Value can not be equal or less than 0", nameof(c));

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double CalculateArea()
        {
            double p = (a + b + c) / 2;

            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return double.Round(s, 2);
        }

        public override bool IsRightAngled() 
        {
            double[] areas = new double[] { a, b, c };
            
            double max = areas.Max();

            double d = areas.Min();

            double sum = areas.Sum();

            double e = sum - (max + d);

            if(Math.Pow(max, 2) == (Math.Pow(d, 2) + Math.Pow(e, 2)))
                return true;

            return false;
        }
    }
}
