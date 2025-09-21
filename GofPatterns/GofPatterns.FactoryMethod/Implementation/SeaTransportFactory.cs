using GofPatterns.FactoryMethod.Interfaces;

namespace GofPatterns.FactoryMethod.Implementation;

public class SeaTransportFactory : AbstractTransportFactory
{
    protected override ITransport CreateTransport()
    {
        return new SeaTransport();
    }
}