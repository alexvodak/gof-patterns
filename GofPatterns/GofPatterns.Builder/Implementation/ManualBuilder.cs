using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GofPatterns.Builder.Interfaces;
using GofPatterns.Builder.Models;

namespace GofPatterns.Builder.Implementation;

public class ManualBuilder : IBuilder
{
    private CarManual _car;

    public ManualBuilder()
    {
        _car = new CarManual();
    }

    public void SetName(string name)
    {
        _car.Name = string.Format("manual {0}", name);
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
