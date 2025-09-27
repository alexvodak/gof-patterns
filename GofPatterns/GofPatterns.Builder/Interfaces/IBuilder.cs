using GofPatterns.Builder.Models;

namespace GofPatterns.Builder.Interfaces;

interface IBuilder
{
    void SetName(string name);
    void SetSeats(int count);
    void SetEngine(EngineTypeEnum engineType);
    void SetTripComputer(TripComputerEnum tripComputer);
    void SetGPS(GpsEnum gps);
    ICar Build();
}
