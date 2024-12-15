namespace _7;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Введите количество дисков: ");
        int n = int.Parse(Console.ReadLine());
        
        // Запускаем решение задачи
        SolveHanoi(n, 'A', 'C', 'B'); // A - начальный, C - целевой, B - вспомогательный
    }

    
    static void SolveHanoi(int n, char source, char target, char auxiliary)
    {
        if (n == 1) 
        {
            Console.WriteLine($"Переместить диск 1 с {source} на {target}");
            return;
        }

       SolveHanoi(n - 1, source, auxiliary, target);
        
       Console.WriteLine($"Переместить диск {n} с {source} на {target}");
        
        SolveHanoi(n - 1, auxiliary, target, source);
    }
}
