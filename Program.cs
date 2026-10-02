using System;

public class HelloWorld {
    public static void Main(string[] args) {
        // Prices and tax constants
            const double smallPrice = 25.0;
            const double largePrice = 35.0;
            const double taxRate = 0.06;
            const int validDays = 30;

            // Welcome Message
            Console.WriteLine("Estimate for carpet cleaning service");

            // User Inputs
            Console.Write("Number of small carpets: ");
            int smallCount = int.Parse(Console.ReadLine());

            Console.Write("Number of large carpets: ");
            int largeCount = int.Parse(Console.ReadLine());

            // Display Prices
            Console.WriteLine("Price per small carpet: $" + smallPrice);
            Console.WriteLine("Price per large carpet: $" + largePrice);

            // Calculations
            double cost = (smallCount * smallPrice) + (largeCount * largePrice);
            double tax = cost * taxRate;
            double totalEstimate = cost + tax;
  //  Display Result     
        Console.WriteLine("Cost : $" + cost);
            Console.WriteLine("Tax: $" + tax);
            Console.WriteLine("Total estimate: $" + totalEstimate);
      Console.WriteLine("This estimate is valid for " + validDays + " days");
        
    }
}

      
