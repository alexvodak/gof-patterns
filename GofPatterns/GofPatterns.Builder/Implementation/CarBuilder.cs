using GofPatterns.Builder.Interfaces;
using GofPatterns.Builder.Models;

namespace GofPatterns.Builder.Implementation;

public class CarBuilder : IBuilder
{
    private Car _car;

    public CarBuilder()
    {
        _car = new Car();
    }

    public void SetName(string name)
    {
        _car.Name = string.Format("Car {0}", name);
    }

    public void SetSeats(int count)
    {
        _car.Seats = count;
    }
    public void SetEngine(EngineTypeEnum engineType)
    {
        _car.EngineType = engineType;
    }
    public void SetTripComputer(TripComputerEnum tripComputer)
    {
        _car.TripComputer = tripComputer;
    }
    public void SetGPS(GpsEnum gps)
    {
        _car.Gps = gps;
    }

    public ICar Build()
    {
        return _car;
    }
}
