using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<char, int> CharacterFrequency(string input)
    {
        Dictionary<char, int> frequency = new Dictionary<char, int>();


        foreach (char c in input)
        {
            if (frequency.ContainsKey(c))
                frequency[c]++;
            else
                frequency[c] = 1;
        }

        return frequency;
    }

    static void Main()
    {
        string input = "hello";
        var result = CharacterFrequency(input);
        foreach (var kvp in result)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
        Console.ReadKey();

    }
}
