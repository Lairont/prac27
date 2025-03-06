using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Point>points = new List<Point>();
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"x {i + 1} точки: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write($"y {i + 1} точки: ");
                int y = Convert.ToInt32(Console.ReadLine());
                points.Add(new Point(x, y));
                Console.WriteLine();
            }
            foreach (var p in points)
            {

                Console.WriteLine($"{p.ToString()}");
                p.Length();
            }
            Console.ReadLine();
        }
    }
}
