using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgracionOrientadaObjetos.Business
{
    public class Wine:  Drink // bedida me obliga a tener barias categorias, nuestro constructor 
    {
        private const string category = "Vino"; // constante
        public Wine(int quantity) : base(quantity) // llamamos al constructor de la clase base
        {
           
        }
        public override string GetCategory() => category; // retornamos
                                                          //ka constante esta menaera podemos
                                                          //escribir metodos de una sola linea cuando solo retorna algo y no tiene nadamas 
        
        

    }
}
