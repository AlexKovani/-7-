using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    //Два треугольника заданы длинами своих сторон.
    //Определить, площадь какого из них больше(создать метод для вычисления площади треугольника по длинам его сторон).
    //Для решения задачи можно использовать формулу Герона:
    //s = sqr(p*(p-x)*(p-y)*(p-z), где x,y,z - стороны треугольника, р - полупериметр.


    class Program
    {
        static double CalcSquar (double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            double t =  p * (p - x) * (p - y) * (p - z);
            double s = Math.Sqrt(t);
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины 3-х сторон 1-го треугольника, через Enter:");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длины 3-х сторон 2-го треугольника, через Enter:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double s1 = CalcSquar(x, y, z);
            double s2 = CalcSquar(x1, y1, z1);
            Console.WriteLine("S1 = {0:F3}\r\nS2 = {1:F3}", s1, s2);
            double max = (s1 > s2) ? 1 : 2;
            Console.WriteLine("Площадь {0}-го треугольника больше", max);
            Console.ReadKey();

        }
    }
}
