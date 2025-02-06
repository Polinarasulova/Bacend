namespace _4;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];
        Console.WriteLine("Введите 5 целых чисел для массива:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine()); 
        }

        Console.WriteLine("Четные числа:");
        bool Numbers = false; 
        foreach (int number in numbers)
        {
            if (number % 2 == 0) 
            {
                Console.WriteLine(number);
                Numbers = true; 
            }
        }

           if (!Numbers)
        {
            Console.WriteLine("Четных чисел в массиве нет.");
        }
    }
}
