namespace _7;

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

            
            Console.WriteLine("Элементы массива на нечетных позициях:");
            for (int i = 0; i < numbers.Length; i += 2) 
            {
                Console.WriteLine(numbers[i]);
            }
    }
}