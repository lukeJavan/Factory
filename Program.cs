
using Factory.Abstractions;
using Factory.Abstractions.Factory;
using Factory.ConcreteImp.Road;
using Factory.ConcreteImp.Sea;

namespace Factory;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a factory instance
        ILogisticsFactory roadLogisticsFactory = new RoadLogistics();

        // Create a product using the factory
        ITransport product = roadLogisticsFactory.CreateTransport();

        product.Deliver();

        Console.WriteLine($"Transport Type: {product.GetTransportType()}");


        ILogisticsFactory seaLogisticsFactory = new SeaLogistics();

        ITransport seaProduct = seaLogisticsFactory.CreateTransport();

        seaProduct.Deliver();

        Console.WriteLine($"Transport Type: {seaProduct.GetTransportType()}");
    }
}