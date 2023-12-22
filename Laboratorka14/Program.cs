using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("14 лаба 1 вариант");
            Avto avto = new Avto("Honda", 2022);
            Gruzovik gruzovik = new Gruzovik("Volvo", 2020);

            avto.Opisanie();
            avto.DvigatelBenzin();
            gruzovik.Opisanie();
            gruzovik.DvigatelDizel();

            Console.WriteLine("\n15 лаба: ");
            Poly poly = new Poly();
            poly.LoadEmployee();
            poly.Raschet();

            Console.WriteLine("\n16 лаба: ");

            Korabl korabl= new Korabl("Общий корабль", 2000);
            korabl.Display();
            Parohod parohod = new Parohod("dwdw", 222, 2222);
            parohod.Display();
            Korvet korvet = new Korvet("wdwdwdw", 1888, 3, 9000);
            korvet.Display();

 

            Console.ReadLine();
        }

        class ContractEmployee : Employee {
             public ContractEmployee(string name): base(name) { }
            public override void CalculatePay()
            {
                Console.WriteLine("ContractEmployee.CalculatePay Вызвана для {0}", name);
            }
        }
        class SalariedEmployee : Employee {
             public SalariedEmployee(string name): base(name) { }
            override public void CalculatePay()
            {
                Console.WriteLine("Вызван для {0}", name);
            }
        }

        class Poly {
            protected Employee[] employees;
            public void LoadEmployee()
            {
                employees = new Employee[2];
                employees[0] = new ContractEmployee("Dasha");
                employees[1] = new SalariedEmployee("Yabs");
            }
            public void Raschet()
            {
                foreach(Employee emp in employees)
                {
                    emp.CalculatePay();
                }
            }
        }

       
    }


}
