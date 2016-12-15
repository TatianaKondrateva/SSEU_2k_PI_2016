using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_2._
{
    class Program
    {
        static void Main(string[] args)
       
        {
            double ruble = 1.00;   // 1 ����� = 1 ������
            double �uro = 65.05; // 1 ���� = 65.05 ������
            double dollars = 61.18; // 1 ������ = 61.18 ������
            double pounds = 77.47; // 1 ���� = 77.47 ������
            double yen = 0.62; // 1 ��� = 0,62 ������



            String currencyEnter;
            String currencyConclusion;
            double summaEnter = 0;
            double summaResult = 0; 
            double summaBufferRubl = 0;

            Console.WriteLine("������� �����:");

            if (double.TryParse(Console.ReadLine(), out summaEnter))
            {

                Console.WriteLine("�������� ������ �� ������� ���� ���������� \n   ruble,   �uro,   dollars,   pounds,   yen");               
                currencyEnter = Console.ReadLine();


     
                    //������� �� ����� ������ � �����
                    switch (currencyEnter)
                    {
                        case "ruble": summaBufferRubl = summaEnter * ruble; break;
                        case "euro": summaBufferRubl = summaEnter * �uro; break;
                        case "dollars": summaBufferRubl = summaEnter * dollars; break;
                        case "pounds": summaBufferRubl = summaEnter * pounds; break;
                        case "yen": summaBufferRubl = summaEnter * yen; break;
                        default: Console.WriteLine("�������� ������ �� ������������"); break;
                            
                        // ������� �� ������� � ����� ������ ������
                           

                    };

                    Console.WriteLine("�������� ������ � ������� ���� ���������� \n  ruble,   �uro,  dollars,   pounds,   yen");
                    currencyConclusion = Console.ReadLine();  

                    switch (currencyConclusion)
                    {
                        case "ruble": summaResult = summaBufferRubl / ruble; break;
                        case "euro": summaResult = summaBufferRubl / �uro; break;
                        case "dollars": summaResult = summaBufferRubl / dollars; break;
                        case "pounds": summaResult = summaBufferRubl / pounds; break;
                        case "yen": summaResult = summaBufferRubl / yen; break;
                        default: Console.WriteLine("�������� ������ �� ������������"); break;

                    };

                    Console.WriteLine(summaEnter + " " + currencyEnter + " --> " + Math.Round(summaResult, 2, MidpointRounding.AwayFromZero) + "  " + currencyConclusion);
            }
            else
            {
                Console.WriteLine("�������� ����� ������ ���� ������!");
            };
            Console.ReadKey();           

        }
    }
}
