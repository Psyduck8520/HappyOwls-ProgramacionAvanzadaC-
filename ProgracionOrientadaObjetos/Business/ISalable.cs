using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgracionOrientadaObjetos.Business
{
    public interface ISalable // es paracida a una clase abstracta pero puedo usar varias interfaces en mi clases, 

    {
        //Metodos para implementar solo tienen esto 

        public decimal GetPrice(); // vamos a obtener el precio

        // que es lo que  importa internamente no le importa a la 
        // interfaz es un contrato, el objetivo  de esto es que la arquitectura dependemos de abstranccion
    }
}