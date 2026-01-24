using System;
using System.Collections.Generic;

class Program
{
    static int Count(int[] arr)
    {
        int count = 0;
        int max = 0;
        if (arr.Length > 0)
        {
            count++;
            max = count;
        }
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i + 1] - arr[i] == 1)
                count++;
            else if (arr[i+1] != arr[i])
            {
                count = 1;
            }

            if (count > max) max = count;

        }
        return max;
    }

    static int LongestConsecutive(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;


                while (set.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }


                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }
        return longestStreak;




        //List<int> ints = new List<int> { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };

        //SortedSet<int> set = new SortedSet<int>(ints);


        //int LongestStrick = 0;
        //int CurrentStrick = 1;

        //foreach (int i in set)
        //{
        //    if (set.Contains(i + 1)) CurrentStrick++;

        //    else
        //    {
        //        if (CurrentStrick > LongestStrick) LongestStrick = CurrentStrick;

        //        CurrentStrick = 1;


        //    }
        //}

        //if (CurrentStrick > LongestStrick) LongestStrick = CurrentStrick;
    }

    static void Main()
    {
        int[] arr = { 100, 4, 200, 1, 3, 2 };
        Array.Sort(arr);
        Console.WriteLine("Long Consecutive Sequence: " + Count(arr));

        int[] nums = { 100, 4, 200, 1, 3, 2 };
        Console.WriteLine(LongestConsecutive(nums)); // Output: 4
        Console.ReadKey();

    }
}
