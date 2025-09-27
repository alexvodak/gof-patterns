using GofPatterns.Builder.Models;

namespace GofPatterns.Builder.Interfaces;

public interface ICar
{
    string Name { get; }
    int Seats { get; }
    EngineTypeEnum EngineType { get; }
    TripComputerEnum TripComputer { get; }
    GpsEnum Gps { get; }
    void Act();
}
