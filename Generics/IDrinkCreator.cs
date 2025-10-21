using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public interface IDrinkCreator< out T> //our para  trabajar con corvarianza , y funciona en returns
    {
         T CreateDrink(Double quantity); //este metodo crea una bebida con la cantidad especificada
    }
}
