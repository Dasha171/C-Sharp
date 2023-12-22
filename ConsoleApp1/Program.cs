using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 задание: ");
            SayHello();
            SayAge();
            SayUcheba();

            Console.WriteLine("\n2 задание");
            Prizma prizma = new Prizma(7, 2);
            Console.WriteLine("Объем равен: " + prizma.Prizma7());
            Console.WriteLine("Поверхность призмы равна: " + prizma.PrizmaPow());

            Console.WriteLine("\n3 задание");
            Prizma pr = new Prizma(1,2 );
            double res = 0;
            double a = 5;
            double b = 10;
            double h = 12;
            pr.VP(ref res, a, b, h);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        static void SayHello() 
        {
            Console.WriteLine("Привет Ябс Дарья!");
        
        }
        static void SayAge() 
        { 
            Console.WriteLine("Возраст: " + 18);
        }
        static void SayUcheba()
        {
            Console.WriteLine("Место учебы: Колледж Политех");
        }
       

    }
       

}


