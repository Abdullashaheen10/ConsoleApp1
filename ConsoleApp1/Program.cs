using System;

class Program
{
    static void Main()
    {
        int[] prices = new int[2];
        prices[0] = 25;
        prices[1] = 35;

        double taxRate = 0.06;

        int[] carpets = new int[2];

        Console.Write("Enter number of small carpets: ");
        carpets[0] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of large carpets: ");
        carpets[1] = Convert.ToInt32(Console.ReadLine());

        int cost = (carpets[0] * prices[0]) + (carpets[1] * prices[1]);
        double tax = cost * taxRate;
        double total = cost + tax;

        Console.WriteLine();
        Console.WriteLine("Estimate for carpet cleaning service");
        Console.WriteLine("Number of small carpets: " + carpets[0]);
        Console.WriteLine("Number of large carpets: " + carpets[1]);
        Console.WriteLine("Price per small room: $" + prices[0]);
        Console.WriteLine("Price per large room: $" + prices[1]);
        Console.WriteLine("Cost: $" + cost);
        Console.WriteLine("Tax: $" + tax);
       
        Console.WriteLine("Total estimate: $" + total);
        Console.WriteLine("This estimate is valid for 30 days");
    }
}
