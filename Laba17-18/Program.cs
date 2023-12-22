using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba17_18
{
        struct Tovar 
        {
            public string Nazv;
            public int Stoim;
            public int Kol;

            public void Print()
            {
                Console.WriteLine($"Название товара: {Nazv}, Стоимость товара: {Stoim}, Количество товара: {Kol}");
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("17 лаба");
            Tovar[] shop = new Tovar[5];
            for (int i = 0; i < shop.Length; i++)
            {
                Console.WriteLine($"Введите информацию о товаре {i + 1}:");
                Console.Write("Название товара: ");
                shop[i].Nazv = Console.ReadLine();
                Console.Write("Стоимость товара: ");
                shop[i].Stoim = Int32.Parse(Console.ReadLine());
                Console.Write("Количество товара: ");
                shop[i].Kol = Int32.Parse(Console.ReadLine());
            }
            Console.Write("Введите минимальную стоимость для поиска товаров: ");
            double minStoim = double.Parse(Console.ReadLine());
            bool found = false;
            Console.WriteLine("Товары со стоимостью выше " + minStoim + ":");
            for (int i = 0; i < shop.Length; i++)
            {
                if (shop[i].Stoim > minStoim)
                {
                    Console.WriteLine($"Название: {shop[i].Nazv}, Стоимость: {shop[i].Stoim}, Количество: {shop[i].Kol}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Товаров со стоимостью выше " + minStoim + " не найдено.");
            }
            Console.ReadLine(); 
        }
    }
}
