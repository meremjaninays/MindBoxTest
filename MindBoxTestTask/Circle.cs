using System;
using System.Collections.Generic;
using System.Text;

namespace MindBoxTestTask
{
    public class Circle : IFigure
    {
        public double CalculateSpace()
        {
            return  Math.PI * r * r;
        }
        public Circle(double r)
        {
            this.r = r;
        }

        private readonly double r;
    }
}
