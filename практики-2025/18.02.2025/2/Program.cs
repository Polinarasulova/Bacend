using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите числитель: ");
        int numerator = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите знаменатель: ");
        int denominator = Convert.ToInt32(Console.ReadLine());
        
        try
        {
            int result = numerator / denominator;
            Console.WriteLine($"Результат: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка: деление на ноль недопустимо.");
        }
        
        Console.WriteLine("Программа продолжает работу...");
    }
}