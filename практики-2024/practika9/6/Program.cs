namespace _6;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[3];

       for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine()); 
            }

           Console.Write("число: ");
           int target = int.Parse(Console.ReadLine());

            // Линейный поиск
            bool found = false; 
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target) 
                {
                    Console.WriteLine($"Элемент {target} найден на индексе {i}.");
                    found = true; 
                    break; 
                }
            }

    }
}
