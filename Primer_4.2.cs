using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_4._
{
    class Program
    {
        static void Main(string[] args)
        {
            bool noErrors = true;
            Console.Write("������� �������������: ");
            string id = Console.ReadLine();
            Console.ReadKey();

            if (!((id[0] >= 'a') && (id[0] <= 'z')
                 || (id[0] >= 'A') && (id[0] <= 'Z')
                 || (id[0] == '_')))
            {
                noErrors = false;
                Console.WriteLine("������ ������ ������ ���� ������ ��� ��������������!");
            };

            for (int i = 1; i < id.Length; i++)
            {
                if (!((id[i] >= 'a') && (id[i] <= 'z')
                      || (id[i] >= 'A') && (id[i] <= 'Z')
                      || (id[i] >= '0') && (id[i] <= '9')
                      || (id[i] == '_')))
                {
                    noErrors = false;
                    Console.WriteLine("������ " + i + " (" + id[i] + ")"
                                      + " ������ ���� ������, ������ ��� ������ �������������!");
                };
            };
            if (noErrors) { Console.WriteLine("������������� ������!"); 
            };
        }
    }
}
