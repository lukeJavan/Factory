using Factory.Abstractions;
using Factory.Abstractions.Factory;

namespace Factory.ConcreteImp.Road;

public class RoadLogistics : ILogisticsFactory
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}