//Son un mecanismos que nos permite reutilizar codigo
using Generics;
using System.Dynamic;

var box = new Box<int>(12); // creamos una caja de tipo string, como mi clase es generica puedo crear una caja de cualquier tipo
var box2 = new Box<string>("Hola"); // creamos una caja de tipo string, mirate el constructor y lo entenderas

Console.WriteLine(box.GetContent()); // mostramos el contenido de la caja
Console.WriteLine(box2.GetContent()); // mostramos el contenido de la caja 

//tambien pueden ser usados en intefaces y metodos

//creamos las dos cervezs 
 var  beerRepository = new BeerRepository(); // creamos un repositorio de cervezas 

beerRepository.Add("Corona"); // añadimos una cerveza
beerRepository.Add("Heineken"); // añadimos otra cerveza
// posteriormente vamos a mostrar
Show<string>(beerRepository); // llamamos al metodo show y le pasamos el repositorio de cervezas, aki le pasamos el tipo de dato 
//pero tampoco es obligatior 
void Show<T>(IRepository<T> repository) // creamos un metodo generico que recibe un repositorio de cualquier tipo
{
    foreach (var item in repository.GetAll()) // recorremos todas las cervezas del repositorio
    {
        Console.WriteLine(item); // mostramos cada cerveza
    }
}

// las interfaces genericas son muy utiles para crear repositorios de datos , por que podemos hacer 
//que funcionen con diferentes tipos de datosl eso nos da una ventaja muy grande o una base de datos
// por ejemplo podemos tener un repositorio de cervezas , otro de vinos , otro de refrescos etc
// es algo muy util en la arquitectur12a de software.
// Los generics no ayudan a no tener  tantas interfaces.
// por ejemplo si no tuvieramos generics tendriamos que crear una interfaz para cada tipo de dato,

//Delegados es una forma de hacer referencia a un metodo lo podemos dar un tipo y le damos  puede func accion o func.

Operation<int> add = (x, y) => x + y; // creamos una variable de tipo delegado que suma dos enteros
Operation<double> addDouble = (a, b) => a * b; // creamos una variable de tipo delegado que multiplica dos dobles
// Podemos definir otro comportamiento
Operation<string> concat = (s1, s2) => s1 + " " + s2; // creamos una variable de tipo delegado que concatena dos cadenas

Action<IRepository<string>>  s = Show; // creamos una variable de tipo accion que llama al metodo Show

s(beerRepository); // llamamos al metodo Show por medio de la accion

Console.WriteLine(add(3, 4)); // mostramos el resultado de la suma  podemos ejecutarlo como si fuera un metodo normal  por medio de generics    
Console.WriteLine(addDouble(3.5, 2.0)); // mostramos el resultado de la multiplicacion 
Console.WriteLine(concat("Hola", "Mundo")); // mostramos el resultado de la concatenacion
delegate T     Operation<T>(T element1, T element2 ); // creamos un delegado que recibe dos enteros y devuelve un entero
