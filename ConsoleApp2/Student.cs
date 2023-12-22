using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    ///
    class Student
    {
        public string FullName { get; set; }
        public int BirthYear { get; set; }
        public int EnrollmentYear { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }

        public Student(string fullName, int birthYear, int enrollmentYear, string gender, string nationality)
        {
            if (birthYear < 1990 || birthYear > 1995)
            {
                Console.WriteLine("Год рождения должен быть  от 1990 до 1995.");
            }

            if (enrollmentYear < 1996 || enrollmentYear > 2011)
            {
                Console.WriteLine("Год поступления должен быть от 1996 до 2011.");
            }
            FullName = fullName;
            BirthYear = birthYear;
            EnrollmentYear = enrollmentYear;
            Gender = gender;
            Nationality = nationality;
        }

        public override string ToString()
        {
            return $"ФИО: {FullName}, Год рождения: {BirthYear}, Год поступления: {EnrollmentYear}, Пол: {Gender}, Национальность: {Nationality}";
        }
    }
    ///
    class Parallelepiped
    {
        private double length;
        private double width;
        private double height;

        public Parallelepiped(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public double CalculateVolume()
        {
            return length * width * height;
        }

        public double CalculateSurfaceArea()
        {
            double surfaceArea = 2 * (length * width + length * height + width * height);
            return surfaceArea;
        }
    }
    ///
    class Piramida3
    {
        private double leftP;
        private double rigthP;
        private double heightP;
        
        public Piramida3(double leftP, double rigthP, double heightP)
        {
            this.leftP = leftP;
            this.rigthP = rigthP;   
            this.heightP = heightP;
        }
        public double Piramid()
        {
            return (1.0 / 3.0) * leftP * rigthP * heightP;
        }
        public double PiramidS()
        {
            double s = Math.Sqrt((leftP*leftP/4) + heightP*heightP);
            double h = (leftP*rigthP) + (0.5*leftP*s)+(0.5*rigthP*s);
            return h;
        }
    }
    ///
    class Cilindr
    {
        private double radius;
        private double heightC;
        
        public Cilindr(double radius, double heightC)
        {
            this.radius = radius;
            this .heightC = heightC;
        }
        public double Radius()
        {
            return Math.PI * radius * radius * heightC;
        }
        public double Cil()
        {
            double cilindrR = 2 * Math.PI * radius * heightC;
            double cilH = Math.PI* radius * radius;
            double cilS = cilindrR + 2 * cilH;
            return cilS;
        }
    }
    ///
    class Kub
    {
        private double lengthK;

        public Kub(double lengthK)
        {
            this.lengthK = lengthK;
        }
        public double LengthK()
        {
            return lengthK * lengthK * lengthK;
        }
        public double KubH()
        {
            return 6 * lengthK * lengthK;
        }
    }
    ///
    class Konus
    {
        private double radiuskonus;
        private double heightkonus;

        public Konus(double radiuskonus, double heightkonus)
        {
            this.radiuskonus = radiuskonus;
            this.heightkonus = heightkonus;
        }
        public double radiusKonus()
        {
            return (1.0 / 3.0) * Math.PI * radiuskonus * radiuskonus * heightkonus;
        }
        public double Kon()
        {
            double vich = Math.Sqrt(Math.Pow(radiuskonus, 2) + Math.Pow(heightkonus, 2));
            return Math.PI * radiuskonus * (radiuskonus + vich);
        }
    }





    //вывод всего результата
    class Program
    {
        static void Main()
        {
            Console.WriteLine("1 лабораторная\n");
            Student[] group = new Student[]
            {
            new Student("Ябс Дарья Александровна", 1990, 2008, "женский", "немка"),
            new Student("Ризабек Дидар", 1992, 2010, "мужской", "немец"),
            new Student("Павлова Мария Александровна", 1994, 2009, "женский", "русская"),
            };
            foreach (var student in group)
            {
                Console.WriteLine(student);
            }

            //////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("2 лабораторная\n");
            Console.WriteLine("2.1");
            Parallelepiped box = new Parallelepiped(5, 4, 3);
            double volume = box.CalculateVolume();
            double surfaceArea = box.CalculateSurfaceArea();
            Console.WriteLine("Объем параллелепипеда: " + volume);
            Console.WriteLine("Площадь поверхности параллелепипеда: " + surfaceArea);

            //////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("2.2\n");
            
                Piramida3 pyramid = new Piramida3(4, 8, 4);
                double volume2 = pyramid.Piramid();
                double h = pyramid.PiramidS();

                Console.WriteLine("Объем пирамиды: " + volume2);
                Console.WriteLine("Площадь пирамиды: " + h);

            //////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("2.3\n");
            Cilindr cylindr = new Cilindr(3, 5);
            double cylRadius = cylindr.Radius();
            double cylCil = cylindr.Cil();
            Console.WriteLine("Объем цилиндра: " + cylRadius);
            Console.WriteLine("Площадь поверхности цилиндра: " + cylCil);

            //////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("2.4\n");
            Kub cube = new Kub(4);
            double kubR= cube.LengthK();
            double kubH = cube.KubH();
            Console.WriteLine("Объем куба: " + kubR);
            Console.WriteLine("Площадь поверхности куба: " + kubH);

            //////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("2.5\n");
            Konus konus = new Konus(7,2);  
            double radiusKonus = konus.radiusKonus();
            double heightKonus = konus.Kon();
            Console.WriteLine("Объем конуса: " + radiusKonus);
            Console.WriteLine("Площадь поверхности конуса: " + heightKonus);
            Console.ReadKey();
        
        }
       
 
        
    }

}
