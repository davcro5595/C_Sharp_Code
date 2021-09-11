/* David Crouch  
*  CIS 317  
*  Columns
*  06/16/2021  
* */  
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
  
namespace ConsoleApplication1 
{ 
    class InitArray 
    { 
        static void Main(string[] args) 
        { 
            //initializer list specifies the value for each element 
            int[] array = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37 }; 
  
            Console.WriteLine("{0}{1,29}{2,6}", "Index", "Test Column", "Value"); //This sets up the headings for the columns. 
            //Each of these pairs of brackets represents a column.  There are 3 pairs of brackets so there will be 3 columns. 
            //The first number indicates which column index is being referred to. 
            //The column numbers must be in order; if you order them incorrectly, it will throw an error. 
            //The second number indicates at what character place the LAST character of the string will be placed. 
            //This second number does NOT necessarily indicate how many spaces will be placed between each column. 
            //If this second number does not allow for the whole string to fit, then the string will get smushed against the previous string 
            //...but the string will not get cut off 
  
            //output each array element's value 
            for (int counter = 0; counter < array.Length; ++counter) 
                Console.WriteLine("{0,5}{1,29}", counter, array[counter]); 
         }//end Main 
    }//end class InitArray 
} 