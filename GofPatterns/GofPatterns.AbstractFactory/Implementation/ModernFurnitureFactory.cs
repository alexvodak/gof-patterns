using GofPatterns.AbstractFactory.Interfaces;
using GofPatterns.AbstractFactory.Models;

namespace GofPatterns.AbstractFactory.Implementation;

public class ModernFurnitureFactory : BaseFurnitureFactory
{
    public ModernFurnitureFactory(IFurnitureFactory factory) : base(factory, FurnitureStyle.Modern)
    {
    }
}