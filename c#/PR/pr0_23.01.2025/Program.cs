using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr0_23._01._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pr0");

            Console.WriteLine("Введите число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int maxNum = GetMax(a, b, c);
            Console.WriteLine("Наибольшее число: " + maxNum);
            Console.WriteLine("Удвоенное число: " + maxNum * 2);
            Console.ReadKey();
        }

        static int GetMax(int a, int b, int c)
        {
            if (a > b && a > c) return a;
            else if (b > a && b > c) return b;
            else return c;
        }
    }
}
