using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int> { -3, 5, -1, 10, -7 };

        Console.WriteLine("Исходный список: " + string.Join(", ", numbers));

         RemoveNegativeNumbers(numbers);

        Console.WriteLine("Список после удаления отрицательных чисел: " + string.Join(", ", numbers));
    }

     public static void RemoveNegativeNumbers(List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
        {
            Console.WriteLine("Список пуст или не существует.");
            return;
        }

        int removedCount = numbers.RemoveAll(x => x < 0);

        Console.WriteLine($"Удалено отрицательных чисел: {removedCount}");
    }
}