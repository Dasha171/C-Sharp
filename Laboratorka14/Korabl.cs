using Laboratorka14;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorka14
{
    public class Korabl
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public Korabl(string name, int year) {
            Name = name;
            Year = year;
        }
        public virtual void Display() {
            Console.WriteLine($"Корабль {Name}. Год постройки {Year}.");
        }
    }

    class Parohod : Korabl
    {
        public int Moshnost { get; set; }

        public Parohod(string name, int year, int mosh) : base(name, year)
        {
            Moshnost = mosh;
        }
        public override void Display()
        {
            Console.WriteLine($"Корабль {Name}. Год постройки {Year}. Мощность парохода {Moshnost}");
        }

    }

    

    class Parusnik : Korabl 
    { 
          public int MoshPar { get; set; }
        public Parusnik(string name, int year,int moshP) : base(name, year)
        {
            MoshPar = moshP;
        }
        public override void Display()
        {
            Console.WriteLine($"Корабль {Name}. Год постройки {Year}. Мощность парусника {MoshPar}");
        }

    }

    class Korvet : Parusnik 
    {
        public int MoshKorvet { get; set; }

        public Korvet(string name,int year,int moshP, int moshK) : base(name, year, moshP)
        {
            MoshKorvet = moshK;
        }
        public override void Display()
        {
             Console.WriteLine($"Корабль {Name}. Год постройки {Year}. Мощность корвета {MoshKorvet}. Парусников {MoshPar}");
        }
    }


}
