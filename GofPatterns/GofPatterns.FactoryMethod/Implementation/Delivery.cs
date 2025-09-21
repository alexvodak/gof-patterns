using GofPatterns.FactoryMethod.Interfaces;

namespace GofPatterns.FactoryMethod.Implementation;

public record Delivery : IDelivery
{
    public string Name {  get; set; }
}
