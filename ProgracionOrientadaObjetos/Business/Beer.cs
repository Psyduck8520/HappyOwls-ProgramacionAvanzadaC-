using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgracionOrientadaObjetos.Business
{
    public class Beer
    {
        private decimal _alcohol; // campo  con guion bajo si  es privado por convension y las propiedades son mayusculas por convension, el encapsulamiento es una de las caracteristicas de la programacion orientada a objetos, que nos permite ocultar los detalles de implementacion de una clase y exponer solo lo necesario a traves de propiedades y metodos publicos.
                                  //si es privado solo se accede dentro de la clase, si es publico se puede acceder desde fuera de la clase, si es protegido se puede acceder desde la clase y sus clases derivadas, si es interno se puede acceder desde el mismo ensamblado, si es protegido interno se puede acceder desde el mismo ensamblado y sus clases derivadas.
        public string Name { get; set; } // Las propiedades de la clase Beer, con sus respectivos getters y setters  de manera publica podemos acceder 
        public decimal Price { get; set; }

        public decimal Alcohol // propiedad con un campo privado, con un getter y setter personalizado, el encapsulamiento nos permite controlar el acceso a los datos de una clase y protegerlos de modificaciones no deseadas.
        {
            get { return _alcohol; } // getter personalizado, devuelve el valor del campo privado _alcohol
            set
            {
                if (value < 0) //  si es negativo no se permite y se asigna el valor a 0, esto es una validacion para evitar que se asignen valores no validos a la propiedad Alcohol, el encapsulamiento nos permite controlar el acceso a los datos de una clase y protegerlos de modificaciones no deseadas.
                {
                    value = 0;
                }
                _alcohol = value; // setter personalizado, asigna el valor al campo privado _alcohol
            }
        }

        public string SAlcohol
        {
            get
            {
                return "Alcohol : " + _alcohol.ToString();
            }
        }

        //constructor ss

        public Beer(string name, decimal price, decimal alcohol) // constructor vacio, mismo nombre de la clase, no tiene tipo de retorno, y recibe parametros para inicializar las propiedades de la clase
        {
            this.Name = name;
            this.Price = price;
            Alcohol = alcohol;
        }

        //  Comoportamiento ,  tiene un metodo
        public virtual string GetBeerInfo() // estoy haciendo una sobre escritura, el metodo no debe recibir parametro.
        {   
            return $"La cerveza {Name} cuesta {Price} , el alchol es {Alcohol}"; // metodo que contiene get info
        }

        public string GetBeerInnfo(string message) // estamos haciendo sobrecarga de metodos, el mismo metodo con diferente firma, en este caso el mismo metodo GetBeerInfo pero con un parametro string message, esto es una caracteristica de la programacion orientada a objetos que nos permite tener varios metodos con el mismo nombre pero con diferente firma, es decir, con diferente numero o tipo de parametros.
        {
            return message + GetBeerInfo();

        }
        public string GetBeerInnfo(int number) //  mandamos un numero 
        { 
            return number + ".-" + GetBeerInfo();
        }
    }
}


//Nota  si es private solo puedo acceder en sus clases 
// si es protected si mis hijos pueden acceder a ese campo o propiedad, como en las clases que me hereden
