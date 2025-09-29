// App infonramation:----------------------------------------------------------------------
System.Console.WriteLine("Welcome to Our Carpet Cleaning Service ");
System.Console.WriteLine("We provide the best cleaning service with the following prices ");
System.Console.WriteLine("Small carpets: 30$ each");
System.Console.WriteLine("Large carpets: 35$ each");
System.Console.WriteLine("Sales Tax Rate is: 6% , This Estimates are valid for 30 days");

System.Console.WriteLine("--------------------------------------------------------------");


//inputs-----------------------------------------------------------------------------------
System.Console.Write("Please enter the number of small carpets to be cleaned: ");
decimal small = Convert.ToDecimal(Console.ReadLine());

System.Console.Write("Please enter the number of large carpets to be cleaned: ");
decimal large = Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine("--------------------------------------------------------------");


//calculations-----------------------------------------------------------------------------
decimal total = (small * 30 ) + ( large * 35 );
decimal tax = (total * 6) / 100;
decimal price = total + tax;


//outputs----------------------------------------------------------------------------------

System.Console.WriteLine($"Carpets cost:{total:C}");
System.Console.WriteLine($"Tax: {tax:C}");
System.Console.WriteLine($"Total Cost:{price:C}");

System.Console.WriteLine("Thank you for using Islam's Carpet Cleaning Service!");
System.Console.WriteLine ("Your order has been received");