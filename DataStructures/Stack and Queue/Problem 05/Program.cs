using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Initialize a queue to represent vehicles at the traffic signal
        Queue<string> trafficQueue = new Queue<string>();

        // Add vehicles to the queue
        trafficQueue.Enqueue("Car 1");
        trafficQueue.Enqueue("Truck 1");
        trafficQueue.Enqueue("Bike 1");
        trafficQueue.Enqueue("Bus 1");

        Console.WriteLine("Traffic Signal Simulation Started...\n");

        while (trafficQueue.Count > 0)
        {
            // Process the vehicle at the front of the queue
            string vehicle = trafficQueue.Dequeue();
            Console.WriteLine($"{vehicle} has passed the signal.\n");


            // Display the remaining vehicles
            if (trafficQueue.Count > 0)
            {
                Console.WriteLine("Vehicles waiting: " + string.Join(", ", trafficQueue));
            }
            else
            {
                Console.WriteLine("No vehicles waiting.");
            }


            Console.WriteLine();
        }


        Console.WriteLine("Traffic Signal Simulation Ended.");
        Console.ReadKey();
    }
}