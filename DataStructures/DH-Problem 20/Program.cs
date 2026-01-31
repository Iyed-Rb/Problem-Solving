using System;
using System.Collections.Generic;

class Program
{
    static public bool CheckIfPangram(string sentence)
    {
        HashSet<char> letters = new HashSet<char>();

        foreach (char c in sentence)
        {
            if (c >= 'a' && c <= 'z')
                letters.Add(c);
        }

        return letters.Count == 26;
    }

    static void Main()
    {
        string sentence = "The quick brown fox jumps over the lazy dog";
        Console.WriteLine(IsPangram(sentence)); // Output: True
        Console.ReadKey();
    }
}
