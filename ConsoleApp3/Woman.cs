using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Woman:Home
    {
        public int ves;
        public int Ves
        {
            set { this.ves = value; }
            get { return ves; }
        }
        public string pol = "женский";
        private string[] haracter = new string[4];

        public string this[int i]
        {
            set
            {
                if (value != "глупая") haracter[i] = value;
                else haracter[i] = " я не такая ";
            }
            get { return haracter[i]; }
        }
        public void show()
        {
            for (int i = 0; i < haracter.Length; i++)
            Console.WriteLine(haracter[i]);
        }
        public void gotovit()
        {
            Console.WriteLine("Я вкусно готовлю!");
        }
        public void ubiraet()
        {
            Console.WriteLine(" У меня всегда чисто в квартире");
        }
        public void stiraet()
        {
            Console.WriteLine(" Моя семья опрятно одета");
        }
    }
}
