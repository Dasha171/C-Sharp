using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka12
{
    internal class Program
    {    
    static void Main(string[] args)
        {
            Console.WriteLine("12 лабораторная\n");
            Man man = new Man();
            man[0] = "Умный";
            man[1] = "Сильный";
            man[2] = "Добрый";
            man[3] = "Храбрый";
            man[4] = "Честный";
            Console.WriteLine("Характер мужчины:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Черта {i + 1}: {man[i]}");
            }
            Rebenok rebenok = new Rebenok();
            rebenok[0] = "Умный";
            rebenok[1] = "Сильный";
            rebenok[2] = "Добрый";
            rebenok[3] = "Храбрый";
            rebenok[4] = "Честный";
            Console.WriteLine("\nХарактер ребенка:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Черта {i + 1}: {rebenok[i]}");
            }

            Console.ReadLine();
        }
    }
}

