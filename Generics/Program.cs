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
