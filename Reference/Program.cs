using System.Timers;

int num = 1;

Console.WriteLine(num); // Si solo lo ejecutamos de esta manera
change( num); // pasamos la variable por referencia con ref
Console.WriteLine(num); // el numero no va cambiar por que los tipos por valor no cambian por que es  struct 

// Pero si lo pasamos por referencia con ref  si vamos a lograr realizar el cambio 

int numRef = 1;
Console.WriteLine("Este es el numero antes de iniciar" + numRef);
changeRef( ref numRef); // pasamos la variable por referencia con ref
Console.WriteLine("Este es el numero cambiado " + numRef);

//Vamos a crear el objeto
 var number   =  new Number() { NumberValue = 10m }; // creamos un objeto de la clase number

// vamos a ver como cambia  esto

Console.WriteLine(number.NumberValue);
changeObject(number); // pasamos el objeto a la funcion
Console.WriteLine(number.NumberValue); // el valor del objeto si va cambiar por que los objetos son tipos por referencia , si se pasa por referencia

string str = "pedro";
Console.WriteLine(str);
changeString(str); // pasamos el string a la funcion
Console.WriteLine(str); // el valor del string no va cambiar por que los string son inmutables, esto  se hace por rendimiento
// por que un string es un encadenamiento de caracteres  y si se modificara cada vez que se cambia un string se tendria que crear un nuevo espacio en memoria



void change( int num )
{
    num = 5;
}

void changeRef( ref int num ) // con ref si va cambiar por que estamos pasando la referencia de la variable
{
    num = 5;
}

// Ahora creamos la funcion para modificar el objeto  

void changeObject( Number number ) 
{
    number.NumberValue = 20m; // modificamos la propiedad del objeto
} 

//vamos a crear una funciona pra cambiar un objeto string 
void changeString(  string str ) 
{
    str = "juan"; // modificamos el valor del string
}

// ahora lo que vamos hacer es crear una clase 

public class  Number
{
     public decimal NumberValue { get; set; } 
}

// inmutabilidad  es  cuando no quieres  modificar los elementos ,  es inmutable 
// se trabaja  con clones y copias 