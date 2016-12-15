using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_2._
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите температуру в градусах Цельсия: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = c * 9 / 5 + 32;
            Console.WriteLine("Температура по Фаренгейту равна: {0}", f);
            Console.ReadKey();
        }
    }
}
