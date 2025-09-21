using GofPatterns.FactoryMethod.Implementation;

namespace GofPatterns.FactoryMethod;

public static class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Truck factory");
        await new TruckTransportFactory().FactoryWorkAsync();
        Console.WriteLine("Sea transport factory");
        await new SeaTransportFactory().FactoryWorkAsync();
    }
}
