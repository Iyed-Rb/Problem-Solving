using System;
using System.Collections.Generic;


class Program
{
    static Queue<int> SortQueue(Queue<int> queue)
    {
        //this will generate a list from a queue
        List<int> list = new List<int>(queue);
        list.Sort();


        // this will generate a queue from list
        return new Queue<int>(list);
    }


    static void Main()
    {
        Queue<int> queue = new Queue<int>(new[] { 5, 1, 3, 2, 4 });
        Queue<int> sortedQueue = SortQueue(queue);
        Console.WriteLine(string.Join(", ", sortedQueue)); // Output: 1, 2, 3, 4, 5


        Console.ReadKey();
    }

}