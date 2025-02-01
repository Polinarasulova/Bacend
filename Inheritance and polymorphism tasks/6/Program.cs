using System;

public class Delivery
{
    public string Adres { get; set; }
    public decimal Price { get; set; }

    public Delivery(string adres, decimal price)
    {
        Adres = adres;
        Price = price;
    }
}

public class CourierDelivery : Delivery
{
    public CourierDelivery(string adres, decimal price) : base(adres, price)
    {
    }

    public void DeliverByCourier()
    {
        Console.WriteLine($"Доставка по адресу: {Adres} Стоимость: {Price} ");
    }
}

public class Pickup : Delivery
{
    public Pickup(string adres, decimal price) : base(adres, price)
    {
    }

    public void PickUpFromStore()
    {
        Console.WriteLine($"Самовывоз по адресу: {Adres} Стоимость: {Price} ");
    }
}

class Program
{
    static void Main(string[] args)
    {
         Delivery[] deliveries = 
        {
            new CourierDelivery("50 лет октября, дом 9", 1300),
            new Pickup(" Просвещение , дом 6", 0),
            new CourierDelivery("ВЛКСМ, дом 15", 500)
        };

        foreach (var delivery in deliveries)
        {
            if (delivery is CourierDelivery courierDelivery)
            {
                courierDelivery.DeliverByCourier();
            }
            else if (delivery is Pickup pickup)
            {
                pickup.PickUpFromStore();
            }
        }
    }
}