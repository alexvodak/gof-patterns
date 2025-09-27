using GofPatterns.Builder.Interfaces;
using GofPatterns.Builder.Models;

namespace GofPatterns.Builder.Implementation;

public class CarManual : ICar
{
    public string Name { get; set; }

    public int Seats { get; set; }

    public EngineTypeEnum EngineType { get; set; }

    public TripComputerEnum TripComputer { get; set; }

    public GpsEnum Gps { get; set; }

    public void Act()
    {
        Console.WriteLine("Manual name is {0}", Name);
        Console.WriteLine("You should install {0} of seats", Seats);
        Console.WriteLine("You should install and configure {0} engine", EngineType);
        Console.WriteLine("You should install and configure {0} trip computer before starting your trip", TripComputer);
        Console.WriteLine("{0} gps will guide you to your destination", Gps);
    }
}