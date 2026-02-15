
using System.Runtime.CompilerServices;

Beer endingerBeer =  new Beer( "Endinger" ,3, 2 );

//Tambien podemos crear nuestros objetos con la palabra var 
//var coronaBeer = new Beer();  aki me va dar error por que el costructor requiere que tenga esos datos 
//coronaBeer.Name = "Corona";
//coronaBeer.Price = 4m;

var coronaBeer = new Beer("Corona", 4m, -2); // aqui si me va a funcionar por que el constructor requiere esos datos


Console.WriteLine($"La cerveza {endingerBeer.Name} cuesta {endingerBeer.Price} su continenido de alcohol es {endingerBeer.Alcohol}");
Console.WriteLine($"La cerveza {coronaBeer.Name} cuesta {coronaBeer.Price} su continenido de alcohol es {coronaBeer.Alcohol}");
Console.WriteLine(endingerBeer.GetBeerInfo());// podemos hacer models que puede ser reutilizados y podemos usar el paradigma orientados objetos.

Console.WriteLine(endingerBeer.SAlcohol); // podemos acceder a la propiedad SAlcohol que nos devuelve una cadena con el contenido de alcohol de la cerveza, esto es una forma de encapsulamiento, ya que estamos ocultando el campo privado _alcohol y exponiendo solo lo necesario a traves de la propiedad SAlcohol.

public class   Beer 
{
    private decimal _alcohol; // campo  con guion bajo si  es privado por convension y las propiedades son mayusculas por convension, el encapsulamiento es una de las caracteristicas de la programacion orientada a objetos, que nos permite ocultar los detalles de implementacion de una clase y exponer solo lo necesario a traves de propiedades y metodos publicos.
    //si es privado solo se accede dentro de la clase, si es publico se puede acceder desde fuera de la clase, si es protegido se puede acceder desde la clase y sus clases derivadas, si es interno se puede acceder desde el mismo ensamblado, si es protegido interno se puede acceder desde el mismo ensamblado y sus clases derivadas.
    public string Name { get; set; } // Las propiedades de la clase Beer, con sus respectivos getters y setters  de manera publica podemos acceder 
    public decimal Price { get; set; }

    public decimal Alcohol // propiedad con un campo privado, con un getter y setter personalizado, el encapsulamiento nos permite controlar el acceso a los datos de una clase y protegerlos de modificaciones no deseadas.
    {
        get { return  _alcohol; } // getter personalizado, devuelve el valor del campo privado _alcohol
        set
        {
            if (value < 0) //  si es negativo no se permite y se asigna el valor a 0, esto es una validacion para evitar que se asignen valores no validos a la propiedad Alcohol, el encapsulamiento nos permite controlar el acceso a los datos de una clase y protegerlos de modificaciones no deseadas.
            {
                value = 0;
            }
            _alcohol= value; // setter personalizado, asigna el valor al campo privado _alcohol
        }
    }

    public string SAlcohol
    {
        get
        {
             return "Alcohol : " +  _alcohol.ToString();
        }
    }

    //constructor 

    public Beer(string  name, decimal price, decimal alcohol) // constructor vacio, mismo nombre de la clase, no tiene tipo de retorno, y recibe parametros para inicializar las propiedades de la clase
    {
        this.Name = name;
        this.Price = price;
        Alcohol = alcohol;
    }

    //  Comoportamiento ,  tiene un metodo
    public string  GetBeerInfo()
    {
        return $"La cerveza {Name} cuesta {Price} , el alchol es {Alcohol}"; // metodo que contiene get info
    }
    
}