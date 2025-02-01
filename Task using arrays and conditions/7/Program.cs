using System;

public class Book
{
     public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }

    public Book(string title, string author, decimal price)
    {
        Title = title;
        Author = author;
        Price = price;
    }
}

public class Program
{
    public static void Main()
    {
         Book[] books = 
        {
            new Book("реквием", "ахматова", 250),
            new Book("любовь-ненавесть", "Анна Джей", 505),
            new Book("три девочки", "верейская", 699),
            new Book("молитвы на основе мироздания", "секлитова", 306),
            new Book("ЕГЭ ОБЩЕСТВОЗНАНИЕ", "КОТОВА", 900)
        };

        Console.WriteLine("Книги с ценой от 500 до 600:");
        foreach (var book in books)
        {
            if (book.Price >= 300 && book.Price <= 1000)
            {
                Console.WriteLine($"Название: {book.Title}, Автор: {book.Author}, Цена: {book.Price}");
            }
        }
    }
}