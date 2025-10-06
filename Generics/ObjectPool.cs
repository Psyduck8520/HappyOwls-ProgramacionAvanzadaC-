using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ObjectPool<T> where T : new() // donde T es un nuevo objeto, esto es un contructo sin parametros
    {

        // esto va esta  restringido a que solo acepte objetos de tipo drink
        private readonly Stack<T> _objects; // pila de objetos disponibles, ultimo que entra es el primero que sale
        public int Count
        {
            get => _objects.Count; // propiedad de solo lectura que devuelve el numero de objetos disponibles en la pila
        }
        public ObjectPool(int n)
        {
            _objects = new Stack<T>(n); // inicializamos la pila con una capacidad inicial de n
            for (int i = 0; i < n; i++) // creamos n objetos y los añadimos a la pila
            {
                _objects.Push(new T()); // creamos un nuevo objeto y lo añadimos a la pila
            }
        }

        public T Get()
        {
            if (_objects.Count > 0) // si hay objetos disponibles en la pila
            {
                return _objects.Pop(); // devolvemos el ultimo objeto añadido a la pila
            }
            else
            {
                return default(T); // esti haceramos devolviendo null , si fuera entero devolvemos 0 , si fuera booleano devolvemos false, si fuera struct devolvemos un struct vacio
            }
        }
    }
}

