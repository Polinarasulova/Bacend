using System;

namespace Практика_B
{
    class Program
    {
        static void Main()
        {
            // Запрашиваем имя
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите номер телефона:");
            string phoneNumber = Console.ReadLine();
            
            Console.WriteLine($"Имя: {name}, Телефон: {phoneNumber}");
        }
    }
}
