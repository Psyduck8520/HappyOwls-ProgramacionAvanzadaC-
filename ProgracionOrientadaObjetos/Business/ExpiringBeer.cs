using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProgracionOrientadaObjetos.Business
{
    public class ExpiringBeer: Beer 
    {
        // constructor de la clase derivada 
        public DateTime Expiration
        {
             get; set; 
        }
        public ExpiringBeer(string nombre, decimal price, decimal alcohol, DateTime expirationDate)
            : base(nombre, price, alcohol) // Llamada al constructor de la clase base 
        {
             this.Expiration = expirationDate; //  solo le mandamos la propiedade del hijo
        }
         
    }
}
