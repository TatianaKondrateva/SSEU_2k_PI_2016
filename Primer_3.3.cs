using System;
using System.Collections.Generic;
using System.Text;

namespace SortArray
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
            int max = int.MaxValue;
            while (i < n)
            {
                Console.Write("������� � [" + i + "]: ");
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
                    Console.WriteLine("������� ����� �����!");
                }; ;
            };
            for (i = 0; i < a.Length - 1; i++)
            {
                for (int j = 1; j < a.Length - 1; j++)
                {
                    if (a[j - 1] > a[j])
                    {
                        int buf = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = buf;
                    };
                };
            };
            Console.WriteLine("��������������� ������: ");
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
    }
}
