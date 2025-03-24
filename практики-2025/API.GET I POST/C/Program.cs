using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Выберите тип запроса (1 - GET, 2 - POST):");
        
        if (!int.TryParse(Console.ReadLine(), out int choice) || (choice != 1 && choice != 2))
        {
            Console.WriteLine("Неверный выбор.");
            return;
        }

        using HttpClient client = new HttpClient();

        if (choice == 1)
        {
            Console.WriteLine("Введите URL для GET-запроса:");
            string url = Console.ReadLine();

            try
            {
                string response = await client.GetStringAsync(url);
                Console.WriteLine("Ответ сервера:");
                Console.WriteLine(response);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }
        else if (choice == 2)
        {
            string[] apis = {
                "https://api.example.com/endpoint1",
                "https://api.example.com/endpoint2"
            };

            Console.WriteLine("Выберите API для POST-запроса:");
            for (int i = 0; i < apis.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {apis[i]}");
            }

            if (!int.TryParse(Console.ReadLine(), out int apiChoice) || apiChoice < 1 || apiChoice > apis.Length)
            {
                Console.WriteLine("Неверный выбор API.");
                return;
            }

            string apiUrl = apis[apiChoice - 1];

            Console.WriteLine("Введите данные для отправки (в формате JSON):");
            string postData = Console.ReadLine();

            try
            {
                HttpContent content = new StringContent(postData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Ответ сервера:");
                    Console.WriteLine(responseBody);
                }
                else
                {
                    Console.WriteLine($"Ошибка HTTP: {response.StatusCode}");
                    Console.WriteLine(await response.Content.ReadAsStringAsync());
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }
    }
}