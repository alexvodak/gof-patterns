using GofPatterns.FactoryMethod.Interfaces;

namespace GofPatterns.FactoryMethod.Implementation;

public class SeaTransport : ITransport
{
    public Task DeliverAsync(IDelivery delivery)
    {
        Console.WriteLine("Delivering by sea {0}", delivery.Name);
        return Task.CompletedTask;
    }
}
