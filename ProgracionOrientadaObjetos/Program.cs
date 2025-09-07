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

Beer beer = new Beer("Corona", 20, -24);
var cornaBeer = new Beer("Corona", 20, 3023); 

Console.WriteLine(beer.GetInfo());
// de testa manera tenemos la certeza de que la cerveza siempre va a tener un nombre y un precio 

Console.WriteLine(beer.SAlcohol);  

var delirium  = new ExpiringBeer("Delirium Tremens", 50, 8.5m, new DateTime(2024, 10, 20));

Console.WriteLine(delirium.GetInfo());