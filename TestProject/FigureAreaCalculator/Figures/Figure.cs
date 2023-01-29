using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureAreaCalculator.Figures
{
    public class Figure
    {
        public virtual double CalculateArea()
        {
            return 0;
        }

        public virtual bool IsRightAngled()
        {
            return false;
        }
    }
}
