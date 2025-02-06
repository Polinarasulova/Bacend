namespace A;

class Program
{
    static void Main(string[] args)
    {
        // 1
        Console.WriteLine("Сумма: " + Sum(5, 10));

        // 2
        GreetUser ("Полина");

        // 3.
        Console.WriteLine("Максимум: " + Max(5, 15));

        // 4
        Console.WriteLine("Четное число: " + IsEven(4));

        // 5
        Console.WriteLine("Температура в Фаренгейтах: " + CelsiusToFahrenheit(25));

        // 6
        Console.WriteLine("Обратная строка: " + ReverseString("Полина"));

        // 7
        Console.WriteLine("Количество 'и' в строке: " + CountCharacter("Привет, мир!", 'и'));

        // 8. Функция Расчета Факториала
        Console.WriteLine("Факториал 5: " + Factorial(5));

        // 9
        Console.WriteLine("Простое число: " + IsPrime(7));

        // 10
        Console.WriteLine("Случайное число: " + GenerateRandomNumber(1, 100));
    }

    // 1
    static int Sum(int a, int b)
    {
        return a + b;
    }

    // 2
    static void GreetUser (string name)
    {
        Console.WriteLine("Привет, " + name + "!");
    }

    // 3
    static int Max(int a, int b)
    {
        return a > b ? a : b;
    }

    // 4
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // 5
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // 6
    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // 7
    static int CountCharacter(string str, char character)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (c == character)
            {
                count++;
            }
        }
        return count;
    }

    // 8
    static long Factorial(int number)
    {
        if (number < 0) throw new ArgumentException("Факториал не определен для отрицательных чисел.");
        long result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }

    // 9
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    // 10
    static int GenerateRandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max + 1);
    }
}