using System;

public class Calculator
{
     public static int UsageCount = 0;

    public int Add(int a, int b)
    {
        UsageCount++; 
        return a + b;
    }

    // Метод для вычитания двух чисел
    public int Subtract(int a, int b)
    {
        UsageCount++; 
        return a - b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Calculator calculator = new Calculator();

         int sum = calculator.Add(7, 3);
        Console.WriteLine($"Сумма: {sum}");

        int difference = calculator.Subtract(15, 4);
        Console.WriteLine($"Разница: {difference}");

        Console.WriteLine($"Количество вызовов методов: {Calculator.UsageCount}");
    }
}