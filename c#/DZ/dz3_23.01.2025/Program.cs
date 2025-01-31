using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3_27._01._2025
{
class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Random random = new Random();
            bool repeat = true;

            while (repeat)
            {
                int S = random.Next(100, 1000);
                Console.WriteLine($"Сгенерированное расстояние между автомобилями: {S} км.");

                double V1 = GetPositiveNonZeroSpeed("Введите скорость первого автомобиля (км/ч): ");
                double V2 = GetPositiveNonZeroSpeed("Введите скорость второго автомобиля (км/ч): ");

                double time = S / (V1 + V2);
                Console.WriteLine($"Автомобили встретятся через {time:F2} часов.");

                Console.WriteLine("Хотите повторить расчет? (да/нет)");
                string answer = Console.ReadLine().ToLower();
                repeat = answer == "да";
            }
        }

        static double GetPositiveNonZeroSpeed(string prompt)
        {
            double speed;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out speed) && speed > 0)
                {
                    return speed;
                }
                Console.WriteLine("Ошибка: скорость должна быть положительным числом. Пожалуйста, попробуйте снова.");
            }
        }
    }
}
