using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text = "hello world hello universe";
        Dictionary<string, int> wordCount = new Dictionary<string, int>();


        foreach (var word in text.Split(' '))
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        foreach (var word in wordCount)
        {
            Console.WriteLine($"{word.Key}: {word.Value}");
        }
        Console.ReadKey();

        // Output:
        // hello: 2
        // world: 1
        // universe: 1
    }
}