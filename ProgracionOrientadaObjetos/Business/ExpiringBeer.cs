using System;
using System.Collections.Generic;
using System.Linq;
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

                expirationDate = expirationDate;

            }
        }

}
