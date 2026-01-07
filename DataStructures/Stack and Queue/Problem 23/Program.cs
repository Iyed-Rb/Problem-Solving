using System;
using System.Collections.Generic;


class Program
{
    //static Queue<int> Clone(Queue<int> queue)
    //{
    //    //if (queue.Count == 0) return new Queue<int>();

    //    //int front = queue.Dequeue();
    //    //Queue<int> clone = CloneQueue(queue);
    //    //queue.Enqueue(front);
    //    //clone.Enqueue(front);
    //    //return clone;

    //    if (queue.Count == 0)
    //        return new Queue<int>();

    //    int front = queue.Dequeue();
    //    queue.Enqueue(front);  // restore early

    //    Queue<int> clone = Clone(queue);
    //    clone.Enqueue(front);

    //    return clone;
    //}
    public static Queue<int> CloneQueue = new Queue<int>();
    public static Queue<int> Clone(Queue<int> queue)
    {

        int Value = queue.Dequeue();
        queue.Enqueue(Value);
        CloneQueue.Enqueue(Value);

        if (CloneQueue.Count != queue.Count)
            Clone(queue);


        return CloneQueue;
    }

    static void Main()
    {
        Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4 });
        Queue<int> clonedQueue = Clone(queue);
        Console.WriteLine(string.Join(", ", clonedQueue)); // Output: 1, 2, 3, 4
        Console.WriteLine(string.Join(", ", queue)); // Output: 1, 2, 3, 4
        Console.ReadKey();

    }
}
