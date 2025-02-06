using System;
using System.Collections.Generic;

namespace ProductStore
{
     public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public bool Buy(int quantity)
        {
            if (quantity <= Quantity)
            {
                Quantity -= quantity;
                Console.WriteLine($"Куплено {quantity}  '{Name}' Осталось : {Quantity}.");
                return true;
            }
            else
            {
                Console.WriteLine($"Недостаточно товара '{Name}'  Доступно: {Quantity}.");
                return false;
            }
        }
    }

      public class Store
    {
        private List<Product> products;

        public Store()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine($"Товар '{product.Name}' добавлен в магазин.");
        }

        public Product FindProductByName(string name)
        {
            foreach (var product in products)
            {
                if (product.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            Console.WriteLine($"Товар '{name}' не найден.");
            return null; 
        }

         public void SellProduct(string name, int quantity)
        {
            var product = FindProductByName(name);
            if (product != null)
            {
                product.Buy(quantity);
            }
        }
    }

     public class Program
    {
        public static void Main()
        {
            Store store = new Store();

            store.AddProduct(new Product("Яблоки", 50, 100));
            store.AddProduct(new Product("Бананы", 30, 150));
            store.AddProduct(new Product("Апельсины", 70, 80));

            store.SellProduct("Яблоки", 20); 
            store.SellProduct("Бананы", 200); 
            store.SellProduct("Апельсины", 50); 
            store.SellProduct("Груши", 10); 
        }
    }
}