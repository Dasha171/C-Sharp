using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        public class Pet
        {
            public double Weight { get; set; }
            public int Age { get; set; }
            public string FeedingTime { get; set; }
            public string OwnerName { get; set; }

            public Pet(double weight, int age, string feedingTime, string ownerName)
            {
                Weight = weight;
                Age = age;
                FeedingTime = feedingTime;
                OwnerName = ownerName;
            }

            public virtual void MakeSound()
            {
                Console.WriteLine("Звук домашнего животного: ");
            }
        }

        public class Cat : Pet
        {
            public Cat(double weight, int age, string feedingTime, string ownerName)
                : base(weight, age, feedingTime, ownerName)
            {

            }

            public override void MakeSound()
            {
                Console.WriteLine("Мяу-мяу!");
            }
        }
        public class Dog : Pet
        {
            public Dog(double weight, int age, string feedingTime, string ownerName)
                : base(weight, age, feedingTime, ownerName)
            {

            }

            public override void MakeSound()
            {
                Console.WriteLine("гав - гав");
            }
        }


        public class Shotland : Cat
        {
            public string Color { get; set; }

            public Shotland(double weight, int age, string feedingTime, string ownerName, string catColor)
                : base(weight, age, feedingTime, ownerName)
            {
                Color = catColor;
            }

            public override void MakeSound()
            {
                Console.WriteLine("мяу-мяу. шотландская порода");
            }
        }
        public class Buldog : Dog
        {
            public string DogColor { get; set; }

            public Buldog(double weight, int age, string feedingTime, string ownerName, string dogColor)
                : base(weight, age, feedingTime, ownerName)
            {
                DogColor = dogColor;
            }

            public override void MakeSound()
            {
                Console.WriteLine("гав-гав,Бульдог");
            }
        }
        public class Pig : Pet
        {
            public string PigBreed { get; set; }

            public Pig(double weight, int age, string feedingTime, string ownerName, string pigBreed)
                : base(weight, age, feedingTime, ownerName)
            {
                PigBreed = pigBreed;
            }

            public override void MakeSound()
            {
                Console.WriteLine("хрю-хрю");
            }
        }
        public class Cow : Pet
        {
            public string CowBreed { get; set; }

            public Cow(double weight, int age, string feedingTime, string ownerName, string cowBreed)
                : base(weight, age, feedingTime, ownerName)
            {
                CowBreed = cowBreed;
            }

            public override void MakeSound()
            {
                Console.WriteLine("муу");
            }
        }
        public class Horse : Pet
        {
            public string HorseBreed { get; set; }

            public Horse(double weight, int age, string feedingTime, string ownerName, string horseBreed)
                : base(weight, age, feedingTime, ownerName)
            {
                HorseBreed = horseBreed;
            }

            public override void MakeSound()
            {
                Console.WriteLine("его-го-го");
            }
        }

        static void Main(string[] args)
        {
            //////////////////////////////////////////
            Console.WriteLine("4 лабораторная");
            Pet pet = new Pet( 1, 4, "Анфиса", "Черная");
            pet.MakeSound();
            Shotland cat1 = new Shotland(4.0, 1, "12-00", "Анфиса", "Черная");
            Console.WriteLine("Звуки кошки: ");
            cat1.MakeSound();
            Buldog dog = new Buldog(4.0, 1, "12-00", "Анфиса", "Черная");
            Console.WriteLine("Звуки собаки: ");
            dog.MakeSound();
            Pig pig = new Pig(4.0, 1, "12-00", "Анфиса", "Черная");
            Console.WriteLine("Звуки свиньи: ");
            pig.MakeSound();
            Cow cow = new Cow(4.0, 1, "12-00", "Анфиса", "Черная");
            Console.WriteLine("Звуки коровы: ");
            cow.MakeSound();
            Horse horse = new Horse(4.0, 1, "12-00", "Анфиса", "Черная");
            Console.WriteLine("Звуки лошади: ");
            horse.MakeSound();
            /////////////////////////////////////////
            Console.WriteLine("\n5 лабораторная");
            Avto car = new Avto(2000,1990);
            car.ToString();
            Kamaz kamaz = new Kamaz(1900, 2000, "Люкс");
            MonstrTruck truck = new MonstrTruck(8000, 1890, "МонстрТрак");
            Console.WriteLine(car);
            Console.WriteLine(kamaz);
            Console.WriteLine(truck);
            PassengerVan pass = new PassengerVan(8000, 1890, "хендай");
            Console.WriteLine(pass);
            /////////////////////////////////////////
            Console.WriteLine("\n6 лабораторная");
            Triangle triangle = new Triangle(8, 2, 7);
            double area = triangle.Reshenie();
            Console.WriteLine($"Площадь треугольника по формуле Герона: {area}");
            Console.ReadKey();
        }
    }
    
}
