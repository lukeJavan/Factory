namespace Factory.Abstractions;

public interface ITransport
{
    void Deliver();
    
    string GetTransportType();
}