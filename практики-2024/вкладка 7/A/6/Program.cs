namespace _6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите предложениее: ");
        string input = Console.ReadLine();
        bool isPalindrome = IsPalindrome(input);
        Console.WriteLine("Предложение \"{0}\" {1} палиндромом.", input, isPalindrome ? "является" : "не является");
    }

    // Рекурсивная функция для проверки, является ли строка палиндромом
    static bool IsPalindrome(string str)
    {
        // Удаляем пробелы и приводим к нижнему регистру для корректной проверки
        str = str.Replace(" ", "").ToLower();
        
         if (str.Length <= 1)
            return true;
            
        if (str[0] != str[str.Length - 1])
        return false;

         return IsPalindrome(str.Substring(1, str.Length - 2));
    }
}