namespace Factory.Abstractions.Factory;

public abstract class ILogisticsFactory
{
    public abstract ITransport CreateTransport();
}