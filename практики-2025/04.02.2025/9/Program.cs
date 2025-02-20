using System;

interface IReadable
{
    void Read();
}

abstract class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

class FictionBook : Book, IReadable
{
    public FictionBook(string title, string author) : base(title, author) { }

    public void Read() => Console.WriteLine($"Читаю художественную книгу: {Title} ({Author}).");
}

class ScienceBook : Book, IReadable
{
    public ScienceBook(string title, string author) : base(title, author) { }

    public void Read() => Console.WriteLine($"Читаю научную книгу: {Title} ({Author}).");
}

class Library
{
    private List<Book> _books = new List<Book>();

    public void AddBook(Book book) => _books.Add(book);

    public void RentBook(Book book)
    {
        if (_books.Contains(book))
        {
            _books.Remove(book);
            Console.WriteLine($"{book.Title} успешно арендован.");
        }
        else
        {
            Console.WriteLine($"{book.Title} недоступен для аренды.");
        }
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Книги в библиотеке:");
        foreach (var book in _books)
        {
            Console.WriteLine($"- {book.Title} ({book.Author})");
        }
    }
}

class Program
{
    static void Main()
    {
        var library = new Library();
        library.AddBook(new FictionBook("Война и мир", "Лев Толстой"));
        library.AddBook(new ScienceBook("любовное такси", "Полин"));

        library.DisplayBooks();

        var book = new FictionBook("Война и мир", "Лев Толстой");
        library.RentBook(book);
    }
}