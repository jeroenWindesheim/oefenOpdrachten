using System;
using System.Diagnostics;
using System.Text;

List<int> iterations = new List<int>();

iterations =
[
    10_000, 20_000, 30_000, 40_000, 50_000, 60_000, 70_000, 80_000, 90_000, 100_000, 50_000_000
];
Stopwatch totalTime = new Stopwatch();
totalTime.Start();
foreach (int iteration in iterations)
{ 
    string textToAdd = "-nog een stukje geplakt";

    Console.WriteLine($"Aantal mutaties: {iteration}");
    
    
    
    // String
    // Stopwatch stringStopwatch = new Stopwatch();
    // stringStopwatch.Start();
    //
    // string langeWoorden = string.Empty;
    //
    // for (int i = 0; i < iteration; i++)
    // {
    //     langeWoorden += textToAdd;
    // }
    //
    // stringStopwatch.Stop();
    // Console.WriteLine($"String stopwatch: {stringStopwatch}");
    //
    //
    //
    // // String 2
    // Stopwatch stringStopwatch2 = new Stopwatch();
    // stringStopwatch2.Start();
    //
    // string langeWoorden2 = string.Empty;
    //
    // for (int i = 0; i < iteration; i++)
    // {
    //     langeWoorden2 = langeWoorden2 + textToAdd;
    // }
    //
    // stringStopwatch2.Stop();
    // Console.WriteLine($"String stopwatch2: {stringStopwatch2}");
    
    
    
    
    // StringBuilder

    StringBuilder s = new StringBuilder();

    Stopwatch stringBuilderStopWatch = new Stopwatch();
    stringBuilderStopWatch.Start();

    for (int i = 0; i < iteration; i++)
    {
        s.Append(textToAdd);
    }

    stringBuilderStopWatch.Stop();
    Console.WriteLine($"String Builder stopwatch: {stringBuilderStopWatch}");

    Console.WriteLine("----------------------------------------------------");
}

totalTime.Stop();
Console.WriteLine($"Total time: {totalTime}");