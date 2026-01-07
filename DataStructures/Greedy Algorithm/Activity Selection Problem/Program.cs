//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class Activity
//{
//    private static int counter = 0; 
//    public int Number { get; private set; }
//    public int Start { get; set; }
//    public int End { get; set; }

//    public Activity(int start, int end)
//    {
//        counter++;          
//        Number = counter;   
//        Start = start;
//        End = end;
//    }
//}

//internal class Program
//{

//    public static bool IsOverlap(Activity A1, Activity A2)
//    {
//        if (A2.Start < A1.End && A1.Start < A2.End)
//            return true;
//        else
//            return false;
//    }

//    static void Main(string[] args)
//    {

//        List<Activity> activities = new List<Activity>
//        {
//            new Activity(1, 4),
//            new Activity(3, 5),
//            new Activity(0, 6),
//            new Activity(5, 7),
//            new Activity(8, 9),
//            new Activity(5, 9),

//        };

//        activities = activities.OrderBy(a => a.End).ToList();

//        List<Activity> SelectedActivities = new List<Activity>();

//        // **** Important: ut for this specific problem (Activity Selection),
//        // the greedy choice of “always take the earliest finishing activity”
//        // is mathematically proven to lead to an optimal solution.

//        Activity Current = activities[0];
//        SelectedActivities.Add(Current);

//        for (int i = 1; i < activities.Count; i++)
//        {
//            if (!IsOverlap(Current, activities[i]))
//            {
//                SelectedActivities.Add(activities[i]);
//                Current = activities[i];
//            }
//        }


//        Console.WriteLine("Number Of Activities: " + SelectedActivities.Count);
//        foreach (Activity act in SelectedActivities)
//        {
//            Console.WriteLine("\n" + act.Number);
//        }

//        Console.ReadKey();
//    }
//}



using System;
using System.Collections.Generic;


// Definition of an Activity with start and finish times.
class Activity
{
    public int Start { get; set; }
    public int Finish { get; set; }


    // Constructor to initialize an activity.
    public Activity(int start, int finish)
    {
        Start = start;
        Finish = finish;
    }
}


class Program
{
    static void Main()
    {
        // Initialize a list of activities with start and end times.
        List<Activity> activities = new List<Activity>()
        {
            new Activity(1, 4),
            new Activity(3, 5),
            new Activity(0, 6),
            new Activity(5, 7),
            new Activity(8, 9),
            new Activity(5, 9)
        };




        Console.WriteLine("Activities List:\n");
        foreach (var activity in activities)
        {
            Console.WriteLine($"Activity({activity.Start}, {activity.Finish})");
        }




        // Call the function to select the maximum number of non-overlapping activities.
        var selectedActivities = SelectActivities(activities);
        Console.WriteLine("\nSelected activities:\n");
        foreach (var activity in selectedActivities)
        {
            Console.WriteLine($"Activity({activity.Start}, {activity.Finish})");
        }


        // Wait for a key press before closing the console window.
        Console.ReadKey();
    }


    // Function to select the maximum number of non-overlapping activities.
    static List<Activity> SelectActivities(List<Activity> activities)
    {
        // Sort activities based on their finish times.
        activities.Sort((a, b) => a.Finish.CompareTo(b.Finish));
        List<Activity> result = new List<Activity>();


        // Variable to keep track of the last selected activity.
        Activity lastSelectedActivity = null;


        // Iterate through the sorted list of activities.
        foreach (var activity in activities)
        {
            // If no activity has been selected or the current activity starts after the last selected activity finishes.
            if (lastSelectedActivity == null || activity.Start >= lastSelectedActivity.Finish)
            {
                // Add the current activity to the result as it does not overlap.
                result.Add(activity);
                // Update the last selected activity to the current one.
                lastSelectedActivity = activity;
            }
        }
        return result;
    }
}

