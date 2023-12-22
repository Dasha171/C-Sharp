using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Prizma
    {
        private double obiem;
        private double height;

        public Prizma(double obiem, double height) {
             this.obiem = obiem;
             this.height = height;
        }
        //2 задание
        //метод вычисления обьема
        public double Prizma7()
        {
            double result = Math.Pow(obiem,2) * height;
            return result;
        }

        //метод вычисления поверхности призмы
        public double PrizmaPow()
        {
            double a = Math.Pow(obiem,2);
            double b = 4 * obiem * height;
            double c = 2 * a + b;
            return c;
        }
        public void VP(ref double V1, double a, double b, double h)
        {
            V1 = a * b * h / 3;
        }
    }
}
