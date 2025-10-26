//podemos agregar funcionamiento nuevo a tipos ya existentes sin tener que modificarlos
//para agregar tenemos que hacer metodos estaticos en clases estaticas, se van a comportar como metodods de la instancia

using ExtensionMethods;

int number = 10; // los estruct seon tipos por valor
number.CompareTo(5); //metodo de la instancia
//Para extender el medtodo una clase estatica  una  calse estatica
//una clase estatica no me permite crear ojetos solo tiene metodos estaticos para se ejecutados sin instanciar
int number2 =   number.X2(); //llamamos al metodo de extension , aki no le pasamos parametros por que asi lo estamos nombrandos
Console.WriteLine(number2); //20 

// esto es util para hacer funcionalidades externascomo las bibliotecas por que ha pesar que ya esten compilado podemos agregar mas funcionamiento.

// Ahora podemos llamar a la extension aki

var sale = new Sale(500); //creamos una venta
Console.WriteLine(sale.GetInfo()); //llamamos al metodo de extension que hemos creado, aki podemos hacer 

public static class  IntOperation
{
     public static int X2(this int number)=> number * 2; //el this indica que es un metodo de extension y el tipo que extiende
    // es un metodo estatico que no pertenece a la clases si no que pertenece al tipo que extiende 
}


public static class SaleExtensions
{
    public static string GetInfo(this Sale sale) // recuerda que aki tenemos que llamar al constructor
    
        => $" El monto de la venta es: {sale.Amount}";
} // esto funciona como un dll que extendie el fucionamiento de la clase Sale sin modificarla.



