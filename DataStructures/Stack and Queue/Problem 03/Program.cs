//Undo Operations in a Calculator
// yu can do direclty like this: 
/*
 
  static void Main()
    {
        Stack<int> calculatorStack = new Stack<int>();
        calculatorStack.Push(10);
        calculatorStack.Push(20);
        calculatorStack.Push(30);


        Console.WriteLine("Undo: " + calculatorStack.Pop()); // Output: Undo: 30
        Console.WriteLine("Current Result: " + calculatorStack.Peek()); // Output: Current Result: 20
        Console.ReadKey();
    }
 
 
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
class clsCalculator
{
    public clsCalculator()
    {
        _Result = 0;
    }

    private int _Result;
    private int _LastNumber;
    enum enOperation {Add = 1, Sub = 2, Mult = 3, Divide = 4, Back = 5 };
    enOperation _Operation;

    static Stack<int> stack = new Stack<int>();

    public string OperationString()
    {

        switch (_Operation)
        {
            case enOperation.Add:
                    return "Adding";
            case enOperation.Sub:
                return "Subtracting";
            case enOperation.Mult:
                return "Multiplying";
            case enOperation.Divide:
                return "Dividing By";
            default:
                return "";
        }
    }

    public void Undo()
    {
        _Operation = enOperation.Back;
        if (stack.Count == 0) return;
        _Result = stack.Pop();
    }
    public void Add(int Number)
    {
        _Operation = enOperation.Add;
        _LastNumber = Number;
        stack.Push(_Result);
        _Result += Number;
    }
    public void Subtract(int Number)
    {
        _Operation = enOperation.Sub;
        _LastNumber = Number;
        stack.Push(_Result);
        _Result -= Number;
    }
    public void Multiple(int Number)
    {
        _Operation = enOperation.Mult;
        _LastNumber = Number;
        stack.Push(_Result);
        _Result *= Number;
    }
    public void Divide(int Number)
    {
        _Operation = enOperation.Divide;
        _LastNumber = Number;
        stack.Push(_Result);
        _Result /= Number;
    }

    public int Result()
    {
        return _Result;
    }

    public int LastNumber()
    {
        return _LastNumber;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("=-= Welcome =-=");

        clsCalculator calculator = new clsCalculator();

        calculator.Add(10);
        Console.WriteLine("Result After " + calculator.OperationString() + " " + calculator.LastNumber() + " = " + calculator.Result());

        calculator.Subtract(3);
        Console.WriteLine("Result After " + calculator.OperationString() + " " + calculator.LastNumber() + " = " + calculator.Result());

        calculator.Multiple(2);
        Console.WriteLine("Result After " + calculator.OperationString() + " " + calculator.LastNumber() + " = " + calculator.Result());

        calculator.Divide(4);
        Console.WriteLine("Result After " + calculator.OperationString() + " " + calculator.LastNumber() + " = " + calculator.Result());

        // Test Undo
        calculator.Undo();
        Console.WriteLine("Result After Undo = " + calculator.Result());

        calculator.Undo();
        Console.WriteLine("Result After Undo = " + calculator.Result());

        calculator.Undo();
        Console.WriteLine("Result After Undo = " + calculator.Result());

        Console.ReadKey();
    }
}

