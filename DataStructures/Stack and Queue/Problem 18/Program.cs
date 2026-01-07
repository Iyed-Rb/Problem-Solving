using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

class Program
{
    static void FindFirstNonRepeating(string stream)
    {
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        Queue<char> queue = new Queue<char>();

        foreach(var item in stream)
        {
            if(!dictionary.ContainsKey(item))
            {
                dictionary[item] = 0;
            }
            dictionary[item]++;

            queue.Enqueue(item);

            while(queue.Count > 0 && dictionary[queue.Peek()] > 1)
            {
                queue.Dequeue();
            }

            if (queue.Count > 0)
            {
                Console.WriteLine(queue.Peek());
            }
            else
                Console.WriteLine("-");
        }

    }
    static void Main()
    {
        FindFirstNonRepeating("aabbccd");
      
        Console.ReadKey();
    }
}
