using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class DrinkShow : Ishow<Drink>
    {
        public void Show(Drink drink) // Implementacion del metodo Show de la interfaz Ishow
        => Console.WriteLine("cantidad : "  + drink +  "ml"); // Muestra la cantidad de la bebida

    }
}
