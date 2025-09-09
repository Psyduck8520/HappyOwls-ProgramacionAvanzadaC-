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
        public DateTime Expiration //  esta es la nueva propiedad 
        {
             get; set; 
        }
        public ExpiringBeer(string nombre, decimal price, decimal alcohol, DateTime expirationDate)
            : base(nombre, price, alcohol) // Llamada al constructor de la clase base 
        {
             this.Expiration = expirationDate; //  solo le mandamos la propiedade del hijo
        }
        public override string GetInfo() // sobreescribimos el metodo de la clase base 
        {
            return  $"Aqui estamos llamando desde el hijo: {Expiration.ToShortDateString()}"; // llamamos al metodo de la clase base y le agregamos mas informacion 
        }

    }
}

// Protected  puedo acceder en lo hijos, privado  solo lo puedo accder en la misma clase 
// internal  puedo acceder en el mismo proyecto
// public  puedo acceder desde cualquier proyecto
// private protected  puedo acceder en los hijos y en el mismo proyecto 
///otected internal  puedo acceder en los hijos y en el mismo proyecto y en otros proyectos