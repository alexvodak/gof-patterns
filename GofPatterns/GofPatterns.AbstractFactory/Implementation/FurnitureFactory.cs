using GofPatterns.AbstractFactory.Interfaces;
using GofPatterns.AbstractFactory.Models;

namespace GofPatterns.AbstractFactory.Implementation;

public class FurnitureFactory : IFurnitureFactory
{
    public T CreateFurniture<T>(FurnitureStyle furnitureStyle) where T : IFurniture, new()
    {
        return new T { Style = furnitureStyle };
    }
}