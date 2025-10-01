using System;
System.Console.WriteLine("Welcome to Our Carpet Cleaning Service ");
System.Console.WriteLine("We provide the best cleaning service with the following prices ");

const decimal smallCarpetPrice = 30m;
System.Console.WriteLine($"Small carpets: {smallCarpetPrice:C} each");

const decimal largeCarpetPrice = 35m;
System.Console.WriteLine($"Large carpets: {largeCarpetPrice:C} each");

const decimal salesTaxRate = 0.06m;
System.Console.WriteLine($"Sales Tax Rate is: {salesTaxRate:P} , This Estimates are valid for 30 days");

System.Console.WriteLine("--------------------------------------------------------------");


//inputs-----------------------------------------------------------------------------------
System.Console.Write("Please enter the number of small carpets to be cleaned: ");
int small = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Please enter the number of large carpets to be cleaned: ");
int large = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("--------------------------------------------------------------");


//calculations-----------------------------------------------------------------------------
decimal total = (small * smallCarpetPrice ) + ( large * largeCarpetPrice );
decimal tax =  total * salesTaxRate;
decimal price = total + tax;


//outputs----------------------------------------------------------------------------------
System.Console.WriteLine($"Carpets cost:{total,10:C}");
System.Console.WriteLine($"Tax: {tax,10:C}");
System.Console.WriteLine($"Total Cost:{price,10:C}");

System.Console.WriteLine("Thank you for using Islam's Carpet Cleaning Service!");
System.Console.WriteLine ("Your order has been received");