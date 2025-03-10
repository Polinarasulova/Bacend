using System;
using System.Linq; 

class Program
{
    static void Main()
    {
        int[] numbers = { 4, 6, 10, 16, 31, 22, 8 };

        int max = numbers.Max();

        Console.WriteLine($"Макс: {max}");
    }
}