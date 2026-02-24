using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ObjectPool<T> where T : new() // 1. esta restriccion
                                               // nos permite crear objetos del tipo T,
                                               // pero solo si tienen un constructor sin parametros,
                                               // es decir, un constructor por defecto.
    {

        private readonly Stack<T> _objects; // 

        public int Count
        {
             get => _objects.Count;
        }

        public ObjectPool(  int n )
        {
            _objects = new Stack<T>(n);
        
            for  ( int i = 0; i < n; i++)
            {
                _objects.Push(new T()); // 2. se crea un nuevo objeto del tipo T utilizando el constructor por defecto, y se agrega a la pila de objetos disponibles en el pool.
            }

        }
         
        public T Get() // 3. se define un metodo GetObject que devuelve un objeto del tipo T, este metodo se utiliza para obtener un objeto del pool, si hay objetos disponibles en la pila, se devuelve el objeto en la parte superior de la pila, y se elimina de la pila, si no hay objetos disponibles, se lanza una excepcion.
        {
            if (Count > 0)
            {
                return _objects.Pop(); // 4. se devuelve el objeto en la parte superior de la pila utilizando el metodo Pop, y se elimina de la pila.
            }
            else
            {
                return default(T); // 5. se devuelve el valor por defecto del tipo T utilizando la palabra clave default, esto nos permite evitar lanzar una excepcion, y en su lugar devolver un valor nulo o un valor predeterminado para el tipo T, dependiendo de si T es una clase o una struct.
            }
        }

        




    }
}
