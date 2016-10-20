using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_2._
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1, operand2;
            double result;
            string operation;

            if (double.TryParse(Console.ReadLine(), out operand1) && double.TryParse(Console.ReadLine(), out operand2))
            {
                operation = Console.ReadLine();
                switch (operation)
                {
                    case "+": result = operand1 + operand2; break;
                    case "-": result = operand1 - operand2; break;
                    case "*": result = operand1 * operand2; break;
                    case "/": result = operand1 / operand2; break;
                    case "sqrt": result = Math.Sqrt(operand1); break;
                    default: Console.WriteLine("Неверная операция!"); result = 0; break;
                }
                Console.WriteLine(operand1 + " " + operation + " " + operand2 + " = " + result);


            }
            else
            {
                Console.WriteLine("Операнд должен быть числом!");
            };
            Console.ReadKey();
        }
    }
}


