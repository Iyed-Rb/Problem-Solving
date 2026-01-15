using System;
using System.Collections.Generic;
using System.Xml.Linq;

class TreeNode
{
    public int Value { get; set; } 
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; } 


    public TreeNode(int value)
    {
        Value = value; 
    }
}


class BinaryTree
{

    public void LevelOrderMax(TreeNode root)
    {
        if (root == null) return;

        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        int level = 0;

        while (q.Count > 0)
        {
            int nodesInLevel = q.Count; // freeze the size at the start of this level
            int maxValue = int.MinValue; // track max for this level

          
            for (int i = 0; i < nodesInLevel; i++)
            {
                TreeNode current = q.Dequeue();

                // Update max for this level
                if (current.Value > maxValue)
                    maxValue = current.Value;

                // Enqueue children for the next level
                if (current.Left != null)
                    q.Enqueue(current.Left);
                if (current.Right != null)
                    q.Enqueue(current.Right);
            }

            // Print max for this level
            Console.WriteLine($"Level {level}: {maxValue}");
            level++; // move to next level
        }
    }



    // Method to print a tree (in-order traversal)
    public void PrintTree(TreeNode root, string indent = "")
    {
        if (root == null) return;


        PrintTree(root.Left, indent + "  ");
        Console.WriteLine($"{indent}{root.Value}");
        PrintTree(root.Right, indent + "  "); 
    }

}

class Program
{
    static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();

        TreeNode root = new TreeNode(1);
        root.Left = new TreeNode(2);
        root.Right = new TreeNode(3);
        root.Left.Left = new TreeNode(4);
        root.Left.Right = new TreeNode(5);
        root.Right.Left = new TreeNode(6);
        root.Right.Right = new TreeNode(7);

       
        Console.WriteLine("In-order tree print:");
        tree.PrintTree(root);

      
        Console.WriteLine("\nLevel-order traversal:");
        tree.LevelOrderMax(root);


        Console.ReadKey();
    }

}