using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgracionOrientadaObjetos.Business
{
    public class Collection<T> // clase generica
    {
        private T[] _elements; // arreglo de elementos genericos]
        private int _index; // contador de elementos
        private int _limit; // limite de elementos

        public Collection(int limit) // constructor
        {
            _limit = limit;
            _elements = new T[_limit]; // inicializamos el arreglo
            _index = 0; // inicializamos el contador
        }
        public void Add(T element) // metodo para agregar elementos
        {
            if (_index < _limit) // verificamos que no se pase del limite
            {
                _elements[_index] = element; // agregamos el elemento
                _index++; // incrementamos el contador
            }
       
        }
        public T[] Get() => _elements; // metodo para obtener los elementos

    }
}
