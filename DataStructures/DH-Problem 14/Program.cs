using System;
using System.Collections.Generic;

class Program
{
    static List<string> FindWords(List<string> words)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();

        List<string> list = new List<string>();

        List<char> topRow = new List<char> { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P' };
        List<char> middleRow = new List<char> { 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L' };
        List<char> bottomRow = new List<char> { 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };

        int row1 = 0;
        int row2 = 0;
        bool SameRow = true;
        char letter;
        foreach (string c in words)
        {
            
            SameRow = true;
            for (int i = 0; i < c.Length - 1; i++)
            {
                letter = char.ToUpper(c[i]);
                row1 = row2 = 0;
                if (topRow.Contains(letter)) row1 = 1;
                else if (middleRow.Contains(letter)) row1 = 2;
                else if (bottomRow.Contains(letter)) row1 = 3;

                letter = char.ToUpper(c[i + 1]);
                if (topRow.Contains(letter)) row2 = 1;
                else if (middleRow.Contains(letter)) row2 = 2;
                else if (bottomRow.Contains(letter)) row2 = 3;


                if (row1 != row2)
                {
                    SameRow = false;
                    break;
                }
            }
            if (SameRow)
            list.Add(c);
        }

        return list;
    }


    static string[] FindWords(string[] words)
    {
        string[] rows = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
        Dictionary<char, int> charRow = new Dictionary<char, int>();


        for (int i = 0; i < rows.Length; i++)
        {
            foreach (char c in rows[i])
            {
                charRow[c] = i;
            }
        }


        List<string> result = new List<string>();


        foreach (string word in words)
        {
            int row = charRow[char.ToLower(word[0])];
            bool isValid = true;


            foreach (char c in word)
            {
                if (charRow[char.ToLower(c)] != row)
                {
                    isValid = false;
                    break;
                }
            }


            if (isValid)
                result.Add(word);
        }


        return result.ToArray();
    }

    static void Main()
    {
        List<string> words = new List<string> { "Hello", "Alaska", "Dad", "Peace" };
        Console.WriteLine(string.Join(", ", FindWords(words))); // Output: "Alaska, Dad"
        Console.ReadKey();
    }
}





/*
 
 using System;
using System.Collections.Generic;


class Program
{
    static string[] FindWords(string[] words)
    {
        string[] rows = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
        Dictionary<char, int> charRow = new Dictionary<char, int>();


        for (int i = 0; i < rows.Length; i++)
        {
            foreach (char c in rows[i])
            {
                charRow[c] = i;
            }
        }


        List<string> result = new List<string>();


        foreach (string word in words)
        {
            int row = charRow[char.ToLower(word[0])];
            bool isValid = true;


            foreach (char c in word)
            {
                if (charRow[char.ToLower(c)] != row)
                {
                    isValid = false;
                    break;
                }
            }


            if (isValid)
                result.Add(word);
        }


        return result.ToArray();
    }


    static void Main()
    {
        string[] words = { "Hello", "Alaska", "Dad", "Peace" };
        Console.WriteLine(string.Join(", ", FindWords(words))); // Output: "Alaska, Dad"
        Console.ReadKey();


    }
}

 
 */