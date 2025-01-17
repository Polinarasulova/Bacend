using System;

namespace Books
{
    public class Book
    {
       public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

     public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

     public string GetDescription()
        {
            return $"Название : {Title}, Автор: {Author}, Сколько страниц: {Pages}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов класса Book
            Book book1 = new Book("2022", "Твое сердце будет разбито", 543);
            Book book2 = new Book("По осколкам твоего сердца", "Анна Джей", 509);
            Book book3 = new Book("До встречи с тобой", "Джоджо Мойес", 480);

            Console.WriteLine(book1.GetDescription());
            Console.WriteLine(book2.GetDescription());
            Console.WriteLine(book3.GetDescription());
        }
    }
}
    