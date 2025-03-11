using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "example.txt";
        string additionalContent = "Полина крута";

        try
        {
            File.AppendAllText(path, additionalContent + Environment.NewLine);
            Console.WriteLine("Текст добавлен в файл.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}