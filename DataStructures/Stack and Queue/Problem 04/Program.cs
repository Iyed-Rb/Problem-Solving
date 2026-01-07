using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> printerQueue = new Queue<string>();
        printerQueue.Enqueue("Document1");
        printerQueue.Enqueue("Document2");
        printerQueue.Enqueue("Document3");

        Console.WriteLine("Processing: " + printerQueue.Dequeue()); // Output: Processing: Document1
        Console.WriteLine("Next Job: " + printerQueue.Peek()); // Output: Next Job: Document2
        Console.ReadKey();
    }
}