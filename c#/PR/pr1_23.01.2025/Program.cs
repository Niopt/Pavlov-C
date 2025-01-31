using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1_23._01._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая 1 Солнечная система");

            // Данные о планетах и Солнце
            Dictionary<string, Planet> solarSystem = new Dictionary<string, Planet>
            {
                { "Солнце", new Planet("Солнце", 1392700, 1.989e30, 0) },
                { "Меркурий", new Planet("Меркурий", 4879, 3.3011e23, 57.91e6) },
                { "Венера", new Planet("Венера", 12104, 4.8675e24, 108.2e6) },
                { "Земля", new Planet("Земля", 12742, 5.97237e24, 149.6e6) },
                { "Марс", new Planet("Марс", 6779, 6.4171e23, 227.9e6) },
                { "Юпитер", new Planet("Юпитер", 139820, 1.8982e27, 778.5e6) },
                { "Сатурн", new Planet("Сатурн", 116460, 5.6834e26, 1.429e9) },
                { "Уран", new Planet("Уран", 50724, 8.6810e25, 2.871e9) },
                { "Нептун", new Planet("Нептун", 49244, 1.02413e26, 4.498e9) }
            };

            // Словарь для связи номера планеты с её названием
            Dictionary<int, string> planetNumbers = new Dictionary<int, string>
            {
                { 1, "Меркурий" },
                { 2, "Венера" },
                { 3, "Земля" },
                { 4, "Марс" },
                { 5, "Юпитер" },
                { 6, "Сатурн" },
                { 7, "Уран" },
                { 8, "Нептун" }
            };

            bool continueProgram = true;
            while (continueProgram)
            {
                Console.WriteLine("Выберите опцию:");
                Console.WriteLine("1. Расстояние между планетами солнечной системы <Р>");
                Console.WriteLine("2. Разницу масс выбранных планет <М>");
                Console.WriteLine("3. Во сколько диаметр выбранной планеты меньше Солнца <Д>");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();

                switch (choice.ToUpper())
                {
                    case "Р":
                        CalculateDistance(solarSystem, planetNumbers);
                        break;
                    case "М":
                        CalculateMassDifference(solarSystem, planetNumbers);
                        break;
                    case "Д":
                        CalculateDiameterRatio(solarSystem, planetNumbers);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите снова.");
                        break;
                }

                Console.Write("Хотите продолжить? (да/нет): ");
                string answer = Console.ReadLine();
                continueProgram = answer.ToLower() == "да";
            }
        }

        static void CalculateDistance(Dictionary<string, Planet> solarSystem, Dictionary<int, string> planetNumbers)
        {
            foreach (var pair in planetNumbers)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            Console.Write("Введите название или номер первой планеты: ");
            string input1 = Console.ReadLine();
            Console.Write("Введите название или номер второй планеты: ");
            string input2 = Console.ReadLine();

            string planet1 = GetPlanetName(input1, planetNumbers);
            string planet2 = GetPlanetName(input2, planetNumbers);

            if (planet1 == null || planet2 == null)
            {
                Console.WriteLine("Одна или обе планеты не найдены.");
                return;
            }

            if (planet1 == planet2)
            {
                Console.WriteLine("Выбраны одинаковые планеты. Пожалуйста, выберите разные планеты.");
                return;
            }
            
            double distance = Math.Abs(solarSystem[planet1].DistanceFromSun - solarSystem[planet2].DistanceFromSun);
            Console.WriteLine($"Расстояние между {planet1} и {planet2} составляет {distance} км.");
        }

        static void CalculateMassDifference(Dictionary<string, Planet> solarSystem, Dictionary<int, string> planetNumbers)
        {
            Console.Write("Введите название или номер первой планеты: ");
            string input1 = Console.ReadLine();
            Console.Write("Введите название или номер второй планеты: ");
            string input2 = Console.ReadLine();

            string planet1 = GetPlanetName(input1, planetNumbers);
            string planet2 = GetPlanetName(input2, planetNumbers);

            if (planet1 == null || planet2 == null)
            {
                Console.WriteLine("Одна или обе планеты не найдены.");
                return;
            }

            if (planet1 == planet2)
            {
                Console.WriteLine("Выбраны одинаковые планеты. Пожалуйста, выберите разные планеты.");
                return;
            }

            double massDifference = solarSystem[planet1].Mass - solarSystem[planet2].Mass;
            Console.WriteLine($"Разница масс между {planet1} и {planet2} составляет {massDifference} кг.");
        }

        static void CalculateDiameterRatio(Dictionary<string, Planet> solarSystem, Dictionary<int, string> planetNumbers)
        {
            Console.Write("Введите название или номер планеты: ");
            string input = Console.ReadLine();

            string planet = GetPlanetName(input, planetNumbers);

            if (planet == null)
            {
                Console.WriteLine("Планета не найдена.");
                return;
            }

            double diameterRatio = solarSystem["Солнце"].Diameter / solarSystem[planet].Diameter;
            Console.WriteLine($"Диаметр Солнца больше диаметра {planet} в {diameterRatio} раз.");
        }

        static string GetPlanetName(string input, Dictionary<int, string> planetNumbers)
        {
            // Проверяем, является ли ввод числом (номером планеты)
            if (int.TryParse(input, out int number))
            {
                if (planetNumbers.ContainsKey(number))
                {
                    return planetNumbers[number];
                }
                else
                {
                    return null; // Номер планеты не найден
                }
            }
            else
            {
                // Если ввод не число, считаем его названием планеты
                return input;
            }
        }
    }

    class Planet
    {
        public string Name { get; }
        public double Diameter { get; } // в км
        public double Mass { get; } // в кг
        public double DistanceFromSun { get; } // в км

        public Planet(string name, double diameter, double mass, double distanceFromSun)
        {
            Name = name;
            Diameter = diameter;
            Mass = mass;
            DistanceFromSun = distanceFromSun;
        }
    }
}

