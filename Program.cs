using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage {

public class Program
{

    public static void Main()
    {

        Cessna plane = new Cessna();
        Car Accord = new Car();
        FighterJet Jet = new FighterJet();
        JetSki Floaty = new JetSki();
        Motorcycle AndreBikey = new Motorcycle();
        Boat BoatyMcBoatFace = new Boat();

        // Build a collection of all vehicles that fly
        List<IAir> FlyingThings = new List<IAir>() {
        plane, Jet
        };

        // With a single `foreach`, have each vehicle Fly()
        FlyingThings.ForEach(ft => ft.Fly());




        // Build a collection of all vehicles that operate on roads
        List<ILand> RoadVehicles = new List<ILand>() {
            AndreBikey, Accord
        };

        // With a single `foreach`, have each road vehicle Drive()
        RoadVehicles.ForEach(rv => rv.Drive());



        // Build a collection of all vehicles that operate on water
        List<IWater> WaterVehicles = new List<IWater>() {
            BoatyMcBoatFace, Floaty
        };

        // With a single `foreach`, have each water vehicle Drive()
        WaterVehicles.ForEach(wv => wv.Drive());
    }

}
}