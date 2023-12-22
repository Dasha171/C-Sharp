using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    abstract class Figure
    {
        public abstract double Reshenie();
    }

    class Triangle : Figure
    {
        private double a, b, c;

        public Triangle(double figA, double figB, double figC)
        {
            a = figA;
            b = figB;
            c = figC;
        }   
        public override double Reshenie()
        {
            double s = (a + b + c) / 2;
            // Формула Герона
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
    }
}
