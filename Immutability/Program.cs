// La inmutabilidad es importante  por que 
// 1. Seguridad :  los objetos inmutables son seguros para usar en entornos multihilo
// 2. Simplicidad :  los objetos inmutables son mas faciles de razonar y entender
// 3. Rendimiento :  los objetos inmutables pueden ser optimizados por el compilador y el runtime 

var  calculator = new Calculator(10);
//calculator.PI  si lo tengo qde esta manera no puedo acceder a PI por que es una constante y se accede directamente por la clase
// pero de la siguiente manera si 
Console.WriteLine(Calculator.PI); // aki si puede acceder a la constante PI directamente por la clase Calculator

public class Brand
{
     public string Name { get; }// si quito el sed  de aki la unica manera de asignar el valor es por el constructor, no se va poder modificar despues de creado el objeto
    public Brand(string name)
        => Name = name;
} 

public class Calculator
{
     public const double  PI = 3.1416; // ES ALGO QUE NO SE PUEDE CAMBIAR , YA NO SE CAMBIO O NO SE MODIFICA
                                       //FORMUlas , IMPUESTOS , VALORES FIJOS, SOLO PUEDE  GUARDAR TIPOS PRIMITIVOS
                                       //int float , double , decimal , char , bool , string, tipos  derivados de estos
                                       //ademas esto es un static por defecto 
    public readonly int value; // Tambien es un objeto que no cambia pero si puedo,agregarle su valor en el constructor 

    public Calculator( int value)
    {
        this.value =  value; // aki le puedo asignar un valor a la variable readonly, entonces lo que pasa es que aki asigamos un valor
        // para cada objeto , si luego quiero modificar ese value ya no puedo modificarlo  por que solo puedo asignar el valor en el
        // constructor
    }
    // Las  constantes toman su valor en el momento de compilación, el reaadonly toma su valor en tiempo de ejecución  en la creacion 
    //  para otro objeto ya es como una constate pero que puede tomar diferentes valores en tiempo de ejecucion




}
