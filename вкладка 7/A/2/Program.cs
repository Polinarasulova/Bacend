namespace _2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("n-ое число: ");
        int n = int.Parse(Console.ReadLine());
        int result = Fibonacci(n);
        Console.WriteLine("n-е число Фибоначчи для n = {0} равно {1}", n, result);
    }

    // Рекурсивная функция для нахождения n-го числа Фибоначчи
    static int Fibonacci(int n)
    {
        if (n <= 0) 
        return 0;
        if (n == 1) 
        return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2); 
    }
}