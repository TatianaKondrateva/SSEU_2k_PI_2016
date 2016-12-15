using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_2._
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                /*
                 * Пользователь вводит
                 * сумму 
                 * и срок кредитования, 
                 * годовую процентную ставку,
                 * количество выплат в год
                 * и метод начисления процентов (простые или сложные).
                 */
                int month12 = 12;           // 12 месяцев. Для перевода из месяцев в год
                double percent100 = 0.01;   // Для перевода из процентов
                double summa;               // Введенная сумма кредитования
                double totalSumm = 0;       // Итоговая сумма вместо с процентами
                double summOfPercent = 0;   // Сумма начисленная процентами
                double paymentAtTime = 0;   // Выплаты за один раз

                int creditTermMonth; //срок кредита  - количество месяцев
                int percentYear; // Годовая процентная ставка
                int numberOfPayments; //Частота выплаты процентов
                int metod;

                Console.WriteLine("Введите сумму");
                double.TryParse(Console.ReadLine(), out summa);
                Console.WriteLine("Введите срок кредита  - количество месяцев");
                int.TryParse(Console.ReadLine(), out creditTermMonth);
                Console.WriteLine("Введите годовую процентную ставку");
                int.TryParse(Console.ReadLine(), out percentYear);
                Console.WriteLine("Введите количество выплат в год");
                int.TryParse(Console.ReadLine(), out numberOfPayments);
                Console.WriteLine("Выберете метод начисления процентов:   1 - простой,  2 - сложный");
                int.TryParse(Console.ReadLine(), out metod);

                switch (metod)
                {
                    case 1:
                        //итоговая сумма выплат 
                        totalSumm = summa * (1 + (creditTermMonth * percentYear * percent100) / month12);
                        //из них начисленно процентов
                        summOfPercent = totalSumm - summa;
                        //Выплата за один раз
                        paymentAtTime = totalSumm / numberOfPayments;
                        break;
                    case 2:
                        totalSumm = summa * Math.Pow(1 + percentYear * percent100, creditTermMonth / month12);
                        summOfPercent = totalSumm - summa;
                        paymentAtTime = totalSumm / numberOfPayments;
                        break;

                    default: Console.WriteLine("Неверная операция"); break;
                }
                Console.WriteLine("\n \t Итоговая сумма выплат " + totalSumm);
                Console.WriteLine("\t Из них начислено процентов " + summOfPercent);
                Console.WriteLine("\t Выплата за один раз: " + paymentAtTime);
            }
            Console.ReadLine();
        }
    }
}
