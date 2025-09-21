using GofPatterns.FactoryMethod.Interfaces;

namespace GofPatterns.FactoryMethod.Implementation;

public class TruckTransportFactory : AbstractTransportFactory
{
    protected override ITransport CreateTransport()
    {
        return new TruckTransport();
    }
}