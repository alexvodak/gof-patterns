using GofPatterns.FactoryMethod.Interfaces;

namespace GofPatterns.FactoryMethod.Implementation;

public abstract class BaseTransportFactoryGeneric<TDelivery, TTransport> : ITransportFactory
    where TDelivery : IDelivery, new()
    where TTransport : ITransport, new()
{
    protected virtual IDelivery CreateDelivery()
    {
        return new TDelivery
        {
            Name = Guid.NewGuid().ToString(),
        };
    }

    protected virtual ITransport CreateTransport()
    {
        return new TTransport();
    }

    public async Task FactoryWorkAsync()
    {
        var delivery = CreateDelivery();
        var transport = CreateTransport();
        await transport.DeliverAsync(delivery);
    }
}