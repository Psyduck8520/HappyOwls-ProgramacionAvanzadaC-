// Esta funcion no es pura 

Console.WriteLine(Tomorrow()); // esta funcion no es pura porque devuelve un valor diferente cada vez que se ejecuta, ya que depende del estado del sistema, en este caso la fecha y hora actual, esto es una caracteristica de las funciones impuras, ya que pueden devolver resultados diferentes para los mismos argumentos dependiendo del estado del sistema, esto dificulta la depuracion y mantenimiento del codigo, ya que el resultado de la funcion puede cambiar dependiendo del estado del sistema.
//Esta si es una funcion Pura 
Console.WriteLine(TomorrowPure(new DateTime(2024,05, 01, 00,00,00))); // esta funcion es pura porque devuelve el mismo valor cada vez que se ejecuta, ya que no depende del estado del sistema, en este caso la fecha y hora actual, esto es una caracteristica de las funciones puras, ya que siempre devuelven el mismo resultado para los mismos argumentos, esto facilita la depuracion y mantenimiento del codigo, ya que el resultado de la funcion no cambia dependiendo del estado del sistema.


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

