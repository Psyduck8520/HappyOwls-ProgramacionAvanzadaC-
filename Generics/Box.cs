using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Box <T> // ponemos una T, por convension, para indicar que es un tipo generic, son  importantes 
        //en las convenciones 

    {
        private readonly T _value; // creamos una variable privada de tipo T  no sabes que sea pero va a ser un tipo

        public Box(T  value) => _value =value; // creamos un constructor que recibe un parametro de tipo T, no se que recibe algo


       public  string GetContent() => _value.ToString(); // creamos un metodo que devuelve el contenido de la caja como string
       

    }
}
