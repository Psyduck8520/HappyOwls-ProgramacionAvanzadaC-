using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgracionOrientadaObjetos.Business
{
    public class Service : ISalable
    {
        private decimal _amount;
        private decimal _tax;

        public Service(decimal amount,decimal tax) {
            _amount = amount;
              _tax = tax;
        }
        public decimal GetPrice()  
            => _amount + _tax; // el precio del servicio es la suma del monto y el impuesto, esto es una implementacion de la interfaz ISalable, ya que estamos implementando el metodo GetPrice que nos permite obtener el precio del servicio, esto es una caracteristica de la programacion orientada a objetos que nos permite definir contratos a traves de interfaces y luego implementar esos contratos en nuestras clases.
    }
}
