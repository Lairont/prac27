using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Point
    {
        private double x;
        private double y;

        public double X 
        {
            get => x; 
            set => x = value; 
        }
        public double Y 
        { 
            get => y; 
            set => y = value; 
        }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public  double Length()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public  override string ToString()
        {
            return $"x={X}\ty={Y}";
        }
    }
}
