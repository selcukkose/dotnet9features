using System.Diagnostics;
using ConsoleApp1.Features.Common;
using ConsoleApp1.Features.Interfaces;

namespace ConsoleApp1.Features;

public class ParamsEx : IFeature
{
    public void Run()
    {
        var road1 = new Road { Distance = 100 };
        var road2 = new Road { Distance = 200 };
        var road3 = new Road { Distance = 300 };

        var roadOldWay = GetRoadOldWay(road1, road2, road3);
        Console.WriteLine(roadOldWay.Distance);

        var roadNewWay = GetRoadNewWay(road1, road2, road3);
        Console.WriteLine(roadNewWay.Distance);
    }
    
    private Road GetRoadNewWay(params List<Road> roads)
    {
        var road = new Road();
        foreach (var r in roads)
        {
            road.Distance += r.Distance;
        }

        return road;
    }

    private Road GetRoadOldWay(params Road[] roads)
    {
        var road = new Road();
        foreach (var r in roads)
        {
            road.Distance += r.Distance;
        }

        return road;
    }
}


