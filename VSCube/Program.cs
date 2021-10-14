using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSCube
{
    class Program
    {
        // Создать метод для вычисления объема куба и площади поверхности куба по длине его ребра 
        static int cubeCalc(int a, out int V)
        {
            int S = 6 * (int)Math.Pow(a,2);
            V = (int)Math.Pow(a, 3);
            return S;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Для определения площади поверхности куба и объема куба введите значения длины ребра куба а:");
            int edge = Convert.ToInt32(Console.ReadLine());
            int V;
            int S = cubeCalc(edge, out V);
            Console.WriteLine("Площадь поверхности куба = {0}, Объем куба = {1}", S, V);
            Console.ReadKey();
        }
    }
}
