using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFilePath = "aziz.txt";
        string polFilePath = "pol.txt";

        try
        {
            if (File.Exists(inputFilePath))
            {
                string[] lines = File.ReadAllLines(inputFilePath);
                
                for (int i = 0; i < lines.Length; i++)
                {
                    lines[i] = lines[i].ToUpper();
                }

                File.WriteAllLines(polFilePath, lines);
                Console.WriteLine("Файл успешно обработан и сохранён как pol.txt.");
            }
            else
            {
                Console.WriteLine("Входной файл не найден.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}