﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace csharp_and_the_strava_web_api
{
    class Program
    {
        async static Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Strava strava = new Strava("8202cc10d26b0609f892ca63291aeb36a0223a9d");
            IEnumerable<Activity> rides = await strava.GetStravaRides();

            foreach (Activity ride in rides)
            {
                Console.WriteLine($"On {ride.Date} you rode {ride.Distance} km with an average of {ride.AverageSpeed} km/h and max {ride.MaxSpeed} km/h.");
            }

            Console.ReadLine();
        }
    }
}
