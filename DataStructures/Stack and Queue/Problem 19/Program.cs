using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_19
{

    class clsQueue
    {
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();

        private int _count = 0; 

        public int Count { get { return _count; } }
        public void Enqueue(int item)
        {
            stack1.Push(item);
            _count++;
        }
        
        public int Dequeue2()
        {
            if (stack2.Count == 0) 
            { while (stack1.Any()) 

                {
                    stack2.Push(stack1.Pop());
                }
            }

            return stack2.Pop();

        }
        public int Dequeue()
        {
            

            if (stack1.Count == 0)
                return -1;

            int LastItem = 0;
            int Count = stack1.Count;
            while (Count > 0)
            {
                
                if (stack1.Count == 1)
                {
                    LastItem = stack1.Pop();
                    break;
                }
                stack2.Push(stack1.Pop());
               

                Count--;
            }

            while(stack2.Count > 0)
            {
                stack1.Push(stack2.Pop());
            }
            _count = stack1.Count;

            return LastItem;
            
        }

        public int Peek()
        {

            if (stack1.Count == 0)
                return -1;

            int LastItem = 0;
            int Count = stack1.Count;
            while (Count > 0)
            {
                if (stack1.Count == 1)
                {
                    LastItem = stack1.Peek();
                }

                stack2.Push(stack1.Pop());

                Count--;
            }
            while (stack2.Count > 0)
            {
                stack1.Push(stack2.Pop());
            } 


            return LastItem;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            clsQueue queue = new clsQueue();

            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(15);

            Console.WriteLine("Count: " + queue.Count); // Expected: 3

            Console.WriteLine("Peek: " + queue.Peek());      // Expected: 5
            Console.WriteLine("Dequeue: " + queue.Dequeue()); // Expected: 5

            Console.WriteLine("Peek: " + queue.Peek());      // Expected: 10
            Console.WriteLine("Count: " + queue.Count);      // Expected: 2

            queue.Enqueue(20);
            Console.WriteLine("Peek: " + queue.Peek());      // Expected: 10

            Console.WriteLine("Dequeue: " + queue.Dequeue()); // Expected: 10
            Console.WriteLine("Dequeue: " + queue.Dequeue()); // Expected: 15
            Console.WriteLine("Dequeue: " + queue.Dequeue()); // Expected: 20
            Console.WriteLine("Dequeue: " + queue.Dequeue()); // Expected: -1

            Console.WriteLine("Count: " + queue.Count);      // Expected: 0

            Console.ReadKey();

        }
    }
}
