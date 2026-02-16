using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProgracionOrientadaObjetos.Business
{
   
        public class ExpiringBeer : Beer
        {
            //Tenemos que complir con el constructor de la clase base, por lo tanto tenemos que llamar al constructor de la clase base con la palabra base y pasarle los parametros necesarios para inicializar las propiedades de la clase base.
            public DateTime ExpirationDate { get; set; } // indica   cuando  va caducar 

            public ExpiringBeer(string name, decimal price, decimal alcohol, DateTime expirationDate) :
                base(name, price, alcohol) //Estoy enviando al padre
            {

                ExpirationDate = expirationDate;
                var p = Price; // como es protected puedo acceder a el desde la clase hija, pero no puedo acceder a el desde fuera de la clase, por ejemplo desde el programa principal.
             }

        public override string GetBeerInfo() // estoy haciendo una sobre escritura, tenemos que poner un override para indicar que estamos sobre escribiendo un metodo de la clase base, el metodo debe tener la misma firma que el metodo de la clase base, es decir, el mismo nombre y los mismos parametros, en este caso el metodo GetBeerInfo no recibe parametros, esto es una caracteristica de la programacion orientada a objetos que nos permite modificar el comportamiento de un metodo heredado de la clase base, esto es una forma de polimorfismo, ya que podemos tener diferentes comportamientos para el mismo metodo dependiendo de la clase que lo implemente.
        {
            return  "Cerveza con caducidad " + Name + " cuesta " + Price + " , el alchol es " + Alcohol + " y caduca el " + ExpirationDate.ToShortDateString(); // aqui estamos modificando el comportamiento del metodo GetBeerInfo para que nos muestre la informacion de la cerveza con caducidad, esto es una forma de polimorfismo, ya que podemos tener diferentes comportamientos para el mismo metodo dependiendo de la clase que lo implemente.
        }


    }

}
