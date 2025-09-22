using GofPatterns.AbstractFactory.Models;

namespace GofPatterns.AbstractFactory.Interfaces;

public interface IFurniture
{
    string Name { get; }
    FurnitureStyle Style { get; set; }
}