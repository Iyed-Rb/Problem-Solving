using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_17
{
    internal class Program
    { 

        // Other Alternative, there are a soltuion that do a list, add to it queue 1 and 2, the Sort the List
        // then Fill the Merged queue

        static void Main(string[] args)
        {
            Queue<int> queue1 = new Queue<int>();
            Queue<int> queue2 = new Queue<int>();

            queue1.Enqueue(1);
            queue1.Enqueue(2);
            queue1.Enqueue(3);

            Console.WriteLine("Queue 1 : ");
            Console.WriteLine(string.Join(", ", queue1));

            queue2.Enqueue(4);
            queue2.Enqueue(5);
            queue2.Enqueue(6);

            Console.WriteLine("Queue 2 : ");
            Console.WriteLine(string.Join(", ", queue2));


            Queue<int> queue = new Queue<int>();
            while (queue1.Count > 0 || queue2.Count > 0)
            {
                if (queue1.Count > 0 && queue2.Count > 0)
                {
                    if (queue1.Peek() < queue2.Peek())
                    {
                        queue.Enqueue(queue1.Dequeue());                    }
                    else
                    {
                        queue.Enqueue(queue2.Dequeue());
                    }
                }
                else
                {
                    if (queue1.Count > 0)
                        queue.Enqueue(queue1.Dequeue());
                    else if (queue2.Count > 0)
                    {
                        queue.Enqueue(queue2.Dequeue());
                    }
                }

            }

            Console.WriteLine("Merged Queue : ");
            Console.WriteLine(string.Join(", ", queue));

            Console.ReadKey();  
        }
    }
}
