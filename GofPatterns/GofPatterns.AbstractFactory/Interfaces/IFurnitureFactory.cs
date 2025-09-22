using GofPatterns.AbstractFactory.Models;

namespace GofPatterns.AbstractFactory.Interfaces;

public interface IFurnitureFactory
{
    T CreateFurniture<T>(FurnitureStyle furnitureStyle) where T : IFurniture, new();
}