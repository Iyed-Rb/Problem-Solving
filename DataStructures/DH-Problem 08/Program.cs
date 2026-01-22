using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> candidateSkills = new HashSet<string> { "C#", "SQL", "JavaScript" };
        HashSet<string> jobRequirements = new HashSet<string> { "C#", "JavaScript", "React" };


        candidateSkills.IntersectWith(jobRequirements);


        Console.WriteLine("Matching Skills: " + string.Join(", ", candidateSkills));
        Console.ReadKey();
        // Output: Matching Skills: C#, JavaScript
    }
}
