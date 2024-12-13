using System;

public class Calculator
{
    public void Run()
    {
        Console.WriteLine("Простой калькулятор");

        // Запрос у пользователя первого числа
        Console.Write("первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Запрос у пользователя второго числа
        Console.Write("второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Сложение чисел
        double result = num1 + num2;

        // Вывод результата
        Console.WriteLine($"Результат: {num1} + {num2} = {result}");
         Console.WriteLine("Вот это я молодец посчитала, а не то что ты!");
    }

}