using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1_23._01._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dz1");
            // Запрос у пользователя двузначного числа
            Console.Write("Введите двузначное число (от 10 до 99): ");
            int count;
            while (!int.TryParse(Console.ReadLine(), out count) || count < 10 || count > 99)
            {
                Console.Write("Некорректный ввод. Пожалуйста, введите двузначное число: ");
            }

            // Запрос у пользователя порядка генерации чисел
            Console.Write("Введите '1' для генерации в возрастающей последовательности или '2' для убывающей: ");
            int order;
            while (!int.TryParse(Console.ReadLine(), out order) || (order != 1 && order != 2))
            {
                Console.Write("Некорректный ввод. Пожалуйста, введите '1' или '2': ");
            }

            // Генерация трехзначных вещественных чисел
            Random random = new Random();
            double[] numbers = new double[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = Math.Round(random.NextDouble() * 900 + 100, 2); // Генерация числа от 100 до 999
            }

            // Упорядочивание чисел в зависимости от выбора пользователя
            if (order == 1)
            {
                Array.Sort(numbers); // Возрастающая последовательность
            }
            else
            {
                Array.Sort(numbers);
                Array.Reverse(numbers); // Убывающая последовательность
            }

            // Проверка на упорядоченность
            bool isOrdered = true;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    isOrdered = false;
                    break;
                }
            }

            // Вывод результатов
            Console.WriteLine("Сгенерированные числа:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Проверка упорядоченности и вывод разности
            if (!isOrdered)
            {
                double difference = numbers[0] - numbers[numbers.Length - 1];
                Console.WriteLine($"Последовательность не упорядочена. Разность между первым и последним числом: {difference}");
            }
            else
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию.");
            }

            // Вычисление среднеарифметического значения
            double average = 0;
            foreach (var number in numbers)
            {
                average += number;
            }
            average /= count;

            Console.WriteLine($"Среднеарифметическое значение последовательности: {average}");

            // Ожидание ввода перед закрытием консоли
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadLine();
        }
    }
}
