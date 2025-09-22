using GofPatterns.AbstractFactory.Interfaces;
using GofPatterns.AbstractFactory.Models;

namespace GofPatterns.AbstractFactory.Implementation;

public abstract class BaseFurnitureFactory : IFurnitureAbstractFactory
{
    private readonly IFurnitureFactory _factory;
    private readonly FurnitureStyle _furnitureStyle;

    protected BaseFurnitureFactory(IFurnitureFactory factory, FurnitureStyle furnitureStyle)
    {
        _factory = factory;
        _furnitureStyle = furnitureStyle;
    }

    public Task<Chair> CreateChairAsync()
    {
        return Task.FromResult(_factory.CreateFurniture<Chair>(_furnitureStyle));
    }

    public Task<CoffeTable> CreateCoffeTableAsync()
    {
        return Task.FromResult(_factory.CreateFurniture<CoffeTable>(_furnitureStyle));
    }

    public Task<Sofa> CreateSofaAsync()
    {
        return Task.FromResult(_factory.CreateFurniture<Sofa>(_furnitureStyle));
    }
}


