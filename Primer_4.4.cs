using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_4._
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("������� �����, ����������� ���������:");
            string words = Console.ReadLine();

            string[] wordsArr = words.Split(' ');
            Array.Sort(wordsArr);
            words = wordsArr[0];
            for (int i = 1; i < wordsArr.Length; i++)
                words += " " + wordsArr[i];

            Console.WriteLine("���������� ���� �� ��������: ");
            Console.WriteLine(words);
            Console.ReadKey();
        }
    }
}
