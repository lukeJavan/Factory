using Factory.Abstractions;

namespace Factory.ConcreteImp.Sea;

public class Boat : ITransport
{
    public void Deliver()
    {
        // Implementation for delivering goods by boat
        Console.WriteLine("Delivering by boat.");
    }

    public string GetTransportType()
    {
        return "Boat";
    }
}