namespace C;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Введите число:");

            string input = Console.ReadLine();
            if (int.TryParse(input, out int число))
            {
                
                число += 5;
                Console.WriteLine($"Результат: {число}");
            }
            else
            {
                Console.WriteLine("Некорректное число.");
            }
        }
    }
