using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> dataEntries = new HashSet<string>();

        string[] entries = { "A", "B", "C", "A" }; // A is a duplicate
        foreach (var entry in entries)
        {
            if (!dataEntries.Add(entry))
            {
                Console.WriteLine($"Duplicate detected: {entry}");
            }
        }
        Console.ReadKey();

        // Output: Duplicate detected: A
    }
}