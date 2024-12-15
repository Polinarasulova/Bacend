namespace _1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("число: ");
        int number = int.Parse(Console.ReadLine());
        long result = Factorial(number);
        Console.WriteLine("Факториал {0} равен {1}", number, result);
    }

    static long Factorial(int n)
    {
        if (n <= 1) 
            return 1;
        return n * Factorial(n - 1); 
    }
}
   