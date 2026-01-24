using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> translations = new Dictionary<string, string>
        {
            { "Hello", "Hola" },
            { "World", "Mundo" },
            { "Goodbye", "Adios" }
        };

        Console.WriteLine($"Hello in Spanish: {translations["Hello"]}");
        Console.WriteLine($"Goodbye in Spanish: {translations["Goodbye"]}");
        Console.ReadKey();
        // Output:
        // Hello in Spanish: Hola
        // Goodbye in Spanish: Adiós
    }
}