using System;

public abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height; 
    }

    public override double CalculatePerimeter()
    {
        return 2 * (Width + Height); 
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius; 
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius; 
    }
}

public class Triangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double CalculateArea()
    {
         double semiPerimeter = CalculatePerimeter() / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
    }

    public override double CalculatePerimeter()
    {
        return SideA + SideB + SideC; 
    }
}

public class Program
{
    public static void Main()
    {
        Shape[] shapes = 
        {
            new Rectangle(5, 10),
            new Circle(7),
            new Triangle(3, 4, 5)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Фигура: {shape.GetType().Name}");
            Console.WriteLine($"Площадь: {shape.CalculateArea():F2}");
            Console.WriteLine($"Периметр: {shape.CalculatePerimeter():F2}");
            Console.WriteLine();
        }
    }
}