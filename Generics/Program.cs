//Son un mecanismos que nos permite reutilizar codigo
using Generics;
using System.Dynamic;

var box = new Box<int>(12); // creamos una caja de tipo string, como mi clase es generica puedo crear una caja de cualquier tipo
var box2 = new Box<string>("Hola"); // creamos una caja de tipo string, mirate el constructor y lo entenderas

Console.WriteLine(box.GetContent()); // mostramos el contenido de la caja
Console.WriteLine(box2.GetContent()); // mostramos el contenido de la caja 