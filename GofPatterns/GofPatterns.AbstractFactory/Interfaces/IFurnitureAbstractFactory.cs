using GofPatterns.AbstractFactory.Models;

namespace GofPatterns.AbstractFactory.Interfaces;

public interface IFurnitureAbstractFactory
{
    Task<Chair> CreateChairAsync();
    Task<CoffeTable> CreateCoffeTableAsync();
    Task<Sofa> CreateSofaAsync();
}

