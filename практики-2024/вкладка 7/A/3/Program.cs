namespace _3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Напиши что-нибудь: ");
        string input = Console.ReadLine();
        string reversed = ReverseString(input);
        Console.WriteLine("Обратная строка: " + reversed);
    }

   static string ReverseString(string str)
    {
        if (str.Length == 0) 
            return str;
        return str[str.Length - 1] + ReverseString(str.Substring(0, str.Length - 1)); 
    }
}