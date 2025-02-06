using System;

public class Calculator
{
    public void Run()
    {
        Console.WriteLine("Простой калькулятор");

        
        Console.Write("первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        
        double result = num1 + num2;

        
        Console.WriteLine($"Результат: {num1} + {num2} = {result}");
         Console.WriteLine("Вот это я молодец посчитала, а не то что ты!");
    }

}