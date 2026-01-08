using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;

class Node
{
    private string Text { get; set; }  //  Maybe question or pet
    private Node? right = null;
    private Node? left = null;
    private bool IsQuestion; //if no, mean pet

    public Node(string name, bool Isquesiton)
    {
        Text = name;
        IsQuestion = Isquesiton;

    }

    public void AddChildRight(Node child)
    {
        right = child;

    }

    public void AddChildLeft(Node child)
    {
        left = child;

    }

    public void Moove()
    {
        if (IsQuestion == false)
        {
            Console.WriteLine("Your pet is a " + Text);
            return;
        }

        string choice = "";
        if (IsQuestion)
        {
            Console.WriteLine(Text);
            Console.WriteLine("Answer with yes or no:");
            choice = Console.ReadLine()?.ToLower();  
        }

        if (choice == "yes")
        {
            left.Moove();
        }
        else if(choice == "no")
        {
            right.Moove();
        }

    }
}


class Program
{
    static void Main(string[] args)
    {
        var Q1 = new Node("Q1: Do you like active pets?", true);
        var Q2 = new Node("Q2: want a big pet?", true);
        var Q3 = new Node("Q3: Want a quiet pet?", true);

        Q1.AddChildLeft(Q2);
        Q1.AddChildRight(Q3);

        var Dog = new Node("Dog", false);
        var Hamster = new Node("Hamster", false);

        Q2.AddChildLeft(Dog);
        Q2.AddChildRight(Hamster);

        var Fish = new Node("Fish", false);
        var Cat = new Node("Cat", false);

        Q3.AddChildLeft(Fish);
        Q3.AddChildRight(Cat);


        Q1.Moove();

        // Pause the screen
        Console.ReadKey();
    }
}



// Mentor Solution:
/*
 
 using System;
class DecisionNode
{
    public string Question { get; set; } // The question or recommendation stored in the node
    public DecisionNode Yes { get; set; } // Next node if the answer is "Yes"
    public DecisionNode No { get; set; } // Next node if the answer is "No"


    // Constructor to initialize a decision node with a question
    public DecisionNode(string question)
    {
        Question = question;
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Build the decision tree manually
        var root = new DecisionNode("Do you like active pets?");
        root.Yes = new DecisionNode("Do you have a lot of space?");
        root.Yes.Yes = new DecisionNode("Recommended: Dog"); // If Yes -> Yes
        root.Yes.No = new DecisionNode("Recommended: Cat");  // If Yes -> No
        root.No = new DecisionNode("Do you prefer low-maintenance pets?");
        root.No.Yes = new DecisionNode("Recommended: Fish"); // If No -> Yes
        root.No.No = new DecisionNode("Recommended: Hamster"); // If No -> No


        // Start traversal from the root node
        var currentNode = root;


        // Traverse the tree based on user input
        while (currentNode.Yes != null && currentNode.No != null)
        {
            Console.WriteLine(currentNode.Question); // Ask the current question
            string answer = Console.ReadLine().Trim().ToLower(); // Get user input ("yes" or "no")


            // Navigate to the next node based on the answer
            if (answer == "yes")
                currentNode = currentNode.Yes;
            else if (answer == "no")
                currentNode = currentNode.No;
            else
                Console.WriteLine("Please answer 'yes' or 'no'.");
        }


        // Display the recommendation (leaf node)
        Console.WriteLine(currentNode.Question);


        // Pause the screen
        Console.ReadKey();
    }
}

 
 
 
 
 
 
 
 */