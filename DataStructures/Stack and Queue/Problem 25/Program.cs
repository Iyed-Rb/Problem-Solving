using System;
using System.Collections.Generic;


class ReverseString
{
    static string Reverse(string input)
    {
        Stack<char> stack = new Stack<char>();


        // Push each character onto the stack
        foreach (char c in input)
        {
            stack.Push(c);
        }


        // Pop characters to form the reversed string
        string reversed = "";
        while (stack.Count > 0)
        {
            reversed += stack.Pop();
        }


        return reversed;
    }


    static void Main()
    {
        string input = "hello";
        Console.WriteLine($"Original: {input}");
        Console.WriteLine($"Reversed: {Reverse(input)}");
        Console.ReadKey();


    }

}
