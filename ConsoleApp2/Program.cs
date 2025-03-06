using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car>cars = new List<Car>();
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Введите марку авто {i + 1}: ");
                string make = Console.ReadLine();
                Console.Write($"Введите модель авто {i + 1}: ");
                string model = Console.ReadLine();
                Console.Write($"Введите год выпуска авто {i + 1}: ");
                int year = Convert.ToInt32(Console.ReadLine());
                cars.Add(make, model, year);
                Console.WriteLine();
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.ToString()}");
            }

            Console.ReadLine();
        }
    }
}
