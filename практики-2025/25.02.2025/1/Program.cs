using System;
using System.IO;

class FileReader
{
    static void Main()
    {
        string filePath = "polina.txt";
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Ошибка: файл '{filePath}' не найден.");
                return;
            }

            using (StreamReader reader = new StreamReader(filePath, System.Text.Encoding.UTF8))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine("\nСодержимое файла:\n");
                Console.WriteLine(content);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
        }
    }
}
