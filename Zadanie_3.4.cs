using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_3._
{
    class Program
    {
        static void Sort(int[] myint, int flagSort)
        {
            //int[] myint = { 99, 88, 77, 66, 55, 44, 33, 22, 11, 8, 5, 3, 1 };

            WriteArray(myint);
            if (flagSort.Equals(1))
            {
                ShakerSortV(myint);
            }
            else
            {
                if (flagSort.Equals(2))
                {
                    ShakerSortY(myint);
                }

            }
            WriteArray(myint);

            Console.ReadLine();
        }

        /* Шейкер-сортировка по возрастанию*/
        static void ShakerSortV(int[] myint)
        {
            int left = 0,
                right = myint.Length - 1,
                count = 0;

            while (left <= right)
            {
                // направление с лева на право
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (myint[i] > myint[i + 1])
                        Swap(myint, i, i + 1);
                }
                right--;

                // направление с права на лево, не влючая последний элемент
                for (int i = right; i > left; i--)
                {
                    count++;
                    if (myint[i - 1] > myint[i])
                        Swap(myint, i - 1, i);
                }
                left++;
            }
            Console.WriteLine("\nКоличество сравнений = {0}", count.ToString());
        }

        /* Шейкер-сортировка по убыванию*/
        static void ShakerSortY(int[] myint)
        {
            int left = 0,
                right = myint.Length - 1,
                count = 0;

            while (left <= right)
            {
                // направление с лева на право
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (myint[i] < myint[i + 1])
                        Swap(myint, i, i + 1);
                }
                right--;

                // направление с права на лево, не влючая последний элемент
                for (int i = right; i > left; i--)
                {
                    count++;
                    if (myint[i - 1] < myint[i])
                        Swap(myint, i - 1, i);
                }
                left++;
            }
            Console.WriteLine("\nКоличество сравнений = {0}", count.ToString());
        }

        /* Поменять элементы местами */
        static void Swap(int[] myint, int i, int j)
        {
            int glass = myint[i];
            myint[i] = myint[j];
            myint[j] = glass;
        }

        /*Вывести массив*/
        static void WriteArray(int[] a)
        {
            foreach (int i in a)
                Console.Write("{0}|", i.ToString());
            Console.WriteLine("\n\n\n");
        }

        static void Main(string[] args)
        {
            int lengthArray;
            Console.Write("Шейкерная сортировка:\n");
            do
            {
                Console.Write("Введите длину массива:");
            } while (!int.TryParse(Console.ReadLine(), out lengthArray) || (lengthArray <= 0));
            int[] array = new int[lengthArray];
            int i = 0;
            while (i < lengthArray)
            {
                Console.Write("Введите array[" + i + "]: ");
                if (int.TryParse(Console.ReadLine(), out array[i]))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("Введите целое число");
                }; ;
            };
            Console.Write("Отсортировать массив по возрастанию (1) или по убыванию (2)?");
            int flagSort;
            int.TryParse(Console.ReadLine(), out flagSort);
            Sort(array, flagSort);
        }
    }
}
