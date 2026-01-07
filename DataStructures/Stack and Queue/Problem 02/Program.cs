using System;
using System.Collections.Generic;

class Program
{
    static string DecimalToBinary(int number)
    {
        Stack<int> stack = new Stack<int>();

        while (number > 0)
        {
            stack.Push(number % 2);
            number /= 2;
        }

        return string.Join("", stack);
    }

    static void Main()
    {
        Console.WriteLine(DecimalToBinary(10)); // Output: 1010
        Console.ReadKey();
    }
}