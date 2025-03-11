using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> data = new Dictionary<string, int>
        {
            { "apple", 10 },
            { "banana", 5 },
            { "orange", 7 }
        };

        try
        {
            Console.Write("Введите название фрукта: ");
            string key = Console.ReadLine();
            if (data.ContainsKey(key))
            {
                Console.WriteLine($"Значение: {data[key]}"); 
            }
            else
            {
                throw new KeyNotFoundException("Ключ не найден в словаре.");
            }

            Console.Write("Введите числитель: ");
            if (int.TryParse(Console.ReadLine(), out int numerator)) 
            {
                Console.WriteLine($"Числитель: {numerator}");
            }
            else
            {
                Console.WriteLine("Ошибка: введено не число.");
            }
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine(ex.Message); 
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}"); 
        }
    }
}