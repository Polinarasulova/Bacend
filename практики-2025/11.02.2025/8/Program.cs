using System;
using System.Collections.Generic;

class Program
{
    static Queue<string> customers = new Queue<string>();

    static void Main(string[] args)
    {
         customers.Enqueue("Покупатель 1");
        customers.Enqueue("Покупатель 2");
        customers.Enqueue("Покупатель 3");

         ServeCustomers();
    }

    static void ServeCustomers()
    {
        while (customers.Count > 0)
        {
            ServeCustomer();
        }
        Console.WriteLine("Очередь пуста.");
    }

    static void ServeCustomer()
    {
        if (customers.Count > 0)
        {
            string customer = customers.Dequeue();
            Console.WriteLine($"Обслужен: {customer}");
        }
    }
}