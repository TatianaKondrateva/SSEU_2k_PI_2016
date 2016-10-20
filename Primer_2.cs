using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            if (int.TryParse(Console.ReadLine(), out A))
            {
                if (int.TryParse(Console.ReadLine(), out B))
                {
                    if (int.TryParse(Console.ReadLine(), out C))
                    {
                        int Max;
                        if ((A >= B) && (A >= C))
                        {
                            Max = A;
                        }
                        else if ((B >= A) && (B >= C))
                        {
                            Max = B;
                        }
                        else 
                        {
                            Max = C;
                         };
                      
                        Console.WriteLine("Максимальное число = " + Max);
                        }
                    else
                   {
                    Console.WriteLine("Неверное значение! Нужно ввести целое число.");
                   };
                }
                else
                {
                    Console.WriteLine("Неверное значение! Нужно ввести целое число.");
                };
            }
            else
            {
                Console.WriteLine("Неверное значение! Нужно ввести целое число.");
            };
            Console.ReadKey();
        }
    }
}
    


       


    



