//David Crouch
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
  
namespace Account 
{ 
    class Account 
    { 
        private decimal balance; //instance variable that stores the balance 
  
        //constructor 
        public Account(decimal initialBalance) 
        { 
            Balance = initialBalance; //set balance using property 
        }//end Account constructor 
  
        //credit an amount to the account 
        public void Credit(decimal amount) 
        { 
            balance = balance + amount; //add amount to balance 
        }//end method Credit 
  
        //a property to get and set the account balance 
        public decimal Balance 
        { 
            get 
            { 
                return balance; 
            }//end get 
            set 
            { 
                //input validation 
                if (value >= 0) 
                    balance = value; 
            }//end set 
        }//end property Balance 
         
    }//end class Account 
} 
 
************************* 
 
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
  
namespace Account 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            Account account1 = new Account(50.00M); //create Account object 
            Account account2 = new Account(-7.53M); //create Account object 
  
            //display initial balance of each object using a property 
            Console.WriteLine("account1 balance: {0:C}", account1.Balance); //display Balance property 
            Console.WriteLine("account2 balance: {0:C}\n", account2.Balance); //display Balance property 
  
            decimal depositAmount; //deposit amount read from user 
  
            //prompt and obtain user input 
            Console.Write("Enter deposit amount for account1: "); 
            depositAmount = Convert.ToDecimal(Console.ReadLine()); 
            Console.WriteLine("adding {0:C} to account1 balance\n", depositAmount); 
            account1.Credit(depositAmount);//add to account 1 balance 
  
            //display balances 
            Console.WriteLine("account1 balance: {0:C}", account1.Balance); //display Balance property 
            Console.WriteLine("account2 balance: {0:C}\n", account2.Balance); //display Balance property 
  
            //prompt and obtain user input 
            Console.Write("Enter deposit amount for account2: "); 
            depositAmount = Convert.ToDecimal(Console.ReadLine()); 
            Console.WriteLine("adding {0:C} to account2 balance\n", depositAmount); 
            account2.Credit(depositAmount);//add to account 2 balance 
  
            //display balances 
            Console.WriteLine("account1 balance: {0:C}", account1.Balance); //display Balance property 
            Console.WriteLine("account2 balance: {0:C}\n", account2.Balance); //display Balance property 
  
        }//end Main 
    }//end class Program 
} 