using GofPatterns.AbstractFactory.Interfaces;

namespace GofPatterns.AbstractFactory.Models;

public class Sofa : FurnitureBase
{
    public FurnitureStyle Style { get; set; }
}
