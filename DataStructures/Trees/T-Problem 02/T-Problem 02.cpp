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

void AddNode(Node*& parent, string name, string position)
{
    parent = new Node;
    parent->Name = name;
    parent->Position = position;
}

void AddChild(Node*& parent, string name, string position)
{
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
    {
        PrintTree(child, indent + "  ");
    }
}

int main()
{
    Node* root = nullptr;

    // CEO
    AddNode(root, "Alice", "CEO");

    // VP of Marketing
    AddChild(root, "Bob", "VP of Marketing");

    // VP of Technology
    AddChild(root, "Lara", "VP of Technology");

    // Marketing Manager under Bob
    AddChild(root->children[0], "Charlie", "Marketing Manager");

    // Architect under Lara
    AddChild(root->children[1], "Tom", "Architect");

    // Print hierarchy
    cout << "Company Hierarchy:\n\n";
    PrintTree(root);

    return 0;
}
