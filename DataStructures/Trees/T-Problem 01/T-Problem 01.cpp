#include <iostream>
#include <vector>
using namespace std;


struct Node
{
    string key;

    vector<Node*> children;

};

void AddChild(Node*& parent,string value)
{
    Node *child = new Node;
    child->key = value;
    parent->children.push_back(child);
}

void AddNode(Node*& parent, string value)
{
    parent = new Node;
    parent->key = value;
}


void PrintTree(Node* root, string s = "   ", int i = 0)
{

    if (root == nullptr)
        return;

    if (i < 2)
    cout << s << "Directory: " << root->key << "\n\n";

    if (i >=2)
    cout << s << "File: " << root->key << "\n\n";

    i++;
    for (Node* child : root->children)
    {
        PrintTree(child, s + "   ",i);
      
    }
}

int main()
{
    Node* root = nullptr;
    AddNode(root, "root");

    // Directories
    AddChild(root, "Documents");
    Node* documents = root->children.back();

    AddChild(root, "Photos");
    Node* photos = root->children.back();

    // Files in Documents
    AddChild(documents, "Resume.docx");
    AddChild(documents, "Project.pdf");

    // Files in Photos
    AddChild(photos, "Vacation.jpg");
    AddChild(photos, "Diving.jpg");
    AddChild(photos, "Family.jpg");

   
    PrintTree(root);
}

/*
#include <iostream>
#include <vector>
#include <string>
using namespace std;

// Struct representing a file or directory
struct FileNode
{
    string Name;                // Name of file or directory
    bool IsFile;                // true = file, false = directory
    vector<FileNode*> Children; // Child nodes

    // Enum used in constructor to specify type
    enum class enType
    {
        Directory,
        File
    };

    // Constructor
    FileNode(const string& name, enType type)
        : Name(name), IsFile(type == enType::File) {}
};

// Recursive print function
void PrintTree(FileNode* node, const string& indent = "")
{
    if (!node) return;

    cout << indent << (node->IsFile ? "File: " : "Directory: ")
         << node->Name << endl;

    for (FileNode* child : node->Children)
    {
        PrintTree(child, indent + "  "); // increase indentation
    }
}

int main()
{
    // Root directory
    FileNode* root = new FileNode("root", FileNode::enType::Directory);

    // Subdirectories
    FileNode* documents = new FileNode("Documents", FileNode::enType::Directory);
    FileNode* photos    = new FileNode("Photos", FileNode::enType::Directory);

    // Files in Documents
    documents->Children.push_back(new FileNode("Resume.docx", FileNode::enType::File));
    documents->Children.push_back(new FileNode("Project.pdf", FileNode::enType::File));

    // Files in Photos
    photos->Children.push_back(new FileNode("Vacation.jpg", FileNode::enType::File));
    photos->Children.push_back(new FileNode("Diving.jpg", FileNode::enType::File));
    photos->Children.push_back(new FileNode("Family.jpg", FileNode::enType::File));

    // Add subdirectories to root
    root->Children.push_back(documents);
    root->Children.push_back(photos);

    // Print the file system
    cout << "File System:\n\n";
    PrintTree(root);

    return 0;
}


*/











/*

using System;
using System.Collections.Generic;


class FileNode
{
    public string Name { get; set; } // Name of the file or directory
    public bool IsFile { get; set; } // Indicates whether this node is a file
    public List<FileNode> Children { get; set; } = new List<FileNode>(); // List of child nodes (subdirectories or files)



   public  enum enType
    {
        Directory,
        File
    }


    public FileNode(string name, enType fType )
    {
        Name = name;
        IsFile = fType == enType.File?true:false;
    }


    public void Print(string indent = "")
    {
        Console.WriteLine(indent + (IsFile ? "File: " : "Directory: ") + Name); // Print the current file/directory
        foreach (var child in Children)
        {
            child.Print(indent + "  "); // Recursively print child nodes
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Create the root directory
        var root = new FileNode("root", FileNode.enType.Directory);


        // Create subdirectories and files
        var documents = new FileNode("Documents", FileNode.enType.Directory);
        var photos = new FileNode("Photos", FileNode.enType.Directory);
        documents.Children.Add(new FileNode("Resume.docx", FileNode.enType.File));
        documents.Children.Add(new FileNode("Project.pdf", FileNode.enType.File));
        photos.Children.Add(new FileNode("Vacation.jpg", FileNode.enType.File));
        photos.Children.Add(new FileNode("Diving.jpg", FileNode.enType.File));
        photos.Children.Add(new FileNode("Family.jpg", FileNode.enType.File));


        // Add subdirectories to root
        root.Children.Add(documents);
        root.Children.Add(photos);


        // Display the file system structure
        Console.WriteLine("File System:\n");
        root.Print();


        // Pause the screen
        Console.ReadKey();
    }
}


*/