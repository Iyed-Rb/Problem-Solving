using System;
using System.Collections.Generic;
using System.Numerics;

class Node
{
    public string Name { get; set; } // Directory or file name
    public List<Node> Children { get; set; } = new List<Node>(); // Subdirectories or files
    public string Permission { get; set; } = string.Empty;// File permission (e.g., "rwxr-xr-x")

    public bool IsFolder { get; set; } = true; // True if folder, false if file

    public Node(string name, bool isFolder, string permission)
    {
        Name = name;
        IsFolder = isFolder;
        Permission = permission;

    }

    public void AddChild(Node child)
    {
        if(child.Permission == "")
        {
            child.Permission = Permission;
        }

        Children.Add(child);
    }
    


}



class Program
{
    static void PrintTree(Node node, int level)
    {
        // Indent based on level
        string indent = new string(' ', level * 2);

        // Print node info
        Console.WriteLine($"{indent}{node.Name}: {node.Permission}");

        // Print children recursively
        foreach (var child in node.Children)
        {
            PrintTree(child, level + 1);
        }
    }
    static void Main(string[] args)
    {
        // 1️⃣ Create the root
        Node root = new Node("Root", true, "rwx");

        // 2️⃣ Create Folder1 and File1
        Node folder1 = new Node("Folder1", true, "rw-"); // explicit permission
        Node file1 = new Node("File1", false, "");       // empty → inherit from Folder1

        // 3️⃣ Add File1 to Folder1, then Folder1 to Root
        folder1.AddChild(file1);
        root.AddChild(folder1);

        // 4️⃣ Create Folder2 and File2
        Node folder2 = new Node("Folder2", true, "");     // empty → inherit from Root
        Node file2 = new Node("File2", false, "r--");    // explicit permission

        // 5️⃣ Add File2 to Folder2, then Folder2 to Root
        folder2.AddChild(file2);
        root.AddChild(folder2);

        // 6️⃣ Print the tree
        PrintTree(root, 0);

        // Pause the screen
        Console.ReadKey();
        Console.ReadKey();
    }
}


// Mentor Solution
/*
 
 
 using System;
using System.Collections.Generic;

class PermissionNode
{
    public string Name { get; set; } // Name of the file or folder
    public string Permissions { get; set; } // Permissions for this node (e.g., "rwx")
    public List<PermissionNode> Children { get; set; } = new List<PermissionNode>();


    public PermissionNode(string name, string permissions)
    {
        Name = name;
        Permissions = permissions; // If empty, inherits permissions from parent
    }


    // Recursive method to print permissions, applying inheritance from parent with indentation
    public void PrintPermissions(string inheritedPermissions = "", string indent = "")
    {
        // If the current node has its own permissions, use them; otherwise, inherit from the parent
        string effectivePermissions = Permissions == "" ? inheritedPermissions : Permissions;


        // Print the current node with indentation
        Console.WriteLine($"{indent}{Name}: {effectivePermissions}");


        // Recursively print permissions for child nodes with additional indentation
        foreach (var child in Children)
        {
            child.PrintPermissions(effectivePermissions, indent + "  "); // Increase indentation for children
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Build the file structure
        var root = new PermissionNode("Root", "rwx"); // Root has "rwx" permissions
        var folder1 = new PermissionNode("Folder1", "rw-"); // Folder1 has "rw-" permissions
        var folder2 = new PermissionNode("Folder2", ""); // Folder2 inherits permissions from its parent
        var file1 = new PermissionNode("File1", ""); // File1 inherits permissions from its parent
        var file2 = new PermissionNode("File2", "r--"); // File2 has "r--" permissions


        // Add children to the structure
        root.Children.Add(folder1);
        root.Children.Add(folder2);
        folder1.Children.Add(file1);
        folder2.Children.Add(file2);


        // Print the file permissions for all nodes
        Console.WriteLine("File Permissions:");
        root.PrintPermissions();


        // Pause the screen
        Console.ReadKey();
    }
}
 */