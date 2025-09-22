using GofPatterns.AbstractFactory.Interfaces;

namespace GofPatterns.AbstractFactory.Models;

public class CoffeTable : FurnitureBase
{
    public FurnitureStyle Style { get; set; }
}