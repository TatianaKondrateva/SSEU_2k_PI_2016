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
            Console.Write("Ââåäèòå èäåíòèôèêàòîğ: ");
            string id = Console.ReadLine();
            Console.ReadKey();

            if (!((id[0] >= 'a') && (id[0] <= 'z')
                 || (id[0] >= 'A') && (id[0] <= 'Z')
                 || (id[0] == '_')))
            {
                noErrors = false;
                Console.WriteLine("Ïåğâûé ñèìâîë äîëæåí áûòü áóêâîé èëè ïîä÷åğêèâàíèåì!");
            };

            for (int i = 1; i < id.Length; i++)
            {
                if (!((id[i] >= 'a') && (id[i] <= 'z')
                      || (id[i] >= 'A') && (id[i] <= 'Z')
                      || (id[i] >= '0') && (id[i] <= '9')
                      || (id[i] == '_')))
                {
                    noErrors = false;
                    Console.WriteLine("Ñèìâîë " + i + " (" + id[i] + ")"
                                      + " äîëæåí áûòü áóêâîé, öèôğîé èëè çíàêîì ïîä÷åğêèâàíèÿ!");
                };
            };
            if (noErrors) { Console.WriteLine("Èäåíòèôèêàòîğ âåğíûé!"); 
            };
        }
    }
}
