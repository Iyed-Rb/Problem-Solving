using System;
using System.Collections.Generic;
using System.Linq;


class PriorityQueue
{
    private SortedDictionary<int, Queue<int>> queue = new SortedDictionary<int, Queue<int>>();


    public void Enqueue(int value, int priority)
    {
        if (!queue.ContainsKey(priority))
        {
            queue[priority] = new Queue<int>();
        }
        queue[priority].Enqueue(value);
    }


    public int? Dequeue()
    {
        if (queue.Count == 0) return null;


        int highestPriority = queue.Keys.Min();
        int value = queue[highestPriority].Dequeue();
        if (queue[highestPriority].Count == 0)
        {
            queue.Remove(highestPriority);
        }
        return value;
    }
}


class Program
{
    static void Main()
    {
        PriorityQueue pq = new PriorityQueue();
        pq.Enqueue(10, 3);
        pq.Enqueue(5, 1);
        pq.Enqueue(20, 2);
        Console.WriteLine(pq.Dequeue()); // Output: 5
        Console.ReadKey();
    }
}