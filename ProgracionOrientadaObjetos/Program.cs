using ProgracionOrientadaObjetos.Business;
using System.Diagnostics;
/*Beer beer = new Beer()
{
    Name = "Corona",
    Price = "20"
};// creammos un objeto de tipo beer 

// otra manera de asignar es  agregando valores a cada uno si son publicos 
 /*var  coronaBeer = new Beer(); 
 coronaBeer.Name = "Corona";
coronaBeer.Price = "20";*

Console.WriteLine($"La cerveza es {beer.Name} y su precio es {beer.Price} pesos");
Console.WriteLine($"La cerveza es {coronaBeer.Name} y su precio es {coronaBeer.Price} pesos");

Console.WriteLine(beer.GetInfo());
*/
// podemos tener varis contructores de deistintos tipos 
// tambine un cosntructor tiene un cuerpo vacio y lo podemos cargar cuando se crean
// tiene que tener el mismo nombre de la clase 

Beer beer = new Beer("Corona", 20, -24, 1000);  // aki tenemos que cambiar por que obviamente cambioel constructor 
var cornaBeer = new Beer("Corona", 20, 3023, 100); // aki tambien cambiamos por que  cambio el contructor

Drink drink  = new Beer("Pepsi", 15, 0.0m, 500); // Podemos crear un objeto drink a partir de su hijo pero no directamente de drink por que es abstracta ,
                                                 // pero solo tendriamos los metodos y propiedades de drink  osea no se puede usar los metodos de  beer 

Console.WriteLine(beer.GetInfo());
// de testa manera tenemos la certeza de que la cerveza siempre va a tener un nombre y un precio 

Console.WriteLine(beer.SAlcohol);  

var delirium  = new ExpiringBeer("Delirium Tremens", 50, 8.5m, new DateTime(2024, 10, 20), 1000);

Drink drinkde =  new Wine(500); // podemos crear un objeto drink a partir de su hijo wine
//dependiendo el cotexto vamos a tenr resultados difirentes, se basa igual al tipo 
// de entrada de informacion 

//Sobrecarga de metodos es lo  mismo pero tener distintos parametros con el mismo nombre de la funcion.

Drink  drink1 = new Wine(750); // podemos crear un objeto drink a partir de su hijo wines
Show(drink1); // llamamos al metodo show y le pasamos el objeto drink1 que es de tipo wine

Drink drink2 = new Beer("Heineken", 30, 5.0m, 600);
 Show(drink2); // llamamos al metodo show y le pasamos el objeto drink2 que es de tipo beer
void Show(Drink drink) => Console.WriteLine(drink.GetCategory()); //
                                                                  //Todos los objetos que sean del tipo drink van a poder usar este metodo getcategory

void SendSome(ISend some) {
    Console.WriteLine("Enviando...");
    some.Send();
    Console.WriteLine("Hago algo mas ");
}