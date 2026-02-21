using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
     public class Beer : Drink , Iinfo
    {
        private string _name;
        
       public string Name
            {
                get => _name;
            }
       
        public Beer(string name, double quantity) : base(quantity)
            => _name = name;

        public string GetInfo()
              =>  _name  + " tiene una cantidad de " + Quantity + " ml"; 
    }
}
