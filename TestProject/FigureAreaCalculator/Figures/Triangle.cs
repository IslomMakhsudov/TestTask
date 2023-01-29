using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculator.Figures
{
    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double CalculateArea()
        {
            double p = (a + b + c) / 2;

            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return s;
        }

        public override bool IsRightAngled() 
        {
            double[] areas = new double[] { a, b, c };
            
            double max = areas.Max();

            double d = areas.First(x => x != max);
            double e = areas.First(x => x != d && x != max);

            if(Math.Pow(max, 2) == (Math.Pow(d, 2) + Math.Pow(e, 2)))
                return true;

            return false;
        }
    }
}
