
using System;
using System.Collections.Generic;

class Program
{
    static void InterleaveQueue(Queue<int> queue)
    {
        int halfSize = queue.Count / 2;
        Stack<int> stack = new Stack<int>();

        // Step 1: Remove the first half from the queue and push onto the stack.
        // Effect: stack holds the first half in reversed order.
        // Example after this loop (input [1,2,3,4,5,6]):
        //   stack (top->bottom): [3,2,1]
        //   queue: [4,5,6]
        for (int i = 0; i < halfSize; i++)
        {
            stack.Push(queue.Dequeue());
        }

        // Step 2: Pop everything from the stack and enqueue back to queue.
        // This appends the reversed first-half to the end of the queue.
        // After this:
        //   queue: [4,5,6,3,2,1]
        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());
        }

        // Step 3: Rotate the queue 'halfSize' times (dequeue then enqueue).
        // This moves the original second half to the back so that the reversed
        // first-half becomes the front of the queue.
        // After rotation (with halfSize=3):
        //   queue: [3,2,1,4,5,6]
        for (int i = 0; i < halfSize; i++)
        {
            queue.Enqueue(queue.Dequeue());
        }

        // Step 4: Push the first half (which is the reversed-first-half) onto the stack again.
        // This reverses it back to original order.
        // After this:
        //   stack (top->bottom): [1,2,3]  (original first-half, top is 1)
        //   queue: [4,5,6]               (original second-half)
        for (int i = 0; i < halfSize; i++)
        {
            stack.Push(queue.Dequeue());
        }

        // Step 5: Interleave by popping from stack (first-half element)
        // and then dequeuing from queue (second-half element), enqueue both.
        // Each iteration enqueues one element from first half then one from second half.
        // Trace example (start of this step):
        //   stack: [1,2,3]  queue: [4,5,6]
        // Iterations produce queue states eventually resulting in:
        //   final queue: [1,4,2,5,3,6]
        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());     // place next element from first half
            queue.Enqueue(queue.Dequeue()); // place next element from second half
        }
    }

    // Example usage in Main:
    // Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });
    // InterleaveQueue(queue);
    // Console.WriteLine(string.Join(", ", queue)); // prints: 1, 4, 2, 5, 3, 6



    static void Main()
    {
        Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });
        InterleaveQueue(queue);
        Console.WriteLine(string.Join(", ", queue)); // Output: 1, 4, 2, 5, 3, 6
        Console.ReadKey();
    }
}











//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Problem_15
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Queue <int> queue = new Queue <int>();  
//            queue.Enqueue(1);
//            queue.Enqueue(2);
//            queue.Enqueue(3);
//            queue.Enqueue(4);
//            queue.Enqueue(5);
//            queue.Enqueue(6);
//            queue.Enqueue(7);
//            queue.Enqueue(8);
//            queue.Enqueue(9);
//            queue.Enqueue(10);


//            int middle = queue.Count / 2;


//            Queue<int> queue1 = new Queue<int>();
//            Queue<int> queue2 = new Queue<int>();


//            for (int i = 1; i <= middle; i++)
//            {
//                queue1.Enqueue(queue.Dequeue());
//            }
//            while (queue.Count > 0)
//            {
//                queue2.Enqueue(queue.Dequeue());
//            }

//            Console.WriteLine("First Half: ");
//            Console.WriteLine(string.Join(" ", queue1));

//            Console.WriteLine("Second Half: ");
//            Console.WriteLine(string.Join(" ", queue2));


//            while (queue1.Count > 0 || queue2.Count > 0)
//            {
//                if (queue1.Count > 0)
//                queue.Enqueue(queue1.Dequeue());

//                if (queue2.Count > 0)
//                queue.Enqueue(queue2.Dequeue());
//            }

//            Console.WriteLine("Final Output: ");
//            Console.WriteLine(string.Join(" ", queue));

//            Console.ReadKey();

//        }
//    }
//}



