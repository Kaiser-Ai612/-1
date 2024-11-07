using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_задания
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вывести на экран число e (основание натурального логарифма) с точностью додесятых.
            Console.WriteLine("2,7");

            //Вывести на экран числа 50 и 10 одно под другим.
            Console.WriteLine("50");
            Console.WriteLine("10");

            //Составить программу вывода на экран «столбиком» четырех любых чисел.
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");

            //Пользователь вводит число. Выведите на экран число, которое больше введенногона 10.
            string num = Console.ReadLine();
            int intnum = Convert.ToInt32(num);
            int ournum = intnum + 10;
            Console.WriteLine(ournum);

            //Дана сторона квадрата. Найти его периметр.
            byte a = 5;
            Console.WriteLine(a * 4);

            //Дан радиус окружности. Найти длину окружности и площадь круга.
            byte r = 5;
            Console.WriteLine($"Plochad {3.14 * r * r},dlina {2 * 3.14 * r}");

            //Найти значение y=cos(x)
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"косинус в радианах {Math.Cos(g * (Math.PI / 180))}");

            //Даны основания и высота равнобедренной трапеции. Найти ее периметр.
            var osn1 = 9;
            var osn2 = 4;
            var h = 3;
            var bok = Math.Sqrt(Math.Pow(h, 2) + Math.Pow((osn1 - osn2) / 2, 2));
            Console.WriteLine(bok * 2 + osn1 + osn2);

            //Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки,
            //если купили x кг конфет, у кг печенья и z кг яблок.
            int ap = Convert.ToInt32(Console.ReadLine());
            int sw = Convert.ToInt32(Console.ReadLine());
            int co = Convert.ToInt32(Console.ReadLine());
            byte swc = 10;
            byte apc = 7;
            byte coc = 6;
            Console.WriteLine(ap * apc + sw * swc + co * coc);

            /*Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май"
            (кавычки не нужны). Причём сделайте, чтобы выводилось сначала так:
            Мир Труд Май
            Затем так:
            Мир
            Труд
            
            Май
            */
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир ");
            Console.WriteLine("    Труд ");
            Console.WriteLine("         Май");

            /*Программа просит пользователя ввести 2 числовые переменные. А после она
            меняет их местами и выводит результат на экран. Но, так как пользователь может
            ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести,
            например, букву или строку, а так же учесть, что число может быть дробным, и для
            выделения её дробной части одни используют точку, другие – запятую.
            */

            /*12. Программа для подсчета периметра и площади фигур (треугольник,
            четырехугольник, круг). Пользователь выбирает фигуру, указывает, что программа
            будет считать – площадь или периметр. Задаётся все необходимые значения, а на
            основе полученных результатов, программа должна подсчитать, какими могли бы
            быть периметры или площади остальных фигур.
            */
            Console.WriteLine("напишите одно : треугольник,круг,квадрат ");
            string ask = Console.ReadLine();
            if (ask == "треугольник")
            {
                Console.WriteLine("площадь или периметр?");
                string ask1 = Console.ReadLine();
                if (ask1 == "площадь")
                {
                    Console.WriteLine("Введите основание и падающую на нее высоту ");
                    int a1 = Convert.ToInt32(Console.ReadLine());
                    int h1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine((a1 * h1) / 2);
                }
                if (ask1 == "периметр")
                {
                    Console.WriteLine("Введите все стороны ");
                    int a1 = Convert.ToInt32(Console.ReadLine());
                    int b1 = Convert.ToInt32(Console.ReadLine());
                    int c1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(a1 + b1 + c1);

                }
            }
            if (ask == "круг")
            {
                Console.WriteLine("площадь или периметр?");
                string ask2 = Console.ReadLine();
                if (ask2 == "площадь")
                {
                    Console.WriteLine("Введите радиус ");
                    int a2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Math.PI * a2 * a2);
                }
                if (ask2 == "периметр")
                {
                    Console.WriteLine("Введите радиус ");
                    int  r2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Math.PI * r2 * 2);

                }
            }
            if (ask == "квадрат")
            {
                Console.WriteLine("площадь или периметр?");
                string ask3 = Console.ReadLine();
                if (ask3 == "площадь")
                {
                    Console.WriteLine("Введите сторону ");
                    int a3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(a3*a3);
                }
                if (ask3 == "периметр")
                {
                    Console.WriteLine("Введите сторону ");
                    int a4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(a4*4);

                }
            }
            /*Составить программу вывода на экран числа, вводимого с клавиатуры. Вводимому
числу должно предшествовать сообщение «Вы ввели число».
            */
            Console.WriteLine("Введите число");
            string num4 = Console.ReadLine();
            Console.WriteLine("вы ввели число");
            Console.WriteLine(num4);

            /*Составить программу вывода на экран следующей информации:
2 кг
13 17
            */
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");

            //Составить программу вывода на экран «столбиком» четырех случайных чисел.
            Random random = new Random();

            for (int i = 0; i < 4; i++)
            {
                int randomNumber = random.Next(1, 101); // Генерирует случайное число от 1 до 100
                Console.WriteLine(randomNumber);
            }

            //Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее
            //геометрическое.
            int z1 = Convert.ToInt32(Console.ReadLine());
            int z2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{(z1+z2)/2}  {Math.Pow(z1*z2,2)}");

            //Известны координаты на плоскости двух точек. Составить программу вычисления
            //расстояния между ними.
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(Math.Pow(x1-x2,2)+ Math.Pow(y1 - y2, 2)));

            /*Составить программу обмена значениями трех переменных величин а, b, c по
следующим двум схемам:
а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
б) b присвоить значение а, с присвоить значение b, а присвоить значение с.
             */
            int a7 = Convert.ToInt32(Console.ReadLine());
            int b7 = Convert.ToInt32(Console.ReadLine());
            int c7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a7} {b7} {c7}");
            (b7, a7,c7) = (c7, b7,a7);
            Console.WriteLine($"{a7} {b7} {c7}");
            (b7, c7, a7) = (a7, b7, c7);
            Console.WriteLine($"{a7} {b7} {c7}");

            /*С начала суток прошло n секунд. Определить:
а) сколько полных часов прошло с начала суток;
б) сколько полных минут прошло с начала очередного часа;
в) сколько полных секунд прошло с начала очередной минуты.
             */
            int sec = Convert.ToInt32(Console.ReadLine());
            int hours = sec / 3600; // 1 час = 3600 секунд
            int minutes = (sec % 3600) / 60; // Остаток от деления на 3600, делим на 60
            int seconds = sec % 60; // Остаток от деления на 60
            Console.WriteLine($"Полных часов с начала суток: {hours}");
            Console.WriteLine($"Полных минут с начала очередного часа: {minutes}");
            Console.WriteLine($"Полных секунд с начала очередной минуты: {seconds}");

            /*Дан прямоугольник с размерами 543 х 130 мм.Сколько квадратов со стороной 130
мм можно отрезать от него ?
            */
            int plo = 543 * 130;
            int minplo = 130 * 130;
            Console.WriteLine(plo / minplo);

            /*Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали
ее в начале. Найти полученное число.
             */
            int cv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{cv % 10}{cv / 10}");

            /*Дано натуральное число n (n > 999). Найти:
а) число сотен в нем;
б) число тысяч в нем.
             */
            int num12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num12 / 100}\n{num12 / 1000}");

            /*24. Дано четырехзначное число. Найти:
а) число, полученное при прочтении его цифр справа налево;
б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр
заданного числа. Например, из числа 5434 получить 4543, из числа 7048 — 784;
в) число, образуемое при перестановке второй и третьей цифр заданного числа.
Например, из числа 5084 получить 5804;
г) число, образуемое при перестановке двух первых и двух последних цифр
заданного числа. Например, из числа 4566 получить 6645, из числа 7304 — 473.
             */
            int num13 = Convert.ToInt32(Console.ReadLine());
            int m1 = num13/1000;
            int m2 = num13 % 1000 / 100;
            int m3 = num13 % 100 / 10;
            int m4 = num13 % 10;
            Console.WriteLine($"{m4}{m3}{m2}{m1}");
            Console.WriteLine($"{m2}{m1}{m3}{m4}");
            Console.WriteLine($"{m1}{m3}{m2}{m4}");
            Console.WriteLine($"{m2}{m1}{m4}{m3}");

            /*Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили
на 10, а к частному слева приписали последнюю цифру числа x, то получилось
число n. Найти число x. Значение n вводится с клавиатуры, 100 ≤ n ≤ 999 и при этом
число десятков в n не равно нулю.
             */
            int s = Convert.ToInt32(Console.ReadLine());
            int n18 = (s - (s%10)) / 10;
            Console.WriteLine($"{s%10}{n18}");

            /*Создать программу, которая будет выводить на экран меньшее по модулю из трёх
введённых пользователем вещественных чисел
             */
            int p1 = Convert.ToInt32(Console.ReadLine());
            int p2 = Convert.ToInt32(Console.ReadLine());
            int p3 = Convert.ToInt32(Console.ReadLine());
            List<int> lf = new List<int>(); 
            lf.Add(p1);
            lf.Add(p2);
            lf.Add(p3);
            Console.WriteLine(lf.Min());

            /*Найти сумму большего и меньшего из трёх заданных чисел
             */
            Console.WriteLine(lf.Min()+lf.Max());

            /*Подсчитать общее количество делителей натурального числа
             */
            /*32. Заданы первый и второй элементы арифметической прогрессии. Требуется
написать программу, которая вычислит элемент прогрессии по ее номеру.
             */
            int w1 = Convert.ToInt32(Console.ReadLine());
            int w2 = 4;
            int w3 = 6;
            int d5 = w3 - w2;
            Console.WriteLine(w2 + (w1 - 1) * d5);

            /*Если я пенсионер или студент и не трудоустроен, то получаю кредит, а если
трудоустроен не получаю кредит. Ну а если я, и пенсионер и
студент,(трудоустройство тут не имеет значения) то не должен получить.
Необходимо вводить строки, содержащие информацию о том, студент, пенсионер
или кто-то ещё. Вывести информацию: дадут кредит или нет.
             */
            Console.WriteLine("кто вы?");
            string rt = Console.ReadLine();
            if ((rt == "пенсионер" || rt == "студент" ))
            {
                Console.WriteLine("вы трудоустроены?");
                string rq = Console.ReadLine();
                if ( rq == "Нет")
                {
                    Console.WriteLine("получаете кредит");
                }
                else
                {
                    Console.WriteLine(" не получаете кредит");
                }
            }
            else
            {
                Console.WriteLine(" не получаете кредит");
            }

            /*34. Составить программу, которая:
а) запрашивает имя человека и повторяет его на экране;

б) запрашивает имя человека и повторяет его на экране с приветствием.
             */
            Console.WriteLine("ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine($"{name}");
            Console.WriteLine("привет,{name}");
















        }
    }
        
    

}