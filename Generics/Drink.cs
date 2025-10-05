using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //podemos restrigir por clases  
    public class Drink
    {
        private double _quantity;
        
        public Drink(double quantity)
        {
            _quantity = quantity;
        }
         
        public  double Quantity
        { //esta funciona como una propiedad de solo lectura
            get => _quantity;
        }
    }
}
