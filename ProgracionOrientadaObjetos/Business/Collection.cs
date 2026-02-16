using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgracionOrientadaObjetos.Business
{
    public class Collection<T> // Trabajamos en codigo
    {
        private T[] _elements;
        private int _index;
        private int _limit;

        public Collection(int limit)
        {
            _index = 0;
            _limit = limit;
            _elements = new T[limit];
        }

        public void Add(T element)
        {
            if (_index < _limit)
            {
                _elements[_index] = element;
                _index++;
            }
        
        }

        public T[] Get()
            => _elements.Take(_index).ToArray(); // aqui estamos devolviendo el arreglo de elementos, esto es una forma de encapsulamiento, ya que estamos ocultando el arreglo de elementos y exponiendo solo lo necesario a traves del metodo Get, esto es una caracteristica de la programacion orientada a objetos que nos permite controlar el acceso a los datos de una clase y protegerlos de modificaciones no deseadas.
    }
}
