using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Both solutions correctly rearrange the queue alternately in increasing and decreasing order.
The main difference is that my version repeatedly calls .Min() and .Max() on the lists,
which scans all elements each time, making it less efficient (O(n²) time complexity).
In contrast, the mentor’s solution directly accesses elements using their indices (first and last), 
achieving the same result in linear time (O(n)). Therefore, the mentor’s version is faster, simpler, and more readable.
 
 

 */



namespace Problem_15
{



    internal class Program
    {
        static Queue<int> SortQueue(Queue<int> queue)
        {
            //this will generate a list from a queue
            List<int> list = new List<int>(queue);
            list.Sort();


            // this will generate a queue from list
            return new Queue<int>(list);
        }

        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            
            queue = SortQueue(queue);

            int middle = queue.Count / 2;

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            for (int i = 1; i <= middle; i++)
            {
                var item = queue.Dequeue();
                list1.Add(item);
            }
            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                list2 .Add(item);
                
            }

            Console.WriteLine("First Half: ");
            Console.WriteLine(string.Join(" ", list1));

            Console.WriteLine("Second Half: ");
            Console.WriteLine(string.Join(" ", list2));


            while (list1.Count > 0 || list2.Count > 0)
            {
                if (list1.Count > 0)
                {
                    var item = list1.Min();
                    list1.Remove(item);
                    queue.Enqueue(item);
                }
                
                if(list2.Count > 0)
                {
                    var item2 = list2.Max();
                    list2.Remove(item2);
                    queue.Enqueue(item2);
                }
            }

            Console.WriteLine("Final Output: ");
            Console.WriteLine(string.Join(" ", queue));

            Console.ReadKey();

        }
    }
}


/*
 
 
 using System;
using System.Collections.Generic;


class Program
{
    static Queue<int> RearrangeAlternately(Queue<int> queue)
    {
        List<int> list = new List<int>(queue);
        int n = list.Count;
        Queue<int> result = new Queue<int>();


        for (int i = 0; i < n / 2; i++)
        {
            result.Enqueue(list[i]);
            result.Enqueue(list[n - i - 1]);
        }


        if (n % 2 != 0)
        {
            result.Enqueue(list[n / 2]);
        }


        return result;
    }


    static void Main()
    {
        Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });
        Queue<int> rearrangedQueue = RearrangeAlternately(queue);
        Console.WriteLine(string.Join(", ", rearrangedQueue)); // Output: 1, 6, 2, 5, 3, 4
        Console.ReadKey();
    }
}
 

 
 */

