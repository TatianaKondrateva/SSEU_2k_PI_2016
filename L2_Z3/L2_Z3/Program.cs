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
            int ONE_THOUSAND = 1000; // �������, ������ ������� ����� ������ ������.
            int SALE = 15; // ������ 15 ���������
            Console.WriteLine("������� ����� ����� �������:");
            if (int.TryParse(Console.ReadLine(), out summ))
            {
                if (summ > ONE_THOUSAND)
                {
                    double valueDiscount = (summ * SALE) / 100;
                    double result = summ - valueDiscount;
                    Console.WriteLine("C����� ���������:" + valueDiscount);
                    Console.WriteLine("����� � ������ � ������ ������:" + result);
                }
                else { Console.WriteLine("����� ����� ������� ������ 1000! ������ ���!"); }

            }
            else { Console.WriteLine("�������� ��������! ������� �����."); }
            Console.ReadKey();
        }
    }
}
