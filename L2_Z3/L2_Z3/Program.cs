using System;
using System.Collections.Generic;
using System.Text;

namespace L2_Z3
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ;
            int ONE_THOUSAND = 1000; // условие, больше данного числа давать скидку.
            int SALE = 15; // скидка 15 процентов
            Console.WriteLine("Введите сумму вашей покупки:");
            if (int.TryParse(Console.ReadLine(), out summ))
            {
                if (summ > ONE_THOUSAND)
                {
                    double valueDiscount = (summ * SALE) / 100;
                    double result = summ - valueDiscount;
                    Console.WriteLine("Cкидка составила:" + valueDiscount);
                    Console.WriteLine("Сумма к оплате с учётом скидки:" + result);
                }
                else { Console.WriteLine("Сумма вашей покупки меньше 1000! Скидки нет!"); }

            }
            else { Console.WriteLine("Неверное значение! Введите число."); }
            Console.ReadKey();
        }
    }
}
