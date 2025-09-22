using GofPatterns.AbstractFactory.Interfaces;

namespace GofPatterns.AbstractFactory.Models;

public abstract class FurnitureBase : IFurniture
{
    public FurnitureStyle Style { get; set; }
    public string Name => GetType().Name;
}