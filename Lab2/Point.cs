using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Point
    {
        private double X;
        private double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double getX()
        {
            return X;
        }
        public double getY()
        {
            return Y;
        }
    }
}
