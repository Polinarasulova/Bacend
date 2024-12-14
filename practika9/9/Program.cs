namespace _9;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[4];

        for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine()); 
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1]) 
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            
            Console.WriteLine("сортировка массива по возрастанию :");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
    }
}
