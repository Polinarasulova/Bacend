using System;
using System.Collections.Generic;

interface IManageable
{
    void AddProduct(string product);
    void RemoveProduct(string product);
}


abstract class User
{
    public string Name { get; set; }
    public string Email { get; set; }

    public User(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public abstract void DisplayInfo();
}

class Customer : User
{
    private Cart _cart; 

    public Customer(string name, string email) : base(name, email)
    {
        _cart = new Cart(); 
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Клиент: {Name}, Email: {Email}");
    }

    
    public void AddToCart(string product)
    {
        _cart.Add(product);
        Console.WriteLine($"{product} добавлен в корзину.");
    }
    public void ViewCart()
    {
        Console.WriteLine("Содержимое корзины:");
        _cart.DisplayContents();
    }
}

class Admin : User, IManageable
{
    private List<string> _products = new List<string>(); 

    public Admin(string name, string email) : base(name, email) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Администратор: {Name}, Email: {Email}");
    }
    public void AddProduct(string product)
    {
        _products.Add(product);
        Console.WriteLine($"{product} добавлен в магазин.");
    }

     public void RemoveProduct(string product)
    {
        if (_products.Contains(product))
        {
            _products.Remove(product);
            Console.WriteLine($"{product} удален из магазина.");
        }
        else
        {
            Console.WriteLine($"{product} не найден в магазине.");
        }
    }

     public void ViewProducts()
    {
        Console.WriteLine("Товары в магазине:");
        foreach (var product in _products)
        {
            Console.WriteLine("- " + product);
        }
    }
}

class Cart
{
    private List<string> _items = new List<string>(); 

   public void Add(string item)
    {
        _items.Add(item);
    }

    public void Remove(string item)
    {
        if (_items.Contains(item))
        {
            _items.Remove(item);
            Console.WriteLine($"{item} удален из корзины.");
        }
        else
        {
            Console.WriteLine($"{item} не найден в корзине.");
        }
    }
    public void DisplayContents()
    {
        if (_items.Count == 0)
        {
            Console.WriteLine("Корзина пуста.");
        }
        else
        {
            foreach (var item in _items)
            {
                Console.WriteLine("- " + item);
            }
        }
    }
}

class Program
{
    static void Main()
    {
         Admin admin = new Admin("Азиз", "aziz@example.com");
        admin.DisplayInfo();

        admin.AddProduct("Ноутбук");
        admin.AddProduct("Смартфон");
        admin.ViewProducts();

        Customer customer = new Customer("Пользователь", "user@gmail.com");
        customer.DisplayInfo();

        customer.AddToCart("Ноутбук");
        customer.AddToCart("Смартфон");

        customer.ViewCart();

        ((Cart)customer.GetType().GetField("_cart", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(customer)).Remove("Смартфон");

       
       customer.ViewCart();
    }
}