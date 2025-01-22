using System;

public interface IMovable
{
    void Move(int speed);
}

public class Car : IMovable
{
    public void Move(int speed)
    {
        Console.WriteLine($"Машина едет со скоростью {speed} км/ч");
    }
}

public class Bird : IMovable
{
    public void Move(int speed)
    {
        Console.WriteLine($"Птица летит со скоростью {speed} км/ч");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMovable myCar = new Car();
        IMovable myBird = new Bird();

        myCar.Move(60); 
        myBird.Move(22); 
    }
}