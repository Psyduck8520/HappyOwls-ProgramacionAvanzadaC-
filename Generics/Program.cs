using Generics;
using System.ComponentModel.DataAnnotations;

var box1 = new Box<int>(123); // 6. se crea una instancia de la clase Box, especificando el tipo de dato int, y se le asigna el valor 123, tengo que mandar algo de int
Console.WriteLine(box1.GetContent()); // 7. se llama al metodo GetContent de la instancia box1, que devuelve el contenido de la caja como una cadena, en este caso "123".

var box2 = new Box<string>("Hola Mundo"); // 8. se crea otra instancia de la clase Box, especificando el tipo de dato string, y se le asigna el valor "Hola Mundo", tengo que mandar algo de string
Console.WriteLine(box2.GetContent()); // 9. se llama al metodo GetContent de la instancia box2, que devuelve el contenido de la caja como una cadena, en este caso "Hola Mundo".

var box3 = new Box<bool>(true); // 10. se crea otra instancia de la clase Box, especificando el tipo de dato DateTime, y se le asigna el valor de la fecha y hora actual, tengo que mandar algo de DateTime
Console.WriteLine(box3.GetContent()); // 11. se llama al metodo GetContent de la instancia box3, que devuelve el contenido de la caja como una cadena, en este caso la fecha y hora actual.
