using System;
using System.Collections.Generic;

class Program
{
    static int Calculate(string s)
    {
        Stack<int> stack = new Stack<int>();
        int result = 0, sign = 1, number = 0;

        foreach (char c in s)
        {
            if (char.IsDigit(c))
            {
                number = number * 10 + (c - '0');
            }
            else if (c == '+')
            {
                result += sign * number;
                number = 0;
                sign = 1;
            }
            else if (c == '-')
            {
                result += sign * number;
                number = 0;
                sign = -1;
            }
            else if (c == '(')
            {
                stack.Push(result);
                stack.Push(sign);
                result = 0;
                sign = 1;
            }
            else if (c == ')')
            {
                result += sign * number;
                number = 0;
                result *= stack.Pop();
                result += stack.Pop();
            }
        }
        result += sign * number;
        return result;
    }

    static void Main()
    {
        Console.WriteLine(Calculate("1 + (5 - 3)")); // Output: 3
        Console.ReadKey();
    }
}



//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Eventing.Reader;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web;

//namespace Problem_29
//{
//    internal class Program
//    {
//        static int Calculate(string s)
//        {
//            int total = 0;
//            int value1 = 0;
//            int value2 = 0;
//            string op = "";
//            s = s.Replace(" ", "");

//            bool FirstFound = false;
//            bool OpFound = false;   
//            foreach (char c in s)
//            {

//                if (char.IsDigit(c))
//                {
//                    if(FirstFound == false)
//                    {
//                        value1 = c - '0'; // convert char → int
//                        FirstFound = true;
//                    }
//                    else if(FirstFound)
//                        value2 = c - '0'; // convert char → int
//                }
//                else
//                {
//                    if(op.Length == 0)
//                    op += c;
//                    else if(c != op[0])
//                        op += c;

//                }
//            }
//            switch(op)
//            {
//                case "+":
//                    total = value1 + value2;
//                    break;
//                case "-":
//                    total = value1 - value2;
//                    break;
//                case "+-":
//                    total = value1 - value2;
//                    break;
//                case "-+":
//                    total = value1 - value2;
//                    break;
//                case "*":
//                    total = value1 * value2;
//                    break;
//                case "/":
//                    total = value1 / value2;
//                    break;
//            }

//            return total;
//        }

//        static void Process(string s)
//        {
//            s = s.Replace(" ", "");
//            string Priority = "";
//            string final = "";
//            Stack<int > stack = new Stack<int >();

//            foreach(var c in s)
//            {
//                if(c != '(')
//                {
//                    final += c;
//                }
//                else
//                    break;
//            }
//            Console.WriteLine("final : " + final);

//            for (int i = 0; i < s.Length; i++)
//            {
//                if (s[i] == '(')
//                {
//                    i++;
//                    while (i < s.Length && s[i] != ')')
//                    {
//                        Priority += s[i];
//                        i++;
//                    }
//                    break; // stop after closing parenthesis
//                }
//            }

//            Console.WriteLine("Priority : " + Priority);
//            var subresult = Calculate(Priority);
//            Console.WriteLine("subresult : " + subresult);
//            final += subresult.ToString();
//            Console.WriteLine("final after priority : " + final);

//            var finalresult = Calculate(final); 

//            Console.WriteLine("Final Result : " + finalresult);
//        }
//        static void Main(string[] args)
//        {
//            string s = "1 + (2 - 3)";

//            Process(s);

//            Console.ReadKey();
//        }
//    }
//}
