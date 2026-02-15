
using System.Runtime.CompilerServices;
using ProgracionOrientadaObjetos.Business;

Beer endingerBeer =  new Beer( "Endinger" ,3, 2 );

//Tambien podemos crear nuestros objetos con la palabra var 
//var coronaBeer = new Beer();  aki me va dar error por que el costructor requiere que tenga esos datos 
//coronaBeer.Name = "Corona";
//coronaBeer.Price = 4m;

var coronaBeer = new Beer("Corona", 4m, -2); // aqui si me va a funcionar por que el constructor requiere esos datos


//Console.WriteLine($"La cerveza {endingerBeer.Name} cuesta {endingerBeer.Price} su continenido de alcohol es {endingerBeer.Alcohol}");
//Console.WriteLine($"La cerveza {coronaBeer.Name} cuesta {coronaBeer.Price} su continenido de alcohol es {coronaBeer.Alcohol}");
//Console.WriteLine(endingerBeer.GetBeerInfo());// podemos hacer models que puede ser reutilizados y podemos usar el paradigma orientados objetos.

//Console.WriteLine(endingerBeer.SAlcohol); // podemos acceder a la propiedad SAlcohol que nos devuelve una cadena con el contenido de alcohol de la cerveza, esto es una forma de encapsulamiento, ya que estamos ocultando el campo privado _alcohol y exponiendo solo lo necesario a traves de la propiedad SAlcohol.
 
 var  delirium  = new  ExpiringBeer("Delirium", 5m, 8, new DateTime (2024, 12, 01) ); // aqui estamos creando un objeto de la clase ExpiringBeer que hereda de la clase Beer, por lo tanto tiene todas las propiedades y metodos de la clase Beer, ademas de la propiedad ExpirationDate que es propia de la clase ExpiringBeer.

Console.WriteLine($"La cerveza {delirium.Name} cuesta {delirium.Price} su continenido de alcohol es {delirium.Alcohol} y su fecha de expiracion es {delirium.ExpirationDate.ToShortDateString()}"); // aqui estamos accediendo a las propiedades de la clase ExpiringBeer, que hereda de la clase Beer, por lo tanto tiene todas las propiedades y metodos de la clase Beer, ademas de la propiedad ExpirationDate que es propia de la clase ExpiringBeer.