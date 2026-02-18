using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics // 1.Un generico nos permitereutilizar codigo y creamos clases que no esten fijadas a un tipo de dato
{
    public class Box <T> //  esta T es lo recomendado, convenciones son importantes en la programaciones. 
    {
        private    T _value; // 2. esta T es un tipo de dato generico, puede ser cualquier tipo de dato, int, string, etc.
        
        public Box(T value) // 3. el constructor de la clase Box recibe un parametro de tipo T, que es el valor que se va a almacenar en la caja.
        {
            _value = value; // 4. el valor se asigna a la variable _value, que es de tipo T.
        }
        public  string GetContent()  
            =>  _value.ToString(); // 5. el metodo GetContent devuelve el contenido de la caja como una cadena, utilizando el metodo ToString() del tipo T.

        //para modificar los datos 
         
         public T  Get()  => _value; // 12. el metodo Get devuelve el contenido de la caja como el tipo de dato original, en este caso T, que puede ser int, string, etc.
           
         public void Set(T value) => _value = value; // 13. el metodo Set recibe un parametro de tipo T, que es el nuevo valor que se va a almacenar en la caja, y lo asigna a la variable _value.


    }
}
