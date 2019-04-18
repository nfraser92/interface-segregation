using System;

namespace Garage {
    public class Car : ILand
{
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 5;
    public int PassengerCapacity { get; set; }
    public bool Winged { get; set; } = false;
    public string TransmissionType { get; set; } = "Auto";
    public double EngineVolume { get; set; } = 1.8;
    public double MaxWaterSpeed { get; set; }
    public double MaxLandSpeed { get; set; } = 155;
    public double MaxAirSpeed { get; set; }

    public void Drive()
    {
        Console.WriteLine("The Accord steams along.");
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