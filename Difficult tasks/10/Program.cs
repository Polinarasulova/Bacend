
using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}

class Order
{
    public List<Product> Products { get; set; }
    public decimal TotalCost { get; set; }

    public Order()
    {
        Products = new List<Product>();
        TotalCost = 0;
    }

    public void AddProduct(Product product, int quantity)
    {
        if (product.Quantity >= quantity)
        {
            Products.Add(new Product(product.Name, product.Price, quantity));
            TotalCost += product.Price * quantity;
            product.Quantity -= quantity; 
        }
        else
        {
            Console.WriteLine($"Товар {product.Name} недоступен в количестве {quantity}. Доступно: {product.Quantity}");
        }
    }

    public void PrintOrder()
    {
        Console.WriteLine("Заказ:");
        foreach (var product in Products)
        {
            Console.WriteLine($"- {product.Name}, Цена: {product.Price}, Количество: {product.Quantity}");
        }
        Console.WriteLine($"Итоговая стоимость: {TotalCost}");
    }
}

class User
{
    public string Username { get; set; }
    public string Email { get; set; }

    public User(string username, string email)
    {
        Username = username;
        Email = email;
    }

    public void PlaceOrder(List<Product> products, Dictionary<string, int> orderItems)
    {
        Order order = new Order();

        foreach (var item in orderItems)
        {
            string productName = item.Key;
            int quantity = item.Value;

            Product product = products.Find(p => p.Name == productName);
            if (product != null)
            {
                order.AddProduct(product, quantity);
            }
            else
            {
                Console.WriteLine($"Товара  {productName} нету");
            }
        }

        if (order.Products.Count > 0)
        {
            Console.WriteLine($"\nПользователь {Username} оформил заказ:");
            order.PrintOrder();
        }
        else
        {
            Console.WriteLine("Заказ не был оформлен");
        }
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product("яблоко", 100, 10),
            new Product("гранат", 200, 5),
            new Product("киви", 50, 20)
        };

        User user = new User("Шерышова Полина", "pili@gmail.com");

        Dictionary<string, int> orderItems = new Dictionary<string, int>
        {
            { "яблоко", 2 },
            { "гранат", 1 },
            { "киви", 3 }
        };

        user.PlaceOrder(products, orderItems);

        Console.WriteLine("\nОстатки");
        foreach (var product in products)
        {
            Console.WriteLine($"- {product.Name}, Количество: {product.Quantity}");
        }
    }
}