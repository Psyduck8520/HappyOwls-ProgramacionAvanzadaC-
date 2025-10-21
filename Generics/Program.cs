//Son un mecanismos que nos permite reutilizar codigo
using Generics;
using System.Dynamic;
var box = new Box<int>(12); // creamos una caja de tipo string, como mi clase es generica puedo crear una caja de cualquier tipo
var box2 = new Box<string>("Hola"); // creamos una caja de tipo string, mirate el constructor y lo entenderas

//Console.WriteLine(box.GetContent()); // mostramos el contenido de la caja
//Console.WriteLine(box2.GetContent()); // mostramos el contenido de la caja 

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

//aqui vamos a crear otra función pra restringir otro generic para que sea solo de la clase drink

void ShowQuantity<T>(T drink) where T : Drink // creamos un metodo generico que recibe un repositorio de cualquier tipo
{
    Console.WriteLine(drink.Quantity);// mostramos cada cerveza.  sabe que existe 

}

var drink  = new Drink(550); // creamos una bebida
ShowQuantity(drink); // llamamos al metodo show y le pasamos el repositorio de cervezas, aki le pasamos el tipo de dato

var drink2 = new Beer( "Corona",330); // creamos una bebida

ShowQuantity(drink2); // llamamos al metodo show y le pasamos el repositorio de cervezas, aki le pasamos el tipo de dato

// ahora vamos a crear otra funcion que reciba un generic que implemente una interfaz, porque dentro de la interfaz ya se tiene este
void showInfo<T>(T element   ) where T :IInfo // creamos un metodo generico que recibe un repositorio de cualquier tipo
// metodo getinfo
 {
     Console.WriteLine(element.GetInfo());// mostramos cada cerveza.  sabe que existe 
} // es util cuando queremos tener tipado 
 
showInfo(drink2); // llamamos al metodo show y le pasamos el repositorio de cervezas, aki le pasamos el tipo de dato

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


var pool = new ObjectPool<Clock>(4); // creamos un pool de 5 objetos de tipo Clock

while( pool.Count > 0 )
{
    var clock = pool.Get(); // obtenemos un objeto del pool
    Console.WriteLine(clock.date); // mostramos el objeto
}

var  pools = new ObjectPool<Randoms>(3); // creamos un pool de 5 objetos de tipo Clock

while ( pools.Count > 0 )
{
    var number = pools.Get(); // obtenemos un objeto del pool
    Console.WriteLine("Nuevo Pools");
    Console.WriteLine(number.Number); // mostramos el objeto
}

IDrinkCreator<Drink> beerCreator = new IPABeerCreator(); // creamos un creador de cervezas IPA, ahora si se puede por que pusimo out en la interfaz
var drink3 = beerCreator.CreateDrink(500); // creamos una cerveza de 500ml, a pesar que retona drink es una cerveza,

return; // salimos del programa

void ShowInfoQuantity<T>(T drink) where T : Drink, IInfo // Podemos tener multiples restricciones y son las clases primero y las interfaces despues
{
    Console.WriteLine(drink.Quantity);// mostramos cada cerveza.  sabe que existe 
}

ShowInfoQuantity(drink2); // llamamos al metodo show y le pasamos el repositorio de cervezas, aki le pasamos el tipo de dato, ademas que que implemente la interfaz, y tambie es drink

//Console.WriteLine(add(3, 4)); // mostramos el resultado de la suma  podemos ejecutarlo como si fuera un metodo normal  por medio de generics    
//Console.WriteLine(addDouble(3.5, 2.0)); // mostramos el resultado de la multiplicacion 
//Console.WriteLine(concat("Hola", "Mundo")); // mostramos el resultado de la concatenacion
delegate T     Operation<T>(T element1, T element2 ); // creamos un delegado que recibe dos enteros y devuelve un entero

// Para les restricciones en generics podemos usar where y tenemos que entender que int es struct y string es class y podemos restringir
// los tipos de datos que pueden ser usados en una clase generica o en un metodo gener
// por ejemplo podemos crear una clase generica que solo acepte tipos de datos que sean clases  

delegate T  OperationStruct<T>(T element1, T element2) where T : struct; // creamos un delegado que recibe dos enteros y devuelve un entero
// donde T es un struct , es decir un tipo de dato por valor , tambien podemos hacer  una para clases   
delegate T OperationClass<T>(T element1, T element2) where T : class; // creamos un delegado que recibe dos enteros y devuelve un entero


// Tambien los generics podemos restrigir por una clase en especifico  o tambien por interfaces.

// restricciones en generics en contructores  hace que se restrinjan que tenga una clase sin parametros y sirve
// fabricas de objetos y pools  un pool es una coleccion de objetos que se pueden reutilizar, que nunca se sobre pase el limite 
// creamos un pool de 5 objetos de tipo Drink