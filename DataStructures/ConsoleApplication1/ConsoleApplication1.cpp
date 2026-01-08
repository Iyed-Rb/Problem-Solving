#include <iostream>
#include <vector>
#include <string>
using namespace std;

struct Node
{
    string Name;
    string Position;
    vector<Node*> children;
};

void CreateRoot(Node*& root, string name, string position)
{
    root = new Node;
    root->Name = name;
    root->Position = position;
}

void AddChild(Node* parent, string name, string position)
{
    if (!parent) return;

    Node* child = new Node;
    child->Name = name;
    child->Position = position;
    parent->children.push_back(child);
}

void PrintTree(Node* node, string indent = "")
{
    if (!node) return;

    cout << indent << node->Position << ": " << node->Name << endl;

    for (Node* child : node->children)
        PrintTree(child, indent + "  ");
}

void DeleteTree(Node* node)
{
    if (!node) return;

    for (Node* child : node->children)
        DeleteTree(child);

    delete node;
}

int main()
{
    Node* root = nullptr;

    CreateRoot(root, "Alice", "CEO");

    AddChild(root, "Bob", "VP of Marketing");
    AddChild(root, "Lara", "VP of Technology");

    AddChild(root->children[0], "Charlie", "Marketing Manager");
    AddChild(root->children[1], "Tom", "Architect");

    cout << "Company Hierarchy:\n\n";
    PrintTree(root);

    DeleteTree(root);
    return 0;
}



//  c#
 /*
 
 
 using System;
using System.Collections.Generic;


class EmployeeNode
{
    public string Name { get; set; } // Employee's name
    public string Position { get; set; } // Employee's position
    public List<EmployeeNode> Subordinates { get; set; } = new List<EmployeeNode>(); // List of subordinates


    public EmployeeNode(string name, string position)
    {
        Name = name;
        Position = position;
    }


    public void Print(string indent = "")
    {
        Console.WriteLine($"{indent}{Position}: {Name}"); // Print the current employee's position and name
        foreach (var subordinate in Subordinates)
        {
            subordinate.Print(indent + "  "); // Recursively print subordinates
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Create the CEO
        var ceo = new EmployeeNode("Alice", "CEO");


        // Create VP and Manager under the CEO
        var vp = new EmployeeNode("Bob", "VP of Marketing");
        var manager = new EmployeeNode("Charlie", "Marketing Manager");


        vp.Subordinates.Add(manager); // Add the manager under the VP
        ceo.Subordinates.Add(vp); // Add the VP under the CEO


         vp = new EmployeeNode("Lara", "VP of Technology");
         manager = new EmployeeNode("Tom", "Architect");


        vp.Subordinates.Add(manager); // Add the manager under the VP
        ceo.Subordinates.Add(vp); // Add the VP under the CEO




        // Display the company hierarchy
        Console.WriteLine("Company Hierarchy:");
        ceo.Print();


        // Pause the screen
        Console.ReadKey();
    }
}


 
 */