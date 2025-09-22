using GofPatterns.FactoryMethod.Interfaces;

namespace GofPatterns.FactoryMethod.Implementation;

public abstract class BaseTransportFactory : ITransportFactory
{
    protected virtual IDelivery CreateDelivery()
    {
        return new Delivery
        {
            Name = Guid.NewGuid().ToString(),
        };
    }

    protected abstract ITransport CreateTransport();

    public async Task FactoryWorkAsync()
    {
        var delivery = CreateDelivery();
        var transport = CreateTransport();
        await transport.DeliverAsync(delivery);
    }
}
