using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Введите заголовок : ");
        string title = Console.ReadLine();

        Console.WriteLine("Введите текст : ");
        string body = Console.ReadLine();

        Console.WriteLine("Введите ID пользователя : ");
        int userId = int.Parse(Console.ReadLine());

        using (HttpClient client = new HttpClient())
        {
            string url = "https://jsonplaceholder.typicode.com/posts";

            // JSON-строки
            string json = $"{{\"title\":\"{title}\", \"body\":\"{body}\", \"userId\":{userId}}}";

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            //POST-запрос
            HttpResponseMessage response = await client.PostAsync(url, content);
            
            if (response.IsSuccessStatusCode)
            {
               string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Данные успешно отправлены : ");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine($"Ошибка при отправке данных : {response.StatusCode}");
            }
        }
    }
}