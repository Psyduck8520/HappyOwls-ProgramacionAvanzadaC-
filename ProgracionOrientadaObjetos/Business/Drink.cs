using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgracionOrientadaObjetos.Business
{
    // una calse abstracta sirve para organizar el codigo, solo se puede heredar de ella, no se pueden crear objetos de una clase abstracta, es decir, no se pueden instanciar objetos de una clase abstracta, pero si se pueden crear clases que hereden de ella y esas clases si se pueden instanciar objetos de ellas, esto es una caracteristica de la programacion orientada a objetos que nos permite organizar el codigo y evitar la duplicacion de codigo.

    // solo nos preocupamos en que es lo que hace y no como lo hace , es decir, nos preocupamos por la interfaz y no por la implementacion, esto es una caracteristica de la programacion orientada a objetos que nos permite abstraer el codigo y evitar la duplicacion de codigo.
    // como si estuvieramos usando una libreria, y recibe y retorna  algo  y no nos importara como esta implementada la libreria, solo nos importaria que es lo que hace la libreria y como usarla, esto es una caracteristica de la programacion orientada a objetos que nos permite abstraer el codigo y evitar la duplicacion de codigo.

    // Tenemos que hacer de lo mas basico que no va cambiar,  en este caso es una cerveza es un liquido entonces  tenemo bebida
    public abstract class Drink
    {
        public int Quantity { get; set; }

        public Drink(int quantity) // constructor vacio, mismo nombre de la clase, no tiene tipo de retorno, y recibe parametros para inicializar las propiedades de la clase
        {
            this.Quantity = quantity; // puede  tener constructor  aunque no nos sirve para crear objetos , si no sirve para inicializar las propiedades de las clases que hereden de la clase abstracta Drink, esto es una caracteristica de la programacion orientada a objetos que nos permite organizar el codigo y evitar la duplicacion de codigo.

        }
         
        public string GetDrinkInfo()
        {
            return $"La bebida tiene una cantidad de {Quantity} ml";
        }
        
        public abstract string GetCategory(); // metodo abstracto, no tiene implementacion, solo tiene la firma del metodo, las clases que hereden de la clase abstracta Drink deben implementar este metodo, esto es una caracteristica de la programacion orientada a objetos que nos permite organizar el codigo y evitar la duplicacion de codigo.
        // este metodo si o si tiene que estar en las clases que las hereden de la clase abstracta Drink, y cada clase que herede de la clase abstracta Drink puede tener una implementacion diferente de este metodo, esto es una caracteristica de la programacion orientada a objetos que nos permite organizar el codigo y evitar la duplicacion de codigo.
    }
}
