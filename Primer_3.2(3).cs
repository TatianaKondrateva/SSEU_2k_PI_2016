using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthArray;
            do
            {
                Console.Write("ВВедите длину массива:");
            } while (!int.TryParse(Console.ReadLine(), out lengthArray) || (lengthArray <= 0));
            int[] array = new int[lengthArray];
            int n = 0;
            while (i < lengthArray)
            {
                Console.Write("Введите array[" + n + "]: ");
                if (int.TryParse(Console.ReadLine(), out array[n]))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Введите целое число");
                }; ;
            };
            int max = array[0];
            string iMax = "0";
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    iMax = iMax + "," + i;
                }
                else if (array[i] > max)
                {
                    max = array[i];
                    iMax = i.ToString();
                };
            };
            Console.WriteLine("Максимально число array[" + iMax + "]= " + max);
            Console.ReadKey();
        }
    }
}

