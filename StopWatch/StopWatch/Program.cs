using System;
using System.Diagnostics;
using System.Threading;
class Program
{
    static void Main()
    {

        // Create new stopwatch.
        Stopwatch stopwatch = new Stopwatch();

        Console.WriteLine("Starting Time ");
        stopwatch.Start();

        // Do something.
        for (int i = 0; i < 1000; i++)
        {
            Thread.Sleep(5);
        }

        Console.WriteLine("Time stopped");
        stopwatch.Stop();

        // Write result.
        Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
    }
}