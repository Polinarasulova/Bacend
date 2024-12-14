namespace B;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1 число:");
        double polina = double.Parse(Console.ReadLine());

        Console.WriteLine("2 число:");
        double vika = double.Parse(Console.ReadLine());

        double сумма = polina + vika;
        double разность = polina - vika;
        double произведение = polina* vika;
        double частное = vika != 0 ? polina / vika : 0;

        Console.WriteLine($"\nРезультаты арифметических операций:");
        Console.WriteLine($"Сложение: {polina} + {vika} = {сумма}");
        Console.WriteLine($"Вычитание: {polina} - {vika} = {разность}");
        Console.WriteLine($"Умножение: {polina} * {vika} = {произведение}");
        if (vika != 0)
        {
            Console.WriteLine($"Деление: {polina} / {vika} = {частное}");
        }
        else
        {
            Console.WriteLine("Деление на ноль нельзя. Ты что , ку-ку?");
        }
        }
    }