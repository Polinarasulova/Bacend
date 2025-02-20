using System;

interface IDiscountable
{
    void ApplyDiscount(int percent);
}

abstract class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"{Name}: ${Price}");
    }

    public void ApplyDiscount(int percent)
    {
        Price *= (100 - percent) / 100.0m;
    }
}

class FoodProduct : Product
{
    public int ShelfLife { get; set; }

    public FoodProduct(string name, decimal price, int shelfLife) : base(name, price)
    {
        ShelfLife = shelfLife;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Срок годности: {ShelfLife} ");
    }
}

class Electronics : Product
{
    public int Warranty { get; set; }

    public Electronics(string name, decimal price, int warranty) : base(name, price)
    {
        Warranty = warranty;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Гарантия: {Warranty} ");
    }
}

class Program
{
    static void Main()
    {
        var apple = new FoodProduct("Яблоко", 10, 7);
        var laptop = new Electronics("Дом", 1000, 12);

        apple.ApplyDiscount(10);
        apple.PrintInfo();

        laptop.ApplyDiscount(20);
        laptop.PrintInfo();
    }
}