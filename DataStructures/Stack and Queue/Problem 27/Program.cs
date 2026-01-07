using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_27
{
    internal class Program
    {
        static bool IsPalindrome(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
                stack.Push(c);

            foreach (char c in s)
            {
                if (stack.Pop() != c)
                    return false;
            }

            return true;
        }


        static void Main(string[] args)
        {
            string s1=  "madam";
            string s2 = "hello";

            Console.WriteLine($"{s1} is palindrome: {IsPalindrome(s1)}");
            Console.WriteLine($"{s2} is palindrome: {IsPalindrome(s2)}");

            Console.ReadKey();
        }
    }
}
