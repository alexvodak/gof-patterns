using GofPatterns.AbstractFactory.Interfaces;
using GofPatterns.AbstractFactory.Models;

namespace GofPatterns.AbstractFactory.Implementation;

public class VictorianFurnitureFactory : BaseFurnitureFactory
{
    public VictorianFurnitureFactory(IFurnitureFactory factory) : base(factory, FurnitureStyle.Victorian)
    {
    }
}