using GofPatterns.AbstractFactory.Implementation;
using GofPatterns.AbstractFactory.Interfaces;

namespace GofPatterns.AbstractFactory;

internal class Program
{
    static async Task Main(string[] args)
    {
        IFurnitureAbstractFactory furnitureAbstractFactory = new ModernFurnitureFactory(new FurnitureFactory());
        ICollection<IFurniture> furnitures = new List<IFurniture>();
        var sofa = await furnitureAbstractFactory.CreateSofaAsync();
        furnitures.Add(sofa);
        var coffeTable = await furnitureAbstractFactory.CreateCoffeTableAsync();
        furnitures.Add(coffeTable);
        var chair = await furnitureAbstractFactory.CreateChairAsync();
        furnitures.Add(chair);
        foreach (var furniture in furnitures)
        {
            Console.WriteLine("furniture {0} style is {1}", furniture.Name, furniture.Style);
        }
        Console.ReadKey();
    }
}
