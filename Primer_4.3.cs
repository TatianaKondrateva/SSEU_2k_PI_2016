using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_4._
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через ;");
            string numbersStr = Console.ReadLine();

            string[] numbersStrArr = numbersStr.Split(';');
            double[] numbersArr = new double[numbersStrArr.Length];

            int n = 0;
            for (int i = 0; i < numbersStrArr.Length; i++)
            {

                if (double.TryParse(numbersStrArr[i].Trim(), out numbersArr[n]))
                {
                    n++;
                };
            };

            double[] buffer = new double[n];
            for (int i = 0; i < n; i++)
            {

                buffer[i] = numbersArr[i];
            };

            numbersArr = buffer;
            for (int i = 0; i < numbersArr.Length; i++)
            {
                Console.WriteLine("Число[" + i + "] = " + numbersArr[i]);
            };

            Console.ReadKey();
        }
    }
}
