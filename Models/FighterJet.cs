using System;

namespace Garage {
    public class FighterJet : IAir
{
  public int Wheels { get; set; } = 3;
  public int Doors { get; set; } =1;
  public int PassengerCapacity { get; set; } = 2;
  public bool Winged { get; set; } = true;
  public string TransmissionType { get; set; } = "None";
  public double EngineVolume { get; set; } = 50.0;
  public double MaxAirSpeed { get; set; } = 700.0;

  public void Drive()
  {
    throw new NotImplementedException();
  }

  public void Fly()
  {
    Console.WriteLine("The Fighter Jet effortlessly zooms through the sky");
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