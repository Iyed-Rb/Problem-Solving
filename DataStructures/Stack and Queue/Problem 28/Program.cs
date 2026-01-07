using System;
using System.Collections.Generic;

class Program
{
    static int EvaluatePostfix(string expression)
    {
        Stack<int> stack = new Stack<int>();


        foreach (char c in expression)
        {
            if (char.IsDigit(c))
            {
                stack.Push(c - '0');
            }
            else
            {
                int b = stack.Pop();
                int a = stack.Pop();
                switch (c)
                {
                    case '+': stack.Push(a + b); break;
                    case '-': stack.Push(a - b); break;
                    case '*': stack.Push(a * b); break;
                    case '/': stack.Push(a / b); break;
                }
            }
        }

        return stack.Pop();
    }

    static void Main()
    {
        Console.WriteLine(EvaluatePostfix("231*+9-")); // Output: -4
        Console.ReadKey();


    }
}