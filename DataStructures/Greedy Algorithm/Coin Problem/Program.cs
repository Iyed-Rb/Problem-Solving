
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //// Define the coin denominations in an array.
        //int[] coins = { 1, 5, 10, 20, 50, 100 };


        // Define the coin denominations in a list.
        List<int> coins = new List<int> { 1, 5, 10, 20, 50, 100 };




        // Define the total amount for which change is needed.
        int amount = 40;


        // Call the MinCoins function to compute the minimum coins needed.
        List<int> result = MinCoins(coins, amount);


        // Output the coins used to make the total amount.
        Console.WriteLine("Coins used to form total:");
        short TotalCoins = 0;


        foreach (var coin in result)
        {
            Console.WriteLine(coin);
            TotalCoins++;
        }
        Console.WriteLine("\nTotal Given Coins = " + TotalCoins);
        // Wait for a key press before closing the console window.
        Console.ReadKey();
    }


    // Function to determine the minimum number of coins needed to make the given amount.
    static List<int> MinCoins(List<int> coins, int amount)
    {


        // Sort the list in descending order.
        coins.Sort((a, b) => b.CompareTo(a));


        // List to store the result of the coins used.
        List<int> result = new List<int>();


        // Iterate over each coin denomination starting from the largest to the smallest.
        foreach (int coin in coins)
        {
            // Keep using this coin denomination until it can no longer be used without exceeding the amount.
            while (amount >= coin)
            {
                // Reduce the amount by the denomination value.
                amount -= coin;
                // Add the coin to the result list.
                result.Add(coin);
            }
        }
        // Return the list of coins that collectively sum up to the original amount.
        return result;
    }
}



//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace w
//{
//    class HandlePapers
//    {

//        public static Dictionary<string, int> CalculatePaper(int amount)
//        {
//            Dictionary<string, int> paperDict = new Dictionary<string, int>
//            {
//                { "100", 0 }, { "50", 0 },{ "20", 0 },
//                { "10", 0 },{ "5", 0 },{ "1", 0 }
//            };

//            while (amount >= 100)
//            {
//                paperDict["100"]++;
//                amount -= 100;
//            }

//            while (amount >= 50)
//            {
//                paperDict["50"]++;
//                amount -= 50;
//            }

//            while (amount >= 20)
//            {
//                paperDict["20"]++;
//                amount -= 20;
//            }

//            while (amount >= 10)
//            {
//                paperDict["10"]++;
//                amount -= 10;
//            }

//            while (amount >= 5)
//            {
//                paperDict["5"]++;
//                amount -= 5;
//            }

//            while (amount >= 1)
//            {
//                paperDict["1"]++;
//                amount -= 1;
//            }

//            return paperDict;
//        }


//        internal class Program
//        {
//            static void Main(string[] args)
//            {

//                Console.Write("Enter Amount: ");
//                int AmountToPay = Convert.ToInt32(Console.ReadLine());

//                Console.Write("Enter Client Amount: ");
//                int clientPayment = Convert.ToInt32(Console.ReadLine());

//                int remainder = clientPayment - AmountToPay;


//                Console.WriteLine("=== You should give the client: " + remainder + " ===");

//                Dictionary<string, int> MyDictionary = null; // declare first

//                if (remainder < 0)
//                {
//                    Console.WriteLine("Client payment is not enough!");
//                }
//                else
//                {
//                    MyDictionary = HandlePapers.CalculatePaper(remainder);

//                    int totalPapers = 0;
//                    int totalValue = 0;
//                    Console.WriteLine("\n--- Breakdown of papers ---");

//                    foreach (var kvp in MyDictionary)
//                    {
//                        if (kvp.Value != 0)
//                        {
//                            int paperValue = int.Parse(kvp.Key);
//                            int subtotal = kvp.Value * paperValue;

//                            Console.WriteLine($"Paper {kvp.Key} : {kvp.Value} pcs × {paperValue} = {subtotal}");

//                            totalPapers += kvp.Value;
//                            totalValue += subtotal;
//                        }
//                    }

//                    Console.WriteLine("-----------------------------");
//                    Console.WriteLine($"Total Papers: {totalPapers}");
//                    Console.WriteLine($"Total Value : {totalValue}");
//                }


//                Console.ReadKey();
//            }
//        }
//    }
//}
