using ConsoleApp1.Features.Common;
using ConsoleApp1.Features.Interfaces;

namespace ConsoleApp1.Features;

public class LinqEx : IFeature
{
    private readonly IEnumerable<Road> roads = [new Road { Distance = 500 }, new Road { Distance = 122 }, new Road { Distance = 122 }, new Road { Distance = 788 }];
    public void Run()
    {
       var countByDistance = roads.CountBy(x => x.Distance);
       foreach (var road in countByDistance)
       {
         Console.WriteLine($"Key: {road.Key}, Value: {road.Value}");
       }
    }
}
