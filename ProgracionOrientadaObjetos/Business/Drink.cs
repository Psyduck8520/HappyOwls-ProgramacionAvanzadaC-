using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//las clases abstractas no se pueden instanciar y sirven para que las hereden y podemos organizar
//mejor el codigo

namespace ProgracionOrientadaObjetos.Business
{
    public abstract class Drink // aki podemos la pabra abstract
    {
        //una funcionalidad que no va cambiar en nuestros objetos o clases hijas
        public int quantity { get; set; }
        //las clases si pueden tener constructores
        public Drink(int quantity)  // no sirven para crear objetos
        {
            this.quantity = quantity;
        }
        //puden tener metodos abstractos implementados y  otros que no tienen implementacion pero sidedben existir en quien hereda
        
        public string GetQuantity()
        {
            return $"La cantidad es {quantity} en ml";
        }
        public abstract string GetCategory(); // no tiene implementacion pero este metodo debe existir en las clases hijas si no va a compilar
    }
}
