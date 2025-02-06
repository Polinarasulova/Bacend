using System;

public abstract class Shape
{
        public abstract double GetArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

   public Circle(double radius)
    {
        Radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * Radius * Radius; // Площадь круга
    }
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

public override double GetArea()
    {
        return Width * Height; 
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[2];

        shapes[0] = new Circle(6); // Круг
        shapes[1] = new Rectangle(4, 6); 

        for (int i = 0; i < shapes.Length; i++)
        {
            Console.WriteLine($"Площадь фигуры: {shapes[i].GetArea():F2}"); 
        }
    }
}