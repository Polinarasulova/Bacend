using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "pol.txt";
        string[] lines = { "First line", "Second line", "Third line" };

        try
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            } 
            Console.WriteLine("Строки успешно записаны в файл.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}