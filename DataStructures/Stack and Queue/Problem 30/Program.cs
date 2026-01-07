
using System;
using System.Collections.Generic;

class Program
{
    static string RemoveInvalidParentheses(string s)
    {
        Stack<int> stack = new Stack<int>();
        HashSet<int> invalidIndices = new HashSet<int>();


        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
            }
            else if (s[i] == ')')
            {
                if (stack.Count == 0)
                {
                    invalidIndices.Add(i);
                }
                else
                {
                    stack.Pop();
                }
            }
        }


        while (stack.Count > 0)
        {
            invalidIndices.Add(stack.Pop());
        }


        char[] result = new char[s.Length - invalidIndices.Count];
        int index = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (!invalidIndices.Contains(i))
            {
                result[index++] = s[i];
            }
        }


        return new string(result);
    }

    static void Main()
    {
        Console.WriteLine(RemoveInvalidParentheses("(()))")); // Output: "(())" or "()"
        Console.ReadKey();
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace Problem_30
//{
//    internal class Program
//    {
//        public static void Check(string s)
//        {
//            Stack<char> stack1 = new Stack<char>();
//            Stack<char> stack2 = new Stack<char>();

//            s = s.Replace(" ", "");

//            foreach (char c in s)
//            {
//                if (c == '(')
//                    stack1.Push(c);
//                else if (c == ')')
//                    stack2.Push(c);

//            }

//            Console.WriteLine("stack1: " + string.Join(", ", stack1));
//            Console.WriteLine("stack2: " + string.Join(", ", stack2));
//            while (stack1.Count != 0 && stack2.Count != 0)
//            {
//                if (stack1.Count != 0)
//                    stack1.Pop();

//                if (stack2.Count != 0)
//                    stack2.Pop();
//            }

//            Console.WriteLine("stack1: " + string.Join(", ", stack1));
//            Console.WriteLine("stack2: " + string.Join(", ", stack2));

//            if (stack1.Count > 0)
//            {
//                Console.WriteLine("you must remove " + stack1.Count + " ( parentheses to balance the string");
//                while (stack1.Count > 0)
//                {
//                    s = s.Remove(s.LastIndexOf('('), 1);
//                    stack1.Pop();
//                }


//                Console.WriteLine("after removing , balanced string is: " + s);
//            }
//            else if (stack2.Count > 0)
//            {
//                Console.WriteLine("you must remove " + stack2.Count + " ) parentheses to balance the string");
//                while (stack2.Count > 0)
//                {
//                    s = s.Remove(s.LastIndexOf(')'), 1);
//                    stack2.Pop();
//                }

//                Console.WriteLine("---after removing---");
//                Console.WriteLine("balanced string is: " + s);
//            }
//            else
//            {
//                Console.WriteLine("the string is already balanced");
//            }

//        }

//        static void Main(string[] args)
//        {

//            string s = "())(()";
//            Console.WriteLine("string is: " + s);
//            Check(s);
//            Console.ReadKey();

//        }
//    }
//}