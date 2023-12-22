using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
     class Avto
    {
            double Moshnost;
            int Year;

            public Avto(double moshnost, int year)
            {
                Moshnost= moshnost;
                Year= year;
            }
            public override string ToString()
            {
                return $"Мощность машины: {Moshnost}, Год выпуска машины: {Year}";
            }
        }
        class Kamaz : Avto
        {
            public string Brand { get; set; }

            public Kamaz(int moshnost, int year, string brand) : base(moshnost, year)
            {
                Brand = brand;
            }

            public override string ToString()
            {
                return $"Грузовая машина, Марка: {Brand}, {base.ToString()}";
            }
        }
        class MonstrTruck : Avto
        {
            public string Brand { get; set; }

            public MonstrTruck(int moshnost, int year, string brand) : base(moshnost, year)
            {
                Brand = brand;
            }

            public override string ToString()
            {
                return $"Грузовой автомобиль, Марка: {Brand}, {base.ToString()}";
            }
        }
        class PassengerVan : Avto
        {
            public string Brand { get; set; }

            public PassengerVan(int moshnost, int year, string brand) : base(moshnost, year)
            {
                Brand = brand;
            }

            public override string ToString()
            {
                return $"Пассажирский автомобиль, Марка: {Brand}, {base.ToString()}";
            }
        }
    
}
