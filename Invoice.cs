/* David Crouch  
*  CIS 214  
*  Invoice
*  01/06/2021  
* */ 
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
  
namespace Invoice 
{ 
    //The Invoice class is a template for making invoices for the hardware store 
    class Invoice 
    { 
  
        private string partNum; //the part number of the product 
        private string description; //description of the product 
        private int quantity; //quantity of the item being purchased 
        private decimal pricePerItem; //the price of the product 
  
        //Properties: 
        //property to get and set the part number 
        public string PartNum 
        { 
            get 
            { 
                return partNum; 
            }//end get  
            set 
            { 
                partNum = value; 
            }//end set  
        }//end property PartNum  
  
        //property to get and set the part description 
        public string Description 
        { 
            get 
            { 
                return description; 
            }//end get  
            set 
            { 
                description = value; 
            }//end set  
        }//end property Description  
  
        //property to get and set the quantity 
        public int Quantity 
        { 
            get 
            { 
                return quantity; 
            }//end get  
            set 
            { 
                if(value > -1) //Do not change the value if it is negative 
                    quantity = value; 
            }//end set  
        }//end property Quantity  
  
        //property to get and set the price per item 
        public decimal PricePerItem 
        { 
            get 
            { 
                return pricePerItem; 
            }//end get  
            set 
            { 
                if (value > -1) //Do not change the value if it is negative 
                    pricePerItem = value; 
            }//end set  
        }//end property PricePerItem  
  
        //class constructor takes 4 values and assigns them to the class variables 
        public Invoice(string partNum, string description, int quantity, decimal pricePerItem) 
            { 
            //set the class variables to the parameter values. 
            PartNum = partNum;  
            Description = description; 
            Quantity = quantity; 
            PricePerItem = pricePerItem; 
            } 
  
        //method for calculating the invoice amount 
        public decimal GetInvoiceAmount() 
        { 
            return quantity * pricePerItem; 
        } 
  
    }//end class Invoice 
} 