
using System.Diagnostics;

var t = TomorrowPure;// aki lo que estoy haciendo es que  t va ser nuestra funcion , esta seria una funcion de primera clase 
Console.WriteLine(t(new DateTime(2024, 05, 01, 00, 00, 00))); // aqui estamos llamando a la funcion TomorrowPure a traves de la variable t, esto es una caracteristica de las funciones de primera clase, ya que podemos asignar funciones a variables, esto nos permite pasar funciones como argumentos a otras funciones, esto es una caracteristica de la programacion funcional que nos permite escribir codigo mas flexible y reutilizable.


Action<string> show = Console.WriteLine; // estamos haciendo  un delegado  por que  consoloreWrite line recibe un string 
//define funciones para tener tipado de funiciones 
show("hola");

Action<string> hi  = name  => Console.WriteLine($"Hola {name}"); // aqui estamos definiendo una funcion de tipo Action<string> que recibe un string como parametro y devuelve void, esto es una caracteristica de las funciones de primera clase, ya que podemos definir funciones con tipos de datos especificos, esto nos permite tener un mejor control sobre el tipo de datos que se estan manejando en nuestro codigo, esto es una caracteristica de la programacion funcional que nos permite escribir codigo mas seguro y facil de mantener.

hi("Edi");

Action<int, int> add = (a, b) => show((a + b).ToString()) ;// aqui estamos definiendo una funcion de tipo Action<int, int> que recibe dos enteros como parametros y devuelve void, esto es una caracteristica de las funciones de primera clase, ya que podemos definir funciones con tipos de datos especificos, esto nos permite tener un mejor control sobre el tipo de datos que se estan manejando en nuestro codigo, esto es una caracteristica de la programacion funcional que nos permite escribir codigo mas seguro y facil de mantener.
// aki esta usando funciones lamda de una  podemos hacerlo de manera mas rapida.
 add(5, 10); // aqui estamos llamando a la funcion add con los argumentos 5 y 10, esto es una caracteristica de las funciones de primera clase, ya que podemos llamar a funciones a traves de variables, esto nos permite pasar funciones como argumentos a otras funciones, esto es una caracteristica de la programacion funcional que nos permite escribir codigo mas flexible y reutilizable.


///siempre  va retornar  algo , y los primero son los paramentoes 
///
Func<int, int, int> mul = (a, b) => a * b;// aqui estamos definiendo una funcion de tipo Func<int, int, int> que recibe dos enteros como parametros y devuelve un entero, esto es una caracteristica de las funciones de primera clase, ya que podemos definir funciones con tipos de datos especificos, esto nos permite tener un mejor control sobre el tipo de datos que se estan manejando en nuestro codigo, esto es una caracteristica de la programacion funcional que nos permite escribir codigo mas seguro y facil de mantener
show(mul(5,10).ToString()); 
 // aqui estamos llamando a la funcion mul con los argumentos 5 y 10, esto es una caracteristica de las funciones de primera clase, ya que podemos llamar a funciones a traves de variables, esto nos permite pasar funciones como argumentos a otras funciones, esto es una caracteristica de la programacion funcional que nos permite escribir codigo mas flexible y reutilizable.

Func<int, int, string> multiString   = (a, b) =>
{
    var res = a* b;
    return res.ToString();
}; // aqui estamos definiendo una funcion de tipo Func<int, int, int> que recibe dos enteros como parametros y devuelve un entero, esto es una caracteristica de las funciones de primera clase, ya que podemos definir funciones con tipos de datos especificos, esto nos permite tener un mejor control sobre el tipo de datos que se estan manejando en nuestro codigo, esto es una caracteristica de la programacion funcional que nos permite escribir codigo mas seguro y facil de mantener

show(multiString(1, 2).ToString());


//funcion de orden superior peude recibir parametros, puede  retornar una funcion o ambas cosas a la vez
List<int> Filter( List<int> list , Func<int,  bool>  condition )
{
     var  resultList = new List<int>();

    foreach ( int i in list )
        {
        if (condition(i))
        {
            resultList.Add(i);
        }
    }
    return resultList;
}




// Esta funcion no es pura 

Console.WriteLine(Tomorrow()); // esta funcion no es pura porque devuelve un valor diferente cada vez que se ejecuta, ya que depende del estado del sistema, en este caso la fecha y hora actual, esto es una caracteristica de las funciones impuras, ya que pueden devolver resultados diferentes para los mismos argumentos dependiendo del estado del sistema, esto dificulta la depuracion y mantenimiento del codigo, ya que el resultado de la funcion puede cambiar dependiendo del estado del sistema.
//Esta si es una funcion Pura 
Console.WriteLine(TomorrowPure(new DateTime(2024,05, 01, 00,00,00))); // esta funcion es pura porque devuelve el mismo valor cada vez que se ejecuta, ya que no depende del estado del sistema, en este caso la fecha y hora actual, esto es una caracteristica de las funciones puras, ya que siempre devuelven el mismo resultado para los mismos argumentos, esto facilita la depuracion y mantenimiento del codigo, ya que el resultado de la funcion no cambia dependiendo del estado del sistema.


//

var  beer = new Beer()
{
    Name = "Heineken"
}; // aqui estamos creando un nuevo objeto de la clase Beer, esto es una caracteristica de la programacion orientada a objetos que nos permite crear objetos a partir de clases, esto es una forma de encapsulamiento, ya que estamos ocultando los detalles de la implementacion de la clase y exponiendo solo lo necesario a traves de las propiedades y metodos de la clase.

Console.WriteLine(ToUpperPure(beer).Name); // esta funcion no es pura porque modifica el estado del objeto beer, ya que estamos modificando la propiedad Name del objeto beer, esto es una caracteristica de las funciones impuras, ya que pueden modificar el estado del sistema, esto dificulta la depuracion y mantenimiento del codigo, ya que el resultado de la funcion puede cambiar dependiendo del estado del sistema.
Console.WriteLine(beer.Name); // aki podemos vPuer que tambien se modifico el el original.

DateTime Tomorrow()
{
    return DateTime.Now.AddDays(1); // si la ejecuto hoy  y la ejecuto  5 minutos des pues me va dar  valores diferenes.
}

// Funcion pura
DateTime TomorrowPure(DateTime today) // esta funcion es pura porque siempre devuelve el mismo resultado para los mismos argumentos, ya que no depende del estado del sistema, en este caso la fecha y hora actual, esto es una caracteristica de las funciones puras, ya que siempre devuelven el mismo resultado para los mismos argumentos, esto facilita la depuracion y mantenimiento del codigo, ya que el resultado de la funcion no cambia dependiendo del estado del sistema.
{
    return today.AddDays(1); // si le paso la fecha de hoy me va a devolver la fecha de mañana, si le paso la fecha de ayer me va a devolver la fecha de hoy, esto es una caracteristica de las funciones puras, ya que siempre devuelven el mismo resultado para los mismos argumentos, esto facilita la depuracion y mantenimiento del codigo, ya que el resultado de la funcion no cambia dependiendo del estado del sistema.
}

Beer ToUpper( Beer  beer)
{
    beer.Name = beer.Name.ToUpper(); // esta funcion no es pura porque modifica el estado del objeto beer, ya que estamos modificando la propiedad Name del objeto beer, esto es una caracteristica de las funciones impuras, ya que pueden modificar el estado del sistema, esto dificulta la depuracion y mantenimiento del codigo, ya que el resultado de la funcion puede cambiar dependiendo del estado del sistema.
    return beer;

}

Beer ToUpperPure(Beer beer) // esta funcion es pura porque no modifica el estado del objeto beer, ya que estamos creando un nuevo objeto de la clase Beer y asignando el valor de la propiedad Name en mayusculas, esto es una caracteristica de las funciones puras, ya que no modifican el estado del sistema, esto facilita la depuracion y mantenimiento del codigo, ya que el resultado de la funcion no cambia dependiendo del estado del sistema.
{
    var beer2 = new Beer()
    {
        Name = beer.Name.ToUpper() // aqui estamos creando un nuevo objeto de la clase Beer y asignando el valor de la propiedad Name en mayusculas, esto es una caracteristica de las funciones puras, ya que no modifican el estado del sistema, esto facilita la depuracion y mantenimiento del codigo, ya que el resultado de la funcion no cambia dependiendo del estado del sistema.
    };
     return beer2; // aqui estamos devolviendo el nuevo objeto de la clase Beer, esto es una caracteristica de las funciones puras, ya que no modifican el estado del sistema, esto facilita la depuracion y mantenimiento del codigo, ya que el resultado de la funcion no cambia dependiendo del estado del sistema.
}



public class Beer
{
    public string Name { get; set; }

}

