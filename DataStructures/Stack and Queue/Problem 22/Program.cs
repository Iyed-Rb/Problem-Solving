using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
           
            Queue<int> QueueEven = new Queue<int>();
            Queue<int> QueueOdd = new Queue<int>();

            while (queue.Count > 0)
            {
                int item = queue.Dequeue();

                if (item % 2 == 0)
                    QueueEven.Enqueue(item);
                else
                    QueueOdd.Enqueue(item);
            }


            Console.WriteLine("Queue Even: " + string.Join(", ", QueueEven));
            Console.WriteLine("Queue Odd: " + string.Join(", ", QueueOdd));

            while (QueueEven.Count > 0)
                queue.Enqueue(QueueEven.Dequeue());

            while (QueueOdd.Count > 0)
                queue.Enqueue(QueueOdd.Dequeue());


            Console.WriteLine("Queue After Rearranging: " + string.Join(", ", queue));

            Console.ReadKey();

        }
    }
}
