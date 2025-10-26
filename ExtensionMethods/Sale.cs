using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class Sale
    {
        public  decimal Amount { get; set; }
        
        public Sale(decimal amount)
            =>  Amount = amount; 
        
    }
    // Podemos realizar la extension del la clase 

}
