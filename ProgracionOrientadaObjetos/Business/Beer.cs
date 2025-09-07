using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgracionOrientadaObjetos.Business
{
    public class Beer
    {
        public string Name { get; set; }
        public string Price { get; set; }

        public string GetInfo()
        {
            return $"La cerveza es {Name} y su precio es {Price} pesos";
        }
        // metodo contructor 

        public Beer(string nombre, decimal price)
        {
            Name = "Desconocida";
            Price = "0";
        }
    }
}