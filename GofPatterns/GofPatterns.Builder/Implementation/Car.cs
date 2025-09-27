using GofPatterns.Builder.Interfaces;
using GofPatterns.Builder.Models;

namespace GofPatterns.Builder.Implementation;

public class Car : ICar
{
    public string Name { get; set; }

    public int Seats { get; set; }

    public EngineTypeEnum EngineType { get; set; }

    public TripComputerEnum TripComputer { get; set; }

    public GpsEnum Gps { get; set; }

    public void Act()
    {
        Console.WriteLine("Car with name {0} with seats {1}, with engine {2}, uses trip compucter {3} and gps {4}, drives to destination",
            Name, Seats, EngineType, TripComputer, Gps);
    }
}