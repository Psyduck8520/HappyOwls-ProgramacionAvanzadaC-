
using System.Runtime.CompilerServices;

Beer endingerBeer =  new Beer( "Endinger" ,3 );

//Tambien podemos crear nuestros objetos con la palabra var 
//var coronaBeer = new Beer();  aki me va dar error por que el costructor requiere que tenga esos datos 
//coronaBeer.Name = "Corona";
//coronaBeer.Price = 4m;

var coronaBeer = new Beer("Corona", 4m); // aqui si me va a funcionar por que el constructor requiere esos datos


Console.WriteLine($"La cerveza {endingerBeer.Name} cuesta {endingerBeer.Price}");
Console.WriteLine($"La cerveza {coronaBeer.Name} cuesta {coronaBeer.Price}");
Console.WriteLine(endingerBeer.GetBeerInfo());// podemos hacer models que puede ser reutilizados y podemos usar el paradigma orientados objetos.


public class   Beer 
{
     public string Name { get; set; } // Las propiedades de la clase Beer, con sus respectivos getters y setters  de manera publica podemos acceder 
    public decimal Price { get; set; }
    //constructor 

    public Beer(string  name, decimal price) // constructor vacio, mismo nombre de la clase, no tiene tipo de retorno, y recibe parametros para inicializar las propiedades de la clase
    {
       this.Name = name;
       this.Price = price;
    }

    //  Comoportamiento ,  tiene un metodo
    public string  GetBeerInfo()
    {
        return $"La cerveza {Name} cuesta {Price}"; // metodo que contiene get info
    }
    
}