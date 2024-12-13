using System;

namespace Задание_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Простой калькулятор");
            Console.WriteLine("2. Угадай число");
            Console.Write("Введите номер: ");
            
            string? choice = Console.ReadLine(); // Используем ? для обработки возможного null

            if (choice == "1")
            {
                Calculator calculator = new Calculator();
                calculator.Run();
            }
            else if (choice == "2")
            {
                GuessGame guessGame = new GuessGame();
                guessGame.Run();
            }
            else
            {
                Console.WriteLine("ТЫ, что СОВСЕМ.");
            }
        }
    }
}