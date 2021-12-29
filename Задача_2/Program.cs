using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{

    //Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
    class Program
    {
        static void Cube(double a)
        {
            double S, V;
            V = Math.Pow(a, 3);
            S = 6 * Math.Pow(a, 2);
            Console.WriteLine("Объем куба ={0:F3}\n\rПлощадь куба ={1:F3}", V, S);

        }
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Cube(a);
            Console.ReadKey();
        }
    }
}
