using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Вариант 1. Создайте абстрактный класс Mashine, затем подклассы: автомобили,
грузовики.Создайте интерфейсы: с бензиновым двигателем, дизельным двигателем,
газовым двигателем. Организуйте множественное наследование. В главной программе
создайте конкретные экземпляры машин и выведите сведения о них.*/

namespace Laboratorka14
{
    abstract class Mashine
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Mashine(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void Opisanie();
    }

    interface IBenzinEngine
    {
        void DvigatelBenzin();
    }

    interface IDieselEngine
    {
        void DvigatelDizel();
    }

    interface IGasEngine
    {
        void DvigatelGas();
    }

    class Avto : Mashine, IBenzinEngine
    {
        public Avto(string Name, int Age) : base(Name, Age) { }
        public void DvigatelBenzin()
        {
            Console.WriteLine($"{Name} (Age {Age}) - автомобиль с бензиновым двигателем.");
        }

        public override void Opisanie()
        {
            Console.WriteLine("Это автомобиль.");
        }
    }

    class Gruzovik : Mashine, IDieselEngine
    {
        public Gruzovik(string Name, int Age) : base(Name, Age) { }


        public void DvigatelDizel()
        {
            Console.WriteLine($"{Name} (Age {Age}) - грузовик с дизельным двигателем.");
        }

        public override void Opisanie()
        {
            Console.WriteLine("\nЭто грузовик.");
        }
    }
}
