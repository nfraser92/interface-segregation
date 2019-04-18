public interface IWater
{
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    double EngineVolume { get; set; }
    double MaxWaterSpeed { get; set; }
    void Start();
    void Stop();
    void Drive();
}
