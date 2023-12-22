using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Film
    {
        private string Name;
        private int Year;
        private string Zhanr;

        public Film()
        {
            Name = "";
            Year = 0;
            Zhanr = "";  
        }

        public Film(string name, int year, string zhanr)
        {
            this.Name = name;
            this.Year = year;
            this.Zhanr = zhanr;
        }

        public void InfoFilm(string name, int year, string zhanr)
        {
            this.Name = name;
            this.Year = year;
            this.Zhanr = zhanr;
        }

        public void FilmArray()
        {
            Console.WriteLine("Название фильма: " + Name);
            Console.WriteLine("Год выпуска: " + Year);
            Console.WriteLine("Жанр фильма: " + Zhanr);
        }
    }
}
