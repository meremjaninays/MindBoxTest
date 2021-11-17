using System;

namespace MindBoxTestTask
{
    public class Triangular : IFigure
    {
        public double CalculateSpace()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public Triangular(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        private readonly double a;
        private readonly double b;
        private readonly double c;

        public bool IsRightTriangular()
        {
            if ((a * a + b * b) == (c * c))
            {
                return true;
            }
            if ((c * c + b * b) == (a * a))
            {
                return true;
            }
            if ((a * a + c * c) == (b * b))
            {
                return true;
            }
            return false;
        }
    }
}
