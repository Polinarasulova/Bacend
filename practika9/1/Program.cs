using System;

namespace Prac1
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] numbers = new int[5];

           for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine()); 
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i]; 
            }

            Console.WriteLine("Сумма массива: " + sum);
        }
    }
}