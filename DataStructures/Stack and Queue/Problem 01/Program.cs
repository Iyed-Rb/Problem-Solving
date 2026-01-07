using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

public class Navigation
{
   public class Page
   {
        public int pageNumber;
        public Page(int pageNumber)
        {
            this.pageNumber = pageNumber;
        }
   }

    static Page Current = null;
    static Stack<Page> StackBack = new Stack<Page>();
    static Stack<Page> StackForward = new Stack<Page>();

    static public int GetCurrentPage()
    {
        if (Current != null)
        return Current.pageNumber;
        else
            return -1;
    }

    static public void GoTo(Page page)
    {
        if (Current != null)
        {
            StackBack.Push(Current);
        }
        
        Current = page;
        StackForward.Clear();
    }

    static public Page Forward()
    {
        if (StackForward.Count > 0)
        {
            StackBack.Push(Current);
            Current = StackForward.Pop();
            return Current;
        }
        else
            return Current;
    }

    static public Page Back()
    {

        if (StackBack.Count > 0)
        {
            StackForward.Push(Current);
            Current = StackBack.Pop();

            return Current;
        }
        else
            return Current;
    }

}

internal class Program
{
    static void Main(string[] args)
    {
        Navigation.GoTo(new Navigation.Page(1));
        Navigation.GoTo(new Navigation.Page(2));
        Navigation.GoTo(new Navigation.Page(3));
        Navigation.GoTo(new Navigation.Page(4));


        Console.WriteLine("Current Page is: " + Navigation.GetCurrentPage());

        Navigation.Back();

        Console.WriteLine("Current Page is: " + Navigation.GetCurrentPage());

        Navigation.Back();

        Console.WriteLine("Current Page is: " + Navigation.GetCurrentPage());

        Navigation.Back();

        Console.WriteLine("Current Page is: " + Navigation.GetCurrentPage());

        Navigation.GoTo(new Navigation.Page(6));

        Console.WriteLine("Current Page is: " + Navigation.GetCurrentPage());

        Navigation.GoTo(new Navigation.Page(7));

        Console.WriteLine("Current Page is: " + Navigation.GetCurrentPage());

        Navigation.Back();

        Console.WriteLine("Current Page is: " + Navigation.GetCurrentPage());

        Navigation.Back();

        Console.WriteLine("Current Page is: " + Navigation.GetCurrentPage()); 

        Console.ReadKey();

    }
}

