using System;
using System.Collections.Generic;

class Program
{
    static int FindMiddle(Queue<int> queue)
    {
        List<int> list = new List<int>(queue);
        return list[list.Count / 2];
    }


    static void Main()
    {
        Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
        Console.WriteLine(FindMiddle(queue)); // Output: 3
        Console.ReadKey();
    }
}
