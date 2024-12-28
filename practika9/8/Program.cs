namespace _8;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[3];

        for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine()); 
            }

            int min = numbers[0];
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i]; 
                if (numbers[i] > max)
                {
                    max = numbers[i]; 
                }
            }
            
            Console.WriteLine({min});
            Console.WriteLine({max});
    }
}
