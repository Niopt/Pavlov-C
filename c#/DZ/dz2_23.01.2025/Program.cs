using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2_23._01._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dz2");
            // Запрос у пользователя натурального числа
            Console.Write("Введите натуральное число: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.Write("Некорректный ввод. Пожалуйста, введите натуральное число: ");
            }

            // Получение делителей
            List<int> divisors = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                }
            }

            // a) Вывод всех делителей
            Console.WriteLine("Делители числа " + number + ": " + string.Join(", ", divisors));

            // b) Сумма делителей
            int sumOfDivisors = 0;
            foreach (var divisor in divisors)
            {
                sumOfDivisors += divisor;
            }
            Console.WriteLine("Сумма делителей: " + sumOfDivisors);

            // c) Сумма четных делителей
            int sumOfEvenDivisors = 0;
            foreach (var divisor in divisors)
            {
                if (divisor % 2 == 0)
                {
                    sumOfEvenDivisors += divisor;
                }
            }
            Console.WriteLine("Сумма четных делителей: " + sumOfEvenDivisors);

            // d) Количество делителей
            int countOfDivisors = divisors.Count;
            Console.WriteLine("Количество делителей: " + countOfDivisors);

            // e) Количество нечетных делителей
            int countOfOddDivisors = 0;
            foreach (var divisor in divisors)
            {
                if (divisor % 2 != 0)
                {
                    countOfOddDivisors++;
                }
            }
            Console.WriteLine("Количество нечетных делителей: " + countOfOddDivisors);

            // f) Количество четных делителей
            int countOfEvenDivisors = countOfDivisors - countOfOddDivisors;
            Console.WriteLine("Количество четных делителей: " + countOfEvenDivisors);

            // g) Запрос у пользователя числа d
            Console.Write("Введите число d для поиска делителей, больших d: ");
            int d;
            while (!int.TryParse(Console.ReadLine(), out d))
            {
                Console.Write("Некорректный ввод. Пожалуйста, введите число: ");
            }

            // Найти количество делителей, больших d
            int countOfDivisorsGreaterThanD = 0;
            foreach (var divisor in divisors)
            {
                if (divisor > d)
                {
                    countOfDivisorsGreaterThanD++;
                }
            }
            Console.WriteLine("Количество делителей, больших " + d + ": " + countOfDivisorsGreaterThanD);

            // Ожидание ввода перед закрытием консоли
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
