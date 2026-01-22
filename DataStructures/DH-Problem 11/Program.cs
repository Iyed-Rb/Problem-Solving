using System;
using System.Collections.Generic;

class Program
{
    static int Count(int[] arr)
    {
        int count = 0;
        if (arr.Length > 0) count++;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i + 1] - arr[i] == 1) 
                count++;
            else
                return count;
        }


        return count;
    }

    static void Main()
    {
        int[] arr = { 100, 4, 200, 1, 3, 2 };
        Array.Sort(arr);

        Console.WriteLine("Long Consecutive Sequence: " + Count(arr));


    }
}
