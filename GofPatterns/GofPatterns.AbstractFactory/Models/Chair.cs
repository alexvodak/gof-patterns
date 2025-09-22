using GofPatterns.AbstractFactory.Interfaces;

namespace GofPatterns.AbstractFactory.Models;

public class Chair : FurnitureBase
{
    public FurnitureStyle Style {  get; set; }
}
