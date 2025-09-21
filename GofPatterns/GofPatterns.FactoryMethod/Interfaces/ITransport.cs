namespace GofPatterns.FactoryMethod.Interfaces;

public interface ITransport
{
    Task DeliverAsync(IDelivery delivery);
}
