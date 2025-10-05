using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Beer : Drink, IInfo
    {
        private string _name;
        // aqui vamos a poner que permita solo obtener mas no modificarlo 
        public string Name
        {
            get { return _name; }
        }
        public Beer(string name, double quantity) : base(quantity)
        => _name = name; // inicializamos el nombre y la cantidad de la cerveza

        public string GetInfo()
         => _name + " " + Quantity + "ml"; // devolvemos la informacion de la cerveza 

    } 
}
