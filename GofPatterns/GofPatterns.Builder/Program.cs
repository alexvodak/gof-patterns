using GofPatterns.Builder.Implementation;
using GofPatterns.Builder.Interfaces;

namespace GofPatterns.Builder;

internal class Program
{
    static void Main(string[] args)
    {
        IBuilder builder = new CarBuilder();
        Act(builder);
        IBuilder manualBuilder = new ManualBuilder();
        Act(manualBuilder);
    }

    private static void Act(IBuilder builder)
    {
        builder.SetName("Lastochka");
        builder.SetSeats(5);
        builder.SetEngine(Models.EngineTypeEnum.Petrol);
        builder.SetTripComputer(Models.TripComputerEnum.Advanced);
        builder.SetGPS(Models.GpsEnum.Advanced);
        var result = builder.Build();
        result.Act();
    }
}
