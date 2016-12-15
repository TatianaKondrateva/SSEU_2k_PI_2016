using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_2._
{
    class Program
    {
        static void Main(string[] args)
       
        {
            double ruble = 1.00;   // 1 рубль = 1 рублей
            double еuro = 65.05; // 1 евро = 65.05 рублей
            double dollars = 61.18; // 1 доллар = 61.18 рублей
            double pounds = 77.47; // 1 фунт = 77.47 рублей
            double yen = 0.62; // 1 йен = 0,62 рублей



            String currencyEnter;
            String currencyConclusion;
            double summaEnter = 0;
            double summaResult = 0; 
            double summaBufferRubl = 0;

            Console.WriteLine("Введите сумму:");

            if (double.TryParse(Console.ReadLine(), out summaEnter))
            {

                Console.WriteLine("Выберете валюту из которой надо переводить \n   ruble,   еuro,   dollars,   pounds,   yen");               
                currencyEnter = Console.ReadLine();


     
                    //перевод из любой волюты в рубли
                    switch (currencyEnter)
                    {
                        case "ruble": summaBufferRubl = summaEnter * ruble; break;
                        case "euro": summaBufferRubl = summaEnter * еuro; break;
                        case "dollars": summaBufferRubl = summaEnter * dollars; break;
                        case "pounds": summaBufferRubl = summaEnter * pounds; break;
                        case "yen": summaBufferRubl = summaEnter * yen; break;
                        default: Console.WriteLine("Выберете валюту из предложенных"); break;
                            
                        // перевод из руболей в любую другую валюту
                           

                    };

                    Console.WriteLine("Выберете валюту в которую надо переводить \n  ruble,   еuro,  dollars,   pounds,   yen");
                    currencyConclusion = Console.ReadLine();  

                    switch (currencyConclusion)
                    {
                        case "ruble": summaResult = summaBufferRubl / ruble; break;
                        case "euro": summaResult = summaBufferRubl / еuro; break;
                        case "dollars": summaResult = summaBufferRubl / dollars; break;
                        case "pounds": summaResult = summaBufferRubl / pounds; break;
                        case "yen": summaResult = summaBufferRubl / yen; break;
                        default: Console.WriteLine("Выберете валюту из предложенных"); break;

                    };

                    Console.WriteLine(summaEnter + " " + currencyEnter + " --> " + Math.Round(summaResult, 2, MidpointRounding.AwayFromZero) + "  " + currencyConclusion);
            }
            else
            {
                Console.WriteLine("Введеная сумма должна быть числом!");
            };
            Console.ReadKey();           

        }
    }
}
