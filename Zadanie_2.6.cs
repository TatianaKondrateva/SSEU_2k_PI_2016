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
                 * ������������ ������
                 * ����� 
                 * � ���� ������������, 
                 * ������� ���������� ������,
                 * ���������� ������ � ���
                 * � ����� ���������� ��������� (������� ��� �������).
                 */
                int month12 = 12;           // 12 �������. ��� �������� �� ������� � ���
                double percent100 = 0.01;   // ��� �������� �� ���������
                double summa;               // ��������� ����� ������������
                double totalSumm = 0;       // �������� ����� ������ � ����������
                double summOfPercent = 0;   // ����� ����������� ����������
                double paymentAtTime = 0;   // ������� �� ���� ���

                int creditTermMonth; //���� �������  - ���������� �������
                int percentYear; // ������� ���������� ������
                int numberOfPayments; //������� ������� ���������
                int metod;

                Console.WriteLine("������� �����");
                double.TryParse(Console.ReadLine(), out summa);
                Console.WriteLine("������� ���� �������  - ���������� �������");
                int.TryParse(Console.ReadLine(), out creditTermMonth);
                Console.WriteLine("������� ������� ���������� ������");
                int.TryParse(Console.ReadLine(), out percentYear);
                Console.WriteLine("������� ���������� ������ � ���");
                int.TryParse(Console.ReadLine(), out numberOfPayments);
                Console.WriteLine("�������� ����� ���������� ���������:   1 - �������,  2 - �������");
                int.TryParse(Console.ReadLine(), out metod);

                switch (metod)
                {
                    case 1:
                        //�������� ����� ������ 
                        totalSumm = summa * (1 + (creditTermMonth * percentYear * percent100) / month12);
                        //�� ��� ���������� ���������
                        summOfPercent = totalSumm - summa;
                        //������� �� ���� ���
                        paymentAtTime = totalSumm / numberOfPayments;
                        break;
                    case 2:
                        totalSumm = summa * Math.Pow(1 + percentYear * percent100, creditTermMonth / month12);
                        summOfPercent = totalSumm - summa;
                        paymentAtTime = totalSumm / numberOfPayments;
                        break;

                    default: Console.WriteLine("�������� ��������"); break;
                }
                Console.WriteLine("\n \t �������� ����� ������ " + totalSumm);
                Console.WriteLine("\t �� ��� ��������� ��������� " + summOfPercent);
                Console.WriteLine("\t ������� �� ���� ���: " + paymentAtTime);
            }
            Console.ReadLine();
        }
    }
}
