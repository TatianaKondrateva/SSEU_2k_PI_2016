using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_2._
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, f;
            int a = 31;
            int b = 7;
            int c = 1993;

            Console.WriteLine("Введите х: ");
            x = double.Parse(Console.ReadLine());
            f = (((-x) * (Math.Sqrt(x * x + b * x))) / a) + c;
            Console.WriteLine("Функция f(x) = " + f);
            Console.ReadKey();

        }
    }
}
