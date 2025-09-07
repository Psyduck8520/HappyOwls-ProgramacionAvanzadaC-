using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgracionOrientadaObjetos.Business
{
    public class Beer
    {
        private decimal _alcohol; // soin campos
        public string Name { get; set; } // Propiedades

        public string Price { get; set; }
        


        public decimal Alcohol
        {
            get { return _alcohol; } // podemos hacer una evalucion antes
            // de asignar a un atributo.
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _alcohol = value;
            }
        } // Propiedad con validacion

         public string SAlcohol
        {
            get { return $" Alcohol    {_alcohol}%"; }
        }

        public string GetInfo()
        {
            return $"La cerveza es {Name} y su precio es {Price} pesos , alcohol  {Alcohol}  ";
        }
        // metodo contructor 

        public Beer(string nombre, decimal price, decimal alcohol)
        {
            this.Name = "Desconocida";
            this.Price = "0";
            Alcohol = alcohol; // llamamos a la propiedad
        }
    }
}