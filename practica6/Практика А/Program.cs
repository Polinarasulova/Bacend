using System;

namespace Практика_А
{
    class Program
    {
        static void Main()
        {
            // 1. Приветствие пользователя
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");

            // 2. Калькулятор возраста
            Console.WriteLine("Введите ваш год рождения:");
            string input = Console.ReadLine();

            // Проверка на корректность ввода
            if (int.TryParse(input, out int lh))
            {
                int p = DateTime.Now.Year;

                // Проверка на реалистичность введенного года
                if (lh > p)
                {
                    Console.WriteLine("Ошибка: год рождения не может быть больше текущего года.");
                }
               else
                {
                    int age = p - lh;
                    Console.WriteLine($"Ваш возраст: {age} лет.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректный год рождения.");
            }
        }
    }
}
