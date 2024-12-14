namespace _5;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine()); //
            }

            int negativeCount = 0; 
            foreach (int number in numbers)
            {
                if (number < 0) 
                {
                    negativeCount++; 
                }
            }

            
        Console.WriteLine("Количество отрицательных чисел в массиве: " + negativeCount);
    }
}
