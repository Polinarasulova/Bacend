using System;

namespace Практика_C
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();

            // Проверка на корректность ввода
            if (int.TryParse(input, out int number))
            {
                // Получаем разряды числа
                int hundreds = (number / 100) % 10; // Сотни
                int tens = (number / 10) % 10;      // Десятки
                int units = number % 10;            // Единицы

                // Выводим разряды
                Console.WriteLine($"Сотни: {hundreds}, Десятки: {tens}, Единицы: {units}");
            }
            
        }
    }
}
