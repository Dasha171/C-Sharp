using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    delegate double Srednee(int[] массив);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9 лабораторная");
            Film film1 = new Film();
            Film film2 = new Film();
            film1.InfoFilm("Dark Path", 2022, "Horror");
            film2.InfoFilm("Dasha", 2023, "Travel");
            Console.WriteLine("Информация о фильме: ");
            film1.FilmArray();
            Console.WriteLine("Информация о фильме: ");
            film2.FilmArray();
            ////
            Console.WriteLine("\n10 лабораторная");
            int[] num = {1,2,3,4,5};
            Srednee delegateSrednee = Summa;
            delegateSrednee += Srednee;
            double result = delegateSrednee(num);
            Console.WriteLine("Сумма элементов: " + result);
            ////
            Console.WriteLine("\n12 лабораторная");

            Console.ReadLine();
        }
        ///
        static double Summa(int[] ints)
        {
            double sum = 0;
            foreach(int i in ints)
            {
                sum += i;
            }
            return sum;
        }
        static double Srednee(int[] ints)
        {
            double sum = Summa(ints);
            double srednee = sum / ints.Length;
            return srednee;
        }

    }
}
