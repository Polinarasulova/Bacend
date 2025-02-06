using System;

abstract class Shape 
{
    public abstract double GetArea();
    public abstract double GetPerimeter();
}

class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width; 
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }

    public override double GetPerimeter()
    {
        return 2 * (width + height);
    }
}

class Circle : Shape
{
    private double radius; 

    public Circle(double radius)
    {
        this.radius = radius; 
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes =
        {
            new Rectangle(7, 15),
            new Rectangle(5, 7),
            new Circle(5),
            new Circle(12),
            new Circle(9),
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Площадь: {shape.GetArea()},Периметр: {shape.GetPerimeter()}");
        }
    }
}
