
using System.Runtime.CompilerServices;
using ProgracionOrientadaObjetos.Business;

Beer endingerBeer =  new Beer( "Endinger" ,3, 2 ,1 );

//Tambien podemos crear nuestros objetos con la palabra var 
//var coronaBeer = new Beer();  aki me va dar error por que el costructor requiere que tenga esos datos 
//coronaBeer.Name = "Corona";
//coronaBeer.Price = 4m;

var coronaBeer = new Beer("Corona", 4m, -2,1); // aqui si me va a funcionar por que el constructor requiere esos datos




//Console.WriteLine($"La cerveza {endingerBeer.Name} cuesta {endingerBeer.Price} su continenido de alcohol es {endingerBeer.Alcohol}");
//Console.WriteLine($"La cerveza {coronaBeer.Name} cuesta {coronaBeer.Price} su continenido de alcohol es {coronaBeer.Alcohol}");
//Console.WriteLine(endingerBeer.GetBeerInfo());// podemos hacer models que puede ser reutilizados y podemos usar el paradigma orientados objetos.

//Console.WriteLine(endingerBeer.SAlcohol); // podemos acceder a la propiedad SAlcohol que nos devuelve una cadena con el contenido de alcohol de la cerveza, esto es una forma de encapsulamiento, ya que estamos ocultando el campo privado _alcohol y exponiendo solo lo necesario a traves de la propiedad SAlcohol.
 
 var  delirium  = new  ExpiringBeer("Delirium", 5m, 8, new DateTime (2024, 12, 01),2 ); // aqui estamos creando un objeto de la clase ExpiringBeer que hereda de la clase Beer, por lo tanto tiene todas las propiedades y metodos de la clase Beer, ademas de la propiedad ExpirationDate que es propia de la clase ExpiringBeer.

Console.WriteLine($"La cerveza {delirium.GetBeerInnfo("utilizando el metodo de la sobre carga")}"); // aqui estamos accediendo al metodo GetBeerInfo que es heredado de la clase Beer, por lo tanto podemos usarlo en la clase ExpiringBeer, esto es una caracteristica de la programacion orientada a objetos que nos permite reutilizar codigo y evitar la duplicacion de codigo.

Console.WriteLine(delirium.GetBeerInfo()); // aqui estamos accediendo al metodo GetBeerInfo que es sobre escrito en la clase ExpiringBeer, por lo tanto nos va a mostrar la informacion de la cerveza con caducidad, esto es una forma de polimorfismo, ya que podemos tener diferentes comportamientos para el mismo metodo dependiendo de la clase que lo implemente.

// NO PODEMOS HACER ESTO 
 //Drink drink = new Drink();// NO SE PUEDE CREAR UN OBJETO DE UNA CLASE ABSTRACTA, esto es una caracteristica de la programacion orientada a objetos que nos permite organizar el codigo y evitar la duplicacion de codigo, ya que las clases abstractas solo sirven para ser heredadas por otras clases y no para ser instanciadas directamente.

Drink drink = new Beer("Corona", 4m, -2,1); // si podemos crear un objeto de la clase Beer y asignarlo a una variable de tipo Drink, ya que la clase Beer hereda de la clase Drink, esto es una caracteristica de la programacion orientada a objetos que nos permite organizar el codigo y evitar la duplicacion de codigo, ya que las clases abstractas solo sirven para ser heredadas por otras clases y no para ser instanciadas directamente.
// Podemos crear un objeto tipo drink pero a partir de sus clases  derivades,  y estamos  limitados  a lo que tiene la clases abstracta .
drink.GetDrinkInfo(); // aqui estamos accediendo al metodo GetDrinkInfo que es heredado de la clase Drink, por lo tanto podemos usarlo en la clase Beer, esto es una caracteristica de la programacion orientada a objetos que nos permite reutilizar codigo y evitar la duplicacion de codigo.
// drink solo  se limita a los metodos de la clase abstracta .

Console.WriteLine(delirium.GetCategory()); // aqui estamos accediendo al metodo GetDrinkInfo que es heredado de la clase Drink, por lo tanto podemos usarlo en la clase Beer, esto es una caracteristica de la programacion orientada a objetos que nos permite reutilizar codigo y evitar la duplicacion de codigo.

Drink bebida = new Wine(500); // aqui estamos creando un objeto de la clase Wine que hereda de la clase Drink, por lo tanto tiene todas las propiedades y metodos de la clase Drink, ademas de la propiedad Category que es propia de la clase Wine.

Show(bebida); // aqui estamos llamando al metodo Show y le estamos pasando el objeto bebida que es de tipo Drink, esto es una caracteristica de la programacion orientada a objetos que nos permite organizar el codigo y evitar la duplicacion de codigo, ya que podemos usar este metodo para mostrar la informacion de cualquier bebida que herede de la clase Drink, esto es una forma de polimorfismo, ya que podemos tener diferentes comportamientos para el mismo metodo dependiendo de la clase que lo implemente.

Drink corona  = new Beer("Corona", 4m, -2,1); // aqui estamos creando un objeto de la clase Beer que hereda de la clase Drink, por lo tanto tiene todas las propiedades y metodos de la clase Drink, ademas de las propiedades y metodos propios de la clase Beer.

Show(corona); // aqui estamos llamando al metodo Show y le estamos pasando el objeto corona que es de tipo Drink, esto es una caracteristica de la programacion orientada a objetos que nos permite organizar el codigo y evitar la duplicacion de codigo, ya que podemos usar este metodo para mostrar la informacion de cualquier bebida que herede de la clase Drink, esto es una forma de polimorfismo, ya que podemos tener diferentes comportamientos para el mismo metodo dependiendo de la clase que lo implemente.

Show(endingerBeer);  // tambien me permite mandar un objeto hijo  de la clase Drink, ya que la clase Beer hereda de la clase Drink, esto es una caracteristica de la programacion orientada a objetos que nos permite organizar el codigo y evitar la duplicacion de codigo, ya que podemos usar este metodo para mostrar la informacion de cualquier bebida que herede de la clase Drink, esto es una forma de polimorfismo, ya que podemos tener diferentes comportamientos para el mismo metodo dependiendo de la clase que lo implemente.
void Show ( Drink drink ) // aqui estamos creando un metodo que recibe un objeto de tipo Drink, esto es una caracteristica de la programacion orientada a objetos que nos permite organizar el codigo y evitar la duplicacion de codigo, ya que podemos usar este metodo para mostrar la informacion de cualquier bebida que herede de la clase Drink, esto es una forma de polimorfismo, ya que podemos tener diferentes comportamientos para el mismo metodo dependiendo de la clase que lo implemente.
{
    Console.WriteLine(drink.GetCategory()); // aqui estamos accediendo al metodo GetDrinkInfo que es heredado de la clase Drink, por lo tanto podemos usarlo en cualquier clase que herede de la clase Drink, esto es una caracteristica de la programacion orientada a objetos que nos permite reutilizar codigo y evitar la duplicacion de codigo.
}


