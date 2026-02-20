using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class BeerRepository : IRepository<string>
    {
        private string[] _beers;
        private int _index;
        private const int QUANTITY = 10;
        public BeerRepository() {
            _beers = new string[QUANTITY];
            _index  =  0;
        }
        public void Add(string beer) // tiene  que cumplir con la firma
                                      // del metodo de la interfaz, pero el tipo de dato es string,
                                      // porque es lo que se especifica en la clase, si fuera otra clase seria otro tipo de dato
        {
            if (_index < QUANTITY)
            {
                _beers[_index++] = beer;
            }
        }
        public IEnumerable<string> GetAll()
        {
            return _beers; // devuelve una lista de objetos del tipo string, pero solo los que se han agregado, no los que estan vacios
        }
    }
}
