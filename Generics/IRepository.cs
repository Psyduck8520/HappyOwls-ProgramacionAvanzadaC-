using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public interface IRepository<T> // interna funciona solamente el mismo ensamblado, y publico si puede ser accedida desde otros ensamblados
    {
        void Add(T model); // metodo para agregar un modelo
        IEnumerable<T> GetAll(); // metodo para obtener todos los modelos ,
        // con esto podemos crear muchas clases que tengan los mismos metodos pero con distintos tipos de datos

    }
}
