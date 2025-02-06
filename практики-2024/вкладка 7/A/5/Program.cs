namespace _5;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Введите два числа(через пробел): ");
        string[] input = Console.ReadLine().Split(' ');
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        
        int gcd = GCD(a, b);
        Console.WriteLine("Наибольший общий делитель {0} и {1} равен {2}", a, b, gcd);
    }

    static int GCD(int a, int b)
    {
        if (b == 0) 
            return a;
        return GCD(b, a % b); 
    }
}