using System;

class Program
{
    // function to take positive integer input from user and refuse negative numbers and zero and letters:=============
    static int Positiveinteger(string message)
    {
        int n;
        do
        {
            Console.WriteLine(message);
            string m = Console.ReadLine();
            if (!int.TryParse(m, out n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }
        while (n <= 0);
        return n;
    }

    static void Main()
    {
        // Welcome message and App information:==========================================================================
        Console.WriteLine("Welcome to Our Carpet Cleaning Service ");
        Console.WriteLine("We provide the best cleaning service with the following prices ");

        const decimal smallCarpetPrice = 30m;
        Console.WriteLine($"Small carpets: {smallCarpetPrice:C} each");

        const decimal largeCarpetPrice = 35m;
        Console.WriteLine($"Large carpets: {largeCarpetPrice:C} each");

        const decimal salesTaxRate = 0.06m;
        Console.WriteLine($"Sales Tax Rate is: {salesTaxRate:P} , This Estimates are valid for 30 days");

        Console.WriteLine("--------------------------------------------------------------");

        // Inputs:=======================================================================================================
        int small = Positiveinteger("Please enter the number of small carpets to be cleaned: ");
        int large = Positiveinteger("Please enter the number of large carpets to be cleaned: ");

        Console.WriteLine("--------------------------------------------------------------");

        // Calculations:=================================================================================================
        decimal total = (small * smallCarpetPrice) + (large * largeCarpetPrice);
        decimal tax = total * salesTaxRate;
        decimal price = total + tax;

        // Outputs:======================================================================================================
        Console.WriteLine("🧾 --------- Invoice ---------");
        Console.WriteLine($"Date: {DateTime.Now:dd/MM/yyyy HH:mm}");
        Console.WriteLine($"Small Carpets ({small} x {smallCarpetPrice:C}) : {(small * smallCarpetPrice):C}");
        Console.WriteLine($"Large Carpets ({large} x {largeCarpetPrice:C}) : {(large * largeCarpetPrice):C}");
        Console.WriteLine($"--------------------------------");
        Console.WriteLine($"Subtotal: {total,10:C}");
        Console.WriteLine($"Tax (6%): {tax,10:C}");
        Console.WriteLine($"Total: {price,10:C}");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("✅ Thank you for using Islam's Carpet Cleaning Service!");
        Console.WriteLine("📦 Your order has been received.");
    }
}
