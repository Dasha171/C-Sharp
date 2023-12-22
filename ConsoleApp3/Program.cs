using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        delegate void Umeet(); // объявление делегата
        event Umeet Vse_umeet; // объявление события
        static void Main(string[] args)
        {
            Woman wom = new Woman();
            wom.Name = "Mariya";
            wom.Ves = 55;
            Console.WriteLine("Мое имя - " + wom.Name);
            Console.WriteLine("Мой вес - " + wom.Ves);
            Child child = new Child();
            child.Age = 5;
            child.Name = "Denis";
            child.Ves= 15;
            Console.WriteLine("Мое имя - " + child.Name);
            Console.WriteLine("Мой возраст - " + child.Age);
            Console.WriteLine("Мой вес - " + child.Ves);
            Man man= new Man();
            man.Name = "Vlad";
            man.Age = 40;
            man.rabota = "программист";
            Console.WriteLine("Мое имя - " + man.Name);
            Console.WriteLine("Мой возраст - " + man.Age);
            Console.WriteLine("Должность - " + man.rabota);


            Console.WriteLine("\n13 лабораторная\n");
            Man man1 = new Man();
            man1.Name = "Иван";
            man1.Age = 35;
            Console.WriteLine("Моё имя-" + man1.Name + " Мой возраст-" + man1.Age + " Мой пол -" + man1);
            Woman wom1 = new Woman();
            wom1.Name = " Марья";
            wom1.Age = 30;
            Console.WriteLine("Моё имя-" + wom1.Name + "Мой возраст-" + wom1.Age + " Мой пол -" + wom1);
            // пользуемся индексатором
            wom1[0] = "умная"; // задаем черты характера
            wom1[1] = "красивая";
            wom1[2] = "трудолюбивая";
            wom1[3] = " глупая";
            wom1.show();// просмотр характера женщины
            Program pr1 = new Program();
            Umeet eh1 = new Umeet(wom1.gotovit); //создаем
            pr1.Vse_umeet += eh1;// добавляем в событие
            eh1 = wom1.ubiraet; // переопределяем делегат
            pr1.Vse_umeet += eh1; // добавляем в событие
            eh1 = wom1.stiraet; // переопределяем делегат
            pr1.Vse_umeet += eh1; // добавляем в событие
            pr1.Vse_umeet(); // вызов события
            Console.ReadKey();
        }
    }
}
