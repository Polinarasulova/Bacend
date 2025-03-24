using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string url = "https://jsonplaceholder.typicode.com/users/1";

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine("Ответ: ");
                    Console.WriteLine(responseBody);
                }
                else
                {
                    Console.WriteLine($"Ошибка при запросе: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Oшибка: {ex.Message}");
            }
        }
    }
}