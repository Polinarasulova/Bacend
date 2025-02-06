using System;

namespace TransportExample
{
     public abstract class Transport
    {
        public int Speed { get; set; }

        public Transport(int speed)
        {
            Speed = speed;
        }

        public abstract void Move();
    }

    public class Car : Transport
    {
        public Car(int speed) : base(speed) {}

        public override void Move()
        {
            Console.WriteLine($"Еду по дороге со скоростью {Speed} км/ч.");
        }
    }

    public class Boat : Transport
    {
        public Boat(int speed) : base(speed) {}

        public override void Move()
        {
            Console.WriteLine($"Плыву по воде со скоростью {Speed} км/ч.");
        }
    }

     public class Plane : Transport
    {
        public Plane(int speed) : base(speed) {}

        public override void Move()
        {
            Console.WriteLine($"Лечу в небе со скоростью {Speed} км/ч.");
        }
    }

     public class Program
    {
        public static void Main()
        {
             Transport[] transports = 
            {
                new Car(155),
                new Boat(60),
                new Plane(1500)
            };

           foreach (Transport transport in transports)
            {
                transport.Move();
            }
        }
    }
}