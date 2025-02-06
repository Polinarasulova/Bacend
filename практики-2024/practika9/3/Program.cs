namespace _3;

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

        Array.Reverse(numbers);
        Console.WriteLine("Перевернутый массив: " + string.Join(", ", numbers));
    }
 }

