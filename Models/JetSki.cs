using System;

namespace Garage {
public class JetSki : IWater
{
    public int Wheels { get; set; } = 0;
    public int Doors { get; set; } = 50;
    public int PassengerCapacity { get; set; } = 1000;
    public bool Winged { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; } = 20.0;
    public double MaxLandSpeed { get; set; }
    public double MaxAirSpeed { get; set; }

    public void Drive()
    {
        Console.WriteLine("The cruiseliner floats like a majestic beast");
    }

    public void Fly()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

}
