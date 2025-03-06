using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Point
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point()
        {
            X = 1.0;
            Y = 1.0;
        }
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;

        }
        public override string ToString()
        {
            return $"x= {x} y= {y}";

        }
    }
}