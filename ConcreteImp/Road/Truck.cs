using Factory.Abstractions;

namespace Factory.ConcreteImp.Road;

public class Truck : ITransport
{
    public void Deliver()
    {
        // Implementation for delivering goods by truck
        Console.WriteLine("Delivering by truck.");
    }

    public string GetTransportType()
    {
        return "Truck";
    }
}