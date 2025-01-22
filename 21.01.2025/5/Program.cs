using System;

namespace Book
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

       public void PrintDetails()
        {
            Console.WriteLine($"Название: {Title}, Автор: {Author}, Цена: {Price}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание массива из 5 книг
            Book[] books = new Book[5];

            // Заполнение массива данными
            books[0] = new Book { Title = "Война и мир", Author = "Лев Толстой", Price = 600 };
            books[1] = new Book { Title = "Твое сердце будет разбито", Author = "Анна Джей", Price = 450 };
            books[2] = new Book { Title = "Гарри Поттер и философский камень", Author = "Дж.К. Роулинг", Price = 550 };
            books[3] = new Book { Title = "рускиий эгэ", Author = "котова", Price = 300 };
            books[4] = new Book { Title = "Мастер и Маргарита", Author = "Михаил Булгаков", Price = 700 };

            Console.WriteLine("Книги с ценой больше 500:");
            foreach (var book in books)
            {
                if (book.Price > 500)
                {
                    book.PrintDetails();
                }
            }
        }
    }
}