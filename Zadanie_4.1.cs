using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_4._
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            Console.WriteLine("Нажмите клавишу");
            char.TryParse(Console.ReadLine(), out a);

            int b;
            b = Convert.ToInt32(a);

            Console.WriteLine(b);

            Console.ReadKey();
        }   
    }
}
