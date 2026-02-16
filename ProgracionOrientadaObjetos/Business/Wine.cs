using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgracionOrientadaObjetos.Business
{
    public class Wine : Drink
    {
        private  const  string Category = "Vino"; // constante, no se puede modificar su valor, es una caracteristica de la programacion orientada a objetos que nos permite definir valores constantes que no pueden ser modificados, esto es una forma de encapsulamiento, ya que estamos ocultando el valor de la constante y exponiendo solo lo necesario a traves de la propiedad GetCategory.
       
        public Wine(int quantity) : base(quantity) // constructor de la clase Wine, que llama al constructor de la clase base Drink para inicializar la propiedad Quantity, esto es una caracteristica de la programacion orientada a objetos que nos permite organizar el codigo y evitar la duplicacion de codigo.
        {
        }
        public override string GetCategory() => 
            Category; // aqui estamos sobre escribiendo el metodo GetCategory de la clase Drink, ya que la clase Wine hereda de la clase Drink, esto es una caracteristica de la programacion orientada a objetos que nos permite organizar el codigo y evitar la duplicacion de codigo, ya que las clases derivadas pueden tener una implementacion diferente de los metodos heredados de la clase base.
    }
}
