using GofPatterns.FactoryMethod.Interfaces;

namespace GofPatterns.FactoryMethod.Implementation;

public class TruckTransport : ITransport
{
    public Task DeliverAsync(IDelivery delivery)
    {
        Console.WriteLine("Delivering by truck {0}", delivery.Name);
        return Task.CompletedTask;
    }
}
