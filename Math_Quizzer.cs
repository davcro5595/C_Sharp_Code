//David Crouch 
//CIS 214 
//Day 2 Review Assignment 
//12/16/2020 
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
  
namespace Day2_Review 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            System.Random rnd = new System.Random(); 
  
            //declare variables 
            int num1 = rnd.Next(1, 10); 
            int num2 = rnd.Next(1, 10); 
            int selection; 
            int answer; 
            //prompt the user to make a selection 
            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Quit"); 
            Console.WriteLine("Enter an option: "); 
            //get user input 
            selection = Convert.ToInt32(Console.ReadLine()); 
  
            //loop as long as the selection is not 5 
            while( selection != 5) { 
                //Addition problem 
                if ( selection == 1) 
                { 
                    Console.WriteLine(num1 + " + " + num2); 
                    answer = Convert.ToInt32(Console.ReadLine()); 
                    //check the answer 
                    if (answer == num1 + num2) 
                    { 
                        Console.WriteLine("Correct"); 
                    } 
                    else 
                    { 
                        Console.WriteLine("Incorrect"); 
                    } 
                } 
                //Subtraction problem 
                if (selection == 2) 
                { 
                    Console.WriteLine(num1 + " - " + num2); 
                    answer = Convert.ToInt32(Console.ReadLine()); 
                    //check the answer 
                    if (answer == num1 - num2) 
                    { 
                        Console.WriteLine("Correct"); 
                    } 
                    else 
                    { 
                        Console.WriteLine("Incorrect"); 
                    } 
                } 
                // Multiplication problem 
                if (selection == 3) 
                { 
                    Console.WriteLine(num1 + " * " + num2); 
                    answer = Convert.ToInt32(Console.ReadLine()); 
                    //check the answer 
                    if (answer == num1 * num2) 
                    { 
                        Console.WriteLine("Correct"); 
                    } 
                    else 
                    { 
                        Console.WriteLine("Incorrect"); 
                    } 
                } 
                // Division problem 
                if (selection == 4) 
                { 
                    if (num1 >= num2) 
                    {//code for if num1 is larger or equal to num2 
                        Console.WriteLine(num1 + " / " + num2 + " (Provide the answer and remainder in separate prompts)"); 
                        Console.WriteLine("Answer: "); 
                        answer = Convert.ToInt32(Console.ReadLine()); 
                        //check the answer 
                        if (answer == num1 / num2) 
                        { 
                            Console.WriteLine("Remainder: "); 
                            answer = Convert.ToInt32(Console.ReadLine()); 
                            //check the remainder 
                            if (answer == num1 % num2) 
                            { 
                                Console.WriteLine("Correct"); 
                            } 
                            else 
                            { 
                                Console.WriteLine("Incorrect"); 
                            } 
                        } 
                        else 
                        { 
                            Console.WriteLine("Incorrect"); 
                        } 
                    } 
                    else 
                    {//code for if num2 is larger than num1 
                        Console.WriteLine(num2 + " / " + num1 + " (Provide the answer and remainder in separate prompts)"); 
                        Console.WriteLine("Answer: "); 
                        answer = Convert.ToInt32(Console.ReadLine()); 
                        //check the answer 
                        if (answer == num2 / num1) 
                        { 
                            Console.WriteLine("Remainder: "); 
                            answer = Convert.ToInt32(Console.ReadLine()); 
                            //check the remainder 
                            if (answer == num2 % num1) 
                            { 
                                Console.WriteLine("Correct"); 
                            } 
                            else 
                            { 
                                Console.WriteLine("Incorrect"); 
                            } 
                        } 
                        else 
                        { 
                            Console.WriteLine("Incorrect"); 
                        } 
                    } 
                } 
                //prompt the user to make a selection 
                Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Quit"); 
                Console.WriteLine("Enter an option: "); 
                //get user input 
                selection = Convert.ToInt32(Console.ReadLine()); 
            } //end while 
  
        }//end main 
    } 
} 
 
 