using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public interface IRepository<T> //nos sirve para no tener tantas  interfaces, todas
                                    //las clases que implementen esta interfaz van a tener los mismos metodos, pero con diferentes tipos de datos
    {
        void Add(T model);
        
        IEnumerable <T> GetAll(); //devuelve una lista de objetos del tipo T

    }
}
