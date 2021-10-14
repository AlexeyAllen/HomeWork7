using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangles
{
    class Program
    {
        static double AreaTriangle(int sideA, int sideB, int sideC)
        {
            int p = (sideA + sideB + sideC) / 2;
            double S = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return S;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Для определения площади треугольника 1 введите значения длин сторон А, В, С");
            Console.WriteLine("Введите размер стороны А:");
            int sideA1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер стороны B:");
            int sideB1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер стороны C:");
            int sideC1 = Convert.ToInt32(Console.ReadLine());

            double S1 = AreaTriangle(sideA1, sideB1, sideC1);
            Console.WriteLine("Площадь треугольника = {0:f2}", S1);
            Console.WriteLine();

            Console.WriteLine("Для определения площади треугольника 2 введите значения длин сторон А, В, С");
            Console.WriteLine("Введите размер стороны А:");
            int sideA2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер стороны B:");
            int sideB2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер стороны C:");
            int sideC2 = Convert.ToInt32(Console.ReadLine());

            double S2 = AreaTriangle(sideA2, sideB2, sideC2);
            Console.WriteLine("Площадь треугольника = {0:f2}", S2);
            Console.WriteLine();

            if (S1<S2)
            {
                Console.WriteLine("Площадь треугольника 1 < площади треугольника 2");
            }
            else
            {
                Console.WriteLine("Площадь треугольника 1 > площади треугольника 2");
            }

            Console.ReadKey();
        }
    }
}
