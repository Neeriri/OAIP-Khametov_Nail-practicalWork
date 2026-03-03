using System;

class Transport
{
    public string Number_Route { get; set; }
    public int Size { get; set; }
    public string Brand { get; set; }
    public int Speed { get; set; }

    public Transport(string numberRoute, int size, string brand, int speed)
    {
        Number_Route = numberRoute;
        Size = size;
        Brand = brand;
        Speed = speed;
    }

    public void Transport_Brand()
    {
        Console.WriteLine($"Бренд транспорта: {Brand}");
    }

    public void Transport_Size()
    {
        Console.WriteLine($"Размер транспорта {Brand}: {Size}");
    }

    public virtual void Transport_Speed()
    {
        Console.WriteLine($"Скорость транспорта {Brand}: {Speed} км/ч");
    }

    public virtual void Number_Route_Transport()
    {
        Console.WriteLine($"Номер маршрута транспорта: {Number_Route}");
    }
}

class Public_Transport : Transport
{
    public string Number_Public_Transport { get; set; }
    public int Public_Transport_Speed { get; set; }

    public Public_Transport(string numberRoute, int size, string brand, int speed,
                            string numberPublicTransport, int publicTransportSpeed)
        : base(numberRoute, size, brand, speed)
    {
        Number_Public_Transport = numberPublicTransport;
        Public_Transport_Speed = publicTransportSpeed;
    }

    public override void Transport_Speed()
    {
        Console.WriteLine($"Скорость общественного транспорта на маршруте {Number_Route}: {Public_Transport_Speed} км/ч");
    }

    public override void Number_Route_Transport()
    {
        Console.WriteLine($"Номер общественного транспорта: {Number_Public_Transport}, номер маршрута: {Number_Route}");
    }

    public  void Transport_Brand()
    {
        Console.WriteLine($"Бренд общественного транспорта: {Brand} ");
    }

    public  void Transport_Size()
    {
        Console.WriteLine($"Размер общественного транспорта {Brand}: {Size} ");
    }
}

class Program
{
    static void Main()
    {
        Public_Transport bus = new Public_Transport("15А", 12, "Mercedes-Benz", 80, "Т-789", 65);

        bus.Transport_Speed();
        bus.Number_Route_Transport();
        bus.Transport_Brand();
        bus.Transport_Size();

        Transport transportRef = bus;

        transportRef.Transport_Speed();
        transportRef.Number_Route_Transport();
        transportRef.Transport_Brand();
        transportRef.Transport_Size();
    }
}
