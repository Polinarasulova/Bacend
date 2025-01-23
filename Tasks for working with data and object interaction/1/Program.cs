using System;
using System.Collections.Generic;

namespace Store
{
   public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; } 

        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    }

   public class CashRegister
    {
        private List<Product> cart = new List<Product>(); 
        private double total = 0; 
      
        public void AddProductToCart(Product product, int quantity)
        {
            if (quantity > product.Stock)
            {
                Console.WriteLine($"Недостаточно товара '{product.Name}' на складе.");
            }
            else
            {
                cart.Add(product);
                total += product.Price * quantity; 
                product.Stock -= quantity; 
                Console.WriteLine($"'{product.Name}' добавлено в корзину. Количество: {quantity}.");
            }
        }

 public double CalculateTotal()
        {
            return total;
        }

 public void Checkout()
        {
            Console.WriteLine($"Итоговая сумма: {CalculateTotal()}");
            Console.WriteLine("Покупка завершена");
            cart.Clear(); 
            total = 0; 
    }

 class Program
    {
        static void Main(string[] args)
        {
            Product g = new Product("Гранат", 0.15, 10);
            Product k = new Product("Киви", 0.3, 5);
            Product b = new Product("банан", 0.7, 0); 

            CashRegister cashRegister = new CashRegister();

            cashRegister.AddProductToCart(g, 3); 
            cashRegister.AddProductToCart(k, 5);
            cashRegister.AddProductToCart(b, 5); 

            cashRegister.Checkout();
        }
    }
}
}