using System;
using System.Collections.Generic;

class Program
{
    static List<int> FindDuplicates(int[] nums)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        List<int> duplicates = new List<int>();


        foreach (int num in nums)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
                if (counts[num] == 2) // Add to duplicates only once
                    duplicates.Add(num);
            }
            else
            {
                counts[num] = 1;
            }
        }

        return duplicates;
    }


    static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 2, 5, 6, 1 };
        Console.WriteLine(string.Join(", ", FindDuplicates(nums))); // Output: 1, 2
        Console.ReadKey();


    }
}
