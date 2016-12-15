using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_2._
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("¬ведите число");
            long n = Convert.ToInt64(Console.ReadLine());
            long r = 1;
            for (int i = 2; i <= n; ++i)
                r *= i;
            Console.WriteLine(r);
            Console.ReadLine();
        
        }
    }
}
   
