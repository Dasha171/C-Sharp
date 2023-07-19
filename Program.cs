//Задача 1:
//Напишите программу для вывода своих фамилии, имени и отчества на каждой новой строке
//Решение:

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ябс");
            Console.WriteLine("Дарья");
            Console.WriteLine("Александровна");
            Console.ReadKey();
        }
    }
}
//Задача 2:
//Вывести на экран пять строк из нулей, причем количество нулей в каждой строке равно номеру строки. Использовать только Console.Write().
//Решение:

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 строка: 0\n" +
                    "2 строка: 00\n" +
                    "3 строка: 000\n" +
                    "4 строка: 0000\n" +
                    "5 строка: 00000");
        }
    }
}
//Задача 3:
//Как перевести переменную строкового типа «myString» в целый числовой тип данных?
//Решение:

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string myString = "10";
            int num = Convert.ToInt32(myString);
            Console.WriteLine(num);
        }
    }
}
//Задача 4:
//Как перевести переменную строкового типа «inputAge» в целый числовой тип данных, не используя метод Convert?
//Решение:

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputAge = "35";
            int num = int.Parse(inputAge);
        }
    }
}
//Задача 5:
//По данному целому числу, найдите его квадрат.
//Решение:

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите целое число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Квадрат числа равен: " + num * num);
        }
    }
}
//Задача 6:
//Написать программу для обмена значений двух построчно введенных в консоль целых переменных, и вывода результата на одной строке.
//Решение:
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое числа: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Числа после перестановки: " + num2 + " " + num1);
        }
    }
}
//Задача 8:
//Напишите программу, которая находит сумму и произведение трёх целых чисел, построчно введённых с клавиатуры в консоль.
//Решение:

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int summa = num1 + num2 + num3;
            int proizvedenie = num1 * num2 * num3;
            Console.WriteLine("Сумма трех чисел: " + summa + "; Произведение трех чисел: " + proizvedenie + ";");
        }
    }
}
//Задача 9:
//Написать программу нахождения результата для следующего задания: n школьников делят k яблок поровну, не делящийся остаток остается в корзинке. Данные вводятся построчно. Программа должна вывести сколько яблок достанется каждому школьнику.
//Решение:
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите построчно два числа");
            int students = Convert.ToInt32(Console.ReadLine());
            int apples = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(apples + " / " + students + " = " + (apples / students));
            Console.ReadKey();
        }
    }
}
//Задача 10:
//Написать программу нахождения результата для следующего задания: n школьников делят k яблок поровну, не делящийся остаток остается в корзинке. Данные вводятся построчно. Программа должна вывести сколько яблок достанется каждому школьнику.
//Решение:

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите построчно два числа");
            int students = Convert.ToInt32(Console.ReadLine());
            int apples = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Остаток " + apples + " / " + students + " = " + (apples % students));
            Console.ReadKey();
        }
    }
}
//Задача 11:
//Написать программу для нахождения результата из следующей задачи: пирожок в столовой стоит a рублей и b копеек. Вывести в консоль сколько рублей и копеек нужно заплатить за n пирожков. Данные вводятся с консоли построчно: a, b, n.
//Решение:

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число, обозначающие количество рублей");
            int rubles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число, обозначающие количество копеек");
            int kopecks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите нужное число пирожков");
            int cntFood = Convert.ToInt32(Console.ReadLine());
            int onlyKopecks = (rubles * 100 + kopecks) * cntFood;
            Console.WriteLine(cntFood + " пирожков(ка) стоит " +
                      onlyKopecks / 100 + " руб " + onlyKopecks % 100 + " коп");
            Console.ReadKey();
        }
    }
}
//Задача 12:
//Дана сторона квадрата. Найти его периметр.
//Решение:

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны квардрата: ");
            int P = Convert.ToInt32(Console.ReadLine());
            int perimetr = P + P + P + P;
            Console.WriteLine("Периметр квадрата равен: " + perimetr);

        }
    }
}
//Задача 13:
//Дано положительное действительное число x. Выведите его дробную часть не используя приведения и методы класса Math.
//Решение:

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вещественное число");
            double dbl = double.Parse(Console.ReadLine());
            Console.Write("Дробная часть числа = " + dbl - (int)dbl);
            Console.ReadKey();

        }
    }
}
//Задача 14:
//Дано построчно два числа. Вывести максимальное из двух чисел. Если числа равны, вывести любое из двух чисел.
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Максимальное число: " + num1);
            }
            else if (num1 == num2)
            {
                Random random = new Random();
                int randomNumber = random.Next();

                Console.WriteLine("Рандомное число: " + randomNumber);
            }

        }
    }
}
//Задача 15:
//Напишите программу, которая будет принимать введенные числа и выводить рандомным образом.
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int userInput = int.Parse(Console.ReadLine());

            Random random = new Random();
            int randomNumber = random.Next();

            Console.WriteLine("Случайное число: " + randomNumber);

        }
    }
}
//Задача 16:
//Напишите программу, которая будет принимать введенные числа и вычислять четное число или нет с использованием оператора “?”
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a % 2 == 0 ? "Число чётное" : "Число нечётное");

        }
    }
}
//Задача 17:
//На вход построчно подаются два целых числа a и b, проверить делится ли a на b нацело. Выведите «Первое число делится на второе число без остатка» если a делится на b нацело, иначе вывести «Первое число делится на второе число с остатком».
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a % b == 0 ? "Первое число делится на второе число без остатка" : "Первое число делится на второе число с остатком");
        }
    }
}
//Задача 18:
//Дано целое число n. Выведите следующее за ним четное число.
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Следующее четное = ");
            Console.WriteLine(n % 2 == 0 ? n + 2 : n + 1);
        }
    }
}
//Задача 19:
//Софии задали домашнее задание сделать k задач. За день София успевает сделать n задач. Сколько дней нужно, чтобы София сделал домашнее задание?
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число задач выполняемых за один день ");
            int onDay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число задач для выполнения ");
            int allQuestions = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество дней для выполнения задач ");
            Console.Write(allQuestions % onDay == 0 ? allQuestions / onDay : allQuestions / onDay + 1);
        }
    }
}
//Задача 19:
//В средней школе решили набрать три новых класса и оборудовать кабинеты для них новыми партами. За каждой партой может сидеть максимально два учащихся. Известно количество учащихся в каждом из трех новых классов. Выведите наименьшее число парт, которое нужно приобрести для них.
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите построчно три числа: количество учеников в каждом классе ");
            int classA = int.Parse(Console.ReadLine());
            int classB = int.Parse(Console.ReadLine());
            int classC = int.Parse(Console.ReadLine());
            if (classA % 2 == 0) classA /= 2; else classA = classA / 2 + 1;
            if (classB % 2 == 0) classB /= 2; else classB = classB / 2 + 1;
            if (classC % 2 == 0) classC /= 2; else classC = classC / 2 + 1;
            Console.WriteLine("Нужное количество парт " + (classA + classB + classC));
            Console.ReadKey();
        }
    }
}
//Задача 20:
//построчно вводятся три числа. Нужно вывести «Все числа равны» если все числа равны, иначе вывести «Числа различны»:
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите построчно три числа");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2 && num2 == num3) Console.WriteLine("Все числа равны");
            else Console.WriteLine("Числа различны");
        }
    }
}
//Задача 21:
//София и Есения являются большими поклонницами четных чисел, поэтому хотят поделить купленный арбуз так, чтобы доля каждой весила именно четное число килограмм, при этом не обязательно, чтобы доли были равными по величине, и при этом вес доли не может иметь нулевой значение. Дан вес арбуза целым числом, определить, получится ли у девчат поделить арбуз как они хотят.
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вес арбуза: ");
            int massa = Convert.ToInt32(Console.ReadLine());
            Console.Write(massa % 2 == 0 || massa != 2 ? "Можно поделить" : "Нельзя поделить");
        }
    }
}
//Задача 22:
//Определите принадлежит ли точка x одному из выделенных числовых отрезков.
//Решение:
using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write(x >= -5 && x <= -3 || x >= -1 && x <= 1 || x >= 3 && x <= 5 ?
                         "Входит в диапазон" : "Не входит в диапазон");
        }
    }
}
//Задача 23:
//Введите целое шестизначное. Определите является ли это число счастливым билетным номером. Счастливым считается билет если в шестизначном номере которого сумма первых трёх цифр совпадает с суммой трёх последних:
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое шестизначное число:  ");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("вы ввели некорректное число");
                return;
            }
            int cst = n / 100000;
            int cdt = n / 10000 % 10;
            int cet = n / 1000 % 10;
            int cs = n / 100 % 10;
            int cd = n / 10 % 10;
            int ce = n % 10;
            Console.Write(cst + cdt + cet == cs + cd + ce ?
                              "номер билета счастливый" : "номер билета не счастливый");
            Console.ReadKey();
        }
    }
}
//Задача 24:
//По данному номеру месяца, определите количество дней в этом месяце.
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number from 1 to 12:  ");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("вы ввели некорректное число");
                return;
            }
            switch (n)
            {
                case 1:
                    Console.WriteLine("31 days");
                    break;
                case 2:
                    Console.WriteLine("28 days");
                    break;
                case 3:
                    Console.WriteLine("30 days");
                    break;
                case 4:
                    Console.WriteLine("31 days");
                    break;
                case 5:
                    Console.WriteLine("30 days");
                    break;
                case 6:
                    Console.WriteLine("31 days");
                    break;
                case 7:
                    Console.WriteLine("30 days");
                    break;
                    Console.Write("31 days");
                    break;
                case 8:
                    Console.WriteLine("30 days");
                    break;
                case 9:
                    Console.WriteLine("31 days");
                    break;

                case 10:
                    Console.WriteLine("30 days");
                    break;
                case 11:
                    Console.WriteLine("31 days");
                    break;
                case 12:
                    Console.WriteLine("30 days");
                    break;
            }
            Console.ReadKey();
        }
    }
}
//Задача 25:
//Напишите программу, которая выводит «Hello World!» 99 раз, каждый раз на новой строке.
//Решение:
using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 99; i++)
            {
                Console.WriteLine("Hello World!");
            }
            Console.ReadKey();
        }
    }
}
//Задача 26:
//Напишите программу, которая выводит только четные числа от 2 до 200.
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 200; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
//Задача 27:
//Напишите программу, которая выводит все четные числа на заданном отрезке.
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int start = Math.Min(a, b);
            int end = Math.Max(a, b);
            for (int i = start % 2 + start; i <= end; i += 2)
                Console.Write(i + " ");
            Console.ReadKey();
        }
    }
}
//Задача 28:
//По данному натуральному числу x, выведите все его делители.
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i * i <= x; i++)
                if (x % i == 0) Console.Write(i + " ");
            Console.ReadKey();
        }
    }
}
//Задача 29:
//Нарисовать треугольник
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину");
            int width = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < lenght; i++)
                {
                    if (j == 0 || j == width - 1) Console.Write("-");
                    else if (i == 0 || i == lenght - 1) Console.Write("|");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
//Задача 30:
//Посчитать, сколько раз встречается цифра 2 в последовательности чисел от 1 до n, включая n.
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n: ");
            int finalBorder = int.Parse(Console.ReadLine());
            int cntTwosFound = 0, j;
            for (int i = 1; i <= finalBorder; i++)
            {
                j = i;
                while (j > 0)
                {
                    if (j % 10 == 2) cntTwosFound++;
                    j /= 10;
                }
            }
            Console.WriteLine(cntTwosFound != 0 ?
                             "Количество встреченных цифр 2 = " + cntTwosFound : "Цифры 2 в этом диапазоне нет!");
        }
    }
}
//Задача 31:
//Среди натуральных чисел от 1 до n включительно, найдите число, наибольшее по сумме цифр. Вывести это число и сумму его цифр.
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое — конец числового диапазона:");
            int endBorder = int.Parse(Console.ReadLine());
            if (endBorder > 0)
            {
                int nextSumma, numberMaxSumma = 0;
                int maxSumma = 0;
                for (int i = 1; i <= endBorder; i++)
                {
                    nextSumma = 0;
                    for (int j = i; j > 0; j /= 10)
                        nextSumma += j % 10;
                    if (nextSumma > maxSumma)
                    {
                        maxSumma = nextSumma;
                        numberMaxSumma = i;
                    }
                }
                Console.WriteLine($"В числе {numberMaxSumma} наибольшая сумма цифр, равная {maxSumma}");
            }
            else Console.WriteLine("Некорректный ввод");
            Console.ReadKey();
        }
    }
}
//Задача 32:
//Вывести представление натурального целого числа n в виде произведения простых чисел в порядке возрастания.
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число для нахождения его делителей:");
            int number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                Console.Write($"Простые делители числа {number}: ");
                int i = 2;
                while (number != 1)
                {
                    while (number % i == 0)
                    {
                        Console.Write(i + " ");
                        number /= i;
                    }
                    i++;
                }
            }
            else Console.WriteLine("Некорректный ввод");
            Console.ReadKey();
        }
    }
}
//Задача 33:
//Определим еще один метод, который складывает два числа:
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            void Sum(int x, int y)
            {
                int sum = x + y;
                Console.WriteLine(sum);
            }

            Sum(10, 15);

        }

    }
}
//Задача 34:
//Выведите данные ФИО с помощью метода:
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            void Sum(string one, string two, string three)
            {
                string fio = one + " " + two + " " + three;
                Console.WriteLine(fio);
            }

            Sum("Ябс", "Дарья", "Александровна");

        }

    }
}
//Задача 35:
//Выведите данные – Имя, возраст с помощью метода:
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            void PrintPerson(string name, int age)
            {
                Console.WriteLine($"Name: {name}  Age: {age}");
            }

            PrintPerson("Dasha", 24);

        }

    }
}
//Задача 36:
//Вывести сообщение с помощью оператора return:
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string GetMessage()
            {
                return "Darova";
            }

            string message = GetMessage();  // получаем результат метода в переменную message
            Console.WriteLine(message);


        }

    }
}
//Задача 37:
//При передаче параметров по ссылке перед параметрами используется модификатор ref:
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {

            void Increment(ref int n)
            {
                n++;
                Console.WriteLine($"Число в методе Increment: {n}");
            }

            int number = 7;
            Console.WriteLine($"Число до метода Increment: {number}");
            Increment(ref number);
            Console.WriteLine($"Число после метода Increment: {number}");
        }

    }
}
//Задача 38:
//Вычислите периметр и площадь с помощью параметра out(использование in):
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            void GetRectangleData(in int width, in int height, out int rectArea, out int rectPerimetr)
            {
                //width = 25; // нельзя изменить, так как width - входной параметр
                rectArea = width * height;
                rectPerimetr = (width + height) * 2;
            }

            int w = 10;
            int h = 20;
            GetRectangleData(w, h, out var area, out var perimetr);

            Console.WriteLine($"Площадь прямоугольника: {area}");
            Console.WriteLine($"Периметр прямоугольника: {perimetr}");

        }
    }
}
//Задача 39:
//Сложить числа используя параметр params:
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            void Sum(params int[] numbers)
            {
                int result = 0;
                foreach (var n in numbers)
                {
                    result += n;
                }
                Console.WriteLine(result);
            }

            int[] nums = { 1, 2, 3, 4, 5 };
            Sum(nums);
            Sum(1, 2, 3, 4);
            Sum(1, 2, 3);
            Sum();
        }
    }
}
//Задача 40:
//Найти факториал числа с помощью рекурсии:
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int Factorial(int n)
            {

                if (n == 1) return 1;

                return n * Factorial(n - 1);
            }
            int fact = Factorial(4);
            Console.WriteLine($"Факториал числа 4 = {fact}");
        }
    }
}
//Задача 41:
//Рекурсивная функция Фибоначчи:
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fibonachi(int n)
            {
                if (n == 0 || n == 1) return n;

                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }

            int fib4 = Fibonachi(4);
            int fib5 = Fibonachi(5);
            int fib6 = Fibonachi(6);

            Console.WriteLine($"4 число Фибоначчи = {fib4}");
            Console.WriteLine($"5 число Фибоначчи = {fib5}");
            Console.WriteLine($"6 число Фибоначчи = {fib6}");
        }
    }
}
//Задача 41:
//Определим метод который сравнивают сумму чисел двух массивов:
//Решение:

using System;
using System.Runtime.CompilerServices;
using static System.Math;

namespace helloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            void Compare(int[] numbers1, int[] numbers2)
            {
                int numbers1Sum = 0;
                int numbers2Sum = 0;

                foreach (int number in numbers1)
                    numbers1Sum += number;

                foreach (int number in numbers2)
                    numbers2Sum += number;

                if (numbers1Sum > numbers2Sum)
                    Console.WriteLine("сумма чисел из массива numbers1 больше");
                else if (numbers1Sum < numbers2Sum)
                    Console.WriteLine("сумма чисел из массива numbers2 больше");
                else
                    Console.WriteLine("суммы чисел обоих массивов равны");
            }

            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5, 6, 7 };

            Compare(numbers1, numbers2);
        }
    }
}
//Задача 42:
//Нарисуйте треугольник по введенным данным
//Решение:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doshik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину: ");
            int height = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите ширину: ");
            //int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

        }
    }
}
