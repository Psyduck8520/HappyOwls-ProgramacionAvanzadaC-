using Generics;
using System.ComponentModel.DataAnnotations;


var box1 = new Box<int>(123); // 6. se crea una instancia de la clase Box, especificando el tipo de dato int, y se le asigna el valor 123, tengo que mandar algo de int
box1.Set(15);
Console.WriteLine(box1.GetContent()); // 7. se llama al metodo GetContent de la instancia box1, que devuelve el contenido de la caja como una cadena, en este caso "123".

var box2 = new Box<string>("Hola Mundo"); // 8. se crea otra instancia de la clase Box, especificando el tipo de dato string, y se le asigna el valor "Hola Mundo", tengo que mandar algo de string
Console.WriteLine(box2.GetContent()); // 9. se llama al metodo GetContent de la instancia box2, que devuelve el contenido de la caja como una cadena, en este caso "Hola Mundo".
var b = box2.Get(); // 14. se llama al metodo Get de la instancia box2, que devuelve el contenido de la caja como el tipo de dato original, en este caso string, y se asigna a la variable b
Console.WriteLine(b); // 15. se imprime el valor de la variable b, que es "Hola Mundo".

var box3 = new Box<bool>(true); // 10. se crea otra instancia de la clase Box, especificando el tipo de dato DateTime, y se le asigna el valor de la fecha y hora actual, tengo que mandar algo de DateTime
Console.WriteLine(box3.GetContent()); // 11. se llama al metodo GetContent de la instancia box3, que devuelve el contenido de la caja como una cadena, en este caso la fecha y hora actual

// Los generics  nos ayudan a no crear tantas interfaces

// implementar  para llamar a la funcion

var beerRepository = new BeerRepository(); // 16. se crea una instancia de la clase BeerRepository, que implementa la interfaz IRepository<string>, esto nos permite llamar a la funcion Show con esta instancia
beerRepository.Add("Delirium");
beerRepository.Add("celebrator");

Show(beerRepository); // 17. se llama a la funcion Show, pasando como argumento la instancia beerRepository, que es de tipo IRepository<string>, esto nos permite mostrar los elementos almacenados en el repositorio de cervezas, que son "Delirium" y "celebrator".
// toma la t  de la invocacion del metodo 
void  Show<T>(IRepository<T> repository) // 12. se define una funcion generica Show que recibe un parametro de tipo IRepository<T>, donde T es un tipo de dato generico, esto nos permite llamar a la funcion con cualquier tipo de dato que implemente la interfaz IRepository
{
     foreach (var item in repository.GetAll()) // 13. se itera sobre los elementos devueltos por el metodo GetAll de la interfaz IRepository, que devuelve una lista de objetos del tipo T, y se imprime cada elemento en la consola
     {
         Console.WriteLine(item);
    }
}


