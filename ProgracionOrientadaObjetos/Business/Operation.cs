using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgracionOrientadaObjetos.Business
{
    public class Operation
    {
        public static decimal  Add ( decimal a  , decimal b)
            =>   a + b; // metodo estatico, no necesita una instancia de la clase para ser llamado, esto es una caracteristica de la programacion orientada a objetos que nos permite definir metodos que pueden ser llamados sin necesidad de crear un objeto de la clase, esto es util para operaciones matematicas o funciones que no dependen del estado de un objeto.
    
        public static decimal  Mul(decimal a ,decimal b)
        => a * b; // metodo estatico, no necesita una instancia de la clase para ser llamado, esto es una caracteristica de la programacion orientada a objetos que nos permite definir metodos que pueden ser llamados sin necesidad de crear un objeto de la clase, esto es util para operaciones matematicas o funciones que no dependen del estado de un objeto.
    }
}
