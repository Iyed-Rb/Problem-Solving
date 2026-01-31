using System;
using System.Collections.Generic;

class Program
{
    static int[] ElementsNotInSecondArray(int[] nums1, int[] nums2)
    {
        HashSet<int> set2 = new HashSet<int>(nums2);
        List<int> result = new List<int>();

        foreach (int num in nums1)
        {
            if (!set2.Contains(num))
                result.Add(num);
        }

        return result.ToArray();
    }

    static void Main()
    {
        int[] nums1 = { 1, 2, 3, 4 };
        int[] nums2 = { 3, 4, 5, 6 };
        Console.WriteLine(string.Join(", ", ElementsNotInSecondArray(nums1, nums2))); // Output: 1, 2
        Console.ReadKey();
    }
}
