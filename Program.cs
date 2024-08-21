// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Features;
using ConsoleApp1.Features.Interfaces;

List<IFeature> featureList = [
    new ParamsEx(),
    new LockEx(),
    new SerializationEX(),
    new ImplicitIndexAccessEx(),
    new LinqEx()
];

foreach (var feature in featureList)
{
    Console.WriteLine($"\n**** {feature.GetType().Name} ****\n");
    feature.Run();
    
}

Console.ReadKey();