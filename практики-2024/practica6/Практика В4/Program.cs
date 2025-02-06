namespace Практика_В4;

class Program
{
    static void Main(string[] args)
    {
            
            Console.WriteLine("1 число:");
            int polina = int.Parse(Console.ReadLine());

            Console.WriteLine("2 число:");
            int Number = int.Parse(Console.ReadLine());

            // Сравниваем числа и выводим их в нужном порядке
            if (polina > Number)
            {
                Console.WriteLine($"Большее число: {polina}, Меньшее число: {Number}");
            }
            else if (polina < Number)
            {
                Console.WriteLine($"Большее число: {Number}, Меньшее число: {polina}");
            }
            else
            {
                Console.WriteLine("Оба числа равны.");
            }
        }
    }
