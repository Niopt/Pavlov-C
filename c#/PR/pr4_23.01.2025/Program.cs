using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4_28._01._2025
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Выберите задачу (454, 458, 462, 463, 466) или введите '0' для выхода:");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "454":
                        Task454();
                        break;
                    case "458":
                        Task458();
                        break;
                    case "462":
                        Task462();
                        break;
                    case "463":
                        Task463();
                        break;
                    case "466":
                        Task466();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите снова.");
                        break;
                }

                if (running && choice != "0")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Хотите повторить или вернуться к выбору задач? (да/нет)");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() != "да")
                    {
                        running = false;
                    }
                }
            }
        }

        static void Task454()
        {
            Random rand = new Random();
            Console.ForegroundColor = ConsoleColor.Yellow;
            double volume = rand.Next(70, 12001) / 100.0;
            Console.WriteLine($"Сгенерированный объем тела: {volume} см³", ConsoleColor.Yellow);

            Console.WriteLine("Введите массу тела (кг):");
            double mass = double.Parse(Console.ReadLine());
            
            double density = mass / volume;
            Console.WriteLine($"Плотность материала: {density} кг/м³", Console.ForegroundColor = ConsoleColor.Blue);
        }

        static void Task458()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите целое число a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число b:");
            int b = int.Parse(Console.ReadLine());

            Random rand = new Random();
            double c = rand.NextDouble() * 100;
            double d = rand.NextDouble() * 100;

            Console.WriteLine($"Сгенерированные числа: c = {c}, d = {d}", Console.ForegroundColor = ConsoleColor.Blue);

            Console.WriteLine($"Сумма: {a + b + c + d}", Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine($"Разность: {a - b - c - d}", Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine($"Произведение: {a * b * c * d}", Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine($"Частное от деления a на c: {a / c}", Console.ForegroundColor = ConsoleColor.Blue);
        }

        static void Task462()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Random rand = new Random();
            int monitorPrice = rand.Next(1000, 100000);
            int systemUnitPrice = rand.Next(1000, 100000);
            int keyboardPrice = rand.Next(100, 1000);
            int mousePrice = rand.Next(100, 1000);

            Console.WriteLine($"Стоимость монитора: {monitorPrice} руб.", ConsoleColor.Yellow);
            Console.WriteLine($"Стоимость системного блока: {systemUnitPrice} руб.", ConsoleColor.Yellow);
            Console.WriteLine($"Стоимость клавиатуры: {keyboardPrice} руб.", ConsoleColor.Yellow);
            Console.WriteLine($"Стоимость мыши: {mousePrice} руб.", ConsoleColor.Yellow);

            int totalPricePerComputer = monitorPrice + systemUnitPrice + keyboardPrice + mousePrice;
            Console.WriteLine($"Стоимость одного компьютера: {totalPricePerComputer} руб." );

            Console.WriteLine("Введите количество компьютеров:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Стоимость {n} компьютеров: {totalPricePerComputer * n} руб.", Console.ForegroundColor = ConsoleColor.Blue);
        }

        static void Task463()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите скорость первого автомобиля (км/ч):");
            double v1 = double.Parse(Console.ReadLine());
            if (v1 <= 0)
            {
                Console.WriteLine("Скорость должна быть положительной.", ConsoleColor.Red);
                return;
            }

            Console.WriteLine("Введите скорость второго автомобиля (км/ч):");
            double v2 = double.Parse(Console.ReadLine());
            if (v2 <= 0)
            {
                Console.WriteLine("Скорость должна быть положительной.", ConsoleColor.Red);
                return;
            }

            Random rand = new Random();
            double distance = rand.Next(100, 1000);
            Console.WriteLine($"Расстояние между автомобилями: {distance} км", Console.ForegroundColor = ConsoleColor.Blue);

            double time = distance / (v1 + v2);
            Console.WriteLine($"Автомобили встретятся через {time} часов", Console.ForegroundColor = ConsoleColor.Blue);
        }

        static void Task466()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int rectangleWidth = 543;
            int rectangleHeight = 130;

            Console.WriteLine("Дан прямоугольник со сторонами 543 на 130мм. Введите сторону квадрата (от 12 до 120 мм), и мы расчитаем сколько таких квадратов можно вырезать из прямоугольника:");
            int squareSide = int.Parse(Console.ReadLine());
            if (squareSide < 12 || squareSide > 120)
            {
                Console.WriteLine("Сторона квадрата должна быть от 12 до 120 мм.", ConsoleColor.Red);
                return;
            }

            int squaresInWidth = rectangleWidth / squareSide;
            int squaresInHeight = rectangleHeight / squareSide;
            int totalSquares = squaresInWidth * squaresInHeight;

            Console.WriteLine($"Количество квадратов: {totalSquares}", Console.ForegroundColor = ConsoleColor.Blue);
        }
    }
}
