using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.1
            Console.WriteLine("ваше имя");
            string a = Console.ReadLine();
            Console.WriteLine($"привет,{a}");
            
            //2,2
            int n = Convert.ToInt32(Console.ReadLine());
            int n1 = Convert.ToInt32(Console.ReadLine());
            if ( n == 0 || n1 == 0)
            {
                Console.WriteLine("невозможно");
            }
            else
            {
                Console.WriteLine(n/n1);

            }

            //2.1
            string a1 = Console.ReadLine();
            List<int> list = new List<int>() { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я"};
            var index = list.IndexOf(a1);
            Console.WriteLine(list[index+1]);

            //2.2
            int a3 = Convert.ToInt32(Console.ReadLine());
            int b3 = Convert.ToInt32(Console.ReadLine());
            int c3 = Convert.ToInt32(Console.ReadLine());
            int d = b3 * b3 - 4 * a3 * c3;
            int x11 = -b3 - Math.Sqrt(d))/2*a3;
            int x22 =  - b3 + Math.Sqrt(d))/ 2 * a3;
            Console.WriteLine(x22, x11);


        }
    }
}
