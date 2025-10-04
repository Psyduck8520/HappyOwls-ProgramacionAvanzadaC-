using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class BeerRepository : IRepository<string> // implementamos la interfaz con el tipo de dato que queremos
    {
        private string[] _beers; // creamos un array de cervezas
        private int _index; // creamos un indice para saber en que posicion estamos
        private int QUANTITY = 10; // creamos una constante para la cantidad de cervezas
        
       public BeerRepository() // constructor
        {
            _beers = new string[QUANTITY]; // inicializamos el array con la cantidad de cervezas
            _index = 0; // inicializamos el indice en 0
        }

        public void Add(string beer) // implementamos el metodo Add de la interfaz
        {
            if (_index < QUANTITY) // si el indice es menor que la cantidad de cervezas
            {
                _beers[_index++] = beer; // añadimos la cerveza en la posicion del indice
                // incrementamos el indice
            }
            else
            {
                Console.WriteLine("No se pueden agregar mas cervezas"); // si no, mostramos un mensaje de error
            }
        }

        IEnumerable<string> IRepository<string>.GetAll() => _beers; // implementamos el metodo GetAll de la interfaz

    }
}
