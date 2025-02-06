namespace _10;

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

            // Замена отрицательных элементов на нули
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0) 
                {
                    numbers[i] = 0; 
                }
            }

            
            Console.WriteLine("Замена:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
    }
}

    