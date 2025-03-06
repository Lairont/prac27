using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point[] points = new Point[4];
            //points[0] = new Point(3, 4);
            //points[1] = new Point(7, 4);
            //points[2] = new Point(7, 6);
            //points[3] = new Point(3, 6);
            //foreach (var p in points)
            //{
            //    Console.WriteLine($"{p.ToString()}");
            //}

            //Point[] points = new Point[4]
            //{
            //    new Point(3, 6),
            //    new Point(1, -2),
            //    new Point(3, 1),
            //    new Point(-3, -6)
            //};
            //foreach (var p1 in points)
            //{
            //    Console.WriteLine($"{p1.ToString()}");
            //}

            //Point[] points = new Point[4];
            //for (int i = 0; i < points.Length; i++)
            //{
            //    Console.WriteLine("Введите координаты {0}-й точки", i + 1);
            //    double x = Convert.ToDouble(Console.ReadLine());
            //    double y = Convert.ToDouble(Console.ReadLine());
            //    points[i] = new Point(x, y);

            //}
            //foreach (var p2 in points)
            //{
            //    Console.WriteLine($"{p2.ToString()}");
            //}



            Console.Write("Введите количество точек: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Point[] points3 = new Point[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите x для точки {i + 1}: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Введите y для точки {i + 1}: ");
                double y = Convert.ToDouble(Console.ReadLine());
                points3[i] = new Point(x, y);
            }
            foreach (var p3 in points3)
            {
                Console.WriteLine($"{p3.ToString()}");
            }

            Console.ReadLine();
        }
    }
}
