using Factory.Abstractions;
using Factory.Abstractions.Factory;

namespace Factory.ConcreteImp.Sea;

public class SeaLogistics : ILogisticsFactory
{
    public override ITransport CreateTransport()
    {
        return new Boat();
    }
}