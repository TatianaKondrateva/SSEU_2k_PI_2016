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
                Console.Write("������� ����� �������: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));
            int[] a = new int[n];
            int i = 0;
            while (i < n)
            {
                Console.Write("������� � [" + i + "]: ");
                if (int.TryParse(Console.ReadLine(), out a[i]))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("������� ����� �����!");
                }; ;
            };
            int max = a[0];
            for (i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                };
            };
            Console.WriteLine("������������ ��������: " + max);
            Console.ReadKey();
        }
    }
}
