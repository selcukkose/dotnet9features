using System;
using System.Text.Json;
using ConsoleApp1.Features.Interfaces;

namespace ConsoleApp1.Features;

public class SerializationEX : IFeature
{
    public void Run()
    {
        string indentedJson = GetIndentationSettedJSON();
        Console.WriteLine($"Indentation is set : {indentedJson}");

        string webOptimizedJson = GetWebOptimizedJson();
        Console.WriteLine($"web optimized : {webOptimizedJson}");
    }

    private string GetIndentationSettedJSON()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            IndentCharacter = '\t',
            IndentSize = 2,
        };

        return JsonSerializer.Serialize(
            new { Value = 1 },
            options
        );
    }

    private string GetWebOptimizedJson()
    {
        return  JsonSerializer.Serialize(
            new { Value = 1 },
            JsonSerializerOptions.Web
        );
    }
}
