using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
class Person
{
    public string Name { get; set; }
    public List<Person> Friends { get; set; } = new List<Person>();

    public Person(string name)
    {
        Name = name;
    }

    public void AddFriend(Person friend)
    {
        Friends.Add(friend);
    }

    public void Print(string indent = "")
    {
        Console.WriteLine(indent + Name);

        foreach (var friend in Friends)
        {
            friend.Print(indent + "   ");
        }
    }
    // Recursive method to print the person's social network up to a specified depth
    public void PrintFriends(int depth, string indent = "")
    {
        if (depth == 0) return; 
        Console.WriteLine(indent + Name); 
        foreach (var friend in Friends) 
        {
            friend.PrintFriends(depth - 1, indent + "  ");
        }
    }

}



class Program
{
    static void Main(string[] args)
    {

        var Alice = new Person("Alice");
        var Bob = new Person("Bob");
        var Charlie = new Person("Charlie");
        var Dave = new Person("Dave");

        Alice.AddFriend(Bob);
        Alice.AddFriend(Charlie);

        Bob.AddFriend(Dave);


        Alice.Print();
       
        Console.ReadKey();
    }
}


