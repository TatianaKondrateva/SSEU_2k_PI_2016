using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_3._
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int summ = 0;
            int rem  =0;
            Console.WriteLine("������� �����:");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                int i = 0;
               while (number>0) 
                {                 
                    number = Math.DivRem(number, 10, out rem);        
                    summ += rem;
                    i++;
                }
                Console.WriteLine("����� �����:" + summ);
                Console.WriteLine("���������� �����:" + i);
            }
            else { Console.WriteLine("�������� ��������! ������� �����!"); }
            Console.ReadKey();
        }
    }
}
