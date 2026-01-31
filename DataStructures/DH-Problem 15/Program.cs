using System;
using System.Collections.Generic;

class Program
{
    static int FindMissingNumber(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        int n = nums.Length;


        for (int i = 0; i <= n; i++)
        {
            if (!set.Contains(i))
                return i;
        }

        return -1;
    }

    static void Main()
    {
        int[] nums = { 3, 0, 1 };
        Console.WriteLine(FindMissingNumber(nums)); // Output: 2
        Console.ReadKey();

    }
}