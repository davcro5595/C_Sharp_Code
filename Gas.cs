//David Crouch
namespace Gas 
{ 
    class Program 
    { 
     // perform miles per gallon calculations 
     public static void Main(string[] args) 
        { 
            int miles; // miles for one tankful 
            int gallons; // gallons for one tankful 
            int totalMiles = 0; // total miles for trip 
            int totalGallons = 0; // total gallons for trip 
  
            double milesPerGallon; // miles per gallon for tankful 
            double totalMilesPerGallon; // miles per gallon for trip 
  
            // prompt user for miles and obtain the input from user 
            Console.WriteLine("Enter miles for the trip (Enter -1 to quit): "); 
            miles = Convert.ToInt32(Console.ReadLine()); 
  
            // exit if the input is -1 otherwise, proceed with the program 
            while (miles != -1) 
            { 
                // prompt user for gallons and obtain the input from user 
                Console.Write("Enter gallons: "); 
                gallons = Convert.ToInt32(Console.ReadLine()); 
  
                // add gallons and miles for this tank to totals 
                totalGallons += gallons; 
                totalMiles += miles; 
  
                // calculate miles per gallon for the current tank 
                if (gallons != 0) 
                { 
                    milesPerGallon = (double)miles / gallons; 
                    Console.WriteLine("MPG this tankful: {0:F}", 
                       milesPerGallon); 
                } // end if statement 
  
                // calculate miles per gallon for the total trip 
                if (totalGallons != 0) 
                { 
                    totalMilesPerGallon = (double)totalMiles / totalGallons; 
                    Console.WriteLine("Total MPG: {0:F}", 
                      totalMilesPerGallon); 
                } // end if statement 
  
                // prompt user for new value for miles 
                Console.Write("Enter miles (-1 to quit): "); 
                miles = Convert.ToInt32(Console.ReadLine()); 
            } // end while loop      
        } // end Main 
    } // end class Gas 
} 