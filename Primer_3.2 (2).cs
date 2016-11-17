using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Введите длину массива: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));
            int[] a = new int[n];
            int i = 0;
            int max = int.MaxValue;
            while (i < n)
            {
                Console.Write("Введите а [" + i + "]: ");
                if (int.TryParse(Console.ReadLine(), out a[i]))
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                    };
                    i++;
                }
                else
                {
                    Console.WriteLine("Введите целое число!");
                }; ;
            };
            int max = array[0];
            int iMax = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    if (array[i] == max)
                    {
                        iMax = iMax + "," + i;
                    }
                    else if (array[i] > max)
                    {
                        max = array[i];
                        iMax = i;
                    };
                };
                Console.WriteLine("Максимально число array[" + iMax + "]= " + max);

            }
        }
    }
}

    

