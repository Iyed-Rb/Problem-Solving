using System;
using System.Collections.Generic;

class Program
{
    static bool IsPalindrome(Queue<int> queue)
    {
        Stack<int> stack = new Stack<int>(queue);
        foreach (var item in queue)
        {
            if (stack.Pop() != item)
                return false;
        }
        return true;
    }


    static void Main()
    {
        Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 2, 1 });
        Console.WriteLine(IsPalindrome(queue)); // Output: True
        Console.ReadKey();
    }
}

