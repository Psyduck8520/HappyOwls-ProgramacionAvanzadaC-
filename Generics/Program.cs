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

void ShowQuntity<T>(T drink) where T : Drink // con where  decimos  que es  justo  del tipo  T
{
    Console.WriteLine(drink.Quantity);
}

void showInfo<T>(T element) where T : Iinfo
{
    Console.WriteLine($"La bebida tiene una cantidad de {element.GetInfo()}");
}



var Drink = new Drink(500);
var beer = new Beer( "Erdinger",300);


ShowQuntity(Drink); // 14. se crea una instancia de la clase Drink, especificando el valor 500 para la propiedad Quantity, y se llama a la funcion ShowQuantity, pasando como argumento esta instancia, esto nos permite mostrar la cantidad de bebida almacenada en la instancia de Drink, que es 500.
ShowQuntity(beer); // 15. se crea una instancia de la clase Beer, especificando el nombre "Erdinger" y la cantidad 300 para las propiedades Name y Quantity respectivamente, y se llama a la funcion ShowQuantity, pasando como argumento esta instancia, esto nos permite mostrar la cantidad de bebida almacenada en la instancia de Beer, que es 300.
showInfo(beer); // 16. se llama a la funcion showInfo, pasando como argumento la instancia Drink, esto nos permite mostrar la informacion de la bebida almacenada en la instancia de Drink, que es 500.
// De esta manera tenemos tipado de manera restringida los generics. 


// Agregamos un delegado a una fucion 
Action< IRepository<string> > s = Show;
//Guardo la funcion dentro de mi variable
s(beerRepository);



Operation<int> add = (x, y) => x + y; // 19. se crea una instancia del delegado Operation, especificando el tipo de dato int, y se le asigna una expresion lambda que recibe dos parametros x e y, y devuelve la suma de ambos, esto nos permite crear una operacion matematica generica de suma para enteros.
// delegados hacer una referencia a un metodo hay delegados que son predefinidos  como Action, Func, Predicate, etc. pero tambien podemos crear nuestros propios delegados, y estos pueden ser genericos, por ejemplo:
Operation<double> addDouble = (s1, s2) => s1 + s2; // 20. se crea
//Operation<string> concatenate = (a , b) => a + "" + b ;                                                      // otra instancia del delegado Operation, especificando el tipo de dato string, y se le asigna una expresion lambda que recibe dos parametros s1 y s2, y devuelve la concatenacion de ambos, esto nos permite crear una operacion matematica generica de concatenacion para cadenas.
Console.WriteLine(add(5, 10)); // 20. se llama al delegado add, pasando como argumentos los valores 5 y 10, esto nos permite ejecutar la operacion de suma definida en el delegado, y se imprime el resultado en la consola, que es 15.
Console.WriteLine(addDouble(3.5, 2.5)); // 21. se llama al delegado addDouble, pasando como argumentos los valores 3.5 y 2.5, esto nos permite ejecutar la operacion de suma definida en el delegado, y se imprime el resultado en la consola, que es 6.0.
delegate T Operation<T>(T  element1, T  element2) where T : struct  ; // 18. se define un delegado generico Operation que recibe dos parametros de tipo T y devuelve un int, esto nos permite crear operaciones matematicas genericas, como suma, resta, multiplicacion, etc.

//Restricciones de TIPO
// 1. EL INT es un struc , string es una clase.
//2. Struct  cuando lo pasamos por parametro  lo que  se haga dentro de esa funcion no se modifica el original, porque se pasa por valor, mientras que las clases se pasan por referencia, lo que se haga dentro de esa funcion si se modifica el original, porque se pasa por referencia.

//Objetos se guarada en referencia,  