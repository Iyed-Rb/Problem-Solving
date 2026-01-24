using System;
using System.Collections.Generic;

class Program
{
    static int MajorityElement(int[] nums)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();

        int majorityCount = nums.Length / 2;

        foreach (int num in nums)
        {
            if (!counts.ContainsKey(num))
                counts[num] = 0;

            counts[num]++;

            if (counts[num] > majorityCount)
                return num;
        }

        return -1; // This line should not be reached in valid input
    }

    static void Main()
    {
        int[] nums = { 3, 2, 3 };
        Console.WriteLine(MajorityElement(nums)); // Output: 3
        Console.ReadKey();
    }
}