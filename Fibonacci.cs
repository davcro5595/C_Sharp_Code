/* David Crouch  
*  CIS 317 
*  Performance Assessment 4.4 
*  07/12/2021  
* */ 
using System; 
using System.Collections.Generic; 
using System.ComponentModel; 
using System.Data; 
using System.Drawing; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Windows.Forms; 
using System.Diagnostics; 
  
namespace FibonacciTest 
{ 
    public partial class FibonacciForm : Form 
    { 
        //initialize variables 
        private long n1 = 0; //first Fibonacci number  
        private long n2 = 1;//second Fibonacci number  
        private int count = 1; 
  
        //create a Stopwatch to record how long teh asynchronous task takes 
        Stopwatch stopwatch = new Stopwatch(); 
  
        public FibonacciForm() 
        { 
            InitializeComponent(); 
        } 
  
        //start an async Task to calculate specified 
        private async void calculateButton_Click(object sender, EventArgs e) 
        { 
            //start stopwatch to measure time of the task 
            stopwatch.Start(); 
            //retrieve user's input as an integer  
            try 
            { 
                int number = int.Parse(inputTextBox.Text); 
                asyncResultLabel.Text = "Calculating..."; 
                //Task to perform Fibonacci calculation in separate thread  
                Task<long> fibonacciTask = Task.Run(() => Fibonacci(number)); 
  
                //wait for Task in separate thread to complete  
                await fibonacciTask; 
  
                //display result after Task in separate thread completes  
                asyncResultLabel.Text = fibonacciTask.Result.ToString(); 
                //stop the stopwatch and display the time taken to process the Fibonacci number 
                stopwatch.Stop(); 
                TimeSpan timespan = stopwatch.Elapsed; 
                asyncTimeLabel.Text = "Task completed in " + timespan; 
                //reset the stopwatch.  If not reset, it will total the time of all tasks completed instead of each individual task. 
                stopwatch.Reset(); 
            } 
            catch 
            { 
                asyncResultLabel.Text = "Invalid Input."; 
                stopwatch.Stop(); 
                stopwatch.Reset(); 
            } 
        }//end method calculateButton_Click 
  
        private void nextNumberButton_Click(object sender, EventArgs e) 
        { 
            //calculate the next Fibonacci number  
            long temp = n1 + n2;//calculate next Fibonacci number  
            n1 = n2; //store prior Fibonacci number  
            n2 = temp; //store new Fibonacci number  
            ++count; 
  
            //display the next Fibonacci number  
            displayLabel.Text = $"Fibonacci of {count}:"; 
            syncResultLabel.Text = n2.ToString(); 
        }//end method nextNumberButton_Click 
  
        //recursive method Fibonacci; calculates nth Fibonacci number  
        public long Fibonacci(long n) 
        { 
            if (n == 0 || n == 1) 
            { 
                return n; 
            } 
            else 
            { 
                return Fibonacci(n - 1) + Fibonacci(n - 2); 
            } 
        }//end method Fibonacci 
    
    }//end partial class FibonacciForm 
}//end namespace FibonacciTest 
 