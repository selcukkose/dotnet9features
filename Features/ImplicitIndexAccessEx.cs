using System;
using ConsoleApp1.Features.Interfaces;

namespace ConsoleApp1.Features;

public class ImplicitIndexAccessEx : IFeature
{
    public void Run()
    {
        var array = new int[10];
        array[^1] = 0;
        array[^2] = 1;
        array[^3] = 2;
        array[^4] = 3;
        array[^5] = 4;
        array[^6] = 5;
        array[^7] = 6;
        array[^8] = 7;
        array[^9] = 8;
        array[^10] = 9;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
